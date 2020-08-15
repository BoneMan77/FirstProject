using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABB.Robotics.Controllers;
using ABB.Robotics.Controllers.Discovery;
using ABB.Robotics.Controllers.MotionDomain;
using ABB.Robotics.Controllers.RapidDomain;
using ABB.Robotics.Controllers.IOSystemDomain;
using System.Windows.Forms;
using System.Drawing;

namespace DeskTestDome
{

    class RobotClass
    {
        //创建搜索域
        public static NetworkScanner ns;
        //创建控制器
        public static Controller con =null ;
        //控制器权限
        public static Mastership m;
        //判断是否可以登录
        public static bool JudgeLogStatus =false;
        //实例化Form1

        public  bool JudgeBoundControl = true;
        public Control cl;

        //搜索到的控制器列表
        public List<ControllerInfo> ConList = new List<ControllerInfo>();
        /// <summary>
        /// 类初始化
        /// </summary>
        public RobotClass()
        {
            if (JudgeLogStatus)
            {
                con.Logon(UserInfo.DefaultUser);
                m = null;
                JudgeLogStatus = false;
            }

        }

        #region 机器人权限相关操作
        /// <summary>
        /// 判断有没有获得权限
        /// </summary>
        public void JudgeMaster()
        {
            if (m != null)
            {
                if (m.IsMaster) m.Dispose();
            }
        }

        public void MasterConytol(Control c)
        {

            if (JudgeBoundControl)
            {
                cl = c;
                JudgeBoundControl = false;
            }
            if (m == null)
            {
                //Program.MainForm.btn_ClearPower.BackColor = System.Drawing.Color.Yellow;
                c.BackColor = System.Drawing.Color.Yellow;
                m = Mastership.Request(con);
                con.Rapid.MastershipChanged -= Rapid_MastershipChanged;
                con.Rapid.MastershipChanged += Rapid_MastershipChanged;
               
            }
            else
            {
                if (!m.IsMaster)
                {
                    Rapid_MastershipChanged(cl, Color.Yellow);
                    m = Mastership.Request(con);
                }
            }
            

        }

        private void Rapid_MastershipChanged(object sender, MastershipChangedEventArgs e)
        {
            if (RobotClass.m != null)
            {
                if (RobotClass.m.IsMaster)
                {
                    //Program.MainForm.btn_ClearPower.BackColor = System.Drawing.Color.Red;
                    Rapid_MastershipChanged(cl, Color.Red);
                }
                else
                {
                    Rapid_MastershipChanged(cl, Color.Gainsboro);
                }
            }

        }
        /// <summary>
        ///给控件相应颜色
        /// </summary>
        /// <param name="c"></param>
        /// <param name="cr"></param>
        private void Rapid_MastershipChanged(Control c,Color cr)
        {
            c.BackColor= cr;
        }
        #endregion


        #region 将连接到控制的数据进行释放
        public void controllerDis()
        {
                if (RobotClass.con != null)
                {
                    RobotClass.con.Logoff();
                    //RobotClass.con.Dispose();
                    RobotClass.con = null;
                }
        }
        #endregion


        #region 返回控制器列表
        /// <summary>
        /// 搜索控制器返回控制器列表
        /// </summary>
        /// <returns></returns>
        public List<ControllerInfo> ScanList()
        {
            ns = new NetworkScanner();
            ns.Scan();
            foreach (ControllerInfo item in ns.Controllers)
            {
                ConList.Add(item);
            }
            JudgeLogStatus = true;
            return ConList;
        }
        #endregion
    }
}
