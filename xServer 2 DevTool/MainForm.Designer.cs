namespace xS2Development
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStripWaypoints = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dynMap = new Ptv.XServer.Controls.Map.FormsMap();
            this.btnCalcRoute = new System.Windows.Forms.Button();
            this.gbxRouteCoordinates = new System.Windows.Forms.GroupBox();
            this.tbxRadiusValue = new System.Windows.Forms.TextBox();
            this.lblRadiusPoint = new System.Windows.Forms.Label();
            this.cbxManipulateWpt = new System.Windows.Forms.CheckBox();
            this.tbxViaY = new System.Windows.Forms.TextBox();
            this.tbxViaX = new System.Windows.Forms.TextBox();
            this.btnSwitchStartDest = new System.Windows.Forms.Button();
            this.btnClearCoordinates = new System.Windows.Forms.Button();
            this.lblStartY = new System.Windows.Forms.Label();
            this.lblStartX = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbxDestY = new System.Windows.Forms.TextBox();
            this.tbxDestX = new System.Windows.Forms.TextBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.tbxStartY = new System.Windows.Forms.TextBox();
            this.tbxStartX = new System.Windows.Forms.TextBox();
            this.cbxEmissions = new System.Windows.Forms.CheckBox();
            this.tbxRouteResultViolations = new System.Windows.Forms.TextBox();
            this.lblRouteViolations = new System.Windows.Forms.Label();
            this.lbxTollSummary = new System.Windows.Forms.ListBox();
            this.lblTollSummary = new System.Windows.Forms.Label();
            this.tbxRouteResultDistance = new System.Windows.Forms.TextBox();
            this.tbxRouteResultTime = new System.Windows.Forms.TextBox();
            this.lblRouteDistance = new System.Windows.Forms.Label();
            this.lblRouteTime = new System.Windows.Forms.Label();
            this.gbxVehicleProfile = new System.Windows.Forms.GroupBox();
            this.tabControlVehicleProfile = new System.Windows.Forms.TabControl();
            this.tabPagePhysical = new System.Windows.Forms.TabPage();
            this.cbxOnlyReachableRoads = new System.Windows.Forms.CheckBox();
            this.lblFeatureLayers = new System.Windows.Forms.Label();
            this.cbxIsEmergency = new System.Windows.Forms.CheckBox();
            this.cbxFLGenTruckRestr = new System.Windows.Forms.CheckBox();
            this.cbxIsDelivery = new System.Windows.Forms.CheckBox();
            this.cbxFLSpeedPatterns = new System.Windows.Forms.CheckBox();
            this.cbxFLTrafficIncidents = new System.Windows.Forms.CheckBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.tbxTotalPermWeight = new System.Windows.Forms.TextBox();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblTotalPermWeight = new System.Windows.Forms.Label();
            this.tbxLoadWeight = new System.Windows.Forms.TextBox();
            this.lblEmptyWeight = new System.Windows.Forms.Label();
            this.tbxWidth = new System.Windows.Forms.TextBox();
            this.lblLoadWeight = new System.Windows.Forms.Label();
            this.tbxEmptyWeight = new System.Windows.Forms.TextBox();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.cbxFLTruckAttributes = new System.Windows.Forms.CheckBox();
            this.tabPageEngineEmissions = new System.Windows.Forms.TabPage();
            this.cbxTunnelRestrictionCode = new System.Windows.Forms.ComboBox();
            this.lblTunnelRestrictionCode = new System.Windows.Forms.Label();
            this.cbxHazardousGoodsType = new System.Windows.Forms.ComboBox();
            this.lblHazardousGoodsType = new System.Windows.Forms.Label();
            this.cbxLoadType = new System.Windows.Forms.ComboBox();
            this.lblLoadType = new System.Windows.Forms.Label();
            this.labelCylinderCapacity = new System.Windows.Forms.Label();
            this.textBoxCylinderCapacity = new System.Windows.Forms.TextBox();
            this.labelYearOfManufacture = new System.Windows.Forms.Label();
            this.labelFuelType = new System.Windows.Forms.Label();
            this.textBoxYearOfManufacture = new System.Windows.Forms.TextBox();
            this.labelFuelConsumption = new System.Windows.Forms.Label();
            this.cbxFuelType = new System.Windows.Forms.ComboBox();
            this.textBoxFuelConsumption = new System.Windows.Forms.TextBox();
            this.cbxEmissionStandardEU = new System.Windows.Forms.ComboBox();
            this.labelEmissionTechnology = new System.Windows.Forms.Label();
            this.labelEmissionStandardEU = new System.Windows.Forms.Label();
            this.cbxEmissionTechnology = new System.Windows.Forms.ComboBox();
            this.labelBioFuelRatio = new System.Windows.Forms.Label();
            this.textBoxBioFuelRatio = new System.Windows.Forms.TextBox();
            this.lblStoredProfile = new System.Windows.Forms.Label();
            this.cbxStoredProfile = new System.Windows.Forms.ComboBox();
            this.cbxTollSections = new System.Windows.Forms.CheckBox();
            this.cbxSegments = new System.Windows.Forms.CheckBox();
            this.gbxRoutingProfile = new System.Windows.Forms.GroupBox();
            this.tbxNetworkClassPenalties = new System.Windows.Forms.TextBox();
            this.lblPenaltiesByNetworkClass = new System.Windows.Forms.Label();
            this.tbxDeliveryOnlyGateCost = new System.Windows.Forms.TextBox();
            this.lblDeliveryOnlyGateCost = new System.Windows.Forms.Label();
            this.tbxDeliveryOnlyPenalty = new System.Windows.Forms.TextBox();
            this.lblDeliveryOnlyPenalty = new System.Windows.Forms.Label();
            this.tbxForbiddenLEZPenal = new System.Windows.Forms.TextBox();
            this.lblForbiddenLEZPenal = new System.Windows.Forms.Label();
            this.tbxMinimumUrbanNetworkClass = new System.Windows.Forms.TextBox();
            this.lblMinimumUrbanNetworkClass = new System.Windows.Forms.Label();
            this.tbxUrbanPenalty = new System.Windows.Forms.TextBox();
            this.lblUrbanPenalty = new System.Windows.Forms.Label();
            this.tbxResidentsOnlyPenalty = new System.Windows.Forms.TextBox();
            this.lblResidentsOnlyPenalty = new System.Windows.Forms.Label();
            this.tbxDistanceTimeWeighting = new System.Windows.Forms.TextBox();
            this.lblDistanceTimeWeighting = new System.Windows.Forms.Label();
            this.tbxTollPenalty = new System.Windows.Forms.TextBox();
            this.lblTollPenalty = new System.Windows.Forms.Label();
            this.tbxViolationsCost = new System.Windows.Forms.TextBox();
            this.lblViolationsCost = new System.Windows.Forms.Label();
            this.tbxViolationsEnabled = new System.Windows.Forms.TextBox();
            this.lblViolationsEnabled = new System.Windows.Forms.Label();
            this.tbxOnlyReachableRoads = new System.Windows.Forms.TextBox();
            this.lblOnlyReachableRoads = new System.Windows.Forms.Label();
            this.tbxMaximumDistanceToSegment = new System.Windows.Forms.TextBox();
            this.lblMaximumDistanceToSegment = new System.Windows.Forms.Label();
            this.timerLocate = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cbxCoordFormat = new System.Windows.Forms.ComboBox();
            this.tbxAllowedCountries = new System.Windows.Forms.TextBox();
            this.tbxProhibitedCountries = new System.Windows.Forms.TextBox();
            this.tbctrlRouteResults = new System.Windows.Forms.TabControl();
            this.tabRouteSummary = new System.Windows.Forms.TabPage();
            this.tabRouteSegments = new System.Windows.Forms.TabPage();
            this.dataGridRouteSegments = new System.Windows.Forms.DataGridView();
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxRenderMap = new System.Windows.Forms.GroupBox();
            this.cbxMapProfile = new System.Windows.Forms.ComboBox();
            this.lbxMapFeatureLayer = new System.Windows.Forms.ListBox();
            this.btnRenewMap = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbxRoutingOptions = new System.Windows.Forms.GroupBox();
            this.cbxFeatureThemeIds = new System.Windows.Forms.CheckBox();
            this.cbxRoadAttributes = new System.Windows.Forms.CheckBox();
            this.cbxDescriptors = new System.Windows.Forms.CheckBox();
            this.cbxPolyline = new System.Windows.Forms.CheckBox();
            this.cbxTollCalculation = new System.Windows.Forms.CheckBox();
            this.cbxLegs = new System.Windows.Forms.CheckBox();
            this.cbxTollSystems = new System.Windows.Forms.CheckBox();
            this.emissionValuesHBEFA32BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbxRouteOptions = new System.Windows.Forms.GroupBox();
            this.lblCoordFormat = new System.Windows.Forms.Label();
            this.lblProhibitedCountries = new System.Windows.Forms.Label();
            this.lblAllowedCountries = new System.Windows.Forms.Label();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.violatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.attributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combinedTransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polylineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startNodeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.endNodeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contextMenuStripWaypoints.SuspendLayout();
            this.gbxRouteCoordinates.SuspendLayout();
            this.gbxVehicleProfile.SuspendLayout();
            this.tabControlVehicleProfile.SuspendLayout();
            this.tabPagePhysical.SuspendLayout();
            this.tabPageEngineEmissions.SuspendLayout();
            this.gbxRoutingProfile.SuspendLayout();
            this.tbctrlRouteResults.SuspendLayout();
            this.tabRouteSummary.SuspendLayout();
            this.tabRouteSegments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRouteSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            this.gbxRenderMap.SuspendLayout();
            this.gbxRoutingOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emissionValuesHBEFA32BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBindingSource1)).BeginInit();
            this.gbxRouteOptions.SuspendLayout();
            this.pnlMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripWaypoints
            // 
            this.contextMenuStripWaypoints.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItem});
            this.contextMenuStripWaypoints.Name = "contextMenuStrip1";
            this.contextMenuStripWaypoints.Size = new System.Drawing.Size(135, 26);
            // 
            // deleteItem
            // 
            this.deleteItem.Name = "deleteItem";
            this.deleteItem.Size = new System.Drawing.Size(134, 22);
            this.deleteItem.Text = "Delete Item";
            // 
            // dynMap
            // 
            this.dynMap.Center = ((System.Windows.Point)(resources.GetObject("dynMap.Center")));
            this.dynMap.CoordinateDiplayFormat = Ptv.XServer.Controls.Map.CoordinateDiplayFormat.Decimal;
            this.dynMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dynMap.FitInWindow = false;
            this.dynMap.InvertMouseWheel = false;
            this.dynMap.Location = new System.Drawing.Point(0, 0);
            this.dynMap.MaxZoom = 19;
            this.dynMap.MinZoom = 0;
            this.dynMap.MouseDoubleClickZoom = true;
            this.dynMap.MouseDragMode = Ptv.XServer.Controls.Map.Gadgets.DragMode.SelectOnShift;
            this.dynMap.MouseWheelSpeed = 0.5D;
            this.dynMap.Name = "dynMap";
            this.dynMap.ShowCoordinates = true;
            this.dynMap.ShowLayers = true;
            this.dynMap.ShowMagnifier = false;
            this.dynMap.ShowNavigation = false;
            this.dynMap.ShowOverview = false;
            this.dynMap.ShowScale = false;
            this.dynMap.ShowZoomSlider = false;
            this.dynMap.Size = new System.Drawing.Size(951, 953);
            this.dynMap.TabIndex = 9;
            this.dynMap.UseAnimation = true;
            this.dynMap.UseDefaultTheme = true;
            this.dynMap.UseMiles = false;
            this.dynMap.XMapCopyright = "PTV Group";
            this.dynMap.XMapCredentials = "";
            this.dynMap.XMapStyle = "";
            this.dynMap.XMapUrl = "";
            this.dynMap.ZoomLevel = 2D;
            // 
            // btnCalcRoute
            // 
            this.btnCalcRoute.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalcRoute.Location = new System.Drawing.Point(450, 305);
            this.btnCalcRoute.Name = "btnCalcRoute";
            this.btnCalcRoute.Size = new System.Drawing.Size(77, 113);
            this.btnCalcRoute.TabIndex = 10;
            this.btnCalcRoute.Text = "Calc Route";
            this.btnCalcRoute.UseVisualStyleBackColor = false;
            this.btnCalcRoute.Click += new System.EventHandler(this.btnCalcRoute_Click);
            // 
            // gbxRouteCoordinates
            // 
            this.gbxRouteCoordinates.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxRouteCoordinates.Controls.Add(this.tbxRadiusValue);
            this.gbxRouteCoordinates.Controls.Add(this.lblRadiusPoint);
            this.gbxRouteCoordinates.Controls.Add(this.cbxManipulateWpt);
            this.gbxRouteCoordinates.Controls.Add(this.tbxViaY);
            this.gbxRouteCoordinates.Controls.Add(this.tbxViaX);
            this.gbxRouteCoordinates.Controls.Add(this.btnSwitchStartDest);
            this.gbxRouteCoordinates.Controls.Add(this.btnClearCoordinates);
            this.gbxRouteCoordinates.Controls.Add(this.lblStartY);
            this.gbxRouteCoordinates.Controls.Add(this.lblStartX);
            this.gbxRouteCoordinates.Controls.Add(this.lblDestination);
            this.gbxRouteCoordinates.Controls.Add(this.tbxDestY);
            this.gbxRouteCoordinates.Controls.Add(this.tbxDestX);
            this.gbxRouteCoordinates.Controls.Add(this.lblStart);
            this.gbxRouteCoordinates.Controls.Add(this.tbxStartY);
            this.gbxRouteCoordinates.Controls.Add(this.tbxStartX);
            this.gbxRouteCoordinates.Location = new System.Drawing.Point(7, 7);
            this.gbxRouteCoordinates.Name = "gbxRouteCoordinates";
            this.gbxRouteCoordinates.Size = new System.Drawing.Size(519, 83);
            this.gbxRouteCoordinates.TabIndex = 11;
            this.gbxRouteCoordinates.TabStop = false;
            this.gbxRouteCoordinates.Text = "Waypoints";
            // 
            // tbxRadiusValue
            // 
            this.tbxRadiusValue.Location = new System.Drawing.Point(257, 9);
            this.tbxRadiusValue.Name = "tbxRadiusValue";
            this.tbxRadiusValue.Size = new System.Drawing.Size(39, 20);
            this.tbxRadiusValue.TabIndex = 37;
            this.tbxRadiusValue.Text = "1000";
            this.tbxRadiusValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRadiusPoint
            // 
            this.lblRadiusPoint.AutoSize = true;
            this.lblRadiusPoint.Location = new System.Drawing.Point(205, 12);
            this.lblRadiusPoint.Name = "lblRadiusPoint";
            this.lblRadiusPoint.Size = new System.Drawing.Size(54, 13);
            this.lblRadiusPoint.TabIndex = 36;
            this.lblRadiusPoint.Text = "Radius[m]";
            // 
            // cbxManipulateWpt
            // 
            this.cbxManipulateWpt.AutoSize = true;
            this.cbxManipulateWpt.Location = new System.Drawing.Point(172, 11);
            this.cbxManipulateWpt.Name = "cbxManipulateWpt";
            this.cbxManipulateWpt.Size = new System.Drawing.Size(41, 17);
            this.cbxManipulateWpt.TabIndex = 35;
            this.cbxManipulateWpt.Text = "Via";
            this.cbxManipulateWpt.UseVisualStyleBackColor = true;
            // 
            // tbxViaY
            // 
            this.tbxViaY.Location = new System.Drawing.Point(176, 57);
            this.tbxViaY.Name = "tbxViaY";
            this.tbxViaY.Size = new System.Drawing.Size(120, 20);
            this.tbxViaY.TabIndex = 33;
            this.tbxViaY.Text = "49,01095";
            this.tbxViaY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxViaX
            // 
            this.tbxViaX.Location = new System.Drawing.Point(176, 31);
            this.tbxViaX.Name = "tbxViaX";
            this.tbxViaX.Size = new System.Drawing.Size(120, 20);
            this.tbxViaX.TabIndex = 32;
            this.tbxViaX.Text = "8,40847";
            this.tbxViaX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxViaX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxViaX_MouseDoubleClick);
            // 
            // btnSwitchStartDest
            // 
            this.btnSwitchStartDest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSwitchStartDest.Location = new System.Drawing.Point(429, 55);
            this.btnSwitchStartDest.Name = "btnSwitchStartDest";
            this.btnSwitchStartDest.Size = new System.Drawing.Size(75, 23);
            this.btnSwitchStartDest.TabIndex = 28;
            this.btnSwitchStartDest.Text = "Switch";
            this.toolTip.SetToolTip(this.btnSwitchStartDest, "Switch Start and Dest coordinates");
            this.btnSwitchStartDest.UseVisualStyleBackColor = false;
            this.btnSwitchStartDest.Click += new System.EventHandler(this.btnSwitchStartDest_Click);
            // 
            // btnClearCoordinates
            // 
            this.btnClearCoordinates.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClearCoordinates.Location = new System.Drawing.Point(429, 30);
            this.btnClearCoordinates.Name = "btnClearCoordinates";
            this.btnClearCoordinates.Size = new System.Drawing.Size(75, 23);
            this.btnClearCoordinates.TabIndex = 27;
            this.btnClearCoordinates.Text = "Clear";
            this.toolTip.SetToolTip(this.btnClearCoordinates, "Clear all Waypoint entries");
            this.btnClearCoordinates.UseVisualStyleBackColor = false;
            this.btnClearCoordinates.Click += new System.EventHandler(this.btnClearCoordinates_Click);
            // 
            // lblStartY
            // 
            this.lblStartY.AutoSize = true;
            this.lblStartY.Location = new System.Drawing.Point(7, 60);
            this.lblStartY.Name = "lblStartY";
            this.lblStartY.Size = new System.Drawing.Size(30, 13);
            this.lblStartY.TabIndex = 26;
            this.lblStartY.Text = "Lat.y";
            // 
            // lblStartX
            // 
            this.lblStartX.AutoSize = true;
            this.lblStartX.Location = new System.Drawing.Point(7, 34);
            this.lblStartX.Name = "lblStartX";
            this.lblStartX.Size = new System.Drawing.Size(39, 13);
            this.lblStartX.TabIndex = 25;
            this.lblStartX.Text = "Long.x";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(331, 12);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(60, 13);
            this.lblDestination.TabIndex = 22;
            this.lblDestination.Text = "Destination";
            // 
            // tbxDestY
            // 
            this.tbxDestY.Location = new System.Drawing.Point(302, 57);
            this.tbxDestY.Name = "tbxDestY";
            this.tbxDestY.Size = new System.Drawing.Size(120, 20);
            this.tbxDestY.TabIndex = 21;
            this.tbxDestY.Text = "43,12542";
            this.tbxDestY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxDestY.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxDestY_MouseDoubleClick);
            // 
            // tbxDestX
            // 
            this.tbxDestX.Location = new System.Drawing.Point(302, 31);
            this.tbxDestX.Name = "tbxDestX";
            this.tbxDestX.Size = new System.Drawing.Size(120, 20);
            this.tbxDestX.TabIndex = 20;
            this.tbxDestX.Text = "5,92989";
            this.tbxDestX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxDestX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxDestX_MouseDoubleClick);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(95, 12);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(29, 13);
            this.lblStart.TabIndex = 19;
            this.lblStart.Text = "Start";
            // 
            // tbxStartY
            // 
            this.tbxStartY.Location = new System.Drawing.Point(50, 57);
            this.tbxStartY.Name = "tbxStartY";
            this.tbxStartY.Size = new System.Drawing.Size(120, 20);
            this.tbxStartY.TabIndex = 18;
            this.tbxStartY.Text = "52,41852";
            this.tbxStartY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxStartY.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxStartY_MouseDoubleClick);
            // 
            // tbxStartX
            // 
            this.tbxStartX.Location = new System.Drawing.Point(50, 31);
            this.tbxStartX.Name = "tbxStartX";
            this.tbxStartX.Size = new System.Drawing.Size(120, 20);
            this.tbxStartX.TabIndex = 17;
            this.tbxStartX.Text = "4,90502";
            this.tbxStartX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxStartX.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbxStartX_MouseDoubleClick);
            // 
            // cbxEmissions
            // 
            this.cbxEmissions.AutoSize = true;
            this.cbxEmissions.Location = new System.Drawing.Point(6, 45);
            this.cbxEmissions.Name = "cbxEmissions";
            this.cbxEmissions.Size = new System.Drawing.Size(72, 17);
            this.cbxEmissions.TabIndex = 20;
            this.cbxEmissions.Text = "Emissions";
            this.cbxEmissions.UseVisualStyleBackColor = true;
            // 
            // tbxRouteResultViolations
            // 
            this.tbxRouteResultViolations.Location = new System.Drawing.Point(81, 59);
            this.tbxRouteResultViolations.Name = "tbxRouteResultViolations";
            this.tbxRouteResultViolations.Size = new System.Drawing.Size(48, 20);
            this.tbxRouteResultViolations.TabIndex = 19;
            this.tbxRouteResultViolations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRouteViolations
            // 
            this.lblRouteViolations.AutoSize = true;
            this.lblRouteViolations.Location = new System.Drawing.Point(6, 62);
            this.lblRouteViolations.Name = "lblRouteViolations";
            this.lblRouteViolations.Size = new System.Drawing.Size(52, 13);
            this.lblRouteViolations.TabIndex = 18;
            this.lblRouteViolations.Text = "Violations";
            // 
            // lbxTollSummary
            // 
            this.lbxTollSummary.FormattingEnabled = true;
            this.lbxTollSummary.Location = new System.Drawing.Point(9, 102);
            this.lbxTollSummary.Name = "lbxTollSummary";
            this.lbxTollSummary.Size = new System.Drawing.Size(120, 121);
            this.lbxTollSummary.TabIndex = 17;
            // 
            // lblTollSummary
            // 
            this.lblTollSummary.AutoSize = true;
            this.lblTollSummary.Location = new System.Drawing.Point(6, 85);
            this.lblTollSummary.Name = "lblTollSummary";
            this.lblTollSummary.Size = new System.Drawing.Size(70, 13);
            this.lblTollSummary.TabIndex = 15;
            this.lblTollSummary.Text = "Toll Summary";
            // 
            // tbxRouteResultDistance
            // 
            this.tbxRouteResultDistance.Location = new System.Drawing.Point(81, 33);
            this.tbxRouteResultDistance.Name = "tbxRouteResultDistance";
            this.tbxRouteResultDistance.Size = new System.Drawing.Size(48, 20);
            this.tbxRouteResultDistance.TabIndex = 14;
            this.tbxRouteResultDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxRouteResultTime
            // 
            this.tbxRouteResultTime.Location = new System.Drawing.Point(81, 7);
            this.tbxRouteResultTime.Name = "tbxRouteResultTime";
            this.tbxRouteResultTime.Size = new System.Drawing.Size(48, 20);
            this.tbxRouteResultTime.TabIndex = 13;
            this.tbxRouteResultTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRouteDistance
            // 
            this.lblRouteDistance.AutoSize = true;
            this.lblRouteDistance.Location = new System.Drawing.Point(6, 36);
            this.lblRouteDistance.Name = "lblRouteDistance";
            this.lblRouteDistance.Size = new System.Drawing.Size(69, 13);
            this.lblRouteDistance.TabIndex = 12;
            this.lblRouteDistance.Text = "Distance[km]";
            // 
            // lblRouteTime
            // 
            this.lblRouteTime.AutoSize = true;
            this.lblRouteTime.Location = new System.Drawing.Point(6, 10);
            this.lblRouteTime.Name = "lblRouteTime";
            this.lblRouteTime.Size = new System.Drawing.Size(45, 13);
            this.lblRouteTime.TabIndex = 11;
            this.lblRouteTime.Text = "Time[hr]";
            // 
            // gbxVehicleProfile
            // 
            this.gbxVehicleProfile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxVehicleProfile.Controls.Add(this.tabControlVehicleProfile);
            this.gbxVehicleProfile.Location = new System.Drawing.Point(7, 306);
            this.gbxVehicleProfile.Name = "gbxVehicleProfile";
            this.gbxVehicleProfile.Size = new System.Drawing.Size(217, 281);
            this.gbxVehicleProfile.TabIndex = 13;
            this.gbxVehicleProfile.TabStop = false;
            this.gbxVehicleProfile.Text = "vehicleProfile";
            // 
            // tabControlVehicleProfile
            // 
            this.tabControlVehicleProfile.Controls.Add(this.tabPagePhysical);
            this.tabControlVehicleProfile.Controls.Add(this.tabPageEngineEmissions);
            this.tabControlVehicleProfile.Location = new System.Drawing.Point(4, 19);
            this.tabControlVehicleProfile.Name = "tabControlVehicleProfile";
            this.tabControlVehicleProfile.SelectedIndex = 0;
            this.tabControlVehicleProfile.Size = new System.Drawing.Size(208, 257);
            this.tabControlVehicleProfile.TabIndex = 17;
            // 
            // tabPagePhysical
            // 
            this.tabPagePhysical.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPagePhysical.Controls.Add(this.cbxOnlyReachableRoads);
            this.tabPagePhysical.Controls.Add(this.lblFeatureLayers);
            this.tabPagePhysical.Controls.Add(this.cbxIsEmergency);
            this.tabPagePhysical.Controls.Add(this.cbxFLGenTruckRestr);
            this.tabPagePhysical.Controls.Add(this.cbxIsDelivery);
            this.tabPagePhysical.Controls.Add(this.cbxFLSpeedPatterns);
            this.tabPagePhysical.Controls.Add(this.cbxFLTrafficIncidents);
            this.tabPagePhysical.Controls.Add(this.lblLength);
            this.tabPagePhysical.Controls.Add(this.tbxTotalPermWeight);
            this.tabPagePhysical.Controls.Add(this.tbxLength);
            this.tabPagePhysical.Controls.Add(this.lblTotalPermWeight);
            this.tabPagePhysical.Controls.Add(this.tbxLoadWeight);
            this.tabPagePhysical.Controls.Add(this.lblEmptyWeight);
            this.tabPagePhysical.Controls.Add(this.tbxWidth);
            this.tabPagePhysical.Controls.Add(this.lblLoadWeight);
            this.tabPagePhysical.Controls.Add(this.tbxEmptyWeight);
            this.tabPagePhysical.Controls.Add(this.tbxHeight);
            this.tabPagePhysical.Controls.Add(this.lblWidth);
            this.tabPagePhysical.Controls.Add(this.labelHeight);
            this.tabPagePhysical.Controls.Add(this.cbxFLTruckAttributes);
            this.tabPagePhysical.Location = new System.Drawing.Point(4, 22);
            this.tabPagePhysical.Name = "tabPagePhysical";
            this.tabPagePhysical.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePhysical.Size = new System.Drawing.Size(200, 231);
            this.tabPagePhysical.TabIndex = 0;
            this.tabPagePhysical.Text = "Physical";
            // 
            // cbxOnlyReachableRoads
            // 
            this.cbxOnlyReachableRoads.AutoSize = true;
            this.cbxOnlyReachableRoads.Location = new System.Drawing.Point(3, 66);
            this.cbxOnlyReachableRoads.Name = "cbxOnlyReachableRoads";
            this.cbxOnlyReachableRoads.Size = new System.Drawing.Size(128, 17);
            this.cbxOnlyReachableRoads.TabIndex = 26;
            this.cbxOnlyReachableRoads.Text = "onlyReachableRoads";
            this.cbxOnlyReachableRoads.UseVisualStyleBackColor = true;
            // 
            // lblFeatureLayers
            // 
            this.lblFeatureLayers.AutoSize = true;
            this.lblFeatureLayers.Location = new System.Drawing.Point(6, 3);
            this.lblFeatureLayers.Name = "lblFeatureLayers";
            this.lblFeatureLayers.Size = new System.Drawing.Size(77, 13);
            this.lblFeatureLayers.TabIndex = 43;
            this.lblFeatureLayers.Text = "FeatureLayers:";
            // 
            // cbxIsEmergency
            // 
            this.cbxIsEmergency.AutoSize = true;
            this.cbxIsEmergency.Location = new System.Drawing.Point(102, 50);
            this.cbxIsEmergency.Name = "cbxIsEmergency";
            this.cbxIsEmergency.Size = new System.Drawing.Size(86, 17);
            this.cbxIsEmergency.TabIndex = 25;
            this.cbxIsEmergency.Text = "isEmergency";
            this.cbxIsEmergency.UseVisualStyleBackColor = true;
            // 
            // cbxFLGenTruckRestr
            // 
            this.cbxFLGenTruckRestr.AutoSize = true;
            this.cbxFLGenTruckRestr.Location = new System.Drawing.Point(3, 34);
            this.cbxFLGenTruckRestr.Name = "cbxFLGenTruckRestr";
            this.cbxFLGenTruckRestr.Size = new System.Drawing.Size(99, 17);
            this.cbxFLGenTruckRestr.TabIndex = 42;
            this.cbxFLGenTruckRestr.Text = "GenTruckRestr";
            this.cbxFLGenTruckRestr.UseVisualStyleBackColor = true;
            // 
            // cbxIsDelivery
            // 
            this.cbxIsDelivery.AutoSize = true;
            this.cbxIsDelivery.Location = new System.Drawing.Point(102, 34);
            this.cbxIsDelivery.Name = "cbxIsDelivery";
            this.cbxIsDelivery.Size = new System.Drawing.Size(71, 17);
            this.cbxIsDelivery.TabIndex = 24;
            this.cbxIsDelivery.Text = "isDelivery";
            this.cbxIsDelivery.UseVisualStyleBackColor = true;
            // 
            // cbxFLSpeedPatterns
            // 
            this.cbxFLSpeedPatterns.AutoSize = true;
            this.cbxFLSpeedPatterns.Location = new System.Drawing.Point(102, 18);
            this.cbxFLSpeedPatterns.Name = "cbxFLSpeedPatterns";
            this.cbxFLSpeedPatterns.Size = new System.Drawing.Size(96, 17);
            this.cbxFLSpeedPatterns.TabIndex = 40;
            this.cbxFLSpeedPatterns.Text = "SpeedPatterns";
            this.cbxFLSpeedPatterns.UseVisualStyleBackColor = true;
            // 
            // cbxFLTrafficIncidents
            // 
            this.cbxFLTrafficIncidents.AutoSize = true;
            this.cbxFLTrafficIncidents.Location = new System.Drawing.Point(3, 50);
            this.cbxFLTrafficIncidents.Name = "cbxFLTrafficIncidents";
            this.cbxFLTrafficIncidents.Size = new System.Drawing.Size(102, 17);
            this.cbxFLTrafficIncidents.TabIndex = 39;
            this.cbxFLTrafficIncidents.Text = "Traffic Incidents";
            this.cbxFLTrafficIncidents.UseVisualStyleBackColor = true;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(6, 132);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(36, 13);
            this.lblLength.TabIndex = 37;
            this.lblLength.Text = "length";
            // 
            // tbxTotalPermWeight
            // 
            this.tbxTotalPermWeight.Location = new System.Drawing.Point(98, 198);
            this.tbxTotalPermWeight.Name = "tbxTotalPermWeight";
            this.tbxTotalPermWeight.Size = new System.Drawing.Size(49, 20);
            this.tbxTotalPermWeight.TabIndex = 33;
            this.tbxTotalPermWeight.Text = "40000";
            this.tbxTotalPermWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLength
            // 
            this.tbxLength.Location = new System.Drawing.Point(99, 129);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(48, 20);
            this.tbxLength.TabIndex = 36;
            this.tbxLength.Text = "1800";
            this.tbxLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalPermWeight
            // 
            this.lblTotalPermWeight.AutoSize = true;
            this.lblTotalPermWeight.Location = new System.Drawing.Point(6, 201);
            this.lblTotalPermWeight.Name = "lblTotalPermWeight";
            this.lblTotalPermWeight.Size = new System.Drawing.Size(90, 13);
            this.lblTotalPermWeight.TabIndex = 32;
            this.lblTotalPermWeight.Text = "totalPermitWeight";
            // 
            // tbxLoadWeight
            // 
            this.tbxLoadWeight.Location = new System.Drawing.Point(98, 175);
            this.tbxLoadWeight.Name = "tbxLoadWeight";
            this.tbxLoadWeight.Size = new System.Drawing.Size(49, 20);
            this.tbxLoadWeight.TabIndex = 31;
            this.tbxLoadWeight.Text = "25000";
            this.tbxLoadWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEmptyWeight
            // 
            this.lblEmptyWeight.AutoSize = true;
            this.lblEmptyWeight.Location = new System.Drawing.Point(6, 155);
            this.lblEmptyWeight.Name = "lblEmptyWeight";
            this.lblEmptyWeight.Size = new System.Drawing.Size(69, 13);
            this.lblEmptyWeight.TabIndex = 28;
            this.lblEmptyWeight.Text = "emptyWeight";
            // 
            // tbxWidth
            // 
            this.tbxWidth.Location = new System.Drawing.Point(99, 106);
            this.tbxWidth.Name = "tbxWidth";
            this.tbxWidth.Size = new System.Drawing.Size(48, 20);
            this.tbxWidth.TabIndex = 35;
            this.tbxWidth.Text = "260";
            this.tbxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLoadWeight
            // 
            this.lblLoadWeight.AutoSize = true;
            this.lblLoadWeight.Location = new System.Drawing.Point(6, 178);
            this.lblLoadWeight.Name = "lblLoadWeight";
            this.lblLoadWeight.Size = new System.Drawing.Size(61, 13);
            this.lblLoadWeight.TabIndex = 30;
            this.lblLoadWeight.Text = "loadWeight";
            // 
            // tbxEmptyWeight
            // 
            this.tbxEmptyWeight.Location = new System.Drawing.Point(99, 152);
            this.tbxEmptyWeight.Name = "tbxEmptyWeight";
            this.tbxEmptyWeight.Size = new System.Drawing.Size(48, 20);
            this.tbxEmptyWeight.TabIndex = 29;
            this.tbxEmptyWeight.Text = "15000";
            this.tbxEmptyWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxHeight
            // 
            this.tbxHeight.Location = new System.Drawing.Point(99, 83);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(48, 20);
            this.tbxHeight.TabIndex = 27;
            this.tbxHeight.Text = "400";
            this.tbxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(6, 109);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(32, 13);
            this.lblWidth.TabIndex = 34;
            this.lblWidth.Text = "width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(6, 86);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(36, 13);
            this.labelHeight.TabIndex = 26;
            this.labelHeight.Text = "height";
            // 
            // cbxFLTruckAttributes
            // 
            this.cbxFLTruckAttributes.AutoSize = true;
            this.cbxFLTruckAttributes.Location = new System.Drawing.Point(3, 18);
            this.cbxFLTruckAttributes.Name = "cbxFLTruckAttributes";
            this.cbxFLTruckAttributes.Size = new System.Drawing.Size(98, 17);
            this.cbxFLTruckAttributes.TabIndex = 25;
            this.cbxFLTruckAttributes.Text = "TruckAttributes";
            this.cbxFLTruckAttributes.UseVisualStyleBackColor = true;
            // 
            // tabPageEngineEmissions
            // 
            this.tabPageEngineEmissions.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPageEngineEmissions.Controls.Add(this.cbxTunnelRestrictionCode);
            this.tabPageEngineEmissions.Controls.Add(this.lblTunnelRestrictionCode);
            this.tabPageEngineEmissions.Controls.Add(this.cbxHazardousGoodsType);
            this.tabPageEngineEmissions.Controls.Add(this.lblHazardousGoodsType);
            this.tabPageEngineEmissions.Controls.Add(this.cbxLoadType);
            this.tabPageEngineEmissions.Controls.Add(this.lblLoadType);
            this.tabPageEngineEmissions.Controls.Add(this.labelCylinderCapacity);
            this.tabPageEngineEmissions.Controls.Add(this.textBoxCylinderCapacity);
            this.tabPageEngineEmissions.Controls.Add(this.labelYearOfManufacture);
            this.tabPageEngineEmissions.Controls.Add(this.labelFuelType);
            this.tabPageEngineEmissions.Controls.Add(this.textBoxYearOfManufacture);
            this.tabPageEngineEmissions.Controls.Add(this.labelFuelConsumption);
            this.tabPageEngineEmissions.Controls.Add(this.cbxFuelType);
            this.tabPageEngineEmissions.Controls.Add(this.textBoxFuelConsumption);
            this.tabPageEngineEmissions.Controls.Add(this.cbxEmissionStandardEU);
            this.tabPageEngineEmissions.Controls.Add(this.labelEmissionTechnology);
            this.tabPageEngineEmissions.Controls.Add(this.labelEmissionStandardEU);
            this.tabPageEngineEmissions.Controls.Add(this.cbxEmissionTechnology);
            this.tabPageEngineEmissions.Controls.Add(this.labelBioFuelRatio);
            this.tabPageEngineEmissions.Controls.Add(this.textBoxBioFuelRatio);
            this.tabPageEngineEmissions.Location = new System.Drawing.Point(4, 22);
            this.tabPageEngineEmissions.Name = "tabPageEngineEmissions";
            this.tabPageEngineEmissions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEngineEmissions.Size = new System.Drawing.Size(200, 231);
            this.tabPageEngineEmissions.TabIndex = 1;
            this.tabPageEngineEmissions.Text = "Engine, Load, Emission";
            // 
            // cbxTunnelRestrictionCode
            // 
            this.cbxTunnelRestrictionCode.FormattingEnabled = true;
            this.cbxTunnelRestrictionCode.Location = new System.Drawing.Point(70, 207);
            this.cbxTunnelRestrictionCode.Name = "cbxTunnelRestrictionCode";
            this.cbxTunnelRestrictionCode.Size = new System.Drawing.Size(84, 21);
            this.cbxTunnelRestrictionCode.TabIndex = 30;
            this.cbxTunnelRestrictionCode.Text = "NONE";
            // 
            // lblTunnelRestrictionCode
            // 
            this.lblTunnelRestrictionCode.AutoSize = true;
            this.lblTunnelRestrictionCode.Location = new System.Drawing.Point(3, 210);
            this.lblTunnelRestrictionCode.Name = "lblTunnelRestrictionCode";
            this.lblTunnelRestrictionCode.Size = new System.Drawing.Size(61, 13);
            this.lblTunnelRestrictionCode.TabIndex = 29;
            this.lblTunnelRestrictionCode.Text = "tunnelCode";
            // 
            // cbxHazardousGoodsType
            // 
            this.cbxHazardousGoodsType.FormattingEnabled = true;
            this.cbxHazardousGoodsType.Items.AddRange(new object[] {
            "HAZARDOUS",
            "HAZARDOUSTOWATERS",
            "COMBUSTIBLES"});
            this.cbxHazardousGoodsType.Location = new System.Drawing.Point(57, 183);
            this.cbxHazardousGoodsType.Name = "cbxHazardousGoodsType";
            this.cbxHazardousGoodsType.Size = new System.Drawing.Size(97, 21);
            this.cbxHazardousGoodsType.TabIndex = 28;
            this.cbxHazardousGoodsType.Text = "HAZARDOUS";
            // 
            // lblHazardousGoodsType
            // 
            this.lblHazardousGoodsType.AutoSize = true;
            this.lblHazardousGoodsType.Location = new System.Drawing.Point(3, 186);
            this.lblHazardousGoodsType.Name = "lblHazardousGoodsType";
            this.lblHazardousGoodsType.Size = new System.Drawing.Size(48, 13);
            this.lblHazardousGoodsType.TabIndex = 27;
            this.lblHazardousGoodsType.Text = "hazType";
            // 
            // cbxLoadType
            // 
            this.cbxLoadType.FormattingEnabled = true;
            this.cbxLoadType.Location = new System.Drawing.Point(57, 159);
            this.cbxLoadType.Name = "cbxLoadType";
            this.cbxLoadType.Size = new System.Drawing.Size(97, 21);
            this.cbxLoadType.TabIndex = 26;
            this.cbxLoadType.Text = "GOODS";
            // 
            // lblLoadType
            // 
            this.lblLoadType.AutoSize = true;
            this.lblLoadType.Location = new System.Drawing.Point(3, 162);
            this.lblLoadType.Name = "lblLoadType";
            this.lblLoadType.Size = new System.Drawing.Size(51, 13);
            this.lblLoadType.TabIndex = 25;
            this.lblLoadType.Text = "loadType";
            // 
            // labelCylinderCapacity
            // 
            this.labelCylinderCapacity.AutoSize = true;
            this.labelCylinderCapacity.Location = new System.Drawing.Point(3, 6);
            this.labelCylinderCapacity.Name = "labelCylinderCapacity";
            this.labelCylinderCapacity.Size = new System.Drawing.Size(84, 13);
            this.labelCylinderCapacity.TabIndex = 2;
            this.labelCylinderCapacity.Text = "cylinderCapacity";
            // 
            // textBoxCylinderCapacity
            // 
            this.textBoxCylinderCapacity.Location = new System.Drawing.Point(105, 3);
            this.textBoxCylinderCapacity.Name = "textBoxCylinderCapacity";
            this.textBoxCylinderCapacity.Size = new System.Drawing.Size(49, 20);
            this.textBoxCylinderCapacity.TabIndex = 3;
            this.textBoxCylinderCapacity.Text = "12000";
            this.textBoxCylinderCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelYearOfManufacture
            // 
            this.labelYearOfManufacture.AutoSize = true;
            this.labelYearOfManufacture.Location = new System.Drawing.Point(3, 140);
            this.labelYearOfManufacture.Name = "labelYearOfManufacture";
            this.labelYearOfManufacture.Size = new System.Drawing.Size(98, 13);
            this.labelYearOfManufacture.TabIndex = 24;
            this.labelYearOfManufacture.Text = "yearOfManufacture";
            // 
            // labelFuelType
            // 
            this.labelFuelType.AutoSize = true;
            this.labelFuelType.Location = new System.Drawing.Point(3, 28);
            this.labelFuelType.Name = "labelFuelType";
            this.labelFuelType.Size = new System.Drawing.Size(48, 13);
            this.labelFuelType.TabIndex = 4;
            this.labelFuelType.Text = "fuelType";
            // 
            // textBoxYearOfManufacture
            // 
            this.textBoxYearOfManufacture.Location = new System.Drawing.Point(105, 137);
            this.textBoxYearOfManufacture.Name = "textBoxYearOfManufacture";
            this.textBoxYearOfManufacture.Size = new System.Drawing.Size(49, 20);
            this.textBoxYearOfManufacture.TabIndex = 23;
            this.textBoxYearOfManufacture.Text = "2015";
            this.textBoxYearOfManufacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFuelConsumption
            // 
            this.labelFuelConsumption.AutoSize = true;
            this.labelFuelConsumption.Location = new System.Drawing.Point(3, 96);
            this.labelFuelConsumption.Name = "labelFuelConsumption";
            this.labelFuelConsumption.Size = new System.Drawing.Size(85, 13);
            this.labelFuelConsumption.TabIndex = 6;
            this.labelFuelConsumption.Text = "fuelConsumption";
            // 
            // cbxFuelType
            // 
            this.cbxFuelType.FormattingEnabled = true;
            this.cbxFuelType.Location = new System.Drawing.Point(75, 24);
            this.cbxFuelType.Name = "cbxFuelType";
            this.cbxFuelType.Size = new System.Drawing.Size(79, 21);
            this.cbxFuelType.TabIndex = 20;
            this.cbxFuelType.Text = "DIESEL";
            // 
            // textBoxFuelConsumption
            // 
            this.textBoxFuelConsumption.Location = new System.Drawing.Point(105, 93);
            this.textBoxFuelConsumption.Name = "textBoxFuelConsumption";
            this.textBoxFuelConsumption.Size = new System.Drawing.Size(49, 20);
            this.textBoxFuelConsumption.TabIndex = 7;
            this.textBoxFuelConsumption.Text = "35.0";
            this.textBoxFuelConsumption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbxEmissionStandardEU
            // 
            this.cbxEmissionStandardEU.FormattingEnabled = true;
            this.cbxEmissionStandardEU.Location = new System.Drawing.Point(75, 70);
            this.cbxEmissionStandardEU.Name = "cbxEmissionStandardEU";
            this.cbxEmissionStandardEU.Size = new System.Drawing.Size(79, 21);
            this.cbxEmissionStandardEU.TabIndex = 19;
            this.cbxEmissionStandardEU.Text = "EURO_5";
            // 
            // labelEmissionTechnology
            // 
            this.labelEmissionTechnology.AutoSize = true;
            this.labelEmissionTechnology.Location = new System.Drawing.Point(3, 50);
            this.labelEmissionTechnology.Name = "labelEmissionTechnology";
            this.labelEmissionTechnology.Size = new System.Drawing.Size(72, 13);
            this.labelEmissionTechnology.TabIndex = 8;
            this.labelEmissionTechnology.Text = "emissionTech";
            // 
            // labelEmissionStandardEU
            // 
            this.labelEmissionStandardEU.AutoSize = true;
            this.labelEmissionStandardEU.Location = new System.Drawing.Point(3, 73);
            this.labelEmissionStandardEU.Name = "labelEmissionStandardEU";
            this.labelEmissionStandardEU.Size = new System.Drawing.Size(72, 13);
            this.labelEmissionStandardEU.TabIndex = 18;
            this.labelEmissionStandardEU.Text = "emissionClass";
            // 
            // cbxEmissionTechnology
            // 
            this.cbxEmissionTechnology.FormattingEnabled = true;
            this.cbxEmissionTechnology.Location = new System.Drawing.Point(75, 47);
            this.cbxEmissionTechnology.Name = "cbxEmissionTechnology";
            this.cbxEmissionTechnology.Size = new System.Drawing.Size(79, 21);
            this.cbxEmissionTechnology.TabIndex = 9;
            this.cbxEmissionTechnology.Text = "EXHAUST_GAS_RECIRCULATION";
            // 
            // labelBioFuelRatio
            // 
            this.labelBioFuelRatio.AutoSize = true;
            this.labelBioFuelRatio.Location = new System.Drawing.Point(3, 118);
            this.labelBioFuelRatio.Name = "labelBioFuelRatio";
            this.labelBioFuelRatio.Size = new System.Drawing.Size(66, 13);
            this.labelBioFuelRatio.TabIndex = 10;
            this.labelBioFuelRatio.Text = "bioFuelRatio";
            // 
            // textBoxBioFuelRatio
            // 
            this.textBoxBioFuelRatio.Location = new System.Drawing.Point(105, 115);
            this.textBoxBioFuelRatio.Name = "textBoxBioFuelRatio";
            this.textBoxBioFuelRatio.Size = new System.Drawing.Size(49, 20);
            this.textBoxBioFuelRatio.TabIndex = 11;
            this.textBoxBioFuelRatio.Text = "0.0";
            this.textBoxBioFuelRatio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStoredProfile
            // 
            this.lblStoredProfile.AutoSize = true;
            this.lblStoredProfile.Location = new System.Drawing.Point(6, 43);
            this.lblStoredProfile.Name = "lblStoredProfile";
            this.lblStoredProfile.Size = new System.Drawing.Size(65, 13);
            this.lblStoredProfile.TabIndex = 1;
            this.lblStoredProfile.Text = "storedProfile";
            // 
            // cbxStoredProfile
            // 
            this.cbxStoredProfile.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxStoredProfile.FormattingEnabled = true;
            this.cbxStoredProfile.Items.AddRange(new object[] {
            "bicycle",
            "car",
            "default",
            "pedestrian",
            "trailertruck",
            "truck7_5t",
            "truck11_99t",
            "truck40t",
            "van"});
            this.cbxStoredProfile.Location = new System.Drawing.Point(97, 39);
            this.cbxStoredProfile.Name = "cbxStoredProfile";
            this.cbxStoredProfile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxStoredProfile.Size = new System.Drawing.Size(94, 21);
            this.cbxStoredProfile.TabIndex = 22;
            this.cbxStoredProfile.Text = "truck40t";
            // 
            // cbxTollSections
            // 
            this.cbxTollSections.AutoSize = true;
            this.cbxTollSections.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxTollSections.Location = new System.Drawing.Point(6, 77);
            this.cbxTollSections.Name = "cbxTollSections";
            this.cbxTollSections.Size = new System.Drawing.Size(84, 17);
            this.cbxTollSections.TabIndex = 41;
            this.cbxTollSections.Text = "TollSections";
            this.cbxTollSections.UseVisualStyleBackColor = true;
            // 
            // cbxSegments
            // 
            this.cbxSegments.AutoSize = true;
            this.cbxSegments.Checked = true;
            this.cbxSegments.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSegments.Location = new System.Drawing.Point(104, 14);
            this.cbxSegments.Name = "cbxSegments";
            this.cbxSegments.Size = new System.Drawing.Size(73, 17);
            this.cbxSegments.TabIndex = 38;
            this.cbxSegments.Text = "Segments";
            this.cbxSegments.UseVisualStyleBackColor = true;
            // 
            // gbxRoutingProfile
            // 
            this.gbxRoutingProfile.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxRoutingProfile.Controls.Add(this.tbxNetworkClassPenalties);
            this.gbxRoutingProfile.Controls.Add(this.lblPenaltiesByNetworkClass);
            this.gbxRoutingProfile.Controls.Add(this.tbxDeliveryOnlyGateCost);
            this.gbxRoutingProfile.Controls.Add(this.lblDeliveryOnlyGateCost);
            this.gbxRoutingProfile.Controls.Add(this.tbxDeliveryOnlyPenalty);
            this.gbxRoutingProfile.Controls.Add(this.lblDeliveryOnlyPenalty);
            this.gbxRoutingProfile.Controls.Add(this.tbxForbiddenLEZPenal);
            this.gbxRoutingProfile.Controls.Add(this.lblForbiddenLEZPenal);
            this.gbxRoutingProfile.Controls.Add(this.tbxMinimumUrbanNetworkClass);
            this.gbxRoutingProfile.Controls.Add(this.lblMinimumUrbanNetworkClass);
            this.gbxRoutingProfile.Controls.Add(this.tbxUrbanPenalty);
            this.gbxRoutingProfile.Controls.Add(this.lblUrbanPenalty);
            this.gbxRoutingProfile.Controls.Add(this.tbxResidentsOnlyPenalty);
            this.gbxRoutingProfile.Controls.Add(this.lblResidentsOnlyPenalty);
            this.gbxRoutingProfile.Controls.Add(this.tbxDistanceTimeWeighting);
            this.gbxRoutingProfile.Controls.Add(this.lblDistanceTimeWeighting);
            this.gbxRoutingProfile.Controls.Add(this.tbxTollPenalty);
            this.gbxRoutingProfile.Controls.Add(this.lblTollPenalty);
            this.gbxRoutingProfile.Controls.Add(this.tbxViolationsCost);
            this.gbxRoutingProfile.Controls.Add(this.lblViolationsCost);
            this.gbxRoutingProfile.Controls.Add(this.tbxViolationsEnabled);
            this.gbxRoutingProfile.Controls.Add(this.lblViolationsEnabled);
            this.gbxRoutingProfile.Controls.Add(this.tbxOnlyReachableRoads);
            this.gbxRoutingProfile.Controls.Add(this.lblOnlyReachableRoads);
            this.gbxRoutingProfile.Controls.Add(this.tbxMaximumDistanceToSegment);
            this.gbxRoutingProfile.Controls.Add(this.lblMaximumDistanceToSegment);
            this.gbxRoutingProfile.Location = new System.Drawing.Point(206, 95);
            this.gbxRoutingProfile.Name = "gbxRoutingProfile";
            this.gbxRoutingProfile.Size = new System.Drawing.Size(320, 206);
            this.gbxRoutingProfile.TabIndex = 14;
            this.gbxRoutingProfile.TabStop = false;
            this.gbxRoutingProfile.Text = "routingProfile";
            // 
            // tbxNetworkClassPenalties
            // 
            this.tbxNetworkClassPenalties.Location = new System.Drawing.Point(128, 170);
            this.tbxNetworkClassPenalties.Name = "tbxNetworkClassPenalties";
            this.tbxNetworkClassPenalties.Size = new System.Drawing.Size(186, 20);
            this.tbxNetworkClassPenalties.TabIndex = 25;
            this.tbxNetworkClassPenalties.Text = "0,0,0,0,15,50,100,100";
            this.tbxNetworkClassPenalties.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPenaltiesByNetworkClass
            // 
            this.lblPenaltiesByNetworkClass.AutoSize = true;
            this.lblPenaltiesByNetworkClass.Location = new System.Drawing.Point(2, 173);
            this.lblPenaltiesByNetworkClass.Name = "lblPenaltiesByNetworkClass";
            this.lblPenaltiesByNetworkClass.Size = new System.Drawing.Size(126, 13);
            this.lblPenaltiesByNetworkClass.TabIndex = 24;
            this.lblPenaltiesByNetworkClass.Text = "penaltiesByNetworkClass";
            // 
            // tbxDeliveryOnlyGateCost
            // 
            this.tbxDeliveryOnlyGateCost.Location = new System.Drawing.Point(269, 144);
            this.tbxDeliveryOnlyGateCost.Name = "tbxDeliveryOnlyGateCost";
            this.tbxDeliveryOnlyGateCost.Size = new System.Drawing.Size(45, 20);
            this.tbxDeliveryOnlyGateCost.TabIndex = 23;
            this.tbxDeliveryOnlyGateCost.Text = "50000";
            this.tbxDeliveryOnlyGateCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxDeliveryOnlyGateCost, resources.GetString("tbxDeliveryOnlyGateCost.ToolTip"));
            // 
            // lblDeliveryOnlyGateCost
            // 
            this.lblDeliveryOnlyGateCost.AutoSize = true;
            this.lblDeliveryOnlyGateCost.Location = new System.Drawing.Point(163, 147);
            this.lblDeliveryOnlyGateCost.Name = "lblDeliveryOnlyGateCost";
            this.lblDeliveryOnlyGateCost.Size = new System.Drawing.Size(108, 13);
            this.lblDeliveryOnlyGateCost.TabIndex = 22;
            this.lblDeliveryOnlyGateCost.Text = "deliveryOnlyGateCost";
            // 
            // tbxDeliveryOnlyPenalty
            // 
            this.tbxDeliveryOnlyPenalty.Location = new System.Drawing.Point(269, 118);
            this.tbxDeliveryOnlyPenalty.Name = "tbxDeliveryOnlyPenalty";
            this.tbxDeliveryOnlyPenalty.Size = new System.Drawing.Size(45, 20);
            this.tbxDeliveryOnlyPenalty.TabIndex = 21;
            this.tbxDeliveryOnlyPenalty.Text = "2500";
            this.tbxDeliveryOnlyPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxDeliveryOnlyPenalty, resources.GetString("tbxDeliveryOnlyPenalty.ToolTip"));
            // 
            // lblDeliveryOnlyPenalty
            // 
            this.lblDeliveryOnlyPenalty.AutoSize = true;
            this.lblDeliveryOnlyPenalty.Location = new System.Drawing.Point(163, 121);
            this.lblDeliveryOnlyPenalty.Name = "lblDeliveryOnlyPenalty";
            this.lblDeliveryOnlyPenalty.Size = new System.Drawing.Size(99, 13);
            this.lblDeliveryOnlyPenalty.TabIndex = 20;
            this.lblDeliveryOnlyPenalty.Text = "deliveryOnlyPenalty";
            // 
            // tbxForbiddenLEZPenal
            // 
            this.tbxForbiddenLEZPenal.Location = new System.Drawing.Point(269, 92);
            this.tbxForbiddenLEZPenal.Name = "tbxForbiddenLEZPenal";
            this.tbxForbiddenLEZPenal.Size = new System.Drawing.Size(45, 20);
            this.tbxForbiddenLEZPenal.TabIndex = 19;
            this.tbxForbiddenLEZPenal.Text = "2500";
            this.tbxForbiddenLEZPenal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxForbiddenLEZPenal, resources.GetString("tbxForbiddenLEZPenal.ToolTip"));
            // 
            // lblForbiddenLEZPenal
            // 
            this.lblForbiddenLEZPenal.AutoSize = true;
            this.lblForbiddenLEZPenal.Location = new System.Drawing.Point(163, 95);
            this.lblForbiddenLEZPenal.Name = "lblForbiddenLEZPenal";
            this.lblForbiddenLEZPenal.Size = new System.Drawing.Size(98, 13);
            this.lblForbiddenLEZPenal.TabIndex = 18;
            this.lblForbiddenLEZPenal.Text = "forbiddenLEZPenal";
            // 
            // tbxMinimumUrbanNetworkClass
            // 
            this.tbxMinimumUrbanNetworkClass.Location = new System.Drawing.Point(269, 66);
            this.tbxMinimumUrbanNetworkClass.Name = "tbxMinimumUrbanNetworkClass";
            this.tbxMinimumUrbanNetworkClass.Size = new System.Drawing.Size(45, 20);
            this.tbxMinimumUrbanNetworkClass.TabIndex = 17;
            this.tbxMinimumUrbanNetworkClass.Text = "2";
            this.tbxMinimumUrbanNetworkClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxMinimumUrbanNetworkClass, "Type \t                           Required \t  Default \t   Since \tDescription\r\nNetw" +
        "orkClass (Integer) \tno \t        2           2.0 \tThe minimum allowed urban netwo" +
        "rk class ");
            // 
            // lblMinimumUrbanNetworkClass
            // 
            this.lblMinimumUrbanNetworkClass.AutoSize = true;
            this.lblMinimumUrbanNetworkClass.Location = new System.Drawing.Point(163, 69);
            this.lblMinimumUrbanNetworkClass.Name = "lblMinimumUrbanNetworkClass";
            this.lblMinimumUrbanNetworkClass.Size = new System.Drawing.Size(94, 13);
            this.lblMinimumUrbanNetworkClass.TabIndex = 16;
            this.lblMinimumUrbanNetworkClass.Text = "minUrbanNetClass";
            // 
            // tbxUrbanPenalty
            // 
            this.tbxUrbanPenalty.Location = new System.Drawing.Point(269, 40);
            this.tbxUrbanPenalty.Name = "tbxUrbanPenalty";
            this.tbxUrbanPenalty.Size = new System.Drawing.Size(45, 20);
            this.tbxUrbanPenalty.TabIndex = 15;
            this.tbxUrbanPenalty.Text = "0";
            this.tbxUrbanPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxUrbanPenalty, resources.GetString("tbxUrbanPenalty.ToolTip"));
            // 
            // lblUrbanPenalty
            // 
            this.lblUrbanPenalty.AutoSize = true;
            this.lblUrbanPenalty.Location = new System.Drawing.Point(163, 43);
            this.lblUrbanPenalty.Name = "lblUrbanPenalty";
            this.lblUrbanPenalty.Size = new System.Drawing.Size(69, 13);
            this.lblUrbanPenalty.TabIndex = 14;
            this.lblUrbanPenalty.Text = "urbanPenalty";
            // 
            // tbxResidentsOnlyPenalty
            // 
            this.tbxResidentsOnlyPenalty.Location = new System.Drawing.Point(269, 14);
            this.tbxResidentsOnlyPenalty.Name = "tbxResidentsOnlyPenalty";
            this.tbxResidentsOnlyPenalty.Size = new System.Drawing.Size(45, 20);
            this.tbxResidentsOnlyPenalty.TabIndex = 13;
            this.tbxResidentsOnlyPenalty.Text = "2500";
            this.tbxResidentsOnlyPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxResidentsOnlyPenalty, resources.GetString("tbxResidentsOnlyPenalty.ToolTip"));
            // 
            // lblResidentsOnlyPenalty
            // 
            this.lblResidentsOnlyPenalty.AutoSize = true;
            this.lblResidentsOnlyPenalty.Location = new System.Drawing.Point(163, 17);
            this.lblResidentsOnlyPenalty.Name = "lblResidentsOnlyPenalty";
            this.lblResidentsOnlyPenalty.Size = new System.Drawing.Size(105, 13);
            this.lblResidentsOnlyPenalty.TabIndex = 12;
            this.lblResidentsOnlyPenalty.Text = "residentsOnlyPenalty";
            // 
            // tbxDistanceTimeWeighting
            // 
            this.tbxDistanceTimeWeighting.Location = new System.Drawing.Point(111, 144);
            this.tbxDistanceTimeWeighting.Name = "tbxDistanceTimeWeighting";
            this.tbxDistanceTimeWeighting.Size = new System.Drawing.Size(45, 20);
            this.tbxDistanceTimeWeighting.TabIndex = 11;
            this.tbxDistanceTimeWeighting.Text = "90.0";
            this.tbxDistanceTimeWeighting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.tbxDistanceTimeWeighting, resources.GetString("tbxDistanceTimeWeighting.ToolTip"));
            // 
            // lblDistanceTimeWeighting
            // 
            this.lblDistanceTimeWeighting.AutoSize = true;
            this.lblDistanceTimeWeighting.Location = new System.Drawing.Point(2, 147);
            this.lblDistanceTimeWeighting.Name = "lblDistanceTimeWeighting";
            this.lblDistanceTimeWeighting.Size = new System.Drawing.Size(94, 13);
            this.lblDistanceTimeWeighting.TabIndex = 10;
            this.lblDistanceTimeWeighting.Text = "distTimeWeighting";
            // 
            // tbxTollPenalty
            // 
            this.tbxTollPenalty.Location = new System.Drawing.Point(111, 118);
            this.tbxTollPenalty.Name = "tbxTollPenalty";
            this.tbxTollPenalty.Size = new System.Drawing.Size(45, 20);
            this.tbxTollPenalty.TabIndex = 9;
            this.tbxTollPenalty.Text = "0";
            this.tbxTollPenalty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTollPenalty
            // 
            this.lblTollPenalty.AutoSize = true;
            this.lblTollPenalty.Location = new System.Drawing.Point(4, 121);
            this.lblTollPenalty.Name = "lblTollPenalty";
            this.lblTollPenalty.Size = new System.Drawing.Size(55, 13);
            this.lblTollPenalty.TabIndex = 8;
            this.lblTollPenalty.Text = "tollPenalty";
            // 
            // tbxViolationsCost
            // 
            this.tbxViolationsCost.Location = new System.Drawing.Point(111, 92);
            this.tbxViolationsCost.Name = "tbxViolationsCost";
            this.tbxViolationsCost.Size = new System.Drawing.Size(45, 20);
            this.tbxViolationsCost.TabIndex = 7;
            this.tbxViolationsCost.Text = "50000";
            this.tbxViolationsCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblViolationsCost
            // 
            this.lblViolationsCost.AutoSize = true;
            this.lblViolationsCost.Location = new System.Drawing.Point(4, 95);
            this.lblViolationsCost.Name = "lblViolationsCost";
            this.lblViolationsCost.Size = new System.Drawing.Size(72, 13);
            this.lblViolationsCost.TabIndex = 6;
            this.lblViolationsCost.Text = "violationsCost";
            // 
            // tbxViolationsEnabled
            // 
            this.tbxViolationsEnabled.Location = new System.Drawing.Point(111, 66);
            this.tbxViolationsEnabled.Name = "tbxViolationsEnabled";
            this.tbxViolationsEnabled.Size = new System.Drawing.Size(45, 20);
            this.tbxViolationsEnabled.TabIndex = 5;
            this.tbxViolationsEnabled.Text = "false";
            this.tbxViolationsEnabled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblViolationsEnabled
            // 
            this.lblViolationsEnabled.AutoSize = true;
            this.lblViolationsEnabled.Location = new System.Drawing.Point(4, 69);
            this.lblViolationsEnabled.Name = "lblViolationsEnabled";
            this.lblViolationsEnabled.Size = new System.Drawing.Size(90, 13);
            this.lblViolationsEnabled.TabIndex = 4;
            this.lblViolationsEnabled.Text = "violationsEnabled";
            // 
            // tbxOnlyReachableRoads
            // 
            this.tbxOnlyReachableRoads.Location = new System.Drawing.Point(111, 40);
            this.tbxOnlyReachableRoads.Name = "tbxOnlyReachableRoads";
            this.tbxOnlyReachableRoads.Size = new System.Drawing.Size(45, 20);
            this.tbxOnlyReachableRoads.TabIndex = 3;
            this.tbxOnlyReachableRoads.Text = "true";
            this.tbxOnlyReachableRoads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOnlyReachableRoads
            // 
            this.lblOnlyReachableRoads.AutoSize = true;
            this.lblOnlyReachableRoads.Location = new System.Drawing.Point(4, 43);
            this.lblOnlyReachableRoads.Name = "lblOnlyReachableRoads";
            this.lblOnlyReachableRoads.Size = new System.Drawing.Size(112, 13);
            this.lblOnlyReachableRoads.TabIndex = 2;
            this.lblOnlyReachableRoads.Text = "onlyReachableRoads ";
            // 
            // tbxMaximumDistanceToSegment
            // 
            this.tbxMaximumDistanceToSegment.Location = new System.Drawing.Point(111, 14);
            this.tbxMaximumDistanceToSegment.Name = "tbxMaximumDistanceToSegment";
            this.tbxMaximumDistanceToSegment.Size = new System.Drawing.Size(45, 20);
            this.tbxMaximumDistanceToSegment.TabIndex = 1;
            this.tbxMaximumDistanceToSegment.Text = "50000";
            this.tbxMaximumDistanceToSegment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMaximumDistanceToSegment
            // 
            this.lblMaximumDistanceToSegment.AutoSize = true;
            this.lblMaximumDistanceToSegment.Location = new System.Drawing.Point(4, 17);
            this.lblMaximumDistanceToSegment.Name = "lblMaximumDistanceToSegment";
            this.lblMaximumDistanceToSegment.Size = new System.Drawing.Size(99, 13);
            this.lblMaximumDistanceToSegment.TabIndex = 0;
            this.lblMaximumDistanceToSegment.Text = "maxDistToSegment";
            // 
            // timerLocate
            // 
            this.timerLocate.Interval = 5000;
            // 
            // cbxCoordFormat
            // 
            this.cbxCoordFormat.FormattingEnabled = true;
            this.cbxCoordFormat.Items.AddRange(new object[] {
            "EPSG:4326",
            "EPSG:3857",
            "EPSG:76131"});
            this.cbxCoordFormat.Location = new System.Drawing.Point(97, 13);
            this.cbxCoordFormat.Name = "cbxCoordFormat";
            this.cbxCoordFormat.Size = new System.Drawing.Size(94, 21);
            this.cbxCoordFormat.TabIndex = 18;
            this.cbxCoordFormat.Text = "EPSG:4326";
            this.toolTip.SetToolTip(this.cbxCoordFormat, resources.GetString("cbxCoordFormat.ToolTip"));
            // 
            // tbxAllowedCountries
            // 
            this.tbxAllowedCountries.Location = new System.Drawing.Point(97, 66);
            this.tbxAllowedCountries.Name = "tbxAllowedCountries";
            this.tbxAllowedCountries.Size = new System.Drawing.Size(94, 20);
            this.tbxAllowedCountries.TabIndex = 25;
            this.toolTip.SetToolTip(this.tbxAllowedCountries, resources.GetString("tbxAllowedCountries.ToolTip"));
            // 
            // tbxProhibitedCountries
            // 
            this.tbxProhibitedCountries.Location = new System.Drawing.Point(97, 92);
            this.tbxProhibitedCountries.Name = "tbxProhibitedCountries";
            this.tbxProhibitedCountries.Size = new System.Drawing.Size(94, 20);
            this.tbxProhibitedCountries.TabIndex = 27;
            this.toolTip.SetToolTip(this.tbxProhibitedCountries, "Specifies a list of country codes that are prohibited for a routing. \r\nISO 3166-1" +
        " alpha-2");
            // 
            // tbctrlRouteResults
            // 
            this.tbctrlRouteResults.Controls.Add(this.tabRouteSummary);
            this.tbctrlRouteResults.Controls.Add(this.tabRouteSegments);
            this.tbctrlRouteResults.Location = new System.Drawing.Point(7, 593);
            this.tbctrlRouteResults.Name = "tbctrlRouteResults";
            this.tbctrlRouteResults.SelectedIndex = 0;
            this.tbctrlRouteResults.Size = new System.Drawing.Size(626, 373);
            this.tbctrlRouteResults.TabIndex = 16;
            // 
            // tabRouteSummary
            // 
            this.tabRouteSummary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabRouteSummary.Controls.Add(this.tbxRouteResultTime);
            this.tabRouteSummary.Controls.Add(this.lblRouteTime);
            this.tabRouteSummary.Controls.Add(this.tbxRouteResultViolations);
            this.tabRouteSummary.Controls.Add(this.lblRouteDistance);
            this.tabRouteSummary.Controls.Add(this.lblRouteViolations);
            this.tabRouteSummary.Controls.Add(this.tbxRouteResultDistance);
            this.tabRouteSummary.Controls.Add(this.lbxTollSummary);
            this.tabRouteSummary.Controls.Add(this.lblTollSummary);
            this.tabRouteSummary.Location = new System.Drawing.Point(4, 22);
            this.tabRouteSummary.Name = "tabRouteSummary";
            this.tabRouteSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabRouteSummary.Size = new System.Drawing.Size(618, 347);
            this.tabRouteSummary.TabIndex = 0;
            this.tabRouteSummary.Text = "Route Result Summary";
            // 
            // tabRouteSegments
            // 
            this.tabRouteSegments.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabRouteSegments.Controls.Add(this.dataGridRouteSegments);
            this.tabRouteSegments.Location = new System.Drawing.Point(4, 22);
            this.tabRouteSegments.Name = "tabRouteSegments";
            this.tabRouteSegments.Padding = new System.Windows.Forms.Padding(3);
            this.tabRouteSegments.Size = new System.Drawing.Size(618, 347);
            this.tabRouteSegments.TabIndex = 1;
            this.tabRouteSegments.Text = "Route Result Segments";
            // 
            // dataGridRouteSegments
            // 
            this.dataGridRouteSegments.AutoGenerateColumns = false;
            this.dataGridRouteSegments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRouteSegments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.distanceDataGridViewTextBoxColumn,
            this.travelTimeDataGridViewTextBoxColumn,
            this.violatedDataGridViewCheckBoxColumn,
            this.attributesDataGridViewTextBoxColumn,
            this.combinedTransportDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.emissionsDataGridViewTextBoxColumn,
            this.polylineDataGridViewTextBoxColumn,
            this.travelSpeedDataGridViewTextBoxColumn,
            this.startNodeIndexDataGridViewTextBoxColumn,
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn,
            this.endNodeIndexDataGridViewTextBoxColumn,
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn});
            this.dataGridRouteSegments.DataSource = this.segmentBindingSource;
            this.dataGridRouteSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRouteSegments.Location = new System.Drawing.Point(3, 3);
            this.dataGridRouteSegments.Name = "dataGridRouteSegments";
            this.dataGridRouteSegments.Size = new System.Drawing.Size(612, 341);
            this.dataGridRouteSegments.TabIndex = 0;
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(xS2Development.xRouteWSService.Segment);
            // 
            // gbxRenderMap
            // 
            this.gbxRenderMap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxRenderMap.Controls.Add(this.cbxMapProfile);
            this.gbxRenderMap.Controls.Add(this.lbxMapFeatureLayer);
            this.gbxRenderMap.Controls.Add(this.btnRenewMap);
            this.gbxRenderMap.Location = new System.Drawing.Point(228, 422);
            this.gbxRenderMap.Name = "gbxRenderMap";
            this.gbxRenderMap.Size = new System.Drawing.Size(157, 165);
            this.gbxRenderMap.TabIndex = 17;
            this.gbxRenderMap.TabStop = false;
            this.gbxRenderMap.Text = "Map settings";
            // 
            // cbxMapProfile
            // 
            this.cbxMapProfile.FormattingEnabled = true;
            this.cbxMapProfile.Items.AddRange(new object[] {
            "amber",
            "blackmarble",
            "classic",
            "gravelpit",
            "sandbox",
            "silica",
            "silkysand"});
            this.cbxMapProfile.Location = new System.Drawing.Point(7, 87);
            this.cbxMapProfile.Name = "cbxMapProfile";
            this.cbxMapProfile.Size = new System.Drawing.Size(145, 21);
            this.cbxMapProfile.TabIndex = 46;
            this.cbxMapProfile.Text = "silkysand";
            // 
            // lbxMapFeatureLayer
            // 
            this.lbxMapFeatureLayer.FormattingEnabled = true;
            this.lbxMapFeatureLayer.Items.AddRange(new object[] {
            "PTV_TruckAttributes",
            "PTV_TrafficIncidents",
            "PTV_SpeedPatterns",
            "PTV_RestrictionZones",
            "PTV_TruckSpeedPatterns",
            "PTV_PreferredRoutes",
            "PTV_TruckWaitingTimes"});
            this.lbxMapFeatureLayer.Location = new System.Drawing.Point(6, 14);
            this.lbxMapFeatureLayer.Name = "lbxMapFeatureLayer";
            this.lbxMapFeatureLayer.Size = new System.Drawing.Size(145, 69);
            this.lbxMapFeatureLayer.TabIndex = 45;
            // 
            // btnRenewMap
            // 
            this.btnRenewMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRenewMap.Location = new System.Drawing.Point(5, 112);
            this.btnRenewMap.Name = "btnRenewMap";
            this.btnRenewMap.Size = new System.Drawing.Size(147, 45);
            this.btnRenewMap.TabIndex = 44;
            this.btnRenewMap.Text = "Renew Map";
            this.btnRenewMap.UseVisualStyleBackColor = false;
            this.btnRenewMap.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // gbxRoutingOptions
            // 
            this.gbxRoutingOptions.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxRoutingOptions.Controls.Add(this.cbxFeatureThemeIds);
            this.gbxRoutingOptions.Controls.Add(this.cbxRoadAttributes);
            this.gbxRoutingOptions.Controls.Add(this.cbxDescriptors);
            this.gbxRoutingOptions.Controls.Add(this.cbxPolyline);
            this.gbxRoutingOptions.Controls.Add(this.cbxTollCalculation);
            this.gbxRoutingOptions.Controls.Add(this.cbxLegs);
            this.gbxRoutingOptions.Controls.Add(this.cbxTollSystems);
            this.gbxRoutingOptions.Controls.Add(this.cbxTollSections);
            this.gbxRoutingOptions.Controls.Add(this.cbxEmissions);
            this.gbxRoutingOptions.Controls.Add(this.cbxSegments);
            this.gbxRoutingOptions.Location = new System.Drawing.Point(228, 306);
            this.gbxRoutingOptions.Name = "gbxRoutingOptions";
            this.gbxRoutingOptions.Size = new System.Drawing.Size(219, 111);
            this.gbxRoutingOptions.TabIndex = 19;
            this.gbxRoutingOptions.TabStop = false;
            this.gbxRoutingOptions.Text = "resultOptions";
            // 
            // cbxFeatureThemeIds
            // 
            this.cbxFeatureThemeIds.AutoSize = true;
            this.cbxFeatureThemeIds.Location = new System.Drawing.Point(104, 59);
            this.cbxFeatureThemeIds.Name = "cbxFeatureThemeIds";
            this.cbxFeatureThemeIds.Size = new System.Drawing.Size(113, 17);
            this.cbxFeatureThemeIds.TabIndex = 48;
            this.cbxFeatureThemeIds.Text = "SfeatureThemeIds";
            this.cbxFeatureThemeIds.UseVisualStyleBackColor = true;
            // 
            // cbxRoadAttributes
            // 
            this.cbxRoadAttributes.AutoSize = true;
            this.cbxRoadAttributes.Location = new System.Drawing.Point(104, 44);
            this.cbxRoadAttributes.Name = "cbxRoadAttributes";
            this.cbxRoadAttributes.Size = new System.Drawing.Size(98, 17);
            this.cbxRoadAttributes.TabIndex = 47;
            this.cbxRoadAttributes.Text = "SroadAttributes";
            this.cbxRoadAttributes.UseVisualStyleBackColor = true;
            // 
            // cbxDescriptors
            // 
            this.cbxDescriptors.AutoSize = true;
            this.cbxDescriptors.Location = new System.Drawing.Point(104, 29);
            this.cbxDescriptors.Name = "cbxDescriptors";
            this.cbxDescriptors.Size = new System.Drawing.Size(84, 17);
            this.cbxDescriptors.TabIndex = 46;
            this.cbxDescriptors.Text = "Sdescriptors";
            this.cbxDescriptors.UseVisualStyleBackColor = true;
            // 
            // cbxPolyline
            // 
            this.cbxPolyline.AutoSize = true;
            this.cbxPolyline.Checked = true;
            this.cbxPolyline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPolyline.Location = new System.Drawing.Point(6, 29);
            this.cbxPolyline.Name = "cbxPolyline";
            this.cbxPolyline.Size = new System.Drawing.Size(62, 17);
            this.cbxPolyline.TabIndex = 45;
            this.cbxPolyline.Text = "Polyline";
            this.cbxPolyline.UseVisualStyleBackColor = true;
            // 
            // cbxTollCalculation
            // 
            this.cbxTollCalculation.AutoSize = true;
            this.cbxTollCalculation.Checked = true;
            this.cbxTollCalculation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTollCalculation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbxTollCalculation.Location = new System.Drawing.Point(6, 61);
            this.cbxTollCalculation.Name = "cbxTollCalculation";
            this.cbxTollCalculation.Size = new System.Drawing.Size(98, 17);
            this.cbxTollCalculation.TabIndex = 44;
            this.cbxTollCalculation.Text = "Toll Calculation";
            this.cbxTollCalculation.UseVisualStyleBackColor = true;
            // 
            // cbxLegs
            // 
            this.cbxLegs.AutoSize = true;
            this.cbxLegs.Location = new System.Drawing.Point(6, 14);
            this.cbxLegs.Name = "cbxLegs";
            this.cbxLegs.Size = new System.Drawing.Size(49, 17);
            this.cbxLegs.TabIndex = 43;
            this.cbxLegs.Text = "Legs";
            this.cbxLegs.UseVisualStyleBackColor = true;
            // 
            // cbxTollSystems
            // 
            this.cbxTollSystems.AutoSize = true;
            this.cbxTollSystems.Location = new System.Drawing.Point(6, 92);
            this.cbxTollSystems.Name = "cbxTollSystems";
            this.cbxTollSystems.Size = new System.Drawing.Size(82, 17);
            this.cbxTollSystems.TabIndex = 42;
            this.cbxTollSystems.Text = "TollSystems";
            this.cbxTollSystems.UseVisualStyleBackColor = true;
            // 
            // emissionValuesHBEFA32BindingSource
            // 
            this.emissionValuesHBEFA32BindingSource.DataSource = typeof(xS2Development.xRouteWSService.EmissionValues_HBEFA_3_2);
            // 
            // loadBindingSource
            // 
            this.loadBindingSource.DataSource = typeof(xS2Development.xRouteWSService.Load);
            // 
            // loadBindingSource1
            // 
            this.loadBindingSource1.DataSource = typeof(xS2Development.xRouteWSService.Load);
            // 
            // gbxRouteOptions
            // 
            this.gbxRouteOptions.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxRouteOptions.Controls.Add(this.tbxProhibitedCountries);
            this.gbxRouteOptions.Controls.Add(this.lblCoordFormat);
            this.gbxRouteOptions.Controls.Add(this.tbxAllowedCountries);
            this.gbxRouteOptions.Controls.Add(this.lblProhibitedCountries);
            this.gbxRouteOptions.Controls.Add(this.lblAllowedCountries);
            this.gbxRouteOptions.Controls.Add(this.cbxCoordFormat);
            this.gbxRouteOptions.Controls.Add(this.lblStoredProfile);
            this.gbxRouteOptions.Controls.Add(this.cbxStoredProfile);
            this.gbxRouteOptions.Location = new System.Drawing.Point(7, 95);
            this.gbxRouteOptions.Name = "gbxRouteOptions";
            this.gbxRouteOptions.Size = new System.Drawing.Size(196, 206);
            this.gbxRouteOptions.TabIndex = 20;
            this.gbxRouteOptions.TabStop = false;
            this.gbxRouteOptions.Text = "routeOptions";
            // 
            // lblCoordFormat
            // 
            this.lblCoordFormat.AutoSize = true;
            this.lblCoordFormat.Location = new System.Drawing.Point(6, 16);
            this.lblCoordFormat.Name = "lblCoordFormat";
            this.lblCoordFormat.Size = new System.Drawing.Size(89, 13);
            this.lblCoordFormat.TabIndex = 26;
            this.lblCoordFormat.Text = "coordinateFormat";
            // 
            // lblProhibitedCountries
            // 
            this.lblProhibitedCountries.AutoSize = true;
            this.lblProhibitedCountries.Location = new System.Drawing.Point(2, 95);
            this.lblProhibitedCountries.Name = "lblProhibitedCountries";
            this.lblProhibitedCountries.Size = new System.Drawing.Size(97, 13);
            this.lblProhibitedCountries.TabIndex = 24;
            this.lblProhibitedCountries.Text = "prohibitedCountries";
            // 
            // lblAllowedCountries
            // 
            this.lblAllowedCountries.AutoSize = true;
            this.lblAllowedCountries.Location = new System.Drawing.Point(5, 69);
            this.lblAllowedCountries.Name = "lblAllowedCountries";
            this.lblAllowedCountries.Size = new System.Drawing.Size(87, 13);
            this.lblAllowedCountries.TabIndex = 23;
            this.lblAllowedCountries.Text = "allowedCountries";
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMap.Controls.Add(this.dynMap);
            this.pnlMap.Location = new System.Drawing.Point(634, 7);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(955, 957);
            this.pnlMap.TabIndex = 21;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ToolTipText = "The travel distance for the segment. It is always a whole number.";
            // 
            // travelTimeDataGridViewTextBoxColumn
            // 
            this.travelTimeDataGridViewTextBoxColumn.DataPropertyName = "travelTime";
            this.travelTimeDataGridViewTextBoxColumn.HeaderText = "travelTime";
            this.travelTimeDataGridViewTextBoxColumn.Name = "travelTimeDataGridViewTextBoxColumn";
            // 
            // violatedDataGridViewCheckBoxColumn
            // 
            this.violatedDataGridViewCheckBoxColumn.DataPropertyName = "violated";
            this.violatedDataGridViewCheckBoxColumn.HeaderText = "violated";
            this.violatedDataGridViewCheckBoxColumn.Name = "violatedDataGridViewCheckBoxColumn";
            // 
            // attributesDataGridViewTextBoxColumn
            // 
            this.attributesDataGridViewTextBoxColumn.DataPropertyName = "attributes";
            this.attributesDataGridViewTextBoxColumn.HeaderText = "attributes";
            this.attributesDataGridViewTextBoxColumn.Name = "attributesDataGridViewTextBoxColumn";
            // 
            // combinedTransportDataGridViewTextBoxColumn
            // 
            this.combinedTransportDataGridViewTextBoxColumn.DataPropertyName = "combinedTransport";
            this.combinedTransportDataGridViewTextBoxColumn.HeaderText = "combinedTransport";
            this.combinedTransportDataGridViewTextBoxColumn.Name = "combinedTransportDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // emissionsDataGridViewTextBoxColumn
            // 
            this.emissionsDataGridViewTextBoxColumn.DataPropertyName = "emissions";
            this.emissionsDataGridViewTextBoxColumn.HeaderText = "emissions";
            this.emissionsDataGridViewTextBoxColumn.Name = "emissionsDataGridViewTextBoxColumn";
            // 
            // polylineDataGridViewTextBoxColumn
            // 
            this.polylineDataGridViewTextBoxColumn.DataPropertyName = "polyline";
            this.polylineDataGridViewTextBoxColumn.HeaderText = "polyline";
            this.polylineDataGridViewTextBoxColumn.Name = "polylineDataGridViewTextBoxColumn";
            // 
            // travelSpeedDataGridViewTextBoxColumn
            // 
            this.travelSpeedDataGridViewTextBoxColumn.DataPropertyName = "travelSpeed";
            this.travelSpeedDataGridViewTextBoxColumn.HeaderText = "travelSpeed";
            this.travelSpeedDataGridViewTextBoxColumn.Name = "travelSpeedDataGridViewTextBoxColumn";
            // 
            // startNodeIndexDataGridViewTextBoxColumn
            // 
            this.startNodeIndexDataGridViewTextBoxColumn.DataPropertyName = "startNodeIndex";
            this.startNodeIndexDataGridViewTextBoxColumn.HeaderText = "startNodeIndex";
            this.startNodeIndexDataGridViewTextBoxColumn.Name = "startNodeIndexDataGridViewTextBoxColumn";
            // 
            // startNodeIndexSpecifiedDataGridViewCheckBoxColumn
            // 
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "startNodeIndexSpecified";
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn.HeaderText = "startNodeIndexSpecified";
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn.Name = "startNodeIndexSpecifiedDataGridViewCheckBoxColumn";
            // 
            // endNodeIndexDataGridViewTextBoxColumn
            // 
            this.endNodeIndexDataGridViewTextBoxColumn.DataPropertyName = "endNodeIndex";
            this.endNodeIndexDataGridViewTextBoxColumn.HeaderText = "endNodeIndex";
            this.endNodeIndexDataGridViewTextBoxColumn.Name = "endNodeIndexDataGridViewTextBoxColumn";
            // 
            // endNodeIndexSpecifiedDataGridViewCheckBoxColumn
            // 
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "endNodeIndexSpecified";
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn.HeaderText = "endNodeIndexSpecified";
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn.Name = "endNodeIndexSpecifiedDataGridViewCheckBoxColumn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 966);
            this.Controls.Add(this.pnlMap);
            this.Controls.Add(this.gbxRouteOptions);
            this.Controls.Add(this.gbxRoutingOptions);
            this.Controls.Add(this.gbxRenderMap);
            this.Controls.Add(this.tbctrlRouteResults);
            this.Controls.Add(this.gbxRoutingProfile);
            this.Controls.Add(this.gbxVehicleProfile);
            this.Controls.Add(this.gbxRouteCoordinates);
            this.Controls.Add(this.btnCalcRoute);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "xRoute2 Test Tool";
            this.contextMenuStripWaypoints.ResumeLayout(false);
            this.gbxRouteCoordinates.ResumeLayout(false);
            this.gbxRouteCoordinates.PerformLayout();
            this.gbxVehicleProfile.ResumeLayout(false);
            this.tabControlVehicleProfile.ResumeLayout(false);
            this.tabPagePhysical.ResumeLayout(false);
            this.tabPagePhysical.PerformLayout();
            this.tabPageEngineEmissions.ResumeLayout(false);
            this.tabPageEngineEmissions.PerformLayout();
            this.gbxRoutingProfile.ResumeLayout(false);
            this.gbxRoutingProfile.PerformLayout();
            this.tbctrlRouteResults.ResumeLayout(false);
            this.tabRouteSummary.ResumeLayout(false);
            this.tabRouteSummary.PerformLayout();
            this.tabRouteSegments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRouteSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            this.gbxRenderMap.ResumeLayout(false);
            this.gbxRoutingOptions.ResumeLayout(false);
            this.gbxRoutingOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emissionValuesHBEFA32BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadBindingSource1)).EndInit();
            this.gbxRouteOptions.ResumeLayout(false);
            this.gbxRouteOptions.PerformLayout();
            this.pnlMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Ptv.XServer.Controls.Map.FormsMap dynMap;
        private System.Windows.Forms.Button btnCalcRoute;
        private System.Windows.Forms.GroupBox gbxRouteCoordinates;
        private System.Windows.Forms.Label lblRouteDistance;
        private System.Windows.Forms.Label lblRouteTime;
        private System.Windows.Forms.TextBox tbxRouteResultDistance;
        private System.Windows.Forms.TextBox tbxRouteResultTime;
        private System.Windows.Forms.Label lblTollSummary;
        private System.Windows.Forms.ListBox lbxTollSummary;
        private System.Windows.Forms.Label lblRouteViolations;
        private System.Windows.Forms.TextBox tbxRouteResultViolations;
        private System.Windows.Forms.CheckBox cbxEmissions;
        private System.Windows.Forms.BindingSource emissionValuesHBEFA32BindingSource;
        private System.Windows.Forms.GroupBox gbxVehicleProfile;
        private System.Windows.Forms.Label lblStoredProfile;
        private System.Windows.Forms.Label labelFuelType;
        private System.Windows.Forms.TextBox textBoxCylinderCapacity;
        private System.Windows.Forms.Label labelCylinderCapacity;
        private System.Windows.Forms.ComboBox cbxEmissionTechnology;
        private System.Windows.Forms.Label labelEmissionTechnology;
        private System.Windows.Forms.TextBox textBoxFuelConsumption;
        private System.Windows.Forms.Label labelFuelConsumption;
        private System.Windows.Forms.TextBox textBoxBioFuelRatio;
        private System.Windows.Forms.Label labelBioFuelRatio;
        private System.Windows.Forms.ComboBox cbxEmissionStandardEU;
        private System.Windows.Forms.Label labelEmissionStandardEU;
        private System.Windows.Forms.ComboBox cbxFuelType;
        private System.Windows.Forms.ComboBox cbxStoredProfile;
        private System.Windows.Forms.Label labelYearOfManufacture;
        private System.Windows.Forms.TextBox textBoxYearOfManufacture;
        private System.Windows.Forms.GroupBox gbxRoutingProfile;
        private System.Windows.Forms.TextBox tbxMaximumDistanceToSegment;
        private System.Windows.Forms.Label lblMaximumDistanceToSegment;
        private System.Windows.Forms.TextBox tbxOnlyReachableRoads;
        private System.Windows.Forms.Label lblOnlyReachableRoads;
        private System.Windows.Forms.TextBox tbxViolationsCost;
        private System.Windows.Forms.TextBox tbxViolationsEnabled;
        private System.Windows.Forms.Label lblViolationsEnabled;
        private System.Windows.Forms.TextBox tbxTollPenalty;
        private System.Windows.Forms.Label lblTollPenalty;
        private System.Windows.Forms.TextBox tbxDistanceTimeWeighting;
        private System.Windows.Forms.Label lblDistanceTimeWeighting;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWaypoints;
        private System.Windows.Forms.ToolStripMenuItem deleteItem;
        private System.Windows.Forms.Timer timerLocate;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabControl tbctrlRouteResults;
        private System.Windows.Forms.TabPage tabRouteSummary;
        private System.Windows.Forms.CheckBox cbxFLTruckAttributes;
        private System.Windows.Forms.TabControl tabControlVehicleProfile;
        private System.Windows.Forms.TabPage tabPagePhysical;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TabPage tabPageEngineEmissions;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.TextBox tbxWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox tbxTotalPermWeight;
        private System.Windows.Forms.Label lblTotalPermWeight;
        private System.Windows.Forms.TextBox tbxLoadWeight;
        private System.Windows.Forms.Label lblEmptyWeight;
        private System.Windows.Forms.Label lblLoadWeight;
        private System.Windows.Forms.TextBox tbxEmptyWeight;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.Label lblViolationsCost;
        private System.Windows.Forms.CheckBox cbxSegments;
        private System.Windows.Forms.CheckBox cbxFLSpeedPatterns;
        private System.Windows.Forms.CheckBox cbxFLTrafficIncidents;
        private System.Windows.Forms.GroupBox gbxRenderMap;
        private System.Windows.Forms.Button btnRenewMap;
        private System.Windows.Forms.ListBox lbxMapFeatureLayer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox cbxTollSections;
        private System.Windows.Forms.Label lblStartY;
        private System.Windows.Forms.Label lblStartX;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox tbxDestY;
        private System.Windows.Forms.TextBox tbxDestX;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.TextBox tbxStartY;
        private System.Windows.Forms.TextBox tbxStartX;
        private System.Windows.Forms.ComboBox cbxCoordFormat;
        private System.Windows.Forms.CheckBox cbxFLGenTruckRestr;
        private System.Windows.Forms.TextBox tbxDeliveryOnlyGateCost;
        private System.Windows.Forms.Label lblDeliveryOnlyGateCost;
        private System.Windows.Forms.TextBox tbxDeliveryOnlyPenalty;
        private System.Windows.Forms.Label lblDeliveryOnlyPenalty;
        private System.Windows.Forms.TextBox tbxForbiddenLEZPenal;
        private System.Windows.Forms.Label lblForbiddenLEZPenal;
        private System.Windows.Forms.TextBox tbxMinimumUrbanNetworkClass;
        private System.Windows.Forms.Label lblMinimumUrbanNetworkClass;
        private System.Windows.Forms.TextBox tbxUrbanPenalty;
        private System.Windows.Forms.Label lblUrbanPenalty;
        private System.Windows.Forms.TextBox tbxResidentsOnlyPenalty;
        private System.Windows.Forms.Label lblResidentsOnlyPenalty;
        private System.Windows.Forms.GroupBox gbxRoutingOptions;
        private System.Windows.Forms.Label lblFeatureLayers;
        private System.Windows.Forms.CheckBox cbxTollSystems;
        private System.Windows.Forms.CheckBox cbxLegs;
        private System.Windows.Forms.CheckBox cbxTollCalculation;
        private System.Windows.Forms.CheckBox cbxPolyline;
        private System.Windows.Forms.CheckBox cbxFeatureThemeIds;
        private System.Windows.Forms.CheckBox cbxRoadAttributes;
        private System.Windows.Forms.CheckBox cbxDescriptors;
        private System.Windows.Forms.ComboBox cbxLoadType;
        private System.Windows.Forms.BindingSource loadBindingSource;
        private System.Windows.Forms.Label lblLoadType;
        private System.Windows.Forms.BindingSource loadBindingSource1;
        private System.Windows.Forms.ComboBox cbxHazardousGoodsType;
        private System.Windows.Forms.Label lblHazardousGoodsType;
        private System.Windows.Forms.ComboBox cbxTunnelRestrictionCode;
        private System.Windows.Forms.Label lblTunnelRestrictionCode;
        private System.Windows.Forms.CheckBox cbxIsEmergency;
        private System.Windows.Forms.CheckBox cbxIsDelivery;
        private System.Windows.Forms.Button btnClearCoordinates;
        private System.Windows.Forms.Button btnSwitchStartDest;
        private System.Windows.Forms.ComboBox cbxMapProfile;
        private System.Windows.Forms.CheckBox cbxOnlyReachableRoads;
        private System.Windows.Forms.TextBox tbxNetworkClassPenalties;
        private System.Windows.Forms.Label lblPenaltiesByNetworkClass;
        private System.Windows.Forms.CheckBox cbxManipulateWpt;
        private System.Windows.Forms.TextBox tbxViaY;
        private System.Windows.Forms.TextBox tbxViaX;
        private System.Windows.Forms.TextBox tbxRadiusValue;
        private System.Windows.Forms.Label lblRadiusPoint;
        private System.Windows.Forms.GroupBox gbxRouteOptions;
        private System.Windows.Forms.Label lblAllowedCountries;
        private System.Windows.Forms.TextBox tbxProhibitedCountries;
        private System.Windows.Forms.Label lblCoordFormat;
        private System.Windows.Forms.TextBox tbxAllowedCountries;
        private System.Windows.Forms.Label lblProhibitedCountries;
        private System.Windows.Forms.TabPage tabRouteSegments;
        private System.Windows.Forms.DataGridView dataGridRouteSegments;
        private System.Windows.Forms.BindingSource segmentBindingSource;
        public System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn violatedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combinedTransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn polylineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startNodeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn startNodeIndexSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endNodeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn endNodeIndexSpecifiedDataGridViewCheckBoxColumn;
    }
}

