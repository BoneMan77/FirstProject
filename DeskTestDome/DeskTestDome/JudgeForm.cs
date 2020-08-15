using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeskTestDome
{
    public partial class JudgeForm : Form
    {
        public static bool JudgeResult =false;
        public static bool CheckResult =false;
        public JudgeForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            JudgeResult = true;
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            JudgeResult = false;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CheckResult = true;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                CheckResult = true;
            }
        }
    }
}
