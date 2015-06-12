namespace AirSurvey
{
    partial class AerialSurveyUI
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
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.batteryModelCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flightAltitudeNm = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maximumSpeedNm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.focalLength = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.sensorHeight = new System.Windows.Forms.NumericUpDown();
            this.sensorWidth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.markerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsStartPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblGSD = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblFlightTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblFlightDistance = new System.Windows.Forms.Label();
            this.lblFovDimensions = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkPhotoWayPoints = new System.Windows.Forms.CheckBox();
            this.chkPhotoAreas = new System.Windows.Forms.CheckBox();
            this.chkOuterGrid = new System.Windows.Forms.CheckBox();
            this.workerRouteCalculator = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.angleNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightAltitudeNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumSpeedNm)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.focalLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorWidth)).BeginInit();
            this.markerMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.AutoSize = true;
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(0, 0);
            this.map.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 20;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(927, 719);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.map_OnMarkerClick);
            this.map.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.map_OnMarkerEnter);
            this.map.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.map_OnMarkerLeave);
            this.map.MouseMove += new System.Windows.Forms.MouseEventHandler(this.map_MouseMove);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.batteryModelCmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.flightAltitudeNm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.maximumSpeedNm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(935, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(379, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flight Options";
            // 
            // batteryModelCmb
            // 
            this.batteryModelCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batteryModelCmb.FormattingEnabled = true;
            this.batteryModelCmb.Location = new System.Drawing.Point(139, 94);
            this.batteryModelCmb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.batteryModelCmb.Name = "batteryModelCmb";
            this.batteryModelCmb.Size = new System.Drawing.Size(229, 24);
            this.batteryModelCmb.TabIndex = 8;
            this.batteryModelCmb.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Battery Model :";
            this.label1.Visible = false;
            // 
            // flightAltitudeNm
            // 
            this.flightAltitudeNm.Location = new System.Drawing.Point(140, 58);
            this.flightAltitudeNm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flightAltitudeNm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.flightAltitudeNm.Name = "flightAltitudeNm";
            this.flightAltitudeNm.Size = new System.Drawing.Size(191, 22);
            this.flightAltitudeNm.TabIndex = 5;
            this.flightAltitudeNm.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.flightAltitudeNm.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 60);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Flight altitude :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(339, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "m/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 26);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "m";
            // 
            // maximumSpeedNm
            // 
            this.maximumSpeedNm.Location = new System.Drawing.Point(140, 25);
            this.maximumSpeedNm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maximumSpeedNm.Name = "maximumSpeedNm";
            this.maximumSpeedNm.Size = new System.Drawing.Size(191, 22);
            this.maximumSpeedNm.TabIndex = 2;
            this.maximumSpeedNm.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.focalLength);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.sensorHeight);
            this.groupBox2.Controls.Add(this.sensorWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(935, 148);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(377, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Options";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(339, 92);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(339, 60);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(339, 27);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "mm";
            // 
            // focalLength
            // 
            this.focalLength.Location = new System.Drawing.Point(139, 90);
            this.focalLength.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.focalLength.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.focalLength.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.focalLength.Name = "focalLength";
            this.focalLength.Size = new System.Drawing.Size(192, 22);
            this.focalLength.TabIndex = 5;
            this.focalLength.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.focalLength.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Focal Length :";
            // 
            // sensorHeight
            // 
            this.sensorHeight.DecimalPlaces = 2;
            this.sensorHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sensorHeight.Location = new System.Drawing.Point(139, 58);
            this.sensorHeight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensorHeight.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.sensorHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensorHeight.Name = "sensorHeight";
            this.sensorHeight.Size = new System.Drawing.Size(192, 22);
            this.sensorHeight.TabIndex = 3;
            this.sensorHeight.Value = new decimal(new int[] {
            462,
            0,
            0,
            131072});
            this.sensorHeight.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // sensorWidth
            // 
            this.sensorWidth.DecimalPlaces = 2;
            this.sensorWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sensorWidth.Location = new System.Drawing.Point(139, 25);
            this.sensorWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sensorWidth.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sensorWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sensorWidth.Name = "sensorWidth";
            this.sensorWidth.Size = new System.Drawing.Size(192, 22);
            this.sensorWidth.TabIndex = 2;
            this.sensorWidth.Value = new decimal(new int[] {
            616,
            0,
            0,
            131072});
            this.sensorWidth.ValueChanged += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sensor Height :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sensor width :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of flights (m) :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(171, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            // 
            // markerMenu
            // 
            this.markerMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.markerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsStartPointToolStripMenuItem});
            this.markerMenu.Name = "markerMenu";
            this.markerMenu.Size = new System.Drawing.Size(190, 28);
            this.markerMenu.Text = "Set as start point";
            // 
            // setAsStartPointToolStripMenuItem
            // 
            this.setAsStartPointToolStripMenuItem.Name = "setAsStartPointToolStripMenuItem";
            this.setAsStartPointToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.setAsStartPointToolStripMenuItem.Text = "Set as start point";
            this.setAsStartPointToolStripMenuItem.Click += new System.EventHandler(this.setAsStartPointToolStripMenuItem_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(1111, 290);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(203, 28);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Route";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.CalculateBtnClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(935, 363);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(377, 356);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.angleNumeric);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.lblAngle);
            this.tabPage1.Controls.Add(this.lblGSD);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.lblFlightTime);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.lblLon);
            this.tabPage1.Controls.Add(this.lblLat);
            this.tabPage1.Controls.Add(this.lblFlightDistance);
            this.tabPage1.Controls.Add(this.lblFovDimensions);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(369, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 274);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 17;
            this.label20.Text = "Polygon Angle :";
            // 
            // lblAngle
            // 
            this.lblAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAngle.AutoSize = true;
            this.lblAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAngle.ForeColor = System.Drawing.Color.Red;
            this.lblAngle.Location = new System.Drawing.Point(165, 267);
            this.lblAngle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(24, 25);
            this.lblAngle.TabIndex = 16;
            this.lblAngle.Text = "0";
            // 
            // lblGSD
            // 
            this.lblGSD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGSD.AutoSize = true;
            this.lblGSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGSD.ForeColor = System.Drawing.Color.Red;
            this.lblGSD.Location = new System.Drawing.Point(167, 231);
            this.lblGSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGSD.Name = "lblGSD";
            this.lblGSD.Size = new System.Drawing.Size(24, 25);
            this.lblGSD.TabIndex = 16;
            this.lblGSD.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 17);
            this.label19.TabIndex = 15;
            this.label19.Text = "GSD :";
            // 
            // lblFlightTime
            // 
            this.lblFlightTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightTime.AutoSize = true;
            this.lblFlightTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightTime.ForeColor = System.Drawing.Color.Red;
            this.lblFlightTime.Location = new System.Drawing.Point(165, 192);
            this.lblFlightTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightTime.Name = "lblFlightTime";
            this.lblFlightTime.Size = new System.Drawing.Size(24, 25);
            this.lblFlightTime.TabIndex = 14;
            this.lblFlightTime.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 199);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 17);
            this.label18.TabIndex = 13;
            this.label18.Text = "Flight Time :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 165);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 17);
            this.label17.TabIndex = 12;
            this.label17.Text = "Flight Distance (km) :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 123);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Lon :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 95);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Lat:";
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLon.Location = new System.Drawing.Point(80, 117);
            this.lblLon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(106, 25);
            this.lblLon.TabIndex = 9;
            this.lblLon.Text = "longtitude";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLat.Location = new System.Drawing.Point(85, 90);
            this.lblLat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(82, 25);
            this.lblLat.TabIndex = 8;
            this.lblLat.Text = "latitude";
            // 
            // lblFlightDistance
            // 
            this.lblFlightDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlightDistance.AutoSize = true;
            this.lblFlightDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightDistance.ForeColor = System.Drawing.Color.Red;
            this.lblFlightDistance.Location = new System.Drawing.Point(163, 162);
            this.lblFlightDistance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightDistance.Name = "lblFlightDistance";
            this.lblFlightDistance.Size = new System.Drawing.Size(24, 25);
            this.lblFlightDistance.TabIndex = 7;
            this.lblFlightDistance.Text = "0";
            // 
            // lblFovDimensions
            // 
            this.lblFovDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFovDimensions.AutoSize = true;
            this.lblFovDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFovDimensions.ForeColor = System.Drawing.Color.Red;
            this.lblFovDimensions.Location = new System.Drawing.Point(172, 54);
            this.lblFovDimensions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFovDimensions.Name = "lblFovDimensions";
            this.lblFovDimensions.Size = new System.Drawing.Size(24, 25);
            this.lblFovDimensions.TabIndex = 7;
            this.lblFovDimensions.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 60);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 17);
            this.label14.TabIndex = 6;
            this.label14.Text = "Field of View (m):";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkPhotoWayPoints);
            this.tabPage2.Controls.Add(this.chkPhotoAreas);
            this.tabPage2.Controls.Add(this.chkOuterGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(369, 327);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Advanced Controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkPhotoWayPoints
            // 
            this.chkPhotoWayPoints.AutoSize = true;
            this.chkPhotoWayPoints.Checked = true;
            this.chkPhotoWayPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhotoWayPoints.Location = new System.Drawing.Point(19, 76);
            this.chkPhotoWayPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPhotoWayPoints.Name = "chkPhotoWayPoints";
            this.chkPhotoWayPoints.Size = new System.Drawing.Size(148, 21);
            this.chkPhotoWayPoints.TabIndex = 3;
            this.chkPhotoWayPoints.Text = "Show Photo Points";
            this.chkPhotoWayPoints.UseVisualStyleBackColor = true;
            this.chkPhotoWayPoints.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // chkPhotoAreas
            // 
            this.chkPhotoAreas.AutoSize = true;
            this.chkPhotoAreas.Checked = true;
            this.chkPhotoAreas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhotoAreas.Location = new System.Drawing.Point(19, 47);
            this.chkPhotoAreas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPhotoAreas.Name = "chkPhotoAreas";
            this.chkPhotoAreas.Size = new System.Drawing.Size(146, 21);
            this.chkPhotoAreas.TabIndex = 2;
            this.chkPhotoAreas.Text = "Show Photo Areas";
            this.chkPhotoAreas.UseVisualStyleBackColor = true;
            this.chkPhotoAreas.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // chkOuterGrid
            // 
            this.chkOuterGrid.AutoSize = true;
            this.chkOuterGrid.Checked = true;
            this.chkOuterGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOuterGrid.Location = new System.Drawing.Point(19, 17);
            this.chkOuterGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkOuterGrid.Name = "chkOuterGrid";
            this.chkOuterGrid.Size = new System.Drawing.Size(206, 21);
            this.chkOuterGrid.TabIndex = 1;
            this.chkOuterGrid.Text = "Show Outer Grid of Polygon";
            this.chkOuterGrid.UseVisualStyleBackColor = true;
            this.chkOuterGrid.CheckedChanged += new System.EventHandler(this.button1_Click);
            // 
            // workerRouteCalculator
            // 
            this.workerRouteCalculator.DoWork += new System.ComponentModel.DoWorkEventHandler(this.workerRouteCalculator_DoWork);
            this.workerRouteCalculator.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.workerRouteCalculator_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(935, 292);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcaulate Grid";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(935, 327);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Calculate with Different Angles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1113, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 29);
            this.button3.TabIndex = 10;
            this.button3.Text = "Best Angle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 299);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(117, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Calculation Angle";
            // 
            // angleNumeric
            // 
            this.angleNumeric.Location = new System.Drawing.Point(154, 297);
            this.angleNumeric.Margin = new System.Windows.Forms.Padding(4);
            this.angleNumeric.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.angleNumeric.Name = "angleNumeric";
            this.angleNumeric.Size = new System.Drawing.Size(160, 22);
            this.angleNumeric.TabIndex = 18;
            this.angleNumeric.ValueChanged += new System.EventHandler(this.angleNumeric_ValueChanged);
            // 
            // AerialSurveyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 737);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AerialSurveyUI";
            this.Text = "Aerial Survey";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AerialSurveyUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightAltitudeNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumSpeedNm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.focalLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensorWidth)).EndInit();
            this.markerMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maximumSpeedNm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sensorHeight;
        private System.Windows.Forms.NumericUpDown sensorWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown focalLength;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip markerMenu;
        private System.Windows.Forms.ToolStripMenuItem setAsStartPointToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown flightAltitudeNm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkOuterGrid;
        private System.Windows.Forms.Label lblFovDimensions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.CheckBox chkPhotoAreas;
        private System.Windows.Forms.CheckBox chkPhotoWayPoints;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.ComponentModel.BackgroundWorker workerRouteCalculator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblFlightDistance;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblFlightTime;
        private System.Windows.Forms.Label lblGSD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox batteryModelCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown angleNumeric;



    }
}