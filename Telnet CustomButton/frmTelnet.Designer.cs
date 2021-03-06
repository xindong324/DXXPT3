namespace Telnet
{
  partial class frmTelnet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelnet));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.lblSend = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbText = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.gbPortSettings = new System.Windows.Forms.GroupBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtRemoteAddress = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lnkAbout = new System.Windows.Forms.LinkLabel();
            this.gbPrint = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrintPreview = new System.Windows.Forms.Button();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.btnExportLog = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.linkUserGuide = new System.Windows.Forms.LinkLabel();
            this.gbCustomBtn = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.sbpLocIP = new System.Windows.Forms.StatusBarPanel();
            this.sbpHost = new System.Windows.Forms.StatusBarPanel();
            this.sbpStatus = new System.Windows.Forms.StatusBarPanel();
            this.rtbAtt = new System.Windows.Forms.RichTextBox();
            this.chartAtt1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartClear = new System.Windows.Forms.Button();
            this.rtbConsole = new Telnet.rtbPrintCtrl();
            this.gbMode.SuspendLayout();
            this.gbPortSettings.SuspendLayout();
            this.gbPrint.SuspendLayout();
            this.gbCustomBtn.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sbpLocIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpHost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAtt1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSendData
            // 
            this.txtSendData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSendData.Location = new System.Drawing.Point(119, 489);
            this.txtSendData.Margin = new System.Windows.Forms.Padding(4);
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(499, 25);
            this.txtSendData.TabIndex = 2;
            this.txtSendData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendData_KeyDown);
            this.txtSendData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSendData_KeyPress);
            // 
            // lblSend
            // 
            this.lblSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSend.AutoSize = true;
            this.lblSend.Location = new System.Drawing.Point(19, 493);
            this.lblSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSend.Name = "lblSend";
            this.lblSend.Size = new System.Drawing.Size(87, 15);
            this.lblSend.TabIndex = 1;
            this.lblSend.Text = "Send &Data:";
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(635, 489);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(125, 29);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Checked = true;
            this.rbHex.Location = new System.Drawing.Point(103, 26);
            this.rbHex.Margin = new System.Windows.Forms.Padding(4);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(52, 19);
            this.rbHex.TabIndex = 1;
            this.rbHex.TabStop = true;
            this.rbHex.Text = "Hex";
            this.rbHex.CheckedChanged += new System.EventHandler(this.rbHex_CheckedChanged);
            // 
            // rbText
            // 
            this.rbText.AutoSize = true;
            this.rbText.Location = new System.Drawing.Point(20, 26);
            this.rbText.Margin = new System.Windows.Forms.Padding(4);
            this.rbText.Name = "rbText";
            this.rbText.Size = new System.Drawing.Size(60, 19);
            this.rbText.TabIndex = 0;
            this.rbText.Text = "Text";
            this.rbText.CheckedChanged += new System.EventHandler(this.rbText_CheckedChanged);
            // 
            // gbMode
            // 
            this.gbMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMode.Controls.Add(this.rbText);
            this.gbMode.Controls.Add(this.rbHex);
            this.gbMode.Location = new System.Drawing.Point(463, 332);
            this.gbMode.Margin = new System.Windows.Forms.Padding(4);
            this.gbMode.Name = "gbMode";
            this.gbMode.Padding = new System.Windows.Forms.Padding(4);
            this.gbMode.Size = new System.Drawing.Size(165, 66);
            this.gbMode.TabIndex = 5;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Data &Mode";
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenPort.Location = new System.Drawing.Point(636, 338);
            this.btnOpenPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(125, 60);
            this.btnOpenPort.TabIndex = 6;
            this.btnOpenPort.Text = "&Open Port";
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // gbPortSettings
            // 
            this.gbPortSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbPortSettings.Controls.Add(this.txtPort);
            this.gbPortSettings.Controls.Add(this.txtRemoteAddress);
            this.gbPortSettings.Controls.Add(this.lblport);
            this.gbPortSettings.Controls.Add(this.lblHost);
            this.gbPortSettings.Location = new System.Drawing.Point(21, 332);
            this.gbPortSettings.Margin = new System.Windows.Forms.Padding(4);
            this.gbPortSettings.Name = "gbPortSettings";
            this.gbPortSettings.Padding = new System.Windows.Forms.Padding(4);
            this.gbPortSettings.Size = new System.Drawing.Size(433, 66);
            this.gbPortSettings.TabIndex = 4;
            this.gbPortSettings.TabStop = false;
            this.gbPortSettings.Text = "Port &Settings";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(355, 25);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(41, 25);
            this.txtPort.TabIndex = 16;
            this.txtPort.Text = "23";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRemoteAddress
            // 
            this.txtRemoteAddress.Location = new System.Drawing.Point(88, 25);
            this.txtRemoteAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemoteAddress.Name = "txtRemoteAddress";
            this.txtRemoteAddress.Size = new System.Drawing.Size(223, 25);
            this.txtRemoteAddress.TabIndex = 14;
            this.txtRemoteAddress.Text = "192.168.1.168";
            this.txtRemoteAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(320, 29);
            this.lblport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(22, 15);
            this.lblport.TabIndex = 15;
            this.lblport.Text = "：";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(25, 29);
            this.lblHost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(54, 15);
            this.lblHost.TabIndex = 13;
            this.lblHost.Text = "Host：";
            // 
            // lnkAbout
            // 
            this.lnkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAbout.AutoSize = true;
            this.lnkAbout.Location = new System.Drawing.Point(1043, 417);
            this.lnkAbout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkAbout.Name = "lnkAbout";
            this.lnkAbout.Size = new System.Drawing.Size(47, 15);
            this.lnkAbout.TabIndex = 7;
            this.lnkAbout.TabStop = true;
            this.lnkAbout.Text = "&About";
            this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
            // 
            // gbPrint
            // 
            this.gbPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrint.Controls.Add(this.btnClear);
            this.gbPrint.Controls.Add(this.btnPrint);
            this.gbPrint.Controls.Add(this.btnPrintPreview);
            this.gbPrint.Controls.Add(this.btnPageSetup);
            this.gbPrint.Controls.Add(this.btnExportLog);
            this.gbPrint.Location = new System.Drawing.Point(21, 406);
            this.gbPrint.Margin = new System.Windows.Forms.Padding(4);
            this.gbPrint.Name = "gbPrint";
            this.gbPrint.Padding = new System.Windows.Forms.Padding(4);
            this.gbPrint.Size = new System.Drawing.Size(607, 69);
            this.gbPrint.TabIndex = 8;
            this.gbPrint.TabStop = false;
            this.gbPrint.Text = "Export / Print Log";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(484, 25);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(369, 25);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 29);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.Location = new System.Drawing.Point(255, 25);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(100, 29);
            this.btnPrintPreview.TabIndex = 2;
            this.btnPrintPreview.Text = "Preview";
            this.btnPrintPreview.UseVisualStyleBackColor = true;
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Location = new System.Drawing.Point(140, 25);
            this.btnPageSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(100, 29);
            this.btnPageSetup.TabIndex = 1;
            this.btnPageSetup.Text = "PageSetup";
            this.btnPageSetup.UseVisualStyleBackColor = true;
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // btnExportLog
            // 
            this.btnExportLog.Location = new System.Drawing.Point(25, 25);
            this.btnExportLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportLog.Name = "btnExportLog";
            this.btnExportLog.Size = new System.Drawing.Size(100, 29);
            this.btnExportLog.TabIndex = 0;
            this.btnExportLog.Text = "ExportLog";
            this.btnExportLog.UseVisualStyleBackColor = true;
            this.btnExportLog.Click += new System.EventHandler(this.btnExportLog_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // linkUserGuide
            // 
            this.linkUserGuide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkUserGuide.AutoSize = true;
            this.linkUserGuide.Location = new System.Drawing.Point(1026, 445);
            this.linkUserGuide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkUserGuide.Name = "linkUserGuide";
            this.linkUserGuide.Size = new System.Drawing.Size(87, 15);
            this.linkUserGuide.TabIndex = 7;
            this.linkUserGuide.TabStop = true;
            this.linkUserGuide.Text = "&User Guide";
            this.linkUserGuide.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUserGuide_LinkClicked);
            // 
            // gbCustomBtn
            // 
            this.gbCustomBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomBtn.Controls.Add(this.tableLayoutPanel1);
            this.gbCustomBtn.Enabled = false;
            this.gbCustomBtn.Location = new System.Drawing.Point(17, 526);
            this.gbCustomBtn.Margin = new System.Windows.Forms.Padding(4);
            this.gbCustomBtn.Name = "gbCustomBtn";
            this.gbCustomBtn.Padding = new System.Windows.Forms.Padding(4);
            this.gbCustomBtn.Size = new System.Drawing.Size(756, 109);
            this.gbCustomBtn.TabIndex = 12;
            this.gbCustomBtn.TabStop = false;
            this.gbCustomBtn.Text = "CustomButton";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 22);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(748, 83);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btn1
            // 
            this.btn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn1.Location = new System.Drawing.Point(27, 6);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(133, 29);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "Button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn5
            // 
            this.btn5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn5.Location = new System.Drawing.Point(27, 47);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(133, 29);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "Button5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2.Location = new System.Drawing.Point(214, 6);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(133, 29);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "Button2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn6
            // 
            this.btn6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn6.Location = new System.Drawing.Point(214, 47);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(133, 29);
            this.btn6.TabIndex = 13;
            this.btn6.Text = "Button6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn3
            // 
            this.btn3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3.Location = new System.Drawing.Point(401, 6);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(133, 29);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "Button3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn7
            // 
            this.btn7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn7.Location = new System.Drawing.Point(401, 47);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(133, 29);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "Button7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn4
            // 
            this.btn4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn4.Location = new System.Drawing.Point(588, 6);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(133, 29);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "Button4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn8
            // 
            this.btn8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn8.Location = new System.Drawing.Point(588, 47);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(133, 29);
            this.btn8.TabIndex = 17;
            this.btn8.Text = "Button8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 641);
            this.statusBar.Margin = new System.Windows.Forms.Padding(4);
            this.statusBar.Name = "statusBar";
            this.statusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.sbpLocIP,
            this.sbpHost,
            this.sbpStatus});
            this.statusBar.ShowPanels = true;
            this.statusBar.Size = new System.Drawing.Size(1643, 29);
            this.statusBar.TabIndex = 13;
            // 
            // sbpLocIP
            // 
            this.sbpLocIP.Name = "sbpLocIP";
            this.sbpLocIP.Text = "本地地址：";
            this.sbpLocIP.Width = 180;
            // 
            // sbpHost
            // 
            this.sbpHost.Name = "sbpHost";
            this.sbpHost.Text = "服务器地址：";
            this.sbpHost.Width = 180;
            // 
            // sbpStatus
            // 
            this.sbpStatus.Name = "sbpStatus";
            this.sbpStatus.Text = "状态：";
            this.sbpStatus.Width = 200;
            // 
            // rtbAtt
            // 
            this.rtbAtt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rtbAtt.Location = new System.Drawing.Point(17, 297);
            this.rtbAtt.Name = "rtbAtt";
            this.rtbAtt.Size = new System.Drawing.Size(744, 28);
            this.rtbAtt.TabIndex = 14;
            this.rtbAtt.Text = "";
            this.rtbAtt.TextChanged += new System.EventHandler(this.rtbAtt_TextChanged);
            // 
            // chartAtt1
            // 
            this.chartAtt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartAtt1.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            chartArea3.Name = "ChartArea3";
            this.chartAtt1.ChartAreas.Add(chartArea1);
            this.chartAtt1.ChartAreas.Add(chartArea2);
            this.chartAtt1.ChartAreas.Add(chartArea3);
            this.chartAtt1.IsSoftShadows = false;
            legend1.Name = "Legend1";
            this.chartAtt1.Legends.Add(legend1);
            this.chartAtt1.Location = new System.Drawing.Point(780, 9);
            this.chartAtt1.Name = "chartAtt1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 0;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series1.Name = "sRoll";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "SPitch";
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "sYaw";
            this.chartAtt1.Series.Add(series1);
            this.chartAtt1.Series.Add(series2);
            this.chartAtt1.Series.Add(series3);
            this.chartAtt1.Size = new System.Drawing.Size(787, 596);
            this.chartAtt1.TabIndex = 15;
            this.chartAtt1.Text = "chart1";
            // 
            // ChartClear
            // 
            this.ChartClear.Location = new System.Drawing.Point(1100, 611);
            this.ChartClear.Name = "ChartClear";
            this.ChartClear.Size = new System.Drawing.Size(124, 24);
            this.ChartClear.TabIndex = 16;
            this.ChartClear.Text = "Clear";
            this.ChartClear.UseVisualStyleBackColor = true;
            this.ChartClear.Click += new System.EventHandler(this.ChartClear_Click);
            // 
            // rtbConsole
            // 
            this.rtbConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConsole.Location = new System.Drawing.Point(16, 9);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(4);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(744, 286);
            this.rtbConsole.TabIndex = 0;
            this.rtbConsole.Text = "";
            // 
            // frmTelnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1643, 670);
            this.Controls.Add(this.ChartClear);
            this.Controls.Add(this.chartAtt1);
            this.Controls.Add(this.rtbAtt);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.gbCustomBtn);
            this.Controls.Add(this.gbPrint);
            this.Controls.Add(this.linkUserGuide);
            this.Controls.Add(this.lnkAbout);
            this.Controls.Add(this.gbPortSettings);
            this.Controls.Add(this.btnOpenPort);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSend);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.rtbConsole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(739, 325);
            this.Name = "frmTelnet";
            this.Text = "Tcp&Telnet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTelnet_FormClosing);
            this.Load += new System.EventHandler(this.frmTelnet_Load);
            this.Shown += new System.EventHandler(this.frmTelnet_Shown);
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            this.gbPortSettings.ResumeLayout(false);
            this.gbPortSettings.PerformLayout();
            this.gbPrint.ResumeLayout(false);
            this.gbCustomBtn.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sbpLocIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpHost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAtt1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

  //  private System.Windows.Forms.RichTextBox 
    private rtbPrintCtrl rtbConsole;
    private System.Windows.Forms.TextBox txtSendData;
    private System.Windows.Forms.Label lblSend;
    private System.Windows.Forms.Button btnSend;
    private System.Windows.Forms.RadioButton rbHex;
    private System.Windows.Forms.RadioButton rbText;
    private System.Windows.Forms.GroupBox gbMode;
    private System.Windows.Forms.Button btnOpenPort;
    private System.Windows.Forms.GroupBox gbPortSettings;
    private System.Windows.Forms.LinkLabel lnkAbout;
    private System.Windows.Forms.GroupBox gbPrint;
    private System.Windows.Forms.Button btnPrint;
    private System.Windows.Forms.Button btnPrintPreview;
    private System.Windows.Forms.Button btnPageSetup;
    private System.Windows.Forms.Button btnExportLog;
    private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    private System.Windows.Forms.PrintDialog printDialog1;
    private System.Drawing.Printing.PrintDocument printDocument1;
    private System.Windows.Forms.LinkLabel linkUserGuide;
    //
    private System.Windows.Forms.Button[] automationButtonGroup;
    private buttonItemCollection btnItems;
    private System.Windows.Forms.GroupBox gbCustomBtn;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.TextBox txtPort;
    private System.Windows.Forms.TextBox txtRemoteAddress;
    private System.Windows.Forms.Label lblport;
    private System.Windows.Forms.Label lblHost;
    private System.Windows.Forms.StatusBar statusBar;
    private System.Windows.Forms.StatusBarPanel sbpLocIP;
    private System.Windows.Forms.StatusBarPanel sbpHost;
    private System.Windows.Forms.StatusBarPanel sbpStatus;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.RichTextBox rtbAtt;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartAtt1;
    private System.Windows.Forms.Button ChartClear;
  }
}

