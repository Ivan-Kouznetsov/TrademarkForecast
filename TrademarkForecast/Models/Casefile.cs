using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Microsoft.ML.Data;

namespace TrademarkForecast.Models
{
    public class Casefile
    {
        public string MarkLiteralElements;    
        public float OwnerTypeId;
        public float NumberOfClasses;
        public float DaysSinceFiling;
        public string GoodsAndServices;
        public string Attorney;
        public float LengthOfGoodsAndServices { get { return GoodsAndServices.Length; } }
        public float LengthOfMarkLiteralElements { get { return MarkLiteralElements.Length; } }
        public bool Is_Class_1;
        public bool Is_Class_2;
        public bool Is_Class_3;
        public bool Is_Class_4;
        public bool Is_Class_5;
        public bool Is_Class_6;
        public bool Is_Class_7;
        public bool Is_Class_8;
        public bool Is_Class_9;
        public bool Is_Class_10;
        public bool Is_Class_11;
        public bool Is_Class_12;
        public bool Is_Class_13;
        public bool Is_Class_14;
        public bool Is_Class_15;
        public bool Is_Class_16;
        public bool Is_Class_17;
        public bool Is_Class_18;
        public bool Is_Class_19;
        public bool Is_Class_20;
        public bool Is_Class_21;
        public bool Is_Class_22;
        public bool Is_Class_23;
        public bool Is_Class_24;
        public bool Is_Class_25;
        public bool Is_Class_26;
        public bool Is_Class_27;
        public bool Is_Class_28;
        public bool Is_Class_29;
        public bool Is_Class_30;
        public bool Is_Class_31;
        public bool Is_Class_32;
        public bool Is_Class_33;
        public bool Is_Class_34;
        public bool Is_Class_35;
        public bool Is_Class_36;
        public bool Is_Class_37;
        public bool Is_Class_38;
        public bool Is_Class_39;
        public bool Is_Class_40;
        public bool Is_Class_41;
        public bool Is_Class_42;
        public bool Is_Class_43;
        public bool Is_Class_44;
        public bool Is_Class_45;
        [ColumnName("Label")]
        public bool Cancelled;

        [JsonConstructor]
        public Casefile(string markLiteralElements, int ownerTypeId, float numberOfClasses, string goodsAndServices, float daysSinceFiling, string attorney, bool is_Class_1, bool is_Class_2, bool is_Class_3, bool is_Class_4, bool is_Class_5, bool is_Class_6, bool is_Class_7, bool is_Class_8, bool is_Class_9, bool is_Class_10, bool is_Class_11, bool is_Class_12, bool is_Class_13, bool is_Class_14, bool is_Class_15, bool is_Class_16, bool is_Class_17, bool is_Class_18, bool is_Class_19, bool is_Class_20, bool is_Class_21, bool is_Class_22, bool is_Class_23, bool is_Class_24, bool is_Class_25, bool is_Class_26, bool is_Class_27, bool is_Class_28, bool is_Class_29, bool is_Class_30, bool is_Class_31, bool is_Class_32, bool is_Class_33, bool is_Class_34, bool is_Class_35, bool is_Class_36, bool is_Class_37, bool is_Class_38, bool is_Class_39, bool is_Class_40, bool is_Class_41, bool is_Class_42, bool is_Class_43, bool is_Class_44, bool is_Class_45, bool cancelled)
        {
            MarkLiteralElements = markLiteralElements;
            OwnerTypeId = ownerTypeId;
            NumberOfClasses = numberOfClasses;
            GoodsAndServices = goodsAndServices;
            DaysSinceFiling = daysSinceFiling;
            Attorney = attorney;
            Is_Class_1 = is_Class_1;
            Is_Class_2 = is_Class_2;
            Is_Class_3 = is_Class_3;
            Is_Class_4 = is_Class_4;
            Is_Class_5 = is_Class_5;
            Is_Class_6 = is_Class_6;
            Is_Class_7 = is_Class_7;
            Is_Class_8 = is_Class_8;
            Is_Class_9 = is_Class_9;
            Is_Class_10 = is_Class_10;
            Is_Class_11 = is_Class_11;
            Is_Class_12 = is_Class_12;
            Is_Class_13 = is_Class_13;
            Is_Class_14 = is_Class_14;
            Is_Class_15 = is_Class_15;
            Is_Class_16 = is_Class_16;
            Is_Class_17 = is_Class_17;
            Is_Class_18 = is_Class_18;
            Is_Class_19 = is_Class_19;
            Is_Class_20 = is_Class_20;
            Is_Class_21 = is_Class_21;
            Is_Class_22 = is_Class_22;
            Is_Class_23 = is_Class_23;
            Is_Class_24 = is_Class_24;
            Is_Class_25 = is_Class_25;
            Is_Class_26 = is_Class_26;
            Is_Class_27 = is_Class_27;
            Is_Class_28 = is_Class_28;
            Is_Class_29 = is_Class_29;
            Is_Class_30 = is_Class_30;
            Is_Class_31 = is_Class_31;
            Is_Class_32 = is_Class_32;
            Is_Class_33 = is_Class_33;
            Is_Class_34 = is_Class_34;
            Is_Class_35 = is_Class_35;
            Is_Class_36 = is_Class_36;
            Is_Class_37 = is_Class_37;
            Is_Class_38 = is_Class_38;
            Is_Class_39 = is_Class_39;
            Is_Class_40 = is_Class_40;
            Is_Class_41 = is_Class_41;
            Is_Class_42 = is_Class_42;
            Is_Class_43 = is_Class_43;
            Is_Class_44 = is_Class_44;
            Is_Class_45 = is_Class_45;
            Cancelled = cancelled;
        }

        public Casefile(string markLiteralElements,
                        string goodsAndServices,             
                        int ownerTypeId,
                        int numberOfClasses,
                        float daysSinceFiling,
                        string attorney,
                        bool is_Class_1, bool is_Class_2, bool is_Class_3, bool is_Class_4, bool is_Class_5, bool is_Class_6, bool is_Class_7, bool is_Class_8, bool is_Class_9, bool is_Class_10, bool is_Class_11, bool is_Class_12, bool is_Class_13, bool is_Class_14, bool is_Class_15, bool is_Class_16, bool is_Class_17, bool is_Class_18, bool is_Class_19, bool is_Class_20, bool is_Class_21, bool is_Class_22, bool is_Class_23, bool is_Class_24, bool is_Class_25, bool is_Class_26, bool is_Class_27, bool is_Class_28, bool is_Class_29, bool is_Class_30, bool is_Class_31, bool is_Class_32, bool is_Class_33, bool is_Class_34, bool is_Class_35, bool is_Class_36, bool is_Class_37, bool is_Class_38, bool is_Class_39, bool is_Class_40, bool is_Class_41, bool is_Class_42, bool is_Class_43, bool is_Class_44, bool is_Class_45, bool cancelled)
        {
            MarkLiteralElements = markLiteralElements;
            GoodsAndServices = goodsAndServices;          
            OwnerTypeId = ownerTypeId;
            NumberOfClasses = numberOfClasses;
            DaysSinceFiling = daysSinceFiling;
            Attorney = attorney;
            Is_Class_1 = is_Class_1;
            Is_Class_2 = is_Class_2;
            Is_Class_3 = is_Class_3;
            Is_Class_4 = is_Class_4;
            Is_Class_5 = is_Class_5;
            Is_Class_6 = is_Class_6;
            Is_Class_7 = is_Class_7;
            Is_Class_8 = is_Class_8;
            Is_Class_9 = is_Class_9;
            Is_Class_10 = is_Class_10;
            Is_Class_11 = is_Class_11;
            Is_Class_12 = is_Class_12;
            Is_Class_13 = is_Class_13;
            Is_Class_14 = is_Class_14;
            Is_Class_15 = is_Class_15;
            Is_Class_16 = is_Class_16;
            Is_Class_17 = is_Class_17;
            Is_Class_18 = is_Class_18;
            Is_Class_19 = is_Class_19;
            Is_Class_20 = is_Class_20;
            Is_Class_21 = is_Class_21;
            Is_Class_22 = is_Class_22;
            Is_Class_23 = is_Class_23;
            Is_Class_24 = is_Class_24;
            Is_Class_25 = is_Class_25;
            Is_Class_26 = is_Class_26;
            Is_Class_27 = is_Class_27;
            Is_Class_28 = is_Class_28;
            Is_Class_29 = is_Class_29;
            Is_Class_30 = is_Class_30;
            Is_Class_31 = is_Class_31;
            Is_Class_32 = is_Class_32;
            Is_Class_33 = is_Class_33;
            Is_Class_34 = is_Class_34;
            Is_Class_35 = is_Class_35;
            Is_Class_36 = is_Class_36;
            Is_Class_37 = is_Class_37;
            Is_Class_38 = is_Class_38;
            Is_Class_39 = is_Class_39;
            Is_Class_40 = is_Class_40;
            Is_Class_41 = is_Class_41;
            Is_Class_42 = is_Class_42;
            Is_Class_43 = is_Class_43;
            Is_Class_44 = is_Class_44;
            Is_Class_45 = is_Class_45;
            Cancelled = cancelled;
        }

        public Casefile(string markLiteralElements,
                        string goodsAndServices,  
                        string attorney,
                        int ownerTypeId,
                        int numberOfClasses,
                        int daysSinceFiling,
                        List<int> classIds,
                        bool cancelled)
        {
            MarkLiteralElements = markLiteralElements;
            GoodsAndServices = goodsAndServices;
            DaysSinceFiling = daysSinceFiling;
            Attorney = attorney;
            OwnerTypeId = ownerTypeId;
            NumberOfClasses = numberOfClasses;
            Is_Class_1 = classIds.Contains(1);
            Is_Class_2 = classIds.Contains(2);
            Is_Class_3 = classIds.Contains(3);
            Is_Class_4 = classIds.Contains(4);
            Is_Class_5 = classIds.Contains(5);
            Is_Class_6 = classIds.Contains(6);
            Is_Class_7 = classIds.Contains(7);
            Is_Class_8 = classIds.Contains(8);
            Is_Class_9 = classIds.Contains(9);
            Is_Class_10 = classIds.Contains(10);
            Is_Class_11 = classIds.Contains(11);
            Is_Class_12 = classIds.Contains(12);
            Is_Class_13 = classIds.Contains(13);
            Is_Class_14 = classIds.Contains(14);
            Is_Class_15 = classIds.Contains(15);
            Is_Class_16 = classIds.Contains(16);
            Is_Class_17 = classIds.Contains(17);
            Is_Class_18 = classIds.Contains(18);
            Is_Class_19 = classIds.Contains(19);
            Is_Class_20 = classIds.Contains(20);
            Is_Class_21 = classIds.Contains(21);
            Is_Class_22 = classIds.Contains(22);
            Is_Class_23 = classIds.Contains(23);
            Is_Class_24 = classIds.Contains(24);
            Is_Class_25 = classIds.Contains(25);
            Is_Class_26 = classIds.Contains(26);
            Is_Class_27 = classIds.Contains(27);
            Is_Class_28 = classIds.Contains(28);
            Is_Class_29 = classIds.Contains(29);
            Is_Class_30 = classIds.Contains(30);
            Is_Class_31 = classIds.Contains(31);
            Is_Class_32 = classIds.Contains(32);
            Is_Class_33 = classIds.Contains(33);
            Is_Class_34 = classIds.Contains(34);
            Is_Class_35 = classIds.Contains(35);
            Is_Class_36 = classIds.Contains(36);
            Is_Class_37 = classIds.Contains(37);
            Is_Class_38 = classIds.Contains(38);
            Is_Class_39 = classIds.Contains(39);
            Is_Class_40 = classIds.Contains(40);
            Is_Class_41 = classIds.Contains(41);
            Is_Class_42 = classIds.Contains(42);
            Is_Class_43 = classIds.Contains(43);
            Is_Class_44 = classIds.Contains(44);
            Is_Class_45 = classIds.Contains(45);
            Cancelled = cancelled;
        }        
        public Casefile() { }
    }
}
