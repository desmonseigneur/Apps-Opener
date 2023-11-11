namespace Apps_Opener
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Title = new Label();
            Instructions001 = new Label();
            Instructions002 = new Label();
            Instructions003 = new Label();
            Instructions004 = new Label();
            Instructions005 = new Label();
            Social = new Button();
            Peripherals = new Button();
            Game = new Button();
            cleanmgr = new Button();
            appdata = new Button();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            closeToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            msteams = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.BackColor = Color.Transparent;
            Title.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Title.ForeColor = Color.Transparent;
            Title.Location = new Point(123, 9);
            Title.Name = "Title";
            Title.Size = new Size(245, 26);
            Title.TabIndex = 0;
            Title.Text = "A P P S   O P E N E R";
            // 
            // Instructions001
            // 
            Instructions001.AllowDrop = true;
            Instructions001.AutoSize = true;
            Instructions001.BackColor = Color.Transparent;
            Instructions001.Font = new Font("UD Digi Kyokasho NK-R", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Instructions001.ForeColor = Color.Lime;
            Instructions001.Location = new Point(12, 63);
            Instructions001.Name = "Instructions001";
            Instructions001.Size = new Size(458, 105);
            Instructions001.TabIndex = 0;
            Instructions001.Text = "This button opens the following apps in order:\r\n\r\n1. Discord\r\n2. Opera GX\r\n3. Spotify";
            // 
            // Instructions002
            // 
            Instructions002.AutoSize = true;
            Instructions002.BackColor = Color.Transparent;
            Instructions002.Font = new Font("UD Digi Kyokasho NK-R", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Instructions002.ForeColor = Color.LightSeaGreen;
            Instructions002.Location = new Point(12, 185);
            Instructions002.Name = "Instructions002";
            Instructions002.Size = new Size(377, 105);
            Instructions002.TabIndex = 0;
            Instructions002.Text = "This button opens the following apps:\r\n\r\n1. Marvo KG916\r\n2. Razer Synapse\r\n3, Peace Equalizer";
            // 
            // Instructions003
            // 
            Instructions003.AutoSize = true;
            Instructions003.BackColor = Color.Transparent;
            Instructions003.Font = new Font("UD Digi Kyokasho NK-R", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Instructions003.ForeColor = Color.Green;
            Instructions003.Location = new Point(12, 301);
            Instructions003.Name = "Instructions003";
            Instructions003.Size = new Size(377, 84);
            Instructions003.TabIndex = 0;
            Instructions003.Text = "This button opens the following apps:\r\n\r\n1. Riot Client\r\n2. U.GG";
            // 
            // Instructions004
            // 
            Instructions004.AutoSize = true;
            Instructions004.BackColor = Color.Transparent;
            Instructions004.Font = new Font("UD Digi Kyokasho NK-R", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Instructions004.ForeColor = Color.Transparent;
            Instructions004.Location = new Point(12, 443);
            Instructions004.Name = "Instructions004";
            Instructions004.Size = new Size(263, 21);
            Instructions004.TabIndex = 0;
            Instructions004.Text = "This button opens 'cleanmgr'";
            // 
            // Instructions005
            // 
            Instructions005.AutoSize = true;
            Instructions005.BackColor = Color.Transparent;
            Instructions005.Font = new Font("UD Digi Kyokasho NK-R", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Instructions005.ForeColor = Color.Transparent;
            Instructions005.Location = new Point(12, 480);
            Instructions005.Name = "Instructions005";
            Instructions005.Size = new Size(286, 21);
            Instructions005.TabIndex = 0;
            Instructions005.Text = "This button opens'%appdata%'";
            // 
            // Social
            // 
            Social.Location = new Point(244, 130);
            Social.Name = "Social";
            Social.Size = new Size(150, 29);
            Social.TabIndex = 1;
            Social.Text = "Social Apps";
            Social.UseVisualStyleBackColor = true;
            Social.Click += Social_Click;
            // 
            // Peripherals
            // 
            Peripherals.Location = new Point(314, 229);
            Peripherals.Name = "Peripherals";
            Peripherals.Size = new Size(150, 29);
            Peripherals.TabIndex = 1;
            Peripherals.Text = "Peripherals";
            Peripherals.UseVisualStyleBackColor = true;
            Peripherals.Click += Peripherals_Click;
            // 
            // Game
            // 
            Game.Location = new Point(244, 340);
            Game.Name = "Game";
            Game.Size = new Size(150, 29);
            Game.TabIndex = 1;
            Game.Text = "Game";
            Game.UseVisualStyleBackColor = true;
            Game.Click += Game_Click;
            // 
            // cleanmgr
            // 
            cleanmgr.Location = new Point(320, 439);
            cleanmgr.Name = "cleanmgr";
            cleanmgr.Size = new Size(124, 29);
            cleanmgr.TabIndex = 1;
            cleanmgr.Text = "Cleaner";
            cleanmgr.UseVisualStyleBackColor = true;
            cleanmgr.Click += cleanmgr_Click;
            // 
            // appdata
            // 
            appdata.Location = new Point(320, 476);
            appdata.Name = "appdata";
            appdata.Size = new Size(124, 29);
            appdata.TabIndex = 1;
            appdata.Text = "Appdata";
            appdata.UseVisualStyleBackColor = true;
            appdata.Click += appdata_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Apps Opener";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(115, 28);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(114, 24);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("UD Digi Kyokasho NK-R", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 399);
            label1.Name = "label1";
            label1.Size = new Size(301, 21);
            label1.TabIndex = 2;
            label1.Text = "This button opens 'MS Teams'";
            // 
            // msteams
            // 
            msteams.Location = new Point(319, 395);
            msteams.Name = "msteams";
            msteams.Size = new Size(125, 29);
            msteams.TabIndex = 3;
            msteams.Text = "MS Teams";
            msteams.UseVisualStyleBackColor = true;
            msteams.Click += msteams_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 518);
            Controls.Add(msteams);
            Controls.Add(label1);
            Controls.Add(appdata);
            Controls.Add(cleanmgr);
            Controls.Add(Game);
            Controls.Add(Peripherals);
            Controls.Add(Social);
            Controls.Add(Instructions005);
            Controls.Add(Instructions004);
            Controls.Add(Instructions003);
            Controls.Add(Instructions002);
            Controls.Add(Instructions001);
            Controls.Add(Title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apps Opener";
            Load += Form1_Load;
            Resize += Form1_Resize;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label Instructions001;
        private Label Instructions002;
        private Label Instructions003;
        private Label Instructions004;
        private Label Instructions005;
        private Button Social;
        private Button Peripherals;
        private Button Game;
        private Button cleanmgr;
        private Button appdata;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Label label1;
        private Button msteams;
    }
}