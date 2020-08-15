namespace DeskTestDome
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbx_scranRobot = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_ForceControl = new System.Windows.Forms.Button();
            this.dgv_ShowData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Zone = new System.Windows.Forms.ComboBox();
            this.lbe_serial = new System.Windows.Forms.Label();
            this.lbe_Status = new System.Windows.Forms.Label();
            this.lbe_MotionStatus = new System.Windows.Forms.Label();
            this.tbx_index = new System.Windows.Forms.TextBox();
            this.btn_ChangeIndex = new System.Windows.Forms.Button();
            this.lbe_connectStaus = new System.Windows.Forms.Label();
            this.tbx_Force = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_Speed = new System.Windows.Forms.TextBox();
            this.cbx_PointAllow = new System.Windows.Forms.CheckBox();
            this.btn_Updata = new System.Windows.Forms.Button();
            this.lbe_threadShow = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ClearPower = new System.Windows.Forms.Button();
            this.btn_RoutStart = new System.Windows.Forms.Button();
            this.btn_RoutStop = new System.Windows.Forms.Button();
            this.btn_MainStart = new System.Windows.Forms.Button();
            this.btn_montionOn = new System.Windows.Forms.Button();
            this.tbx_CycleTimes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbx_FollowPoint = new System.Windows.Forms.CheckBox();
            this.lbe_runStatus = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_cy1 = new System.Windows.Forms.Button();
            this.cbx_cy1 = new System.Windows.Forms.CheckBox();
            this.cbx_cy2 = new System.Windows.Forms.CheckBox();
            this.btn_cy2 = new System.Windows.Forms.Button();
            this.cbx_cy3 = new System.Windows.Forms.CheckBox();
            this.btn_cy3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_signalBound = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除信号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbx_MoveType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_signalBound)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_scranRobot
            // 
            this.cbx_scranRobot.FormattingEnabled = true;
            this.cbx_scranRobot.Location = new System.Drawing.Point(30, 26);
            this.cbx_scranRobot.Name = "cbx_scranRobot";
            this.cbx_scranRobot.Size = new System.Drawing.Size(121, 23);
            this.cbx_scranRobot.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(170, 26);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_Enter.Enabled = false;
            this.btn_Enter.Location = new System.Drawing.Point(26, 409);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(125, 48);
            this.btn_Enter.TabIndex = 3;
            this.btn_Enter.Text = "确定";
            this.btn_Enter.UseVisualStyleBackColor = false;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_ForceControl
            // 
            this.btn_ForceControl.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ForceControl.Enabled = false;
            this.btn_ForceControl.Location = new System.Drawing.Point(26, 337);
            this.btn_ForceControl.Name = "btn_ForceControl";
            this.btn_ForceControl.Size = new System.Drawing.Size(125, 48);
            this.btn_ForceControl.TabIndex = 4;
            this.btn_ForceControl.Text = "启用力控";
            this.btn_ForceControl.UseVisualStyleBackColor = false;
            this.btn_ForceControl.Click += new System.EventHandler(this.btn_ForceControl_Click);
            // 
            // dgv_ShowData
            // 
            this.dgv_ShowData.AllowUserToAddRows = false;
            this.dgv_ShowData.AllowUserToDeleteRows = false;
            this.dgv_ShowData.AllowUserToResizeColumns = false;
            this.dgv_ShowData.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightCyan;
            this.dgv_ShowData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_ShowData.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ShowData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_ShowData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ShowData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_ShowData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_ShowData.Location = new System.Drawing.Point(180, 193);
            this.dgv_ShowData.Name = "dgv_ShowData";
            this.dgv_ShowData.ReadOnly = true;
            this.dgv_ShowData.RowHeadersVisible = false;
            this.dgv_ShowData.RowHeadersWidth = 51;
            this.dgv_ShowData.RowTemplate.Height = 27;
            this.dgv_ShowData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ShowData.Size = new System.Drawing.Size(671, 264);
            this.dgv_ShowData.TabIndex = 6;
            this.dgv_ShowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ShowData_CellContentClick);
            this.dgv_ShowData.SelectionChanged += new System.EventHandler(this.dgv_ShowData_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "RobotStatus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "MotionStatus:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(646, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "RobotSerial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "点序号";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "速度";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "转弯半径";
            // 
            // cbx_Zone
            // 
            this.cbx_Zone.FormattingEnabled = true;
            this.cbx_Zone.Items.AddRange(new object[] {
            "fine",
            "Z0",
            "Z5",
            "Z10",
            "Z20",
            "Z50",
            "Z100"});
            this.cbx_Zone.Location = new System.Drawing.Point(271, 112);
            this.cbx_Zone.Name = "cbx_Zone";
            this.cbx_Zone.Size = new System.Drawing.Size(62, 23);
            this.cbx_Zone.TabIndex = 15;
            // 
            // lbe_serial
            // 
            this.lbe_serial.AutoSize = true;
            this.lbe_serial.Location = new System.Drawing.Point(773, 20);
            this.lbe_serial.Name = "lbe_serial";
            this.lbe_serial.Size = new System.Drawing.Size(55, 15);
            this.lbe_serial.TabIndex = 16;
            this.lbe_serial.Text = "label5";
            // 
            // lbe_Status
            // 
            this.lbe_Status.AutoSize = true;
            this.lbe_Status.Location = new System.Drawing.Point(773, 80);
            this.lbe_Status.Name = "lbe_Status";
            this.lbe_Status.Size = new System.Drawing.Size(55, 15);
            this.lbe_Status.TabIndex = 17;
            this.lbe_Status.Text = "label8";
            // 
            // lbe_MotionStatus
            // 
            this.lbe_MotionStatus.AutoSize = true;
            this.lbe_MotionStatus.Location = new System.Drawing.Point(773, 110);
            this.lbe_MotionStatus.Name = "lbe_MotionStatus";
            this.lbe_MotionStatus.Size = new System.Drawing.Size(55, 15);
            this.lbe_MotionStatus.TabIndex = 18;
            this.lbe_MotionStatus.Text = "label9";
            // 
            // tbx_index
            // 
            this.tbx_index.Location = new System.Drawing.Point(51, 110);
            this.tbx_index.Name = "tbx_index";
            this.tbx_index.ReadOnly = true;
            this.tbx_index.Size = new System.Drawing.Size(30, 25);
            this.tbx_index.TabIndex = 19;
            this.tbx_index.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ChangeIndex
            // 
            this.btn_ChangeIndex.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ChangeIndex.Enabled = false;
            this.btn_ChangeIndex.Location = new System.Drawing.Point(180, 160);
            this.btn_ChangeIndex.Name = "btn_ChangeIndex";
            this.btn_ChangeIndex.Size = new System.Drawing.Size(75, 23);
            this.btn_ChangeIndex.TabIndex = 20;
            this.btn_ChangeIndex.Text = "修改";
            this.btn_ChangeIndex.UseVisualStyleBackColor = false;
            this.btn_ChangeIndex.Click += new System.EventHandler(this.btn_ChangeIndex_Click);
            // 
            // lbe_connectStaus
            // 
            this.lbe_connectStaus.AutoSize = true;
            this.lbe_connectStaus.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbe_connectStaus.Location = new System.Drawing.Point(257, 16);
            this.lbe_connectStaus.Name = "lbe_connectStaus";
            this.lbe_connectStaus.Size = new System.Drawing.Size(277, 43);
            this.lbe_connectStaus.TabIndex = 21;
            this.lbe_connectStaus.Text = "未连接机器人";
            // 
            // tbx_Force
            // 
            this.tbx_Force.Location = new System.Drawing.Point(350, 110);
            this.tbx_Force.Name = "tbx_Force";
            this.tbx_Force.Size = new System.Drawing.Size(62, 25);
            this.tbx_Force.TabIndex = 22;
            this.tbx_Force.Text = "100";
            this.tbx_Force.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "力值";
            // 
            // tbx_Speed
            // 
            this.tbx_Speed.Location = new System.Drawing.Point(190, 110);
            this.tbx_Speed.Name = "tbx_Speed";
            this.tbx_Speed.Size = new System.Drawing.Size(62, 25);
            this.tbx_Speed.TabIndex = 24;
            this.tbx_Speed.Text = "200";
            this.tbx_Speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbx_PointAllow
            // 
            this.cbx_PointAllow.AutoSize = true;
            this.cbx_PointAllow.Checked = true;
            this.cbx_PointAllow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_PointAllow.Enabled = false;
            this.cbx_PointAllow.Location = new System.Drawing.Point(42, 151);
            this.cbx_PointAllow.Name = "cbx_PointAllow";
            this.cbx_PointAllow.Size = new System.Drawing.Size(89, 19);
            this.cbx_PointAllow.TabIndex = 25;
            this.cbx_PointAllow.Text = "点位启用";
            this.cbx_PointAllow.UseVisualStyleBackColor = true;
            // 
            // btn_Updata
            // 
            this.btn_Updata.Enabled = false;
            this.btn_Updata.Location = new System.Drawing.Point(776, 164);
            this.btn_Updata.Name = "btn_Updata";
            this.btn_Updata.Size = new System.Drawing.Size(75, 23);
            this.btn_Updata.TabIndex = 26;
            this.btn_Updata.Text = "更新";
            this.btn_Updata.UseVisualStyleBackColor = true;
            this.btn_Updata.Click += new System.EventHandler(this.btn_Updata_Click);
            // 
            // lbe_threadShow
            // 
            this.lbe_threadShow.AutoSize = true;
            this.lbe_threadShow.Location = new System.Drawing.Point(594, 168);
            this.lbe_threadShow.Name = "lbe_threadShow";
            this.lbe_threadShow.Size = new System.Drawing.Size(67, 15);
            this.lbe_threadShow.TabIndex = 27;
            this.lbe_threadShow.Text = "更新提示";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Enabled = false;
            this.btn_Clear.Location = new System.Drawing.Point(695, 164);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 28;
            this.btn_Clear.Text = "清除";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ClearPower
            // 
            this.btn_ClearPower.BackColor = System.Drawing.Color.Gainsboro;
            this.btn_ClearPower.Enabled = false;
            this.btn_ClearPower.Location = new System.Drawing.Point(265, 160);
            this.btn_ClearPower.Name = "btn_ClearPower";
            this.btn_ClearPower.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearPower.TabIndex = 20;
            this.btn_ClearPower.Text = "退出权限";
            this.btn_ClearPower.UseVisualStyleBackColor = false;
            this.btn_ClearPower.Click += new System.EventHandler(this.btn_ClearPower_Click);
            // 
            // btn_RoutStart
            // 
            this.btn_RoutStart.Location = new System.Drawing.Point(682, 463);
            this.btn_RoutStart.Name = "btn_RoutStart";
            this.btn_RoutStart.Size = new System.Drawing.Size(75, 33);
            this.btn_RoutStart.TabIndex = 29;
            this.btn_RoutStart.Text = "程序开始";
            this.btn_RoutStart.UseVisualStyleBackColor = true;
            this.btn_RoutStart.Click += new System.EventHandler(this.btn_RoutStart_Click);
            // 
            // btn_RoutStop
            // 
            this.btn_RoutStop.Location = new System.Drawing.Point(776, 463);
            this.btn_RoutStop.Name = "btn_RoutStop";
            this.btn_RoutStop.Size = new System.Drawing.Size(75, 33);
            this.btn_RoutStop.TabIndex = 29;
            this.btn_RoutStop.Text = "程序停止";
            this.btn_RoutStop.UseVisualStyleBackColor = true;
            this.btn_RoutStop.Click += new System.EventHandler(this.btn_RoutStop_Click);
            // 
            // btn_MainStart
            // 
            this.btn_MainStart.Location = new System.Drawing.Point(573, 463);
            this.btn_MainStart.Name = "btn_MainStart";
            this.btn_MainStart.Size = new System.Drawing.Size(88, 33);
            this.btn_MainStart.TabIndex = 29;
            this.btn_MainStart.Text = "Main开始";
            this.btn_MainStart.UseVisualStyleBackColor = true;
            this.btn_MainStart.Click += new System.EventHandler(this.btn_MainStart_Click);
            // 
            // btn_montionOn
            // 
            this.btn_montionOn.Location = new System.Drawing.Point(460, 463);
            this.btn_montionOn.Name = "btn_montionOn";
            this.btn_montionOn.Size = new System.Drawing.Size(88, 33);
            this.btn_montionOn.TabIndex = 30;
            this.btn_montionOn.Text = "电机上电";
            this.btn_montionOn.UseVisualStyleBackColor = true;
            this.btn_montionOn.Click += new System.EventHandler(this.btn_montionOn_Click);
            // 
            // tbx_CycleTimes
            // 
            this.tbx_CycleTimes.Location = new System.Drawing.Point(515, 112);
            this.tbx_CycleTimes.Name = "tbx_CycleTimes";
            this.tbx_CycleTimes.ReadOnly = true;
            this.tbx_CycleTimes.Size = new System.Drawing.Size(66, 25);
            this.tbx_CycleTimes.TabIndex = 31;
            this.tbx_CycleTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(514, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "运行次数";
            // 
            // cbx_FollowPoint
            // 
            this.cbx_FollowPoint.AutoSize = true;
            this.cbx_FollowPoint.Checked = true;
            this.cbx_FollowPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_FollowPoint.Location = new System.Drawing.Point(750, 139);
            this.cbx_FollowPoint.Name = "cbx_FollowPoint";
            this.cbx_FollowPoint.Size = new System.Drawing.Size(89, 19);
            this.cbx_FollowPoint.TabIndex = 33;
            this.cbx_FollowPoint.Text = "点位跟随";
            this.cbx_FollowPoint.UseVisualStyleBackColor = true;
            // 
            // lbe_runStatus
            // 
            this.lbe_runStatus.AutoSize = true;
            this.lbe_runStatus.Location = new System.Drawing.Point(773, 50);
            this.lbe_runStatus.Name = "lbe_runStatus";
            this.lbe_runStatus.Size = new System.Drawing.Size(55, 15);
            this.lbe_runStatus.TabIndex = 35;
            this.lbe_runStatus.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(646, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 15);
            this.label10.TabIndex = 34;
            this.label10.Text = "RunStatus:";
            // 
            // btn_cy1
            // 
            this.btn_cy1.Location = new System.Drawing.Point(30, 193);
            this.btn_cy1.Name = "btn_cy1";
            this.btn_cy1.Size = new System.Drawing.Size(86, 38);
            this.btn_cy1.TabIndex = 36;
            this.btn_cy1.Text = " 气缸1";
            this.btn_cy1.UseVisualStyleBackColor = true;
            this.btn_cy1.BackColorChanged += new System.EventHandler(this.btn_cy1_BackColorChanged);
            this.btn_cy1.Click += new System.EventHandler(this.btn_cy1_Click);
            // 
            // cbx_cy1
            // 
            this.cbx_cy1.AutoSize = true;
            this.cbx_cy1.BackColor = System.Drawing.SystemColors.Control;
            this.cbx_cy1.Checked = true;
            this.cbx_cy1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_cy1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbx_cy1.Location = new System.Drawing.Point(133, 204);
            this.cbx_cy1.Name = "cbx_cy1";
            this.cbx_cy1.Size = new System.Drawing.Size(18, 17);
            this.cbx_cy1.TabIndex = 37;
            this.cbx_cy1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbx_cy1.UseVisualStyleBackColor = false;
            this.cbx_cy1.Click += new System.EventHandler(this.cbx_cy1_Click);
            // 
            // cbx_cy2
            // 
            this.cbx_cy2.AutoSize = true;
            this.cbx_cy2.Checked = true;
            this.cbx_cy2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_cy2.Location = new System.Drawing.Point(133, 248);
            this.cbx_cy2.Name = "cbx_cy2";
            this.cbx_cy2.Size = new System.Drawing.Size(18, 17);
            this.cbx_cy2.TabIndex = 39;
            this.cbx_cy2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbx_cy2.UseVisualStyleBackColor = true;
            this.cbx_cy2.Click += new System.EventHandler(this.cbx_cy2_Click);
            // 
            // btn_cy2
            // 
            this.btn_cy2.Location = new System.Drawing.Point(30, 237);
            this.btn_cy2.Name = "btn_cy2";
            this.btn_cy2.Size = new System.Drawing.Size(86, 38);
            this.btn_cy2.TabIndex = 38;
            this.btn_cy2.Text = " 气缸2";
            this.btn_cy2.UseVisualStyleBackColor = true;
            this.btn_cy2.BackColorChanged += new System.EventHandler(this.btn_cy2_BackColorChanged);
            this.btn_cy2.Click += new System.EventHandler(this.btn_cy2_Click);
            // 
            // cbx_cy3
            // 
            this.cbx_cy3.AutoSize = true;
            this.cbx_cy3.Checked = true;
            this.cbx_cy3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_cy3.Location = new System.Drawing.Point(133, 291);
            this.cbx_cy3.Name = "cbx_cy3";
            this.cbx_cy3.Size = new System.Drawing.Size(18, 17);
            this.cbx_cy3.TabIndex = 41;
            this.cbx_cy3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbx_cy3.UseVisualStyleBackColor = true;
            this.cbx_cy3.Click += new System.EventHandler(this.cbx_cy3_Click);
            // 
            // btn_cy3
            // 
            this.btn_cy3.Location = new System.Drawing.Point(30, 280);
            this.btn_cy3.Name = "btn_cy3";
            this.btn_cy3.Size = new System.Drawing.Size(86, 38);
            this.btn_cy3.TabIndex = 40;
            this.btn_cy3.Text = " 气缸3";
            this.btn_cy3.UseVisualStyleBackColor = true;
            this.btn_cy3.BackColorChanged += new System.EventHandler(this.btn_cy3_BackColorChanged);
            this.btn_cy3.Click += new System.EventHandler(this.btn_cy3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(122, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 42;
            this.label9.Text = "等待";
            // 
            // dgv_signalBound
            // 
            this.dgv_signalBound.AllowUserToAddRows = false;
            this.dgv_signalBound.AllowUserToDeleteRows = false;
            this.dgv_signalBound.AllowUserToResizeColumns = false;
            this.dgv_signalBound.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightCyan;
            this.dgv_signalBound.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_signalBound.BackgroundColor = System.Drawing.Color.White;
            this.dgv_signalBound.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv_signalBound.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_signalBound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_signalBound.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv_signalBound.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dgv_signalBound.Location = new System.Drawing.Point(869, 12);
            this.dgv_signalBound.Name = "dgv_signalBound";
            this.dgv_signalBound.ReadOnly = true;
            this.dgv_signalBound.RowHeadersVisible = false;
            this.dgv_signalBound.RowHeadersWidth = 51;
            this.dgv_signalBound.RowTemplate.Height = 27;
            this.dgv_signalBound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_signalBound.Size = new System.Drawing.Size(236, 229);
            this.dgv_signalBound.TabIndex = 44;
            this.dgv_signalBound.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgv_signalBound_MouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "信号描述";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(869, 251);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(236, 245);
            this.treeView1.TabIndex = 45;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除信号ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 28);
            // 
            // 删除信号ToolStripMenuItem
            // 
            this.删除信号ToolStripMenuItem.Name = "删除信号ToolStripMenuItem";
            this.删除信号ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.删除信号ToolStripMenuItem.Text = "删除信号";
            this.删除信号ToolStripMenuItem.Click += new System.EventHandler(this.删除信号ToolStripMenuItem_Click);
            // 
            // cbx_MoveType
            // 
            this.cbx_MoveType.FormattingEnabled = true;
            this.cbx_MoveType.Items.AddRange(new object[] {
            "MoveL",
            "MoveJ",
            "MoveC"});
            this.cbx_MoveType.Location = new System.Drawing.Point(106, 110);
            this.cbx_MoveType.Name = "cbx_MoveType";
            this.cbx_MoveType.Size = new System.Drawing.Size(71, 23);
            this.cbx_MoveType.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(110, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "运动类型";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(428, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 49;
            this.label12.Text = "最大次数";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 25);
            this.textBox1.TabIndex = 48;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "点序号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "等待号";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "运动类型";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "速度(mm/s)";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "转弯半径";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "气缸活动";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "力值设定";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "点位允许";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 525);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbx_MoveType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dgv_signalBound);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbx_cy3);
            this.Controls.Add(this.btn_cy3);
            this.Controls.Add(this.cbx_cy2);
            this.Controls.Add(this.btn_cy2);
            this.Controls.Add(this.cbx_cy1);
            this.Controls.Add(this.btn_cy1);
            this.Controls.Add(this.lbe_runStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbx_FollowPoint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbx_CycleTimes);
            this.Controls.Add(this.btn_montionOn);
            this.Controls.Add(this.btn_RoutStop);
            this.Controls.Add(this.btn_MainStart);
            this.Controls.Add(this.btn_RoutStart);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbe_threadShow);
            this.Controls.Add(this.btn_Updata);
            this.Controls.Add(this.cbx_PointAllow);
            this.Controls.Add(this.tbx_Speed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_Force);
            this.Controls.Add(this.lbe_connectStaus);
            this.Controls.Add(this.btn_ClearPower);
            this.Controls.Add(this.btn_ChangeIndex);
            this.Controls.Add(this.tbx_index);
            this.Controls.Add(this.lbe_MotionStatus);
            this.Controls.Add(this.lbe_Status);
            this.Controls.Add(this.lbe_serial);
            this.Controls.Add(this.cbx_Zone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ShowData);
            this.Controls.Add(this.btn_ForceControl);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cbx_scranRobot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "座椅测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ShowData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_signalBound)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_scranRobot;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_ForceControl;
        private System.Windows.Forms.DataGridView dgv_ShowData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_Zone;
        private System.Windows.Forms.Label lbe_serial;
        private System.Windows.Forms.Label lbe_Status;
        private System.Windows.Forms.Label lbe_MotionStatus;
        private System.Windows.Forms.TextBox tbx_index;
        private System.Windows.Forms.Button btn_ChangeIndex;
        private System.Windows.Forms.TextBox tbx_Force;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_Speed;
        private System.Windows.Forms.CheckBox cbx_PointAllow;
        private System.Windows.Forms.Button btn_Updata;
        private System.Windows.Forms.Label lbe_threadShow;
        private System.Windows.Forms.Button btn_Clear;
        public System.Windows.Forms.Label lbe_connectStaus;
        private System.Windows.Forms.Button btn_RoutStart;
        private System.Windows.Forms.Button btn_RoutStop;
        private System.Windows.Forms.Button btn_MainStart;
        private System.Windows.Forms.Button btn_montionOn;
        private System.Windows.Forms.TextBox tbx_CycleTimes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbx_FollowPoint;
        public System.Windows.Forms.Button btn_ClearPower;
        private System.Windows.Forms.Label lbe_runStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_cy1;
        private System.Windows.Forms.CheckBox cbx_cy1;
        private System.Windows.Forms.CheckBox cbx_cy2;
        private System.Windows.Forms.Button btn_cy2;
        private System.Windows.Forms.CheckBox cbx_cy3;
        private System.Windows.Forms.Button btn_cy3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgv_signalBound;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除信号ToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbx_MoveType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

