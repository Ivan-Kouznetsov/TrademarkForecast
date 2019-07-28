using System;
using System.Collections.Generic;
using Microsoft.ML.Data;

namespace TrademarkForecast.Models
{
    public class Casefile
    {
        private bool[] classes = new bool[45];

        [VectorType(45)]
        public float[] Classes
        {
            get { return Array.ConvertAll(classes, item => Convert.ToSingle(item)); }
            set { classes = Array.ConvertAll(value, item => Convert.ToBoolean(item)); }
        }

        public string MarkLiteralElements;     
        public float OwnerTypeId;
        public float NumberOfClasses;
        public string GoodsAndServices;
        public string Attorney;
        public float LengthOfGoodsAndServices => GoodsAndServices.Length;
        public float LengthOfMarkLiteralElements => MarkLiteralElements.Length;

        [ColumnName("Label")]
        public bool Cancelled;

        public Casefile(string markLiteralElements, float ownerTypeId, float numberOfClasses, string goodsAndServices, string attorney, bool[] classes, bool cancelled)
        {
            MarkLiteralElements = markLiteralElements;           
            OwnerTypeId = ownerTypeId;
            NumberOfClasses = numberOfClasses;
            GoodsAndServices = goodsAndServices;
            Attorney = attorney;
            this.classes = classes;
            Cancelled = cancelled;
        }

        public Casefile() { }

    }
}
