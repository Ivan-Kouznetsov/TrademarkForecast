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
            int ownerTypeId = trademarkFile.trademarks[0].parties.ownerGroups["10"][0].entityType.code;
            string attorney = trademarkFile.trademarks[0].status.correspondence.attorneyName;

            string allGoodsAndServices = string.Empty;
            List<int> classIds = new List<int>();
           
            IEnumerable<object> gsList = trademarkFile.trademarks[0].gsList;
            foreach (dynamic d in gsList)
            {
                allGoodsAndServices += d.description;
                classIds.Add((int)d.internationalClasses[0].code);
            }
            
            Casefile casefile = new Casefile(markLiteralElements,                                                                               
                                             ownerTypeId, 
                                             classIds.Count, 
                                             allGoodsAndServices, 
                                             attorney, 
                                             ClassIdListToBoolArray(classIds), 
                                             false);
            return casefile;
        }

        private static bool[] ClassIdListToBoolArray(List<int> classIds)
        {
            const int ClassCount = 45;
            bool[] results = new bool[ClassCount];

            for (int i = 0; i < ClassCount; i++)
            {
                results[i] = classIds.Contains(i+1); // classes start at 1 not 0
            }

            return results;
        }
    }
}
