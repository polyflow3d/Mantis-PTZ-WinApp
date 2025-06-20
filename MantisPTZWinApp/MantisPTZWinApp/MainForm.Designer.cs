 
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
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        comport_cbox = new ComboBox();
        btnConnect = new Button();
        laptop_icon = new PictureBox();
        mainPanel = new Panel();
        IP_groupbox = new GroupBox();
        ip_maskedTextBox = new TextBox();
        port_maskedTextBox = new MaskedTextBox();
        comPort_groupBox = new GroupBox();
        vertical_groupBox = new GroupBox();
        vertical_feedback_label = new Label();
        numericUpDown1 = new NumericUpDown();
        log_textBox = new TextBox();
        ptzIcon = new PictureBox();
        remoteControllerIcon = new PictureBox();
        horizontal_groupBox = new GroupBox();
        horizonal_feedback_label = new Label();
        horizontal_input_upDown = new NumericUpDown();
        menuStrip1 = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        uart_toolStripMenuItem = new ToolStripMenuItem();
        udp_toolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        timer_100ms = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)laptop_icon).BeginInit();
        mainPanel.SuspendLayout();
        IP_groupbox.SuspendLayout();
        comPort_groupBox.SuspendLayout();
        vertical_groupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ptzIcon).BeginInit();
        ((System.ComponentModel.ISupportInitialize)remoteControllerIcon).BeginInit();
        horizontal_groupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)horizontal_input_upDown).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // comport_cbox
        // 
        comport_cbox.FormattingEnabled = true;
        comport_cbox.Location = new Point(14, 28);
        comport_cbox.Margin = new Padding(4, 5, 4, 5);
        comport_cbox.Name = "comport_cbox";
        comport_cbox.Size = new Size(160, 28);
        comport_cbox.TabIndex = 0;
        comport_cbox.SelectedIndexChanged += cboxComport_SelectedIndexChanged;
        // 
        // btnConnect
        // 
        btnConnect.Location = new Point(142, 92);
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
        laptop_icon.Location = new Point(3, 3);
        laptop_icon.Name = "laptop_icon";
        laptop_icon.Size = new Size(128, 128);
        laptop_icon.TabIndex = 7;
        laptop_icon.TabStop = false;
        laptop_icon.Click += pictureBox1_Click;
        // 
        // mainPanel
        // 
        mainPanel.AutoSize = true;
        mainPanel.Controls.Add(IP_groupbox);
        mainPanel.Controls.Add(comPort_groupBox);
        mainPanel.Controls.Add(vertical_groupBox);
        mainPanel.Controls.Add(log_textBox);
        mainPanel.Controls.Add(btnConnect);
        mainPanel.Controls.Add(ptzIcon);
        mainPanel.Controls.Add(remoteControllerIcon);
        mainPanel.Controls.Add(laptop_icon);
        mainPanel.Controls.Add(horizontal_groupBox);
        mainPanel.Dock = DockStyle.Fill;
        mainPanel.Location = new Point(0, 28);
        mainPanel.Name = "mainPanel";
        mainPanel.Size = new Size(1182, 725);
        mainPanel.TabIndex = 2;
        mainPanel.TabStop = true;
        mainPanel.Resize += mainPanel_Resize;
        // 
        // IP_groupbox
        // 
        IP_groupbox.Controls.Add(ip_maskedTextBox);
        IP_groupbox.Controls.Add(port_maskedTextBox);
        IP_groupbox.Location = new Point(137, 16);
        IP_groupbox.Name = "IP_groupbox";
        IP_groupbox.Size = new Size(246, 68);
        IP_groupbox.TabIndex = 21;
        IP_groupbox.TabStop = false;
        IP_groupbox.Text = "IP/Port";
        // 
        // ip_maskedTextBox
        // 
        ip_maskedTextBox.Location = new Point(5, 29);
        ip_maskedTextBox.Name = "ip_maskedTextBox";
        ip_maskedTextBox.Size = new Size(125, 27);
        ip_maskedTextBox.TabIndex = 21;
        ip_maskedTextBox.Text = "192.168.88.254";
        // 
        // port_maskedTextBox
        // 
        port_maskedTextBox.Location = new Point(150, 29);
        port_maskedTextBox.Name = "port_maskedTextBox";
        port_maskedTextBox.Size = new Size(83, 27);
        port_maskedTextBox.TabIndex = 20;
        port_maskedTextBox.Text = "7777";
        // 
        // comPort_groupBox
        // 
        comPort_groupBox.Controls.Add(comport_cbox);
        comPort_groupBox.Location = new Point(137, 16);
        comPort_groupBox.Name = "comPort_groupBox";
        comPort_groupBox.Size = new Size(181, 68);
        comPort_groupBox.TabIndex = 20;
        comPort_groupBox.TabStop = false;
        comPort_groupBox.Text = "COM port";
        // 
        // vertical_groupBox
        // 
        vertical_groupBox.Controls.Add(vertical_feedback_label);
        vertical_groupBox.Controls.Add(numericUpDown1);
        vertical_groupBox.Location = new Point(278, 171);
        vertical_groupBox.Name = "vertical_groupBox";
        vertical_groupBox.Size = new Size(239, 123);
        vertical_groupBox.TabIndex = 17;
        vertical_groupBox.TabStop = false;
        vertical_groupBox.Text = "Vertical";
        // 
        // vertical_feedback_label
        // 
        vertical_feedback_label.AutoSize = true;
        vertical_feedback_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        vertical_feedback_label.Location = new Point(87, 37);
        vertical_feedback_label.Name = "vertical_feedback_label";
        vertical_feedback_label.Size = new Size(44, 28);
        vertical_feedback_label.TabIndex = 15;
        vertical_feedback_label.Text = "-15";
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(40, 78);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(150, 27);
        numericUpDown1.TabIndex = 14;
        // 
        // log_textBox
        // 
        log_textBox.BackColor = SystemColors.Control;
        log_textBox.BorderStyle = BorderStyle.FixedSingle;
        log_textBox.Location = new Point(12, 315);
        log_textBox.Multiline = true;
        log_textBox.Name = "log_textBox";
        log_textBox.ReadOnly = true;
        log_textBox.ScrollBars = ScrollBars.Vertical;
        log_textBox.Size = new Size(1158, 398);
        log_textBox.TabIndex = 17;
        // 
        // ptzIcon
        // 
        ptzIcon.BackColor = Color.Transparent;
        ptzIcon.BackgroundImage = MantisPTZWinApp.Properties.Resources.mantis_d_icon;
        ptzIcon.BackgroundImageLayout = ImageLayout.Zoom;
        ptzIcon.InitialImage = null;
        ptzIcon.Location = new Point(1042, 3);
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
        remoteControllerIcon.Location = new Point(533, 3);
        remoteControllerIcon.Name = "remoteControllerIcon";
        remoteControllerIcon.Size = new Size(128, 128);
        remoteControllerIcon.TabIndex = 9;
        remoteControllerIcon.TabStop = false;
        // 
        // horizontal_groupBox
        // 
        horizontal_groupBox.Controls.Add(horizonal_feedback_label);
        horizontal_groupBox.Controls.Add(horizontal_input_upDown);
        horizontal_groupBox.Location = new Point(12, 171);
        horizontal_groupBox.Name = "horizontal_groupBox";
        horizontal_groupBox.Size = new Size(239, 123);
        horizontal_groupBox.TabIndex = 16;
        horizontal_groupBox.TabStop = false;
        horizontal_groupBox.Text = "Horizontal";
        // 
        // horizonal_feedback_label
        // 
        horizonal_feedback_label.AutoSize = true;
        horizonal_feedback_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        horizonal_feedback_label.Location = new Point(92, 37);
        horizonal_feedback_label.Name = "horizonal_feedback_label";
        horizonal_feedback_label.Size = new Size(24, 28);
        horizonal_feedback_label.TabIndex = 15;
        horizonal_feedback_label.Text = "0";
        // 
        // horizontal_input_upDown
        // 
        horizontal_input_upDown.Location = new Point(40, 78);
        horizontal_input_upDown.Name = "horizontal_input_upDown";
        horizontal_input_upDown.Size = new Size(150, 27);
        horizontal_input_upDown.TabIndex = 14;
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1182, 28);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uart_toolStripMenuItem, udp_toolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(46, 24);
        fileToolStripMenuItem.Text = "File";
        fileToolStripMenuItem.Click += fileToolStripMenuItem_Click;
        // 
        // uart_toolStripMenuItem
        // 
        uart_toolStripMenuItem.Name = "uart_toolStripMenuItem";
        uart_toolStripMenuItem.Size = new Size(128, 26);
        uart_toolStripMenuItem.Text = "UART";
        uart_toolStripMenuItem.Click += uart_toolStripMenuItem_Click;
        // 
        // udp_toolStripMenuItem
        // 
        udp_toolStripMenuItem.Checked = true;
        udp_toolStripMenuItem.CheckState = CheckState.Checked;
        udp_toolStripMenuItem.Name = "udp_toolStripMenuItem";
        udp_toolStripMenuItem.Size = new Size(128, 26);
        udp_toolStripMenuItem.Text = "UDP";
        udp_toolStripMenuItem.Click += udp_toolStripMenuItem_Click;
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(55, 24);
        helpToolStripMenuItem.Text = "Help";
        // 
        // timer_100ms
        // 
        timer_100ms.Tick += timer_100ms_Tick;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1182, 753);
        Controls.Add(mainPanel);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4, 5, 4, 5);
        MaximumSize = new Size(1200, 800);
        MinimumSize = new Size(1200, 800);
        Name = "MainForm";
        Text = "MANTIS PTZ ";
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;
        ((System.ComponentModel.ISupportInitialize)laptop_icon).EndInit();
        mainPanel.ResumeLayout(false);
        mainPanel.PerformLayout();
        IP_groupbox.ResumeLayout(false);
        IP_groupbox.PerformLayout();
        comPort_groupBox.ResumeLayout(false);
        vertical_groupBox.ResumeLayout(false);
        vertical_groupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)ptzIcon).EndInit();
        ((System.ComponentModel.ISupportInitialize)remoteControllerIcon).EndInit();
        horizontal_groupBox.ResumeLayout(false);
        horizontal_groupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)horizontal_input_upDown).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comport_cbox;
        private System.Windows.Forms.Button btnConnect;
    private PictureBox laptop_icon;
    private Panel mainPanel;
    private PictureBox remoteControllerIcon;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private PictureBox ptzIcon;
    private NumericUpDown horizontal_input_upDown;
    private GroupBox horizontal_groupBox;
    private Label horizonal_feedback_label;
    private ToolStripMenuItem uart_toolStripMenuItem;
    private ToolStripMenuItem udp_toolStripMenuItem;
    private TextBox log_textBox;
    private GroupBox vertical_groupBox;
    private Label vertical_feedback_label;
    private NumericUpDown numericUpDown1;
    private TextBox textBox1;
    private GroupBox comPort_groupBox;
    private GroupBox IP_groupbox;
    private MaskedTextBox port_maskedTextBox;
    public System.Windows.Forms.Timer timer_100ms;
    private TextBox ip_maskedTextBox;
}
 