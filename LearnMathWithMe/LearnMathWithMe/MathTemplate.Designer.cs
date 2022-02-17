namespace LearnMathWithMe
{
    partial class MathTemplate
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathTemplate));
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolHome = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChkAnswer = new System.Windows.Forms.Button();
            this.labelLife = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(351, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 84);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Beige;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolHome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(646, 31);
            this.toolStrip1.TabIndex = 13;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolHome
            // 
            this.toolHome.BackColor = System.Drawing.Color.Orange;
            this.toolHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolHome.Image = ((System.Drawing.Image)(resources.GetObject("toolHome.Image")));
            this.toolHome.Name = "toolHome";
            this.toolHome.Size = new System.Drawing.Size(29, 28);
            this.toolHome.Text = "Back to Home";
            this.toolHome.Click += new System.EventHandler(this.toolHome_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(407, 107);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.Transparent;
            this.labelScore.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.ForeColor = System.Drawing.Color.Ivory;
            this.labelScore.Location = new System.Drawing.Point(535, 107);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(48, 55);
            this.labelScore.TabIndex = 11;
            this.labelScore.Text = "0";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(639, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 47);
            this.label8.TabIndex = 10;
            // 
            // btnChkAnswer
            // 
            this.btnChkAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnChkAnswer.Font = new System.Drawing.Font("Comic Sans MS", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChkAnswer.ForeColor = System.Drawing.Color.DarkRed;
            this.btnChkAnswer.Location = new System.Drawing.Point(162, 312);
            this.btnChkAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChkAnswer.Name = "btnChkAnswer";
            this.btnChkAnswer.Size = new System.Drawing.Size(307, 67);
            this.btnChkAnswer.TabIndex = 8;
            this.btnChkAnswer.Text = "Check Answer";
            this.btnChkAnswer.UseVisualStyleBackColor = false;
            this.btnChkAnswer.Click += new System.EventHandler(this.btnChkAnswer_Click);
            // 
            // labelLife
            // 
            this.labelLife.AutoSize = true;
            this.labelLife.BackColor = System.Drawing.Color.Transparent;
            this.labelLife.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLife.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelLife.Location = new System.Drawing.Point(43, 114);
            this.labelLife.Name = "labelLife";
            this.labelLife.Size = new System.Drawing.Size(260, 48);
            this.labelLife.TabIndex = 7;
            this.labelLife.Text = "♥♥♥♥♥";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.title.Location = new System.Drawing.Point(171, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(281, 56);
            this.title.TabIndex = 6;
            this.title.Text = "Lean Addition";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.Ivory;
            this.txtAnswer.Font = new System.Drawing.Font("Comic Sans MS", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.DarkRed;
            this.txtAnswer.Location = new System.Drawing.Point(424, 196);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(195, 88);
            this.txtAnswer.TabIndex = 5;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelFirst.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirst.ForeColor = System.Drawing.Color.Ivory;
            this.labelFirst.Location = new System.Drawing.Point(18, 194);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(146, 84);
            this.labelFirst.TabIndex = 2;
            this.labelFirst.Text = "123";
            this.labelFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelSecond.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecond.ForeColor = System.Drawing.Color.Ivory;
            this.labelSecond.Location = new System.Drawing.Point(224, 196);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(146, 84);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "123";
            this.labelSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculation
            // 
            this.calculation.AutoSize = true;
            this.calculation.BackColor = System.Drawing.Color.Transparent;
            this.calculation.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculation.ForeColor = System.Drawing.Color.Ivory;
            this.calculation.Location = new System.Drawing.Point(166, 194);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(72, 84);
            this.calculation.TabIndex = 1;
            this.calculation.Text = "+";
            // 
            // MathTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(646, 474);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnChkAnswer);
            this.Controls.Add(this.labelLife);
            this.Controls.Add(this.title);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.label4);
            this.Name = "MathTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MathTemplate_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        protected System.Windows.Forms.TextBox txtAnswer;
        protected System.Windows.Forms.Button btnChkAnswer;
        protected System.Windows.Forms.Label labelScore;
        protected System.Windows.Forms.Label labelFirst;
        protected System.Windows.Forms.Label labelSecond;
        protected System.Windows.Forms.Label labelLife;
        protected System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.Label calculation;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolHome;
    }
}