﻿namespace _2019_Level2_Dodge
{
    partial class frmDodge
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDodge));
            this.tmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.tmrShip = new System.Windows.Forms.Timer(this.components);
            this.lblLogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLives = new System.Windows.Forms.Label();
            this.mnuStart = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrMissile = new System.Windows.Forms.Timer(this.components);
            this.tmrMissile2 = new System.Windows.Forms.Timer(this.components);
            this.tmrMissile3 = new System.Windows.Forms.Timer(this.components);
            this.lblNametag = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.tmrCircle = new System.Windows.Forms.Timer(this.components);
            this.mnuStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrPlanet
            // 
            this.tmrPlanet.Enabled = true;
            this.tmrPlanet.Interval = 70;
            this.tmrPlanet.Tick += new System.EventHandler(this.tmrPlanet_Tick);
            // 
            // tmrShip
            // 
            this.tmrShip.Enabled = true;
            this.tmrShip.Interval = 10;
            this.tmrShip.Tick += new System.EventHandler(this.tmrShip_Tick);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(1376, 29);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(89, 18);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Planet Doge";
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(214, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(83, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Score:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Location = new System.Drawing.Point(152, 28);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(16, 18);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "HP:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.BackColor = System.Drawing.Color.Transparent;
            this.txtLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLives.Location = new System.Drawing.Point(43, 28);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(16, 18);
            this.txtLives.TabIndex = 7;
            this.txtLives.Text = "5";
            // 
            // mnuStart
            // 
            this.mnuStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnuStart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuStart.Location = new System.Drawing.Point(0, 0);
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.Size = new System.Drawing.Size(1495, 24);
            this.mnuStart.TabIndex = 8;
            this.mnuStart.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click_1);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // tmrMissile
            // 
            this.tmrMissile.Enabled = true;
            this.tmrMissile.Interval = 1000;
            this.tmrMissile.Tick += new System.EventHandler(this.tmrMissile_Tick);
            // 
            // tmrMissile2
            // 
            this.tmrMissile2.Enabled = true;
            this.tmrMissile2.Interval = 400;
            this.tmrMissile2.Tick += new System.EventHandler(this.tmrMissile2_Tick);
            // 
            // tmrMissile3
            // 
            this.tmrMissile3.Enabled = true;
            this.tmrMissile3.Interval = 1000;
            this.tmrMissile3.Tick += new System.EventHandler(this.tmrMissile3_Tick);
            // 
            // lblNametag
            // 
            this.lblNametag.AutoSize = true;
            this.lblNametag.BackColor = System.Drawing.Color.Transparent;
            this.lblNametag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNametag.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNametag.Location = new System.Drawing.Point(275, 29);
            this.lblNametag.Name = "lblNametag";
            this.lblNametag.Size = new System.Drawing.Size(48, 18);
            this.lblNametag.TabIndex = 9;
            this.lblNametag.Text = "Name";
            this.lblNametag.Click += new System.EventHandler(this.lblNametag_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Black;
            this.pnlGame.BackgroundImage = global::_2019_Level2_Dodge.Properties.Resources.bruh2;
            this.pnlGame.Location = new System.Drawing.Point(0, 49);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1495, 794);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            this.pnlGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseClick);
            this.pnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseDown);
            this.pnlGame.MouseEnter += new System.EventHandler(this.pnlGame_MouseEnter);
            this.pnlGame.MouseLeave += new System.EventHandler(this.pnlGame_MouseLeave);
            this.pnlGame.MouseHover += new System.EventHandler(this.pnlGame_MouseHover);
            this.pnlGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseMove_1);
            // 
            // tmrCircle
            // 
            this.tmrCircle.Enabled = true;
            this.tmrCircle.Tick += new System.EventHandler(this.tmrCircle_Tick);
            // 
            // frmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackgroundImage = global::_2019_Level2_Dodge.Properties.Resources.bruh21;
            this.ClientSize = new System.Drawing.Size(1495, 843);
            this.ControlBox = false;
            this.Controls.Add(this.lblNametag);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.mnuStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDodge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planet Doge | Game";
            this.Load += new System.EventHandler(this.frmDodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodge_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDodge_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDodge_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDodge_MouseDown);
            this.MouseLeave += new System.EventHandler(this.frmDodge_MouseLeave);
            this.mnuStart.ResumeLayout(false);
            this.mnuStart.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrPlanet;
        private System.Windows.Forms.Timer tmrShip;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.MenuStrip mnuStart;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Timer tmrMissile;
        private System.Windows.Forms.Timer tmrMissile2;
        private System.Windows.Forms.Timer tmrMissile3;
        private System.Windows.Forms.Label lblNametag;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmrCircle;
    }
}

