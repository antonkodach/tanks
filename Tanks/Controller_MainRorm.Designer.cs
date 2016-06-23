namespace Tanks
{
    partial class Controller_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller_MainForm));
            this.StartStop_pcbx = new System.Windows.Forms.PictureBox();
            this.Help_ttip = new System.Windows.Forms.ToolTip(this.components);
            this.MainMenu_strp = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GameStatus_lbl_ststrp = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StartStop_pcbx)).BeginInit();
            this.MainMenu_strp.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartStop_pcbx
            // 
            this.StartStop_pcbx.BackColor = System.Drawing.SystemColors.WindowText;
            this.StartStop_pcbx.Image = global::Tanks.Properties.Resources.PlayButton;
            this.StartStop_pcbx.Location = new System.Drawing.Point(288, 36);
            this.StartStop_pcbx.Name = "StartStop_pcbx";
            this.StartStop_pcbx.Size = new System.Drawing.Size(54, 50);
            this.StartStop_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.StartStop_pcbx.TabIndex = 0;
            this.StartStop_pcbx.TabStop = false;
            this.Help_ttip.SetToolTip(this.StartStop_pcbx, "Click Button to start game");
            this.StartStop_pcbx.Click += new System.EventHandler(this.StartPause_btn_Click);
            this.StartStop_pcbx.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.StartStop_pcbx_PreviewKeyDown);
            // 
            // Help_ttip
            // 
            this.Help_ttip.IsBalloon = true;
            this.Help_ttip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Help_ttip.ToolTipTitle = "Танки 1.0";
            // 
            // MainMenu_strp
            // 
            this.MainMenu_strp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenu_strp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.MainMenu_strp.Location = new System.Drawing.Point(0, 0);
            this.MainMenu_strp.Name = "MainMenu_strp";
            this.MainMenu_strp.Size = new System.Drawing.Size(364, 24);
            this.MainMenu_strp.TabIndex = 1;
            this.MainMenu_strp.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "&Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(129, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soundToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.soundToolStripMenuItem.Text = "&Sound";
            this.soundToolStripMenuItem.Click += new System.EventHandler(this.SoundToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "&Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameStatus_lbl_ststrp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(364, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GameStatus_lbl_ststrp
            // 
            this.GameStatus_lbl_ststrp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GameStatus_lbl_ststrp.Name = "GameStatus_lbl_ststrp";
            this.GameStatus_lbl_ststrp.Size = new System.Drawing.Size(0, 17);
            // 
            // Controller_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StartStop_pcbx);
            this.Controls.Add(this.MainMenu_strp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu_strp;
            this.MaximizeBox = false;
            this.Name = "Controller_MainForm";
            this.Text = "Танки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_MainForm_FormClosing);
            this.Click += new System.EventHandler(this.StartPause_btn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.StartStop_pcbx)).EndInit();
            this.MainMenu_strp.ResumeLayout(false);
            this.MainMenu_strp.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StartStop_pcbx;
        private System.Windows.Forms.ToolTip Help_ttip;
        private System.Windows.Forms.MenuStrip MainMenu_strp;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel GameStatus_lbl_ststrp;

    }
}

