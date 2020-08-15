using ABB.Robotics.Controllers.RapidDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskTestDome
{
    class RobotServise
    {
        public void WriteData(RapidData RapidName, object WriteData, int Index = 1)
        {

            if (RapidName.RapidType == "num")
            {
                Num NumData = new Num();
                NumData.FillFromString2(WriteData.ToString());
                if (RapidName.IsArray)
                {
                    RapidName.WriteItem(NumData, Index);
                }
                else
                {
                    RapidName.Value = NumData;
                }

            }

            switch (RapidName.RapidType)
            {
                case "num":
                    Num NumData = new Num();
                    NumData.FillFromString2(WriteData.ToString());
                    if (RapidName.IsArray)
                    {
                        RapidName.WriteItem(NumData, Index);
                    }
                    else
                    {
                        RapidName.Value = NumData;
                    }
                    break;
                case "bool":
                    Bool BoolData = new Bool();
                    BoolData.FillFromString2(WriteData.ToString());
                    if (RapidName.IsArray)
                    {
                        RapidName.WriteItem(BoolData, Index);
                    }
                    else
                    {
                        RapidName.Value = BoolData;
                    }
                    break;
                default:
                    break;
            }


        }

        public ArrayData TransformData(RapidData RData)
        {
            ArrayData AD = (ArrayData)RData.Value;
            return AD;
        }
    }
}
