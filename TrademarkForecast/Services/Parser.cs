using System;
using System.Collections.Generic;
using TrademarkForecast.Models;
using System.Linq;
using System.Globalization;

namespace TrademarkForecast.Services
{
    public static class Parser
    {
        public static Casefile TrademarkFileToCasefile(dynamic trademarkFile)
        {
            string markLiteralElements = trademarkFile.trademarks[0].status.markElement;
            DateTime filingDate = trademarkFile.trademarks[0].status.filingDate;
            int ownerTypeId = trademarkFile.trademarks[0].parties.ownerGroups["10"][0].entityType.code;
            string attorney = trademarkFile.trademarks[0].status.correspondence.attorneyName;

            string allGoodsAndServices = string.Empty;
            List<int> classIds = new List<int>();
            List<DateTime> useDates = new List<DateTime>();

            int daysSinceFiling;

            IEnumerable<object> gsList = trademarkFile.trademarks[0].gsList;
            foreach (dynamic d in gsList)
            {
                allGoodsAndServices += d.description;
                classIds.Add((int)d.internationalClasses[0].code);
                useDates.Add(DateTime.ParseExact((string)d.firstUseInCommerceDate,"yyyymmdd", CultureInfo.InvariantCulture));
            }

            daysSinceFiling = (useDates.First() - filingDate).Days;            

            Casefile casefile = new Casefile(markLiteralElements, allGoodsAndServices, attorney, ownerTypeId, classIds.Count, daysSinceFiling, classIds, false);

            return casefile;
        }
    }
}
