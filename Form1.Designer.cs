namespace dell_switch_input
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_setDP = new System.Windows.Forms.Button();
            this.bt_setmDP = new System.Windows.Forms.Button();
            this.bt_setHDMI1 = new System.Windows.Forms.Button();
            this.bt_setHDMI2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_setDP
            // 
            this.bt_setDP.Location = new System.Drawing.Point(168, 61);
            this.bt_setDP.Name = "bt_setDP";
            this.bt_setDP.Size = new System.Drawing.Size(191, 48);
            this.bt_setDP.TabIndex = 0;
            this.bt_setDP.Text = "DP";
            this.bt_setDP.UseVisualStyleBackColor = true;
            this.bt_setDP.Click += new System.EventHandler(this.bt_setDP_Click);
            // 
            // bt_setmDP
            // 
            this.bt_setmDP.Location = new System.Drawing.Point(168, 115);
            this.bt_setmDP.Name = "bt_setmDP";
            this.bt_setmDP.Size = new System.Drawing.Size(191, 48);
            this.bt_setmDP.TabIndex = 1;
            this.bt_setmDP.Text = "mDP";
            this.bt_setmDP.UseVisualStyleBackColor = true;
            this.bt_setmDP.Click += new System.EventHandler(this.bt_setmDP_Click);
            // 
            // bt_setHDMI1
            // 
            this.bt_setHDMI1.Location = new System.Drawing.Point(168, 169);
            this.bt_setHDMI1.Name = "bt_setHDMI1";
            this.bt_setHDMI1.Size = new System.Drawing.Size(191, 48);
            this.bt_setHDMI1.TabIndex = 2;
            this.bt_setHDMI1.Text = "HDMI 1";
            this.bt_setHDMI1.UseVisualStyleBackColor = true;
            this.bt_setHDMI1.Click += new System.EventHandler(this.bt_setHDMI1_Click);
            // 
            // bt_setHDMI2
            // 
            this.bt_setHDMI2.Location = new System.Drawing.Point(168, 223);
            this.bt_setHDMI2.Name = "bt_setHDMI2";
            this.bt_setHDMI2.Size = new System.Drawing.Size(191, 48);
            this.bt_setHDMI2.TabIndex = 3;
            this.bt_setHDMI2.Text = "HDMI 2";
            this.bt_setHDMI2.UseVisualStyleBackColor = true;
            this.bt_setHDMI2.Click += new System.EventHandler(this.bt_setHDMI2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(543, 343);
            this.Controls.Add(this.bt_setHDMI2);
            this.Controls.Add(this.bt_setHDMI1);
            this.Controls.Add(this.bt_setmDP);
            this.Controls.Add(this.bt_setDP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dell switch input";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_setDP;
        private System.Windows.Forms.Button bt_setmDP;
        private System.Windows.Forms.Button bt_setHDMI1;
        private System.Windows.Forms.Button bt_setHDMI2;
    }
}

