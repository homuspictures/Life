namespace Life
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MyLab = new System.Windows.Forms.Button();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MyLab
            // 
            this.MyLab.BackColor = System.Drawing.Color.Transparent;
            this.MyLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MyLab.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MyLab.FlatAppearance.BorderSize = 0;
            this.MyLab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.MyLab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.MyLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyLab.Image = global::Life.Properties.Resources.mylab;
            this.MyLab.Location = new System.Drawing.Point(667, 57);
            this.MyLab.Name = "MyLab";
            this.MyLab.Size = new System.Drawing.Size(160, 23);
            this.MyLab.TabIndex = 1;
            this.MyLab.UseVisualStyleBackColor = false;
            this.MyLab.Click += new System.EventHandler(this.MyLab_Click);
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Image = global::Life.Properties.Resources.start;
            this.Start.Location = new System.Drawing.Point(203, 506);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(121, 48);
            this.Start.TabIndex = 2;
            this.Start.UseMnemonic = false;
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Transparent;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Image = global::Life.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(385, 506);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(119, 48);
            this.Stop.TabIndex = 3;
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Transparent;
            this.Clear.FlatAppearance.BorderSize = 0;
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Image = global::Life.Properties.Resources.clear;
            this.Clear.Location = new System.Drawing.Point(563, 506);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(117, 48);
            this.Clear.TabIndex = 4;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.BorderSize = 0;
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Image = global::Life.Properties.Resources.save;
            this.Save.Location = new System.Drawing.Point(714, 539);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(119, 41);
            this.Save.TabIndex = 5;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(840, 591);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.MyLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(846, 616);
            this.MinimumSize = new System.Drawing.Size(846, 616);
            this.Name = "Form1";
            this.Text = "Life";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MyLab;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Save;
    }
}

