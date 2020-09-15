using ABB.Robotics.Controllers.EventLogDomain;
using ABB.Robotics.Controllers.RapidDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeskTestDome
{
    class RobotData 
    {

        private RapidData Rd_Dataindex;//点位信号

        private RapidData Rd_TestNum;//测试次数

        private RapidData Rd_MaxTestTimes;//最大测试次数

        private RapidData Rd_Point;//测试点位

        private RapidData Rd_Zone;//转弯半径

        private RapidData Rd_SelectAction;//气缸动作信号

        private RapidData Rd_SetForce;//设置力值

        private RapidData Rd_PressPermis;//按压允许

        private RapidData Rd_MovePermis;//移动允许

        private RapidData Rd_JudgeWaitSign;//等待开始条件信号

        private RapidData Rd_JudgeWaitMidSign;//等待到位信号

        private RapidData Rd_JudgeWaitStartSign;//等待中间到位信号

        private RapidData Rd_PointC;//圆弧第二个点

        private RapidData Rd_MoveType;//移动类型

        private RapidData Rd_SelectActionReset;//气缸信号复位

        private RapidData Rd_MoveSpeed;//机器人速度

        private EventLog Rd_EventLog;//机器人报警数据

        private RobTarget Rd_RobTarget;//机器人线性坐标

        private JointTarget Rd_RobotJoint;//机器人轴数据

        /// <summary>
        /// 机器人点位信息
        /// </summary>
        public RobTarget rd__RobTarget
        {
            get
            {
                Rd_RobTarget = RobotClass.con.MotionSystem.ActiveMechanicalUnit.GetPosition(ABB.Robotics.Controllers.MotionDomain.CoordinateSystemType.Base);
                return Rd_RobTarget;
            }
            set
            {

                Rd_RobTarget = value;
            }
        }

        public JointTarget rd_RobotJoint
        {
            get
            {
                Rd_RobotJoint = RobotClass.con.MotionSystem.ActiveMechanicalUnit.GetPosition();
                return Rd_RobotJoint;
            }
            set
            {
                Rd_RobotJoint = value;
            }
        }
        /// <summary>
        /// 机器人报警数据
        /// </summary>
        public EventLog rd_EventLog
        {
            get
            {
                Rd_EventLog = RobotClass.con.EventLog;
                return Rd_EventLog;
            }
            set
            {
                Rd_EventLog = value;
            }
        }
        /// <summary>
        /// 机器人速度
        /// </summary>
        public RapidData rd_MoveSpeed
        {
            get
            {
                Rd_MoveSpeed = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "NMoveSpeed");
                return Rd_MoveSpeed;
            }
            set
            {
                Rd_MoveSpeed = value;
            }
        }
        /// <summary>
        /// 点位信号
        /// </summary>
        public RapidData rd_Dataindex
        {
            get
            {
                Rd_Dataindex = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "Dataindex");
                return Rd_Dataindex;
            }
            set
            {
                Rd_Dataindex = value;
            }
        }
        /// <summary>
        /// 测试次数
        /// </summary>
        public RapidData rd_TestNum
        {
            get
            {
                Rd_TestNum = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "TestNum");
                return Rd_TestNum;
            }
            set
            {
                Rd_TestNum = value;
            }
        }
        /// <summary>
        /// 最大测试次数
        /// </summary>
        public RapidData rd_MaxTestTimes
        {
            get
            {
                Rd_MaxTestTimes = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "MaxTestTimes");
                return Rd_MaxTestTimes;
            }
            set
            {
                Rd_MaxTestTimes = value;
            }
        }
        /// <summary>
        /// 测试点位
        /// </summary>
        public RapidData rd_Point
        {
            get
            {
                Rd_Point = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "Point");
                return Rd_Point;
            }
            set
            {
                Rd_Point = value;
            }
        }
        /// <summary>
        /// 转弯半径
        /// </summary>
        public RapidData rd_Zone
        {
            get
            {
                Rd_Zone = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "Zone");
                return Rd_Zone;
            }
            set
            {
                Rd_Zone = value;
            }
        }
        /// <summary>
        /// 气缸动作信号
        /// </summary>
        public RapidData rd_SelectAction
        {
            get
            {
                Rd_SelectAction = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SelectAction");
                return Rd_SelectAction;
            }
            set
            {
                Rd_SelectAction = value;
            }
        }
        /// <summary>
        /// 设置力值
        /// </summary>
        public RapidData rd_SetForce
        {
            get
            {
                Rd_SetForce = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SetForce");
                return Rd_SetForce;
            }
            set
            {
                Rd_SetForce = value;
            }
        }
        /// <summary>
        /// 按压允许
        /// </summary>
        public RapidData rd_PressPermis
        {
            get
            {
                Rd_PressPermis = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "PressPermis");
                return Rd_PressPermis;
            }
            set
            {
                Rd_PressPermis = value;
            }
        }
        /// <summary>
        /// 移动允许
        /// </summary>
        public RapidData rd_MovePermis
        {
            get
            {
                Rd_MovePermis = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "MovePermis");
                return Rd_MovePermis;
            }
            set
            {
                Rd_MovePermis = value;
            }
        }
        /// <summary>
        /// 等待开始条件信号
        /// </summary>
        public RapidData rd_JudgeWaitSign
        {
            get
            {
                Rd_JudgeWaitSign = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "JudgeWaitSignal");
                return Rd_JudgeWaitSign;
            }
            set
            {
                Rd_JudgeWaitSign = value;
            }
        }
        /// <summary>
        /// 等待到位信号
        /// </summary>
        public RapidData rd_JudgeWaitMidSign
        {
            get
            {
                Rd_JudgeWaitMidSign = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "JudgeWaitMidSign");
                return Rd_JudgeWaitMidSign;
            }
            set
            {
                Rd_JudgeWaitMidSign = value;
            }
        }
        /// <summary>
        /// 等待中间到位信号
        /// </summary>
        public RapidData rd_JudgeWaitStartSign
        {
            get
            {
                Rd_JudgeWaitStartSign = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "JudgeWaitStartSign");
                return Rd_JudgeWaitStartSign;
            }
            set
            {
                Rd_JudgeWaitStartSign = value;
            }
        }
        /// <summary>
        /// 圆弧第二个点
        /// </summary>
        public RapidData rd_PointC
        {
            get
            {
                Rd_PointC = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "PointC");
                return Rd_PointC;
            }
            set
            {
                Rd_PointC = value;
            }
        }
        /// <summary>
        /// 移动类型
        /// </summary>
        public RapidData rd_MoveType
        {
            get
            {
                Rd_MoveType = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "MoveType");
                return Rd_MoveType;
            }
            set
            {
                Rd_MoveType = value;
            }
        }
        /// <summary>
        /// 气缸信号复位
        /// </summary>
        public RapidData rd_SelectActionReset
        {
            get
            {
                Rd_SelectActionReset = RobotClass.con.Rapid.GetRapidData("T_ROB1", "RobotData", "SelectActionReset");
                return Rd_SelectActionReset;
            }
            set
            {
                Rd_SelectActionReset = value;
            }
        }

        
    }
}
