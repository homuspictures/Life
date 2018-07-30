namespace Life
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.del = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.load = new System.Windows.Forms.Button();
            this.FileBox = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.FlatAppearance.BorderSize = 0;
            this.del.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del.Image = global::Life.Properties.Resources.delete;
            this.del.Location = new System.Drawing.Point(589, 520);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(118, 46);
            this.del.TabIndex = 0;
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(567, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Transparent;
            this.load.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.load.FlatAppearance.BorderSize = 0;
            this.load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.load.Image = global::Life.Properties.Resources.loadandcontinue;
            this.load.Location = new System.Drawing.Point(165, 520);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(118, 46);
            this.load.TabIndex = 3;
            this.load.UseVisualStyleBackColor = false;
            this.load.Click += new System.EventHandler(this.load_Click);
            // 
            // FileBox
            // 
            this.FileBox.AllowUserToDeleteRows = false;
            this.FileBox.AllowUserToResizeColumns = false;
            this.FileBox.AllowUserToResizeRows = false;
            this.FileBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FileBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FileBox.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FileBox.BackgroundColor = System.Drawing.Color.Black;
            this.FileBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileBox.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.FileBox.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FileBox.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FileBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.FileBox.EnableHeadersVisualStyles = false;
            this.FileBox.GridColor = System.Drawing.Color.Black;
            this.FileBox.Location = new System.Drawing.Point(55, 127);
            this.FileBox.Name = "FileBox";
            this.FileBox.ReadOnly = true;
            this.FileBox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FileBox.RowHeadersVisible = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.FileBox.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.FileBox.Size = new System.Drawing.Size(360, 361);
            this.FileBox.TabIndex = 4;
            this.FileBox.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FileBox_CellMouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Life.Properties.Resources.lupa;
            this.pictureBox2.Location = new System.Drawing.Point(471, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(368, 348);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(241, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Life.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(838, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileBox);
            this.Controls.Add(this.load);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.del);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(846, 616);
            this.MinimumSize = new System.Drawing.Size(846, 616);
            this.Name = "Form2";
            this.Text = "Моя Лаборатория";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FileBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button del;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.DataGridView FileBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}