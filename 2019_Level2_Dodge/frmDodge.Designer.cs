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
            this.tmrShip = new System.Windows.Forms.Timer(this.components);
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
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
            this.tmrStars = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tmrSmoke = new System.Windows.Forms.Timer(this.components);
            this.tmrPaint = new System.Windows.Forms.Timer(this.components);
            this.tmrPowerup = new System.Windows.Forms.Timer(this.components);
            this.tmrPowerup2 = new System.Windows.Forms.Timer(this.components);
            this.tmrShield = new System.Windows.Forms.Timer(this.components);
            this.imgShield = new System.Windows.Forms.PictureBox();
            this.tmrAutoshoot = new System.Windows.Forms.Timer(this.components);
            this.tmrRotation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.mnuStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrShip
            // 
            this.tmrShip.Enabled = true;
            this.tmrShip.Interval = 1;
            this.tmrShip.Tick += new System.EventHandler(this.tmrShip_Tick);
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblLevel.Location = new System.Drawing.Point(1227, 49);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(63, 18);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Level X";
            this.lblLevel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.lblScore.Location = new System.Drawing.Point(425, 37);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(32, 33);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            this.lblScore.Click += new System.EventHandler(this.lblScore_Click);
            // 
            // txtLives
            // 
            this.txtLives.AutoSize = true;
            this.txtLives.BackColor = System.Drawing.Color.Transparent;
            this.txtLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.txtLives.Location = new System.Drawing.Point(102, 38);
            this.txtLives.Name = "txtLives";
            this.txtLives.Size = new System.Drawing.Size(32, 33);
            this.txtLives.TabIndex = 7;
            this.txtLives.Text = "5";
            this.txtLives.Click += new System.EventHandler(this.txtLives_Click);
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
            this.mnuStart.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuStart_ItemClicked);
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
            this.tmrMissile.Interval = 3000;
            this.tmrMissile.Tick += new System.EventHandler(this.tmrMissile_Tick);
            // 
            // tmrMissile2
            // 
            this.tmrMissile2.Enabled = true;
            this.tmrMissile2.Interval = 350;
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
            this.lblNametag.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNametag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.lblNametag.Location = new System.Drawing.Point(716, 41);
            this.lblNametag.Name = "lblNametag";
            this.lblNametag.Size = new System.Drawing.Size(90, 32);
            this.lblNametag.TabIndex = 9;
            this.lblNametag.Text = "Name";
            this.lblNametag.Click += new System.EventHandler(this.lblNametag_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.pnlGame.BackgroundImage = global::_2019_Level2_Dodge.Properties.Resources.backgroundJupiter5;
            this.pnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlGame.Location = new System.Drawing.Point(0, 94);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1495, 749);
            this.pnlGame.TabIndex = 0;
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            this.pnlGame.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseClick);
            this.pnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseDown);
            this.pnlGame.MouseEnter += new System.EventHandler(this.pnlGame_MouseEnter);
            this.pnlGame.MouseLeave += new System.EventHandler(this.pnlGame_MouseLeave);
            this.pnlGame.MouseHover += new System.EventHandler(this.pnlGame_MouseHover);
            this.pnlGame.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseMove_1);
            this.pnlGame.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlGame_MouseUp);
            // 
            // tmrStars
            // 
            this.tmrStars.Enabled = true;
            this.tmrStars.Interval = 150;
            this.tmrStars.Tick += new System.EventHandler(this.tmrCircle_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-53, 29);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 61);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(228, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 61);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(1305, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 60);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // tmrSmoke
            // 
            this.tmrSmoke.Enabled = true;
            this.tmrSmoke.Interval = 70;
            this.tmrSmoke.Tick += new System.EventHandler(this.tmrSmoke_Tick);
            // 
            // tmrPaint
            // 
            this.tmrPaint.Enabled = true;
            this.tmrPaint.Interval = 20;
            this.tmrPaint.Tick += new System.EventHandler(this.tmrPaint_Tick);
            // 
            // tmrPowerup
            // 
            this.tmrPowerup.Enabled = true;
            this.tmrPowerup.Interval = 32222;
            this.tmrPowerup.Tick += new System.EventHandler(this.tmrPowerup_Tick);
            // 
            // tmrPowerup2
            // 
            this.tmrPowerup2.Enabled = true;
            this.tmrPowerup2.Interval = 16049;
            this.tmrPowerup2.Tick += new System.EventHandler(this.tmrPowerup2_Tick);
            // 
            // tmrShield
            // 
            this.tmrShield.Interval = 1000;
            this.tmrShield.Tick += new System.EventHandler(this.tmrShield_Tick);
            // 
            // imgShield
            // 
            this.imgShield.BackColor = System.Drawing.Color.Transparent;
            this.imgShield.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgShield.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgShield.Image = ((System.Drawing.Image)(resources.GetObject("imgShield.Image")));
            this.imgShield.Location = new System.Drawing.Point(1062, 30);
            this.imgShield.Name = "imgShield";
            this.imgShield.Size = new System.Drawing.Size(56, 56);
            this.imgShield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShield.TabIndex = 26;
            this.imgShield.TabStop = false;
            this.imgShield.Visible = false;
            // 
            // tmrAutoshoot
            // 
            this.tmrAutoshoot.Tick += new System.EventHandler(this.tmrAutoshoot_Tick_1);
            // 
            // tmrRotation
            // 
            this.tmrRotation.Interval = 50;
            this.tmrRotation.Tick += new System.EventHandler(this.tmrRotation_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::_2019_Level2_Dodge.Properties.Resources.name;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(560, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(402, 61);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // frmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1495, 843);
            this.ControlBox = false;
            this.Controls.Add(this.imgShield);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtLives);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblNametag);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.mnuStart);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(175)))), ((int)(((byte)(214)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmDodge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Planet Doge 2";
            this.Load += new System.EventHandler(this.frmDodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDodge_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDodge_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDodge_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDodge_MouseDown);
            this.MouseLeave += new System.EventHandler(this.frmDodge_MouseLeave);
            this.mnuStart.ResumeLayout(false);
            this.mnuStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Timer tmrShip;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label txtLives;
        private System.Windows.Forms.MenuStrip mnuStart;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Timer tmrMissile;
        private System.Windows.Forms.Timer tmrMissile2;
        private System.Windows.Forms.Timer tmrMissile3;
        private System.Windows.Forms.Label lblNametag;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer tmrStars;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer tmrSmoke;
        private System.Windows.Forms.Timer tmrPaint;
        private System.Windows.Forms.Timer tmrPowerup;
        private System.Windows.Forms.Timer tmrPowerup2;
        private System.Windows.Forms.Timer tmrShield;
        private System.Windows.Forms.PictureBox imgShield;
        private System.Windows.Forms.Timer tmrAutoshoot;
        private System.Windows.Forms.Timer tmrRotation;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

