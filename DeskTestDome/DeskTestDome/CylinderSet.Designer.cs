namespace DeskTestDome
{
    partial class CylinderSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cy1 = new System.Windows.Forms.Button();
            this.btn_cy3 = new System.Windows.Forms.Button();
            this.btn_cy2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cy1
            // 
            this.btn_cy1.Location = new System.Drawing.Point(168, 22);
            this.btn_cy1.Name = "btn_cy1";
            this.btn_cy1.Size = new System.Drawing.Size(75, 42);
            this.btn_cy1.TabIndex = 0;
            this.btn_cy1.Text = "启用";
            this.btn_cy1.UseVisualStyleBackColor = true;
            this.btn_cy1.Click += new System.EventHandler(this.btn_cy1_Click);
            // 
            // btn_cy3
            // 
            this.btn_cy3.Location = new System.Drawing.Point(168, 166);
            this.btn_cy3.Name = "btn_cy3";
            this.btn_cy3.Size = new System.Drawing.Size(75, 42);
            this.btn_cy3.TabIndex = 1;
            this.btn_cy3.Text = "启用";
            this.btn_cy3.UseVisualStyleBackColor = true;
            this.btn_cy3.Click += new System.EventHandler(this.btn_cy3_Click);
            // 
            // btn_cy2
            // 
            this.btn_cy2.Location = new System.Drawing.Point(168, 91);
            this.btn_cy2.Name = "btn_cy2";
            this.btn_cy2.Size = new System.Drawing.Size(75, 42);
            this.btn_cy2.TabIndex = 2;
            this.btn_cy2.Text = "启用";
            this.btn_cy2.UseVisualStyleBackColor = true;
            this.btn_cy2.Click += new System.EventHandler(this.btn_cy2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "气缸1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "气缸3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "气缸2";
            // 
            // CylinderSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cy2);
            this.Controls.Add(this.btn_cy3);
            this.Controls.Add(this.btn_cy1);
            this.Name = "CylinderSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "气缸设置";
            this.Load += new System.EventHandler(this.CylinderSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cy1;
        private System.Windows.Forms.Button btn_cy3;
        private System.Windows.Forms.Button btn_cy2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}