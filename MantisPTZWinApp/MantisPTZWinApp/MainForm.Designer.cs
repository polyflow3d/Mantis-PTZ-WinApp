 
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
        udp_link_stats_label = new Label();
        command_button1 = new Button();
        command_button_0 = new Button();
        comPort_groupBox = new GroupBox();
        vertical_groupBox = new GroupBox();
        vertical_feedback_label = new Label();
        vertical_input_upDown = new NumericUpDown();
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
        timer_1000ms = new System.Windows.Forms.Timer(components);
        timer_10ms = new System.Windows.Forms.Timer(components);
        ((System.ComponentModel.ISupportInitialize)laptop_icon).BeginInit();
        mainPanel.SuspendLayout();
        comPort_groupBox.SuspendLayout();
        vertical_groupBox.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)vertical_input_upDown).BeginInit();
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
        btnConnect.Location = new Point(138, 53);
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
        mainPanel.Controls.Add(udp_link_stats_label);
        mainPanel.Controls.Add(command_button1);
        mainPanel.Controls.Add(command_button_0);
        mainPanel.Controls.Add(btnConnect);
        mainPanel.Controls.Add(comPort_groupBox);
        mainPanel.Controls.Add(vertical_groupBox);
        mainPanel.Controls.Add(log_textBox);
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
        // udp_link_stats_label
        // 
        udp_link_stats_label.AutoSize = true;
        udp_link_stats_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        udp_link_stats_label.Location = new Point(257, 53);
        udp_link_stats_label.Name = "udp_link_stats_label";
        udp_link_stats_label.Size = new Size(238, 28);
        udp_link_stats_label.TabIndex = 23;
        udp_link_stats_label.Text = "....... 3 packets/seconds....... ";
        // 
        // command_button1
        // 
        command_button1.Location = new Point(491, 229);
        command_button1.Name = "command_button1";
        command_button1.Size = new Size(180, 29);
        command_button1.TabIndex = 22;
        command_button1.Text = "Command 1";
        command_button1.UseVisualStyleBackColor = true;
        command_button1.Click += command_button1_Click;
        // 
        // command_button_0
        // 
        command_button_0.Location = new Point(491, 182);
        command_button_0.Name = "command_button_0";
        command_button_0.Size = new Size(180, 29);
        command_button_0.TabIndex = 21;
        command_button_0.Text = "Command 0";
        command_button_0.UseVisualStyleBackColor = true;
        command_button_0.Click += command_button_0_Click;
        // 
        // comPort_groupBox
        // 
        comPort_groupBox.Controls.Add(comport_cbox);
        comPort_groupBox.Location = new Point(741, 229);
        comPort_groupBox.Name = "comPort_groupBox";
        comPort_groupBox.Size = new Size(181, 68);
        comPort_groupBox.TabIndex = 20;
        comPort_groupBox.TabStop = false;
        comPort_groupBox.Text = "COM port";
        // 
        // vertical_groupBox
        // 
        vertical_groupBox.Controls.Add(vertical_feedback_label);
        vertical_groupBox.Controls.Add(vertical_input_upDown);
        vertical_groupBox.Location = new Point(257, 171);
        vertical_groupBox.Name = "vertical_groupBox";
        vertical_groupBox.Size = new Size(212, 125);
        vertical_groupBox.TabIndex = 17;
        vertical_groupBox.TabStop = false;
        vertical_groupBox.Text = "Vertical";
        // 
        // vertical_feedback_label
        // 
        vertical_feedback_label.AutoSize = true;
        vertical_feedback_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        vertical_feedback_label.Location = new Point(86, 23);
        vertical_feedback_label.Name = "vertical_feedback_label";
        vertical_feedback_label.Size = new Size(44, 28);
        vertical_feedback_label.TabIndex = 15;
        vertical_feedback_label.Text = "-15";
        // 
        // vertical_input_upDown
        // 
        vertical_input_upDown.Location = new Point(60, 77);
        vertical_input_upDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
        vertical_input_upDown.Minimum = new decimal(new int[] { 15, 0, 0, int.MinValue });
        vertical_input_upDown.Name = "vertical_input_upDown";
        vertical_input_upDown.Size = new Size(118, 27);
        vertical_input_upDown.TabIndex = 14;
        vertical_input_upDown.Value = new decimal(new int[] { 15, 0, 0, 0 });
        vertical_input_upDown.ValueChanged += vertical_input_upDown_ValueChanged;
        // 
        // log_textBox
        // 
        log_textBox.BackColor = SystemColors.Control;
        log_textBox.BorderStyle = BorderStyle.FixedSingle;
        log_textBox.Location = new Point(12, 317);
        log_textBox.Multiline = true;
        log_textBox.Name = "log_textBox";
        log_textBox.ReadOnly = true;
        log_textBox.ScrollBars = ScrollBars.Vertical;
        log_textBox.Size = new Size(1170, 381);
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
        horizontal_groupBox.Size = new Size(214, 125);
        horizontal_groupBox.TabIndex = 16;
        horizontal_groupBox.TabStop = false;
        horizontal_groupBox.Text = "Horizontal";
        // 
        // horizonal_feedback_label
        // 
        horizonal_feedback_label.AutoSize = true;
        horizonal_feedback_label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
        horizonal_feedback_label.Location = new Point(86, 23);
        horizonal_feedback_label.Name = "horizonal_feedback_label";
        horizonal_feedback_label.Size = new Size(24, 28);
        horizonal_feedback_label.TabIndex = 15;
        horizonal_feedback_label.Text = "0";
        // 
        // horizontal_input_upDown
        // 
        horizontal_input_upDown.Location = new Point(50, 77);
        horizontal_input_upDown.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
        horizontal_input_upDown.Minimum = new decimal(new int[] { 60, 0, 0, int.MinValue });
        horizontal_input_upDown.Name = "horizontal_input_upDown";
        horizontal_input_upDown.Size = new Size(108, 27);
        horizontal_input_upDown.TabIndex = 14;
        horizontal_input_upDown.ValueChanged += horizontal_input_upDown_ValueChanged;
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
        // timer_1000ms
        // 
        timer_1000ms.Enabled = true;
        timer_1000ms.Interval = 1000;
        timer_1000ms.Tick += timer_1000ms_Tick;
        // 
        // timer_10ms
        // 
        timer_10ms.Enabled = true;
        timer_10ms.Interval = 10;
        timer_10ms.Tick += timer_10ms_Tick;
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
        comPort_groupBox.ResumeLayout(false);
        vertical_groupBox.ResumeLayout(false);
        vertical_groupBox.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)vertical_input_upDown).EndInit();
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
    private NumericUpDown vertical_input_upDown;
    private TextBox textBox1;
    private GroupBox comPort_groupBox;
    public System.Windows.Forms.Timer timer_1000ms;
    private Button command_button1;
    private Button command_button_0;
    private Label udp_link_stats_label;
    private System.Windows.Forms.Timer timer_10ms;
}
 