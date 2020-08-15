using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.MotionDomain;
using ABB.Robotics.Controllers.RapidDomain;
using ABB.Robotics.Controllers.IOSystemDomain;

namespace DeskTestDome
{
    public partial class CylinderSet : Form
    {
        RapidData crd_SelectAction;
        int cPint;
        RobotClass MyRobot = new RobotClass();

        public CylinderSet()
        {
            InitializeComponent();
        }

        private void CylinderSet_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            cPint = f1.Pindex;
            JudgeColor();
            
        }

        

        
        private void btn_cy1_Click(object sender, EventArgs e)
        {
            try
            {
              // MyRobot. MasterConytol();
                if (crd_SelectAction.IsArray)
                {
                    ArrayData pp = (ArrayData)crd_SelectAction.Value;
                    if (((Bool)pp[cPint - 1, 0]).ToString() == "True")
                    {
                        btn_cy1.BackColor = Color.Gainsboro; ;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("False");
                        crd_SelectAction.WriteItem(r_pp, cPint - 1, 0);

                    }
                    if (((Bool)pp[cPint - 1, 0]).ToString() == "False")
                    {
                        btn_cy1.BackColor = Color.Red;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("True");
                        crd_SelectAction.WriteItem(r_pp, cPint - 1, 0);

                    }
                }
            }
            catch (Exception re)
            {
                MyRobot.JudgeMaster();
                MessageBox.Show("没有获得相应权限" + re.Message);
            }
           
        }

        private void btn_cy2_Click(object sender, EventArgs e)
        {
            
            try
            {
               // MyRobot.MasterConytol();
                if (crd_SelectAction.IsArray)
                {
                    ArrayData pp = (ArrayData)crd_SelectAction.Value;
                    if (((Bool)pp[cPint - 1, 1]).ToString() == "True")
                    {
                        btn_cy2.BackColor = Color.Gainsboro; ;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("False");
                        crd_SelectAction.WriteItem(r_pp, cPint - 1, 1);

                    }
                    if (((Bool)pp[cPint - 1, 1]).ToString() == "False")
                    {
                        btn_cy2.BackColor = Color.Red;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("True");
                        crd_SelectAction.WriteItem(r_pp, cPint - 1, 1);

                    }
                }
            }
            catch (Exception re)
            {

                if (RobotClass.m != null)
                {
                    if (RobotClass.m.IsMaster) RobotClass.m.Dispose();
                }
                MessageBox.Show("没有获得相应权限" + re.Message);
            }
        }

        private void btn_cy3_Click(object sender, EventArgs e)
        { 
            
            try
            {
                //MyRobot.MasterConytol();
                if (crd_SelectAction.IsArray)
                {
                    ArrayData pp = (ArrayData)crd_SelectAction.Value;
                    if (((Bool)pp[cPint - 1, 2]).ToString() == "True")
                    {
                        btn_cy3.BackColor = Color.Gainsboro; ;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("False");
                        crd_SelectAction.WriteItem(r_pp, cPint - 1, 2);

                    }
                    if (((Bool)pp[cPint - 1, 2]).ToString() == "False")
                    {
                        btn_cy3.BackColor = Color.Red;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("True");
                        crd_SelectAction.WriteItem(r_pp, cPint - 1, 2);

                    }
                }
            }
            catch (Exception re)
            {

                MyRobot.JudgeMaster();
                MessageBox.Show("没有获得相应权限" + re.Message);
            }
        }
        

        public void JudgeColor()
        {
            crd_SelectAction = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SelectAction");
            ArrayData pp = (ArrayData)crd_SelectAction.Value;
            switch (((Bool)pp[cPint - 1, 0]).ToString())
            {
                case "False":
                    btn_cy1.BackColor = Color.Gainsboro;
                    break;
                case "True":
                    btn_cy1.BackColor = Color.Red;
                    break;
                default:
                    btn_cy1.BackColor = Color.Gainsboro;
                    break;
            }
            switch (((Bool)pp[cPint - 1, 1]).ToString())
            {
                case "False":
                    btn_cy2.BackColor = Color.Gainsboro;
                    break;
                case "True":
                    btn_cy2.BackColor = Color.Red;
                    break;
                default:
                    btn_cy2.BackColor = Color.Gainsboro;
                    break;
            }
            switch (((Bool)pp[cPint - 1, 2]).ToString())
            {
                case "False":
                    btn_cy3.BackColor = Color.Gainsboro;
                    break;
                case "True":
                    btn_cy3.BackColor = Color.Red;
                    break;
                default:
                    btn_cy3.BackColor = Color.Gainsboro;
                    break;
            }
        }
    }
}
