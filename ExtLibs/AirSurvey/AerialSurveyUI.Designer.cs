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
            this.flightAltitudeNm = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.batteryModelCmb = new System.Windows.Forms.ComboBox();
            this.maximumSpeedNm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.calculateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.markerMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setAsStartPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblLon = new System.Windows.Forms.Label();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblFovDimensions = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkPhotoWayPoints = new System.Windows.Forms.CheckBox();
            this.chkPhotoAreas = new System.Windows.Forms.CheckBox();
            this.chkOuterGrid = new System.Windows.Forms.CheckBox();
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
            this.map.Size = new System.Drawing.Size(695, 457);
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
            this.groupBox1.Controls.Add(this.flightAltitudeNm);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.batteryModelCmb);
            this.groupBox1.Controls.Add(this.maximumSpeedNm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(701, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Battery - Vehicle Options";
            // 
            // flightAltitudeNm
            // 
            this.flightAltitudeNm.Location = new System.Drawing.Point(105, 72);
            this.flightAltitudeNm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.flightAltitudeNm.Name = "flightAltitudeNm";
            this.flightAltitudeNm.Size = new System.Drawing.Size(143, 20);
            this.flightAltitudeNm.TabIndex = 5;
            this.flightAltitudeNm.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.flightAltitudeNm.ValueChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Flight altitude :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "m/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(254, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "m";
            // 
            // batteryModelCmb
            // 
            this.batteryModelCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.batteryModelCmb.FormattingEnabled = true;
            this.batteryModelCmb.Location = new System.Drawing.Point(105, 20);
            this.batteryModelCmb.Name = "batteryModelCmb";
            this.batteryModelCmb.Size = new System.Drawing.Size(173, 21);
            this.batteryModelCmb.TabIndex = 3;
            // 
            // maximumSpeedNm
            // 
            this.maximumSpeedNm.Location = new System.Drawing.Point(105, 45);
            this.maximumSpeedNm.Name = "maximumSpeedNm";
            this.maximumSpeedNm.Size = new System.Drawing.Size(143, 20);
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
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Battery Model :";
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
            this.groupBox2.Location = new System.Drawing.Point(701, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Options";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(254, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "mm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "mm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "mm";
            // 
            // focalLength
            // 
            this.focalLength.Location = new System.Drawing.Point(104, 73);
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
            this.focalLength.Size = new System.Drawing.Size(144, 20);
            this.focalLength.TabIndex = 5;
            this.focalLength.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.focalLength.ValueChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
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
            this.sensorHeight.Location = new System.Drawing.Point(104, 47);
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
            this.sensorHeight.Size = new System.Drawing.Size(144, 20);
            this.sensorHeight.TabIndex = 3;
            this.sensorHeight.Value = new decimal(new int[] {
            462,
            0,
            0,
            131072});
            this.sensorHeight.ValueChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // sensorWidth
            // 
            this.sensorWidth.DecimalPlaces = 2;
            this.sensorWidth.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.sensorWidth.Location = new System.Drawing.Point(104, 20);
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
            this.sensorWidth.Size = new System.Drawing.Size(144, 20);
            this.sensorWidth.TabIndex = 2;
            this.sensorWidth.Value = new decimal(new int[] {
            616,
            0,
            0,
            131072});
            this.sensorWidth.ValueChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sensor Height :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sensor width :";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateBtn.Location = new System.Drawing.Point(701, 236);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(134, 23);
            this.calculateBtn.TabIndex = 3;
            this.calculateBtn.Text = "Calculate Route";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Number of flights :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(109, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "0";
            // 
            // markerMenu
            // 
            this.markerMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsStartPointToolStripMenuItem});
            this.markerMenu.Name = "markerMenu";
            this.markerMenu.Size = new System.Drawing.Size(162, 26);
            this.markerMenu.Text = "Set as start point";
            // 
            // setAsStartPointToolStripMenuItem
            // 
            this.setAsStartPointToolStripMenuItem.Name = "setAsStartPointToolStripMenuItem";
            this.setAsStartPointToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.setAsStartPointToolStripMenuItem.Text = "Set as start point";
            this.setAsStartPointToolStripMenuItem.Click += new System.EventHandler(this.setAsStartPointToolStripMenuItem_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(841, 236);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.calculateBtnClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Statistics);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(701, 265);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 192);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblLon);
            this.tabPage1.Controls.Add(this.lblLat);
            this.tabPage1.Controls.Add(this.lblFovDimensions);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 166);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Location = new System.Drawing.Point(18, 99);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(41, 13);
            this.lblLon.TabIndex = 9;
            this.lblLon.Text = "label15";
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(17, 82);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(41, 13);
            this.lblLat.TabIndex = 8;
            this.lblLat.Text = "label15";
            // 
            // lblFovDimensions
            // 
            this.lblFovDimensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFovDimensions.AutoSize = true;
            this.lblFovDimensions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFovDimensions.ForeColor = System.Drawing.Color.Red;
            this.lblFovDimensions.Location = new System.Drawing.Point(109, 44);
            this.lblFovDimensions.Name = "lblFovDimensions";
            this.lblFovDimensions.Size = new System.Drawing.Size(19, 20);
            this.lblFovDimensions.TabIndex = 7;
            this.lblFovDimensions.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Field of View :";
            // 
            // Statistics
            // 
            this.Statistics.Location = new System.Drawing.Point(4, 22);
            this.Statistics.Name = "Statistics";
            this.Statistics.Padding = new System.Windows.Forms.Padding(3);
            this.Statistics.Size = new System.Drawing.Size(275, 166);
            this.Statistics.TabIndex = 1;
            this.Statistics.Text = "Statistics";
            this.Statistics.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkPhotoWayPoints);
            this.tabPage2.Controls.Add(this.chkPhotoAreas);
            this.tabPage2.Controls.Add(this.chkOuterGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(275, 166);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Advanced Controls";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkPhotoWayPoints
            // 
            this.chkPhotoWayPoints.AutoSize = true;
            this.chkPhotoWayPoints.Checked = true;
            this.chkPhotoWayPoints.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhotoWayPoints.Location = new System.Drawing.Point(14, 62);
            this.chkPhotoWayPoints.Name = "chkPhotoWayPoints";
            this.chkPhotoWayPoints.Size = new System.Drawing.Size(116, 17);
            this.chkPhotoWayPoints.TabIndex = 3;
            this.chkPhotoWayPoints.Text = "Show Photo Points";
            this.chkPhotoWayPoints.UseVisualStyleBackColor = true;
            this.chkPhotoWayPoints.CheckedChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // chkPhotoAreas
            // 
            this.chkPhotoAreas.AutoSize = true;
            this.chkPhotoAreas.Checked = true;
            this.chkPhotoAreas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPhotoAreas.Location = new System.Drawing.Point(14, 38);
            this.chkPhotoAreas.Name = "chkPhotoAreas";
            this.chkPhotoAreas.Size = new System.Drawing.Size(114, 17);
            this.chkPhotoAreas.TabIndex = 2;
            this.chkPhotoAreas.Text = "Show Photo Areas";
            this.chkPhotoAreas.UseVisualStyleBackColor = true;
            this.chkPhotoAreas.CheckedChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // chkOuterGrid
            // 
            this.chkOuterGrid.AutoSize = true;
            this.chkOuterGrid.Checked = true;
            this.chkOuterGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOuterGrid.Location = new System.Drawing.Point(14, 14);
            this.chkOuterGrid.Name = "chkOuterGrid";
            this.chkOuterGrid.Size = new System.Drawing.Size(157, 17);
            this.chkOuterGrid.TabIndex = 1;
            this.chkOuterGrid.Text = "Show Outer Grid of Polygon";
            this.chkOuterGrid.UseVisualStyleBackColor = true;
            this.chkOuterGrid.CheckedChanged += new System.EventHandler(this.calculateBtnClick);
            // 
            // AerialSurveyUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 472);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.map);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown maximumSpeedNm;
        private System.Windows.Forms.ComboBox batteryModelCmb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sensorHeight;
        private System.Windows.Forms.NumericUpDown sensorWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown focalLength;
        private System.Windows.Forms.Button calculateBtn;
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
        private System.Windows.Forms.TabPage Statistics;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox chkOuterGrid;
        private System.Windows.Forms.Label lblFovDimensions;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.CheckBox chkPhotoAreas;
        private System.Windows.Forms.CheckBox chkPhotoWayPoints;



    }
}