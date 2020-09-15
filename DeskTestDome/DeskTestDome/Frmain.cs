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
using System.Threading;
using ABB.Robotics.Controllers.EventLogDomain;

namespace DeskTestDome
{
    public partial class Frmain : Form
    {

        //控制器信息
        public ControllerInfo info;
        //数组对应序号
        private int pindex = 1;

        ////机器人数据
        //public RapidData rd_Dataindex;//点位信号
        //public RapidData rd_TestNum;//测试次数
        //public RapidData rd_MaxTestTimes;//最大测试次数
        //public RapidData rd_Point;//测试点位
        //public RapidData rd_MoveSpeed;//移动速度
        //public RapidData rd_Zone;//转弯半径
        //public RapidData rd_SelectAction;//气缸动作信号
        //public RapidData rd_SetForce;//设置力值
        //public RapidData rd_PressPermis;//按压允许
        //public RapidData rd_MovePermis;//移动允许
        //public RapidData rd_JudgeWaitSign;//等待开始条件信号
        //public RapidData rd_JudgeWaitMidSign;//等待到位信号
        //public RapidData rd_JudgeWaitStartSign;//等待中间到位信号
        //public RapidData rd_PointC;//圆弧第二个点
        //public RapidData rd_MoveType;//移动类型
        //public RapidData rd_SelectActionReset;//气缸信号复位


        public ABB.Robotics.Controllers.RapidDomain.Task t;
        string[] SpeedData = new string[100];
        string[] ZoneData = new string[100];
        string[] CylinderData = new string[100];
        string[] ForceData = new string[100];
        string[] PermisData = new string[100];
        string[] MoveTypeData = new string[100];
        string[] WaitSignalData = new string[100];
        string end = "0";

        //弹窗设定
        public bool JudgeBox = false;

        //实例化RobotClass类
        RobotClass MyRobot = new RobotClass();
        RobotData MyData = new RobotData();
        RobotServise MyServise = new RobotServise();

        //实例化FileHelper类
        FileHelper FileHelp = new FileHelper();

        //实例化FileIndex类
        FileIndex MyFileIndex = new FileIndex();

        //信号读取地址
        string StrPath = @"D:\GithubClone\FirstProject\DeskTestDome\DeskTestDome\bin\Debug\信号描述.txt";

        public delegate void PindexValueChange();
        public event PindexValueChange OnPindexValueChange;

        public delegate void DelegateUpdateView();

        RobTarget Rt ;
        JointTarget Jt;

        

        EventLogMessage mgs;
        public Frmain()
        {
            InitializeComponent();
        }
        //开始加载程序
        private void Form1_Load(object sender, EventArgs e)
        {
            //try
            //{
                
            //    //AddItemD();
            //}
            //catch (Exception)
            //{

            //    cbx_scranRobot.Items.Add("没有找到可用的项目");
            //    cbx_scranRobot.SelectedIndex = 0;
            //    MessageBox.Show("没有对应项目");
            //}
            foreach (ControllerInfo info in MyRobot.ScanList())
            {
                cbx_scranRobot.Items.Add(info.Name);
            }
            if (cbx_scranRobot.Items.Count==0)
            {
                btn_connect.Text = "搜索";
                MessageBox.Show("没有对应项目");
            }
            else
            {
                cbx_scranRobot.SelectedIndex = 0;
            }
            cbx_Zone.SelectedIndex = 0;
            cbx_MoveType.SelectedIndex = 0;
            OnPindexValueChange += Form1_OnPindexValueChange;
            Application.ApplicationExit += Application_ApplicationExit;
            tbx_index.Text = Pindex.ToString();
            dgv_ShowData.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_ShowData.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SignalShow();
        }

        //private void AddItemD()
        //{
        //    dgv_signalBound.AllowDrop = true;
        //    treeView1.AllowDrop = true;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        dgv_signalBound.Rows.Add(i, "信号" + i.ToString());
        //    }
        //    this.treeView1.DragDrop += TreeView1_DragDrop;
        //    this.treeView1.DragOver += TreeView1_DragOver;
        //}

        //private void TreeView1_DragDrop(object sender, DragEventArgs e)
        //{
        //    string item = (string)e.Data.GetData(DataFormats.Text);
        //    this.treeView1.Nodes.Add(item);
        //}

        //程序退出时运行
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (MyRobot != null)
            {
                MyRobot.JudgeMaster();
                MyRobot.controllerDis();
            }
            
        }

        //控件启用
        private void ControlEnabled()
        {
            btn_ChangeIndex.Enabled = true;
            btn_Enter.Enabled = true;
            btn_ForceControl.Enabled = true;
            cbx_PointAllow.Enabled = true;
            btn_Clear.Enabled = true;
            btn_Updata.Enabled = true;
            btn_ClearPower.Enabled = true;
        }
        //委托变化
        private void Form1_OnPindexValueChange()
        {
            tbx_index.Text = (Pindex).ToString();
            JudgePress();
        }

        public void AddItem()
        {
            t = RobotClass.con.Rapid.GetTask("T_ROB1");
            RapidSymbolSearchProperties sProp = RapidSymbolSearchProperties.CreateDefault();
            sProp.Recursive = true;
            sProp.GlobalSymbols = true;
            sProp.Types = SymbolTypes.Data;
            sProp.SearchMethod = SymbolSearchMethod.Block;
           //RapidSymbol[] rsCol = t.SearchRapidSymbol(sProp, "RAPID/" + "T_ROB1", string.Empty);
            RapidSymbol[] rsCol = t.SearchRapidSymbol(sProp, "ToolData", string.Empty);
        }

        
        /// <summary>
        /// 控制器连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Text == "搜索")
            {
                btn_connect.Text = "搜索中..";
                foreach (ControllerInfo info in MyRobot.ScanList())
                {
                    cbx_scranRobot.Items.Add(info.Name);
                }
                if (cbx_scranRobot.Items.Count == 0)
                {
                    btn_connect.Text = "搜索";
                    MessageBox.Show("没有对应项目");
                }
                else
                {
                    btn_connect.Text = "连接";
                    cbx_scranRobot.SelectedIndex = 0;
                }
            }
            else
            {

                foreach (ControllerInfo item in RobotClass.ns.Controllers)
                {
                    if (cbx_scranRobot.Text.Equals(item.Name))
                    {
                        if (item.Availability == Availability.Available)
                        {
                            if (RobotClass.con != null)
                            {
                                MyRobot.controllerDis();
                            }
                            RobotClass.con = ControllerFactory.CreateFrom(item);
                            MessageBox.Show("连接上" + item.Name);
                            lbe_connectStaus.Text = "已连接！";
                            lbe_serial.Text = item.ControllerName.ToString();
                            MyRobot = new RobotClass();
                            ControlEnabled();
                            JudgePress();
                            EventChanged();
                            AddItem();
                        }
                    }
                }
            }

            
        }

        public void EventChanged()
        {
            RobotClass.con.Rapid.ExecutionStatusChanged += Rapid_ExecutionStatusChanged;
            RobotClass.con.StateChanged += Con_StateChanged; ;
            RobotClass.con.OperatingModeChanged += Con_OperatingModeChanged;
            MyData.rd_TestNum.ValueChanged += Rd_TestNum_ValueChanged;
            MyData.rd_Dataindex.ValueChanged += Rd_Dataindex_ValueChanged;
            MyData.rd_EventLog.MessageWritten += Rd_EventLog_MessageWritten;
        }
        //通过检测电机的启动停止来后台刷新机器人的坐标值位置
        private void MyData_ChangeEvent(RobTarget Rt)
        {
            lbe_Rx.Text = Rt.Trans.X.ToString("0.00");
            lbe_Ry.Text = Rt.Trans.Y.ToString("0.00");
        }

        private void Rd_EventLog_MessageWritten(object sender, ABB.Robotics.Controllers.EventLogDomain.MessageWrittenEventArgs e)
        {
            mgs = e.Message;
            this.BeginInvoke(new MethodInvoker(() =>
            {
                dgv_log.Rows.Add(mgs.Number, mgs.Title, mgs.Timestamp);
                dgv_log.FirstDisplayedScrollingRowIndex = dgv_log.Rows.Count - 1;
            }));
        }

        private void Con_OperatingModeChanged(object sender, OperatingModeChangeEventArgs e)
        {
            lbe_runStatus.Text = RobotClass.con.OperatingMode.ToString();
        }

        private void Rd_Dataindex_ValueChanged(object sender, DataValueChangedEventArgs e)
        {
           
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(new EventHandler(DataUpdate), sender, e);
            }


        }

        public void DataUpdate(object sender,EventArgs e)
        {
            if (cbx_FollowPoint.Checked)
            {
                for (int i = 0; i < dgv_ShowData.RowCount; i++)
                {
                    if (dgv_ShowData.Rows[i].Cells[0].Value.ToString().Trim() ==MyData.rd_Dataindex.Value.ToString())
                    {
                        for (int j = dgv_ShowData.SelectedRows.Count; j > 0; j--)
                        {
                            int dg = dgv_ShowData.SelectedRows[j - 1].Index;
                            dgv_ShowData.Rows[dgv_ShowData.SelectedRows[j - 1].Index].Selected = false;
                        }
                        dgv_ShowData.Rows[i].Selected = true;
                        dgv_ShowData.FirstDisplayedScrollingRowIndex = i;
                        break;
                    }
                }
            }
        }
        

        private void Rd_TestNum_ValueChanged(object sender, DataValueChangedEventArgs e)
        {
            tbx_CycleTimes.Text = MyData.rd_TestNum.Value.ToString();
        }

        private void Con_StateChanged(object sender, StateChangedEventArgs e)
        {
            try
            {
                lbe_MotionStatus.Text = RobotClass.con.State.ToString();
                if (RobotClass.con.State == ControllerState.MotorsOn)
                {
                    T_RobotData.Start();
                }
                else
                {
                    T_RobotData.Stop();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("控制器中断");
                MyRobot.controllerDis();
                    
            }
            
        }
        private void T_RobotData_Tick(object sender, EventArgs e)
        {
            //MyData.rd__RobTarget = RobotClass.con.MotionSystem.ActiveMechanicalUnit.GetPosition(ABB.Robotics.Controllers.MotionDomain.CoordinateSystemType.Base);
            if(Rt.ToString() != MyData.rd__RobTarget.ToString())
            {
                System.Threading.Tasks.Task task2 = System.Threading.Tasks.Task.Run(() =>
                {
                    Rt = MyData.rd__RobTarget;
                    Jt = MyData.rd_RobotJoint;
                    this.BeginInvoke(new MethodInvoker(() =>
                    {
                        lbe_Rx.Text = Rt.Trans.X.ToString("0.00");
                        lbe_Ry.Text = Rt.Trans.Y.ToString("0.00");
                        lbe_Rz.Text = Rt.Trans.Z.ToString("0.00");
                        lbe_Rq1.Text = Rt.Rot.Q1.ToString("0.000");
                        lbe_Rq2.Text = Rt.Rot.Q2.ToString("0.000");
                        lbe_Rq3.Text = Rt.Rot.Q3.ToString("0.000");
                        lbe_Rq4.Text = Rt.Rot.Q4.ToString("0.000");
                        lbe_R1.Text = Jt.RobAx.Rax_1.ToString("0.00");
                        lbe_R2.Text = Jt.RobAx.Rax_2.ToString("0.00");
                        lbe_R3.Text = Jt.RobAx.Rax_3.ToString("0.00");
                        lbe_R4.Text = Jt.RobAx.Rax_4.ToString("0.00");
                        lbe_R5.Text = Jt.RobAx.Rax_5.ToString("0.00");
                        lbe_R6.Text = Jt.RobAx.Rax_6.ToString("0.00");
                    }));
                });
                Thread.Sleep(10);

            }
            //if (Jt.ToString()!=MyData.rd_RobotJoint.ToString())
            //{
            //    this.BeginInvoke(new MethodInvoker(() =>
            //    {
                    
            //    }));
            //}
        }




        /// <summary>
        /// 运行状态变更
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rapid_ExecutionStatusChanged(object sender, ExecutionStatusChangedEventArgs e)
        {
            lbe_Status.Text = RobotClass.con.Rapid.ExecutionStatus.ToString();
        }
        /// <summary>
        /// 读取机器人数据
        /// </summary>
        //private void ReadRobotData()
        //{
        //    try
        //    {
        //        rd_Dataindex = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "Dataindex");
        //        rd_TestNum = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "TestNum");
        //        rd_MaxTestTimes = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "MaxTestTimes");
        //        rd_Point = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "Point");
        //        rd_MoveSpeed = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "NMoveSpeed");
        //        rd_Zone = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "Zone");
        //        rd_SelectAction = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SelectAction");
        //        rd_SetForce = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SetForce");
        //        rd_PressPermis = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "PressPermis");
        //        rd_MovePermis = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "MovePermis");
        //        rd_JudgeWaitSign = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "JudgeWaitSign");
        //        rd_JudgeWaitMidSign = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "JudgeWaitMidSign");
        //        rd_JudgeWaitStartSign= RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "JudgeWaitStartSign");
        //        rd_PointC= RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "PointC");
        //        rd_MoveType= RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "MoveType");
        //        rd_SelectActionReset = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SelectActionReset");
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("数据丢失请检查机器人程序");
        //    }
        //}

        //判断点位结果

        private void PindexChangeControlPerpor(ArrayData AD, Control c,int i=-1)
        {
            if (c.GetType() == typeof(Button))
            {
                if (i>=0)
                {
                    switch (((Bool)AD[Pindex - 1,i]).ToString())
                    {
                        case "True":
                            c.BackColor = Color.Red;
                            break;
                        case "False":
                            c.BackColor = Color.Gainsboro;
                            break;
                        default:
                            c.BackColor = Color.Gainsboro;
                            break;
                    }
                }
                else
                {
                    switch (((Bool)AD[Pindex - 1]).ToString())
                    {
                        case "True":
                            c.BackColor = Color.Red;
                            break;
                        case "False":
                            c.BackColor = Color.Gainsboro;
                            break;
                        default:
                            c.BackColor = Color.Gainsboro;
                            break;
                    }
                }
                
            }
        }

        private void PindexChangeCbxPerpor(ArrayData AD, CheckBox cb,int i)
        {
           
                switch (((Bool)AD[Pindex - 1, i]).ToString())
                {
                    case "True":
                        cb.Checked = false;
                        break;
                    case "False":
                        cb.Checked = true;
                        break;
                    default:
                        cb.Checked = false;
                        break;
                }
           
        }
        private void JudgePress()
        {
            PindexChangeControlPerpor(MyServise.TransformData(MyData.rd_PressPermis), btn_ForceControl);
            PindexChangeControlPerpor(MyServise.TransformData(MyData.rd_SelectAction), btn_cy1, 0);
            PindexChangeControlPerpor(MyServise.TransformData(MyData.rd_SelectAction), btn_cy2, 1);
            PindexChangeControlPerpor(MyServise.TransformData(MyData.rd_SelectAction), btn_cy3, 2);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitStartSign), cbx_cy1, 0);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitStartSign), cbx_cy2, 1);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitStartSign), cbx_cy3, 2);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitMidSign), cbx_cyc1, 0);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitMidSign), cbx_cyc2, 1);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitMidSign), cbx_cyc3, 2);
            PindexChangeCbxPerpor(MyServise.TransformData(MyData.rd_JudgeWaitMidSign), cbx_cyc3, 2);
            ArrayData mp = (ArrayData)MyData.rd_MovePermis.Value;
            switch (((Bool)mp[Pindex - 1]).ToString())
            {
                case "True":
                    cbx_PointAllow.Checked = true;
                    break;
                case "False":
                    cbx_PointAllow.Checked = false;
                    break;
                default:
                    cbx_PointAllow.Checked = true;
                    break;
            }
        }
        //力控制按钮
        private void btn_ForceControl_Click(object sender, EventArgs e)
        {

            try
            {
                //if (!m.IsMaster)
                //{

                //}
                MyRobot.MasterConytol(btn_ClearPower);
                bool S = false;
                if (MyData.rd_PressPermis.IsArray)
                {
                    ArrayData pp = (ArrayData)MyData.rd_PressPermis.Value;
                    if (((Bool)pp[Pindex - 1]).ToString() == "True")
                    {
                        btn_ForceControl.BackColor = Color.Gainsboro;
                        MyServise.WriteData(MyData.rd_PressPermis, "False", Pindex - 1);
                        
                    }
                    if (((Bool)pp[Pindex - 1]).ToString() == "False")
                    {
                        btn_ForceControl.BackColor = Color.Red;
                        MyServise.WriteData(MyData.rd_PressPermis, "True", Pindex - 1);
                        S = true;
                    }
                }
                if (S)
                {
                    for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
                    {
                        if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                        {
                            ArrayData sf = (ArrayData)MyData.rd_SetForce.Value;
                            dgv_ShowData.Rows[i].Cells[6].Value = sf[Pindex-1].ToString();
                            goto jump;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
                    {
                        if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                        {
                            dgv_ShowData.Rows[i].Cells[6].Value = "×";
                            goto jump;
                        }
                    }
                }
            jump:
                S = false;

            }
            catch (Exception re)
            {
                MyRobot.JudgeMaster();
                MessageBox.Show("没有获得相应权限" + re.Message);
            }
        }
        //Pindex的写入和读取
        public int Pindex
        {
            get 
            {
                
                return pindex;
            }
            set
            {
                if (value<101)
                {
                    pindex = value;
                    PindexValueChang();
                }
                
            }
        }
        //Pindex值变化方法
        public void PindexValueChang()
        {
            OnPindexValueChange?.Invoke();
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            btn_Enter.BackColor = Color.Red;
            JudgeForm JF = new JudgeForm();
            if (!JudgeForm.CheckResult)
            {
                JF.ShowDialog();
            }
            if (JudgeForm.JudgeResult || JudgeForm.CheckResult)
            {
                MyRobot.MasterConytol(btn_ClearPower);
                if (MyData.rd_MoveSpeed.IsArray)
                {
                    List<RapidData> RDataList = new List<RapidData>()
                    {
                        MyData.rd_MoveSpeed,
                        MyData.rd_Zone,
                        MyData.rd_SetForce,
                        MyData.rd_MoveType,
                        MyData.rd_MovePermis,
                        MyData.rd_JudgeWaitSign
                        
                        
                    };

                    List<string> RValueList = new List<string>()
                    {
                        tbx_Speed.Text,
                        cbx_Zone.SelectedItem.ToString(),
                        tbx_Force.Text,
                        cbx_MoveType.SelectedItem.ToString(),
                        cbx_PointAllow.Checked.ToString(),
                        tbx_waitSign.Text
                    };
                    MyServise.WriteData(RDataList, RValueList, Pindex - 1);
                }
                for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
                {
                    if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                    {
                        dgv_ShowData.Rows[i].SetValues((Pindex).ToString(), GetWaitSign(true)[0], GetMoveType(true)[0], GetSpeed(true)[0], GetZone(true)[0], GetCylinder(true)[0], GetForce(true)[0], GetPermis(true)[0]);
                        goto end;
                    }
                }
                dgv_ShowData.Rows.Add((Pindex).ToString(), GetWaitSign(true)[0], GetMoveType(true), GetSpeed(true)[0], GetZone(true)[0], GetCylinder(true)[0], GetForce(true)[0], GetPermis(true)[0]);
            }
            end:
            btn_Enter.BackColor = Color.Gainsboro;
            Pindex += 1;
        }

        private void btn_ChangeIndex_Click(object sender, EventArgs e)
        {
            switch (btn_ChangeIndex.Text)
            {
                case "确认":
                    tbx_index.ReadOnly = true;
                    btn_ChangeIndex.Text = "修改";
                    Pindex = Convert.ToInt16(tbx_index.Text);
                    //JudgePress();
                    break;
                case "修改":
                    if (dgv_ShowData.SelectedRows.Count > 0)
                    {
                        Pindex = Convert.ToInt16(dgv_ShowData.SelectedRows[0].Cells[0].Value);
                        tbx_index.Text = (Pindex).ToString();
                    }
                    else
                    {
                        tbx_index.ReadOnly = false;
                        btn_ChangeIndex.Text = "确认";
                    }
                    break;
                default:
                    btn_ChangeIndex.Text = "修改";
                    break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyRobot != null)
            {
                MyRobot.JudgeMaster();
                MyRobot.controllerDis();
            }
           
        }

        public void GetData()
        {
            //线程开始;
            SpeedData = GetSpeed(false);
            ZoneData = GetZone(false);
            CylinderData = GetCylinder(false);
            ForceData = GetForce(false);
            PermisData = GetPermis(false);
            MoveTypeData = GetMoveType(false);
            WaitSignalData = GetWaitSign(false);
            end = "1";
            //线程结束;
        }

        private void btn_Updata_Click(object sender, EventArgs e)
        {
            Thread MyThread;
            MyThread = new Thread(new ThreadStart(UpdateView));
            lbe_threadShow.Text = "数据加载中";
            MyThread.Start();
        }

        public void UpdateView()
        {
            GetData();
            BeginInvoke(new MethodInvoker(() =>
            {
                dgv_ShowData.Rows.Clear();
                ArrayData pp = (ArrayData)MyData.rd_MoveSpeed.Value;
                if (end.Equals("1"))
                {
                    for (int i = 0; i < pp.Length; i++)
                    {
                        dgv_ShowData.Rows.Add(i + 1, WaitSignalData[i], MoveTypeData[i], SpeedData[i], ZoneData[i], CylinderData[i], ForceData[i], PermisData[i]);
                    }
                }
                lbe_threadShow.Text = "数据加载完成";
            }));
        }

        public string JudgeStringEmpty(string objectString)
        {
            if (objectString == string.Empty)
            {
                return "×";
            }
            else
            {
                return objectString;
            }
        }

        public string[] GetRobotNumArray(bool JIndex, ArrayData pp)
        {
            if (JIndex)
            {
                string[] S = new string[100];
                S[0] = ((Num)pp[Pindex - 1]).ToString();
                return S;
            }
            else
            {
                string[] S = new string[100];
                for (int i = 0; i < pp.Length; i++)
                {
                    S[i] = ((Num)pp[i]).ToString();
                }
                return S;
            }
        }

        public string[] GetRobotBoolArray(bool JIndex, ArrayData pp)
        {
            if (JIndex)
            {
                string[] S = new string[100];
                S[0] = ((Bool)pp[Pindex - 1]).ToString();
                return S;
            }
            else
            {
                string[] S = new string[100];
                for (int i = 0; i < pp.Length; i++)
                {
                    S[i] = ((Bool)pp[i]).ToString();
                }
                return S;
            }
        }

        public string[] GetSpeed(bool JIndex)
        {
            ArrayData pp = (ArrayData)MyData.rd_MoveSpeed.Value;
            return GetRobotNumArray(JIndex, pp);
        }

        public string[] GetZone(bool JIndex)
        {
            ArrayData pp = (ArrayData)MyData.rd_Zone.Value;
            return GetStr(JIndex, pp);
        }

        public string[] GetMoveType(bool JIndex)
        {
            ArrayData pp = (ArrayData)MyData.rd_MoveType.Value;
            return GetStr(JIndex, pp);
        }

        public string[] GetWaitSign(bool JIndex)
        {
            ArrayData pp = (ArrayData)MyData.rd_JudgeWaitSign.Value;
            return GetStr(JIndex, pp);
        }

        public string[] GetStr(bool JIndex, ArrayData pp)
        {
            pp.Mode = ArrayModes.Dynamic;
            string[] S = new string[100];
            int i = 0;
            foreach (IRapidData item in pp)
            {
                if (JIndex)
                {
                    if (i == Pindex - 1)
                    {
                        S[0] = JudgeStringEmpty(item.ToString().Trim('"'));
                        goto end;
                    }
                    
                }
                else
                {
                    S[i] = JudgeStringEmpty(item.ToString().Trim('"'));
                }
                i++;
            }
            end:
            return S;
        }

        public string GetWaitStartSign(int GetIndex,int GetSIndex)
        {
            ArrayData JW = (ArrayData)MyData.rd_JudgeWaitStartSign.Value;
            if (((Bool)JW[GetIndex, GetSIndex]))
            {
                return "1";
            }
            else
            {
                return "0";
            }

        }

        public string GetWaitMidSign(int GetIndex, int GetSIndex)
        {
            ArrayData JW = (ArrayData)MyData.rd_JudgeWaitMidSign.Value;
            if (((Bool)JW[GetIndex, GetSIndex]))
            {
                return "1";
            }
            else
            {
                return "0";
            }

        }

        public string[] GetCylinder(bool JIndex)
        {
            ArrayData pp = (ArrayData)MyData.rd_SelectAction.Value;
            string RS1 = ((Bool)pp[Pindex - 1, 0]).ToString();
            string RS2 = ((Bool)pp[Pindex - 1, 1]).ToString();
            string RS3 = ((Bool)pp[Pindex - 1, 2]).ToString();
            if (JIndex)
            {
                string[] S = new string[100];
                if (((Bool)pp[Pindex - 1, 0]))
                {
                    S[0] = "1" + GetWaitStartSign(Pindex - 1,0)+GetWaitMidSign(Pindex - 1, 0); 
                }
                else
                {
                    S[0] = "0"+ GetWaitStartSign(Pindex - 1, 0) + GetWaitMidSign(Pindex - 1, 0);
                }
                if (((Bool)pp[Pindex - 1, 1]))
                {
                    S[0] = S[0] + " 1" + GetWaitStartSign(Pindex - 1, 1) + GetWaitMidSign(Pindex - 1, 1);
                }
                else
                {
                    S[0] = S[0] + " 0" + GetWaitStartSign(Pindex - 1, 1) + GetWaitMidSign(Pindex - 1, 1);
                }
                if (((Bool)pp[Pindex - 1, 2]))
                {
                    S[0] = S[0] + " 1" + GetWaitStartSign(Pindex - 1, 2) + GetWaitMidSign(Pindex - 1, 2);
                }
                else
                {
                    S[0] = S[0] + " 0" + GetWaitStartSign(Pindex - 1, 2) + GetWaitMidSign(Pindex - 1, 2);
                }
                return S;
            }
            else
            {
                string[] S = new string[100];
                for (int i = 0; i < pp.Length; i++)
                {
                    if (((Bool)pp[i, 0]))
                    {
                        S[i] = "1" + GetWaitStartSign(i, 0) + GetWaitMidSign(i, 0);
                    }
                    else
                    {
                        S[i] = "0" + GetWaitStartSign(i, 0) + GetWaitMidSign(i, 0);
                    }
                    if (((Bool)pp[i, 1]))
                    {
                        S[i] = S[i] + " 1" + GetWaitStartSign(i, 1) + GetWaitMidSign(i, 1);
                    }
                    else
                    {
                        S[i] = S[i] + " 0" + GetWaitStartSign(i, 1) + GetWaitMidSign(i, 1);
                    }
                    if (((Bool)pp[i, 2]))
                    {
                        S[i] = S[i] + " 1" + GetWaitStartSign(i, 2) + GetWaitMidSign(i, 2);
                    }
                    else
                    {
                        S[i] = S[i] + " 0" + GetWaitStartSign(i, 2) + GetWaitMidSign(i, 2);
                    }
                }
                return S;
            }
        }

        public string[] GetForce(bool JIndex)
        {
            ArrayData SF = (ArrayData)MyData.rd_SetForce.Value;
            ArrayData pp = (ArrayData)MyData.rd_PressPermis.Value;
            string ForceNum = ((Num)SF[Pindex - 1]).ToString();
            string PPermis = ((Bool)pp[Pindex - 1]).ToString();
            if (JIndex)
            {

                if ((Bool)pp[Pindex - 1])
                {
                    string[] F = new string[1];
                    F[0] = ((Num)SF[Pindex - 1]).ToString();
                    return F;
                }
                else
                {
                    string[] S = new string[1];
                    S[0] = "×";
                    return S;
                }

            }
            else
            {
                string[] S = new string[100];
                for (int i = 0; i < pp.Length; i++)
                {
                    if ((Bool)pp[i])
                    {
                        S[i] = ((Num)SF[i]).ToString();
                    }
                    else
                    {
                        S[i] = "×";
                    }
                }
                return S;
            }
        }

        public string[] GetPermis(bool JIndex)
        {
            ArrayData pp = (ArrayData)MyData.rd_MovePermis.Value;
            return GetRobotBoolArray(JIndex, pp);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            if (dgv_ShowData.SelectedRows.Count == 0)
            {
                dgv_ShowData.Rows.Clear();
            }
            else
            {
                for (int i = dgv_ShowData.SelectedRows.Count; i > 0; i--)
                {
                    dgv_ShowData.Rows.RemoveAt(dgv_ShowData.SelectedRows[i - 1].Index);
                }
            }


        }

        private void btn_ClearPower_Click(object sender, EventArgs e)
        {
            if (MyRobot != null)
            {
                MyRobot.JudgeMaster();
            }
        }

        private void btn_RoutStop_Click(object sender, EventArgs e)
        {
            if (RobotClass.con.OperatingMode == ControllerOperatingMode.Auto)
            {
                if (RobotClass.con.Rapid.ExecutionStatus == ExecutionStatus.Running)
                {
                    MyRobot.MasterConytol(btn_ClearPower);
                    RobotClass.con.Rapid.Stop(StopMode.Immediate);
                }
            }
        }

        private void btn_RoutStart_Click(object sender, EventArgs e)
        {
            if (RobotClass.con.OperatingMode == ControllerOperatingMode.Auto)
            {
                if (RobotClass.con.Rapid.ExecutionStatus == ExecutionStatus.Stopped)
                {
                    MyRobot.MasterConytol(btn_ClearPower);
                    RobotClass.con.Rapid.Start();
                }
            }
        }

        private void btn_MainStart_Click(object sender, EventArgs e)
        {
            if (RobotClass.con.OperatingMode == ControllerOperatingMode.Auto)
            {
                if (RobotClass.con.Rapid.ExecutionStatus == ExecutionStatus.Stopped)
                {
                    MyRobot.MasterConytol(btn_ClearPower);

                    t = RobotClass.con.Rapid.GetTask("T_ROB1");
                    t.SetProgramPointer("Module1", "main");
                    RobotClass.con.Rapid.Start();
                }
            }
        }

        private void btn_montionOn_Click(object sender, EventArgs e)
        {
            if (RobotClass.con.State == ControllerState.MotorsOff)
            {
                MyRobot.MasterConytol(btn_ClearPower);
                RobotClass.con.State = ControllerState.MotorsOn;

            }
        }

        private void dgv_ShowData_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_ShowData.SelectedRows.Count > 0)
            {
                Pindex = Convert.ToInt16(dgv_ShowData.SelectedRows[0].Cells[0].Value);
            }
        }

        private void btn_cy1_Click(object sender, EventArgs e)
        {
            try
            {
                MyRobot.MasterConytol(btn_ClearPower);
                string S = string.Empty;
                if (MyData.rd_SelectAction.IsArray)
                {
                    ArrayData pp = (ArrayData)MyData.rd_SelectAction.Value;
                    if (((Bool)pp[Pindex - 1, 0]).ToString() == "True")
                    {
                        btn_cy1.BackColor = Color.Gainsboro; ;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("False");
                        MyData.rd_SelectAction.WriteItem(r_pp, Pindex - 1, 0);
                        S = "0";
                    }
                    if (((Bool)pp[Pindex - 1, 0]).ToString() == "False")
                    {
                        btn_cy1.BackColor = Color.Red;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("True");
                        MyData.rd_SelectAction.WriteItem(r_pp, Pindex - 1, 0);
                        S = "1";
                    }
                }
                for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
                {
                    if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                    {
                        string s = dgv_ShowData.Rows[i].Cells[5].Value.ToString();
                        s = s.Remove(0, 1).Insert(0, S);
                        dgv_ShowData.Rows[i].Cells[5].Value = s;
                        goto jump;
                    }
                }
            jump:
                S = null;
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
                MyRobot.MasterConytol(btn_ClearPower);
                string S = string.Empty;
                if (MyData.rd_SelectAction.IsArray)
                {
                    ArrayData pp = (ArrayData)MyData.rd_SelectAction.Value;
                    if (((Bool)pp[Pindex - 1, 1]).ToString() == "True")
                    {
                        btn_cy2.BackColor = Color.Gainsboro; ;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("False");
                        MyData.rd_SelectAction.WriteItem(r_pp, Pindex - 1, 1);
                        S = "0";
                    }
                    if (((Bool)pp[Pindex - 1, 1]).ToString() == "False")
                    {
                        btn_cy2.BackColor = Color.Red;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("True");
                        MyData.rd_SelectAction.WriteItem(r_pp, Pindex - 1, 1);
                        S = "1";
                    }
                }
                for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
                {
                    if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                    {
                        string s = dgv_ShowData.Rows[i].Cells[5].Value.ToString();
                        s = s.Remove(4, 1).Insert(4, S);
                        dgv_ShowData.Rows[i].Cells[5].Value = s;
                        goto jump;
                    }
                }
            jump:
                S = null;
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
                MyRobot.MasterConytol(btn_ClearPower);
                string S = string.Empty;
                if (MyData.rd_SelectAction.IsArray)
                {
                    ArrayData pp = (ArrayData)MyData.rd_SelectAction.Value;
                    if (((Bool)pp[Pindex - 1, 2]).ToString() == "True")
                    {
                        btn_cy3.BackColor = Color.Gainsboro; ;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("False");
                        MyData.rd_SelectAction.WriteItem(r_pp, Pindex - 1, 2);
                        S = "0";
                    }
                    if (((Bool)pp[Pindex - 1, 2]).ToString() == "False")
                    {
                        btn_cy3.BackColor = Color.Red;
                        Bool r_pp = new Bool();
                        r_pp.FillFromString2("True");
                        MyData.rd_SelectAction.WriteItem(r_pp, Pindex - 1, 2);
                        S = "1";
                    }
                }
                for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
                {
                    if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                    {
                        string s = dgv_ShowData.Rows[i].Cells[5].Value.ToString();
                        s = s.Remove(8, 1).Insert(8, S);
                        dgv_ShowData.Rows[i].Cells[5].Value = s;
                        goto jump;
                    }
                }
            jump:
                S = null;
            }
            catch (Exception re)
            {

                MyRobot.JudgeMaster();
                MessageBox.Show("没有获得相应权限" + re.Message);
            }
        }

        private void btn_cy1_BackColorChanged(object sender, EventArgs e)
        {
            if (btn_cy1.BackColor == Color.Red)
            {
                cbx_cy1.Enabled = true;
            }
            else
            {
                cbx_cy1.Enabled = false;
            }
        }

        private void btn_cy2_BackColorChanged(object sender, EventArgs e)
        {
            if (btn_cy2.BackColor == Color.Red)
            {
                cbx_cy2.Enabled = true;
            }
            else
            {
                cbx_cy2.Enabled = false;
            }
        }

        private void btn_cy3_BackColorChanged(object sender, EventArgs e)
        {
            if (btn_cy3.BackColor == Color.Red)
            {
                cbx_cy3.Enabled = true;
            }
            else
            {
                cbx_cy3.Enabled = false;
            }
        }

        private void cbx_Click(object sender, EventArgs e)
        {
            MyRobot.MasterConytol(btn_ClearPower);
            string S = string.Empty;
            RapidData RData = null;
            int Sindex = 0;
            int DgvIndex = 0;
            CheckBox cb = (CheckBox)sender;
            switch (cb.Name)
            {
                case "cbx_cy1":
                    RData = MyData.rd_JudgeWaitStartSign;
                    Sindex = 0;
                    DgvIndex = 1;
                    break;
                case "cbx_cy2":
                    RData = MyData.rd_JudgeWaitStartSign;
                    Sindex = 1;
                    DgvIndex = 5;
                    break;
                case "cbx_cy3":
                    RData = MyData.rd_JudgeWaitStartSign;
                    Sindex = 2;
                    DgvIndex = 9;
                    break;
                case "cbx_cyc1":
                    RData = MyData.rd_JudgeWaitMidSign;
                    Sindex = 0;
                    DgvIndex = 2;
                    break;
                case "cbx_cyc2":
                    RData = MyData.rd_JudgeWaitMidSign;
                    Sindex = 1;
                    DgvIndex = 6;
                    break;
                case "cbx_cyc3":
                    RData = MyData.rd_JudgeWaitMidSign;
                    Sindex = 2;
                    DgvIndex = 10;
                    break;
                default:
                    break;
            }
            if (!cb.Checked)
            {
                Bool r_pp = new Bool();
                r_pp.FillFromString2("True");
                MyServise.WriteData(RData, r_pp, Pindex - 1, Sindex);
                cb.Checked = false;
                S = "1";
            }
            else
            {
                Bool r_pp = new Bool();
                r_pp.FillFromString2("False");
                MyServise.WriteData(RData, r_pp, Pindex - 1, Sindex);
                cb.Checked = true;
                S = "0";
            }
            for (int i = 0; i < dgv_ShowData.Rows.Count; i++)
            {
                if (dgv_ShowData.Rows[i].Cells[0].Value.ToString() == Pindex.ToString())
                {
                    string s = dgv_ShowData.Rows[i].Cells[5].Value.ToString();
                    s = s.Remove(DgvIndex, 1).Insert(DgvIndex, S);
                    dgv_ShowData.Rows[i].Cells[5].Value = s;
                    goto jump;
                }
            }
        jump:
            S = null;
        }

       

        //private void 删除信号ToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //        this.treeView1.SelectedNode.Remove();
        //}

        //private void treeView1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    if (treeView1.SelectedNode==null)
        //    {
        //        this.treeView1.ContextMenuStrip = null;
        //        return;
        //    }
        //    if (MouseButtons==MouseButtons.Right)
        //    {
        //        this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
        //    }
        //}

        private void dgv_ShowData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbx_cy2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MyRobot.MasterConytol(btn_ClearPower);
            MyServise.WriteData(MyData.rd_MaxTestTimes, tbx_MaxTImes.Text);
        }

        private void dgv_signalBound_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SignalShow()
        {
           FileHelp.Signaldescription(StrPath, MyFileIndex.strIndex,MyFileIndex.strDescribe);
            for (int i = 0; i < MyFileIndex.strIndex.Count; i++)
            {
                for (int j = 0; j < dgv_signalShow.Rows.Count; j++)
                {
                    if (dgv_signalShow.Rows[j].Cells[0].Value!=null && dgv_signalShow.Rows[j].Cells[1].Value!=null)
                    {
                        if (dgv_signalShow.Rows[j].Cells[0].Value.Equals(MyFileIndex.strIndex[i]) && dgv_signalShow.Rows[j].Cells[1].Value.Equals(MyFileIndex.strDescribe[i]))
                        {
                            goto end;
                        }
                    }
                    else
                    {
                        dgv_signalShow.Rows.RemoveAt(j);
                        dgv_signalShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        dgv_signalShow.ReadOnly = true;
                        btn_dgvSignalAdd.Visible = false;
                        goto end;
                    }
                    
                }
                dgv_signalShow.Rows.Add(MyFileIndex.strIndex[i], MyFileIndex.strDescribe[i]);
                { Tag = MyFileIndex; };
            end:
            string s = null;
            }
            dgv_signalShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_signalShow.ReadOnly = true;
            btn_dgvSignalAdd.Visible = false;
        }
        /// <summary>
        /// 对文本的信号进行删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (dgv_signalShow.SelectedRows.Count == 0)
            //{
            //    dgv_signalShow.Rows.Clear();
            //}
            //else
            //{
            //    for (int i = dgv_signalShow.SelectedRows.Count; i > 0; i--)
            //    {

            //        dgv_signalShow.Rows.RemoveAt(dgv_signalShow.SelectedRows[i - 1].Index);
            //    }
            //}
            for (int i = 0; i < MyFileIndex.strIndex.Count; i++)
            {
                if (MyFileIndex.strIndex[i].Equals(dgv_signalShow.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    MyFileIndex.strIndex.RemoveAt(i);
                    MyFileIndex.strDescribe.RemoveAt(i);
                }
            }
            FileHelp.SingalContentAdd(StrPath, FileHelp.FileIndex_OnListChange(MyFileIndex.StrB, MyFileIndex.strIndex, MyFileIndex.strDescribe));
            dgv_signalShow.Rows.RemoveAt(dgv_signalShow.SelectedRows[0].Index);
        }
        /// <summary>
        /// 选择对应的信号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_signalShow_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgv_signalShow.SelectedRows.Count>0||dgv_signalShow.SelectedCells.Count>0)
                {
                    dgv_signalShow.ClearSelection();
                    dgv_signalShow.Rows[e.RowIndex].Selected = true;
                    dgv_signalShow.CurrentCell = dgv_signalShow.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    删除ToolStripMenuItem.Visible = true;
                    cms_signalAction.Show(MousePosition.X, MousePosition.Y);
                }
            }

        }
        /// <summary>
        /// 表格右键添加功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_signalShow.ReadOnly = false;
            for (int i = 0; i < dgv_signalShow.Rows.Count; i++)
            {
                dgv_signalShow.Rows[i].ReadOnly = true;
            }
            dgv_signalShow.Rows.Add();
            dgv_signalShow.SelectionMode = DataGridViewSelectionMode.CellSelect;
            btn_dgvSignalAdd.Visible = true;
        }

        private void btn_dgvSignalAdd_Click(object sender, EventArgs e)
        {
            if (dgv_signalShow.Rows[dgv_signalShow.Rows.Count-1].Cells[0].Value!=null&& dgv_signalShow.Rows[dgv_signalShow.Rows.Count-1].Cells[1].Value != null)
            {
                MyFileIndex.strIndex.Add(dgv_signalShow.Rows[dgv_signalShow.Rows.Count - 1].Cells[0].Value.ToString());
                MyFileIndex.strDescribe.Add(dgv_signalShow.Rows[dgv_signalShow.Rows.Count - 1].Cells[1].Value.ToString());
                FileHelp.SingalContentAdd(StrPath, FileHelp.FileIndex_OnListChange(MyFileIndex.StrB,MyFileIndex.strIndex,MyFileIndex.strDescribe));
            }
            dgv_signalShow.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_signalShow.ReadOnly = true;
            btn_dgvSignalAdd.Visible = false;
        }

        private void dgv_signalShow_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgv_signalShow_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (dgv_signalShow.CurrentCell.ColumnIndex==0)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.'))
                    e.Handled = true;
                if (e.KeyChar == '\b')
                    e.Handled = false;
            }
           
        }

        private void dgv_signalShow_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgv_signalShow.CurrentCell.ColumnIndex==0)
            {
                e.Control.KeyPress -= Control_KeyPress;
                e.Control.KeyPress += Control_KeyPress;

                //e.Control.KeyPress += (object obj, KeyPressEventArgs key) =>
                //{
                //    if (!(key.KeyChar >= '0' && key.KeyChar <= '9' || key.KeyChar == '.'))
                //        key.Handled = true;
                //    if (key.KeyChar == '\b')
                //        key.Handled = false;
                //};
            }
        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgv_signalShow.CurrentCell.ColumnIndex == 0)
            {
                if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.'))
                    e.Handled = true;
                if (e.KeyChar == '\b')
                    e.Handled = false;
            }
            
        }

        private void dgv_signalShow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgv_signalShow.Rows.Count==0)
                {
                    删除ToolStripMenuItem.Visible = false;
                    cms_signalAction.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }

        
    }
}

