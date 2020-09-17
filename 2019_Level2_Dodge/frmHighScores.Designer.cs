namespace _2019_Level2_Dodge
{
    partial class frmHighScores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHighScores));
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxName = new System.Windows.Forms.ListBox();
            this.listBoxScore = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(114, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerName.Font = new System.Drawing.Font("Orator Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.lblPlayerName.Location = new System.Drawing.Point(111, 120);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 15);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "namerhere";
            this.lblPlayerName.Click += new System.EventHandler(this.lblPlayerName_Click);
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerScore.Font = new System.Drawing.Font("Orator Std", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.lblPlayerScore.Location = new System.Drawing.Point(241, 120);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(70, 15);
            this.lblPlayerScore.TabIndex = 2;
            this.lblPlayerScore.Text = "scorehere";
            this.lblPlayerScore.Click += new System.EventHandler(this.lblPlayerScore_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Orator Std", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(240, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Score:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // listBoxName
            // 
            this.listBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
            this.listBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxName.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.listBoxName.FormattingEnabled = true;
            this.listBoxName.ItemHeight = 21;
            this.listBoxName.Location = new System.Drawing.Point(119, 176);
            this.listBoxName.Name = "listBoxName";
            this.listBoxName.Size = new System.Drawing.Size(120, 210);
            this.listBoxName.TabIndex = 4;
            // 
            // listBoxScore
            // 
            this.listBoxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(79)))), ((int)(((byte)(139)))));
            this.listBoxScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxScore.Font = new System.Drawing.Font("Orator Std", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.listBoxScore.FormattingEnabled = true;
            this.listBoxScore.ItemHeight = 21;
            this.listBoxScore.Location = new System.Drawing.Point(245, 176);
            this.listBoxScore.Name = "listBoxScore";
            this.listBoxScore.Size = new System.Drawing.Size(120, 210);
            this.listBoxScore.TabIndex = 5;
            this.listBoxScore.SelectedIndexChanged += new System.EventHandler(this.listBoxScore_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblMessage.Font = new System.Drawing.Font("Orator Std", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.lblMessage.Location = new System.Drawing.Point(21, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(457, 72);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "You have made the Top Ten!\r\nCongratulations,  Player\r\n";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::_2019_Level2_Dodge.Properties.Resources.Button_clone_1_png__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(79, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 297);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmHighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2019_Level2_Dodge.Properties.Resources.woke1;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.listBoxScore);
            this.Controls.Add(this.listBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHighScores";
            this.Text = "Planet Doge 2 | High Scores";
            this.Load += new System.EventHandler(this.frmHighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxName;
        private System.Windows.Forms.ListBox listBoxScore;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}