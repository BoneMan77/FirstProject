using ABB.Robotics.Controllers.RapidDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DeskTestDome
{
    class RobotServise
    {
        public void WriteData(RapidData RapidName, object WriteData, int Index = 1 ,int Llndex=1) 
        {
            switch (RapidName.RapidType)
            {
                
                case "num":
                    Num NumData = new Num();
                    NumData.FillFromString(WriteData.ToString());
                    if (RapidName.IsArray)
                    {
                        if (ArrayRank(RapidName)>1)
                        {
                            RapidName.WriteItem(NumData,Index,Llndex);
                        }
                        else
                        {
                            RapidName.WriteItem(NumData, Index);
                        }
                    }
                    else
                    {
                        RapidName.Value = NumData;
                    }
                    break;
                case "bool":
                    Bool BoolData = new Bool();
                    BoolData.FillFromString(WriteData.ToString());
                    if (RapidName.IsArray)
                    {
                        if (ArrayRank(RapidName) > 1)
                        {
                            RapidName.WriteItem(BoolData, Index, Llndex);
                        }
                        else
                        {
                            RapidName.WriteItem(BoolData, Index);
                        }
                    }
                    else
                    {
                        RapidName.Value = BoolData;
                    }
                    break;
                case "string":
                    ABB.Robotics.Controllers.RapidDomain.String StrData = new ABB.Robotics.Controllers.RapidDomain.String();
                    StrData.FillFromString(WriteData.ToString());
                    if (RapidName.IsArray)
                    {
                        if (ArrayRank(RapidName) > 1)
                        {
                            RapidName.WriteItem(StrData, Index, Llndex);
                        }
                        else
                        {
                            RapidName.WriteItem(StrData, Index);
                        }
                    }
                    else
                    {
                        RapidName.Value = StrData;
                    }
                    break;
                default:
                    break;
            }


        }



        public void WriteData(List<RapidData> LRapidName, List<string> LRValue, int Index = 1 ,int Lindex =1)
        {
            for (int i = 0; i < LRapidName.Count; i++)
            {
                switch (LRapidName[i].RapidType)
                {
                    case "num":
                        Num NumData = new Num();
                        NumData.FillFromString(LRValue[i].ToString());
                        if (LRapidName[i].IsArray)
                        {
                            if (ArrayRank(LRapidName[i]) > 1)
                            {
                                LRapidName[i].WriteItem(NumData, Index, Lindex);
                            }
                            else
                            {
                                LRapidName[i].WriteItem(NumData, Index);
                            }
                        }
                        else
                        {
                            LRapidName[i].Value = NumData;
                        }
                        break;
                    case "bool":
                        Bool BoolData = new Bool();
                        BoolData.FillFromString(LRValue[i].ToString());
                        if (LRapidName[i].IsArray)
                        {
                            if (ArrayRank(LRapidName[i]) > 1)
                            {
                                LRapidName[i].WriteItem(BoolData, Index, Lindex);
                            }
                            else
                            {
                                LRapidName[i].WriteItem(BoolData, Index);
                            }
                        }
                        else
                        {
                            LRapidName[i].Value = BoolData;
                        }
                        break;
                    case "string":
                        ABB.Robotics.Controllers.RapidDomain.String StrData = new ABB.Robotics.Controllers.RapidDomain.String();
                        StrData.FillFromString(LRValue[i].ToString());
                        if (LRapidName[i].IsArray)
                        {
                            if (ArrayRank(LRapidName[i]) > 1)
                            {
                                LRapidName[i].WriteItem(StrData, Index, Lindex);
                            }
                            else
                            {
                                LRapidName[i].WriteItem(StrData, Index);
                            }
                        }
                        else
                        {
                            LRapidName[i].Value = StrData;
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public ArrayData TransformData(RapidData RData)
        {
            ArrayData AD = (ArrayData)RData.Value;
            return AD;
        }

        public int ArrayRank(RapidData RData)
        {
            return TransformData(RData).Rank;
        }

        public void LogSub()
        {
            RobotData RD = new RobotData();
            RD.rd_EventLog.MessageWritten += Rd_EventLog_MessageWritten;
        }

        private void Rd_EventLog_MessageWritten(object sender, EventArgs e)
        {
           
        }
    }
}
