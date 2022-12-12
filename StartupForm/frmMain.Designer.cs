namespace StartupForm
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbxBox = new System.Windows.Forms.PictureBox();
            this.rbtnLion = new System.Windows.Forms.RadioButton();
            this.rbtnFullham = new System.Windows.Forms.RadioButton();
            this.rbtnArs = new System.Windows.Forms.RadioButton();
            this.rbtnTot = new System.Windows.Forms.RadioButton();
            this.rbtnMU = new System.Windows.Forms.RadioButton();
            this.rbtnAle = new System.Windows.Forms.RadioButton();
            this.rbtnReal = new System.Windows.Forms.RadioButton();
            this.rbtnBarce = new System.Windows.Forms.RadioButton();
            this.rbtnInter = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLunar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logo các câu lạc bộ bóng đá nổi tiếng:";
            // 
            // pbxBox
            // 
            this.pbxBox.Location = new System.Drawing.Point(210, 46);
            this.pbxBox.Name = "pbxBox";
            this.pbxBox.Size = new System.Drawing.Size(208, 183);
            this.pbxBox.TabIndex = 3;
            this.pbxBox.TabStop = false;
            // 
            // rbtnLion
            // 
            this.rbtnLion.AutoSize = true;
            this.rbtnLion.Checked = true;
            this.rbtnLion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnLion.Location = new System.Drawing.Point(25, 66);
            this.rbtnLion.Name = "rbtnLion";
            this.rbtnLion.Size = new System.Drawing.Size(53, 21);
            this.rbtnLion.TabIndex = 4;
            this.rbtnLion.TabStop = true;
            this.rbtnLion.Text = "Lion";
            this.rbtnLion.UseVisualStyleBackColor = true;
            this.rbtnLion.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnFullham
            // 
            this.rbtnFullham.AutoSize = true;
            this.rbtnFullham.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnFullham.Location = new System.Drawing.Point(25, 93);
            this.rbtnFullham.Name = "rbtnFullham";
            this.rbtnFullham.Size = new System.Drawing.Size(76, 21);
            this.rbtnFullham.TabIndex = 5;
            this.rbtnFullham.Text = "Fullham";
            this.rbtnFullham.UseVisualStyleBackColor = true;
            this.rbtnFullham.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnArs
            // 
            this.rbtnArs.AutoSize = true;
            this.rbtnArs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnArs.Location = new System.Drawing.Point(25, 120);
            this.rbtnArs.Name = "rbtnArs";
            this.rbtnArs.Size = new System.Drawing.Size(72, 21);
            this.rbtnArs.TabIndex = 6;
            this.rbtnArs.Text = "Arsenal";
            this.rbtnArs.UseVisualStyleBackColor = true;
            this.rbtnArs.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnTot
            // 
            this.rbtnTot.AutoSize = true;
            this.rbtnTot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnTot.Location = new System.Drawing.Point(25, 147);
            this.rbtnTot.Name = "rbtnTot";
            this.rbtnTot.Size = new System.Drawing.Size(93, 21);
            this.rbtnTot.TabIndex = 7;
            this.rbtnTot.Text = "Tottenham";
            this.rbtnTot.UseVisualStyleBackColor = true;
            this.rbtnTot.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnMU
            // 
            this.rbtnMU.AutoSize = true;
            this.rbtnMU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnMU.Location = new System.Drawing.Point(25, 174);
            this.rbtnMU.Name = "rbtnMU";
            this.rbtnMU.Size = new System.Drawing.Size(142, 21);
            this.rbtnMU.TabIndex = 8;
            this.rbtnMU.Text = "Manchester United";
            this.rbtnMU.UseVisualStyleBackColor = true;
            this.rbtnMU.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnAle
            // 
            this.rbtnAle.AutoSize = true;
            this.rbtnAle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnAle.Location = new System.Drawing.Point(286, 247);
            this.rbtnAle.Name = "rbtnAle";
            this.rbtnAle.Size = new System.Drawing.Size(117, 21);
            this.rbtnAle.TabIndex = 9;
            this.rbtnAle.Text = "Aletico Madrid";
            this.rbtnAle.UseVisualStyleBackColor = true;
            this.rbtnAle.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnReal
            // 
            this.rbtnReal.AutoSize = true;
            this.rbtnReal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnReal.Location = new System.Drawing.Point(286, 274);
            this.rbtnReal.Name = "rbtnReal";
            this.rbtnReal.Size = new System.Drawing.Size(100, 21);
            this.rbtnReal.TabIndex = 10;
            this.rbtnReal.Text = "Real Madrid";
            this.rbtnReal.UseVisualStyleBackColor = true;
            this.rbtnReal.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnBarce
            // 
            this.rbtnBarce.AutoSize = true;
            this.rbtnBarce.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnBarce.Location = new System.Drawing.Point(286, 301);
            this.rbtnBarce.Name = "rbtnBarce";
            this.rbtnBarce.Size = new System.Drawing.Size(86, 21);
            this.rbtnBarce.TabIndex = 11;
            this.rbtnBarce.Text = "Barcenola";
            this.rbtnBarce.UseVisualStyleBackColor = true;
            this.rbtnBarce.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // rbtnInter
            // 
            this.rbtnInter.AutoSize = true;
            this.rbtnInter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnInter.Location = new System.Drawing.Point(286, 328);
            this.rbtnInter.Name = "rbtnInter";
            this.rbtnInter.Size = new System.Drawing.Size(94, 21);
            this.rbtnInter.TabIndex = 12;
            this.rbtnInter.Text = "Inter Milan";
            this.rbtnInter.UseVisualStyleBackColor = true;
            this.rbtnInter.Click += new System.EventHandler(this.rbtnLion_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(47, 251);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLunar
            // 
            this.btnLunar.Location = new System.Drawing.Point(47, 280);
            this.btnLunar.Name = "btnLunar";
            this.btnLunar.Size = new System.Drawing.Size(75, 23);
            this.btnLunar.TabIndex = 14;
            this.btnLunar.Text = "Lunar";
            this.btnLunar.UseVisualStyleBackColor = true;
            this.btnLunar.Click += new System.EventHandler(this.btnLunar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StartupForm.Properties.Resources._131231hinh_nen_bong_da_san_co_dep_mat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(452, 370);
            this.Controls.Add(this.btnLunar);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbtnInter);
            this.Controls.Add(this.rbtnBarce);
            this.Controls.Add(this.rbtnReal);
            this.Controls.Add(this.rbtnAle);
            this.Controls.Add(this.rbtnMU);
            this.Controls.Add(this.rbtnTot);
            this.Controls.Add(this.rbtnArs);
            this.Controls.Add(this.rbtnFullham);
            this.Controls.Add(this.rbtnLion);
            this.Controls.Add(this.pbxBox);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Click += new System.EventHandler(this.rbtnLion_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pbxBox;
        private RadioButton rbtnLion;
        private RadioButton rbtnFullham;
        private RadioButton rbtnArs;
        private RadioButton rbtnTot;
        private RadioButton rbtnMU;
        private RadioButton rbtnAle;
        private RadioButton rbtnReal;
        private RadioButton rbtnBarce;
        private RadioButton rbtnInter;
        private Button btnExit;
        private Button btnLunar;
    }
}