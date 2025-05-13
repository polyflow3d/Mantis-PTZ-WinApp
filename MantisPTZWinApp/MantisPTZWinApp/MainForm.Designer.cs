 
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        cboxComport = new ComboBox();
        btnConnect = new Button();
        laptop_icon = new PictureBox();
        mainPanel = new Panel();
        groupBox1 = new GroupBox();
        label1 = new Label();
        numericUpDown1 = new NumericUpDown();
        listView_packets = new ListView();
        startByte = new ColumnHeader();
        packetID = new ColumnHeader();
        COBS = new ColumnHeader();
        ptzIcon = new PictureBox();
        remoteControllerIcon = new PictureBox();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        ((System.ComponentModel.ISupportInitialize)laptop_icon).BeginInit();
        mainPanel.SuspendLayout();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ptzIcon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)remoteControllerIcon).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // cboxComport
        // 
        cboxComport.FormattingEnabled = true;
        cboxComport.Location = new Point(140, 32);
        cboxComport.Margin = new Padding(4, 5, 4, 5);
        cboxComport.Name = "cboxComport";
        cboxComport.Size = new Size(100, 28);
        cboxComport.TabIndex = 0;
        cboxComport.SelectedIndexChanged += cboxComport_SelectedIndexChanged;
        // 
        // btnConnect
        // 
        btnConnect.Location = new Point(140, 71);
        btnConnect.Margin = new Padding(4, 5, 4, 5);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(100, 28);
        btnConnect.TabIndex = 2;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = true;
        btnConnect.Click += btnConnect_Click;
        // 
        // laptop_icon
        // 
        laptop_icon.BackColor = Color.Transparent;
        laptop_icon.BackgroundImage = MantisPTZWinApp.Properties.Resources.laptop_icon1;
        laptop_icon.BackgroundImageLayout = ImageLayout.Zoom;
        laptop_icon.Location = new Point(0, 0);
        laptop_icon.Name = "laptop_icon";
        laptop_icon.Size = new Size(128, 128);
        laptop_icon.TabIndex = 7;
        laptop_icon.TabStop = false;
        laptop_icon.Click += pictureBox1_Click;
        // 
        // mainPanel
        // 
        mainPanel.AutoSize = true;
        mainPanel.Controls.Add(listView_packets);
        mainPanel.Controls.Add(cboxComport);
        mainPanel.Controls.Add(btnConnect);
        mainPanel.Controls.Add(ptzIcon);
        mainPanel.Controls.Add(remoteControllerIcon);
        mainPanel.Controls.Add(laptop_icon);
        mainPanel.Controls.Add(groupBox1);
        mainPanel.Dock = DockStyle.Top;
        mainPanel.Location = new Point(0, 28);
        mainPanel.Name = "mainPanel";
        mainPanel.Size = new Size(905, 406);
        mainPanel.TabIndex = 2;
        mainPanel.TabStop = true;
        mainPanel.Resize += mainPanel_Resize;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(numericUpDown1);
        groupBox1.Location = new Point(12, 134);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(275, 112);
        groupBox1.TabIndex = 16;
        groupBox1.TabStop = false;
        groupBox1.Text = "Horizontal";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        label1.Location = new Point(16, 23);
        label1.Name = "label1";
        label1.Size = new Size(70, 28);
        label1.TabIndex = 15;
        label1.Text = "label1";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(16, 54);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(150, 27);
        numericUpDown1.TabIndex = 14;
        // 
        // listView_packets
        // 
        listView_packets.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        listView_packets.Columns.AddRange(new ColumnHeader[] { startByte, packetID, COBS });
        listView_packets.Location = new Point(18, 234);
        listView_packets.Name = "listView_packets";
        listView_packets.Size = new Size(881, 163);
        listView_packets.TabIndex = 13;
        listView_packets.UseCompatibleStateImageBehavior = false;
        listView_packets.View = View.Details;
        // 
        // startByte
        // 
        startByte.Text = "Start byte";
        startByte.Width = 120;
        // 
        // packetID
        // 
        packetID.Text = "Packet ID";
        // 
        // COBS
        // 
        COBS.Text = "COBS";
        // 
        // ptzIcon
        // 
        ptzIcon.BackColor = Color.Transparent;
        ptzIcon.BackgroundImage = MantisPTZWinApp.Properties.Resources.mantis_d_icon;
        ptzIcon.BackgroundImageLayout = ImageLayout.Zoom;
        ptzIcon.InitialImage = null;
        ptzIcon.Location = new Point(774, 0);
        ptzIcon.Name = "ptzIcon";
        ptzIcon.Size = new Size(128, 128);
        ptzIcon.TabIndex = 10;
        ptzIcon.TabStop = false;
        // 
        // remoteControllerIcon
        // 
        remoteControllerIcon.BackColor = Color.Transparent;
        remoteControllerIcon.BackgroundImage = (Image)resources.GetObject("remoteControllerIcon.BackgroundImage");
        remoteControllerIcon.BackgroundImageLayout = ImageLayout.Zoom;
        remoteControllerIcon.InitialImage = null;
        remoteControllerIcon.Location = new Point(360, 0);
        remoteControllerIcon.Name = "remoteControllerIcon";
        remoteControllerIcon.Size = new Size(128, 128);
        remoteControllerIcon.TabIndex = 9;
        remoteControllerIcon.TabStop = false;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(905, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(46, 24);
        fileToolStripMenuItem.Text = "File";
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(55, 24);
        helpToolStripMenuItem.Text = "Help";
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(905, 776);
        Controls.Add(mainPanel);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 5, 4, 5);
        Name = "MainForm";
        Text = "MANTIS PTZ ";
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)laptop_icon).EndInit();
        mainPanel.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)ptzIcon).EndInit();
        ((System.ComponentModel.ISupportInitialize)remoteControllerIcon).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboxComport;
        private System.Windows.Forms.Button btnConnect;
    private PictureBox laptop_icon;
    private Panel mainPanel;
    private PictureBox remoteControllerIcon;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private PictureBox ptzIcon;
    private ListView listView_packets;
    private ColumnHeader packetID;
    private ColumnHeader startByte;
    private ColumnHeader COBS;
    private NumericUpDown numericUpDown1;
    private GroupBox groupBox1;
    private Label label1;
}
 