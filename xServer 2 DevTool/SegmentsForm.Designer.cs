namespace xS2Development
{
    partial class SegmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SegmentsForm));
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewSegments = new System.Windows.Forms.DataGridView();
            this.violatedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.travelSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travelTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.endNodeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.startNodeIndexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combinedTransportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attributesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polylineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSegments)).BeginInit();
            this.SuspendLayout();
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(xS2Development.xRouteWSService.Segment);
            // 
            // dataGridViewSegments
            // 
            this.dataGridViewSegments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSegments.AutoGenerateColumns = false;
            this.dataGridViewSegments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSegments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.polylineDataGridViewTextBoxColumn,
            this.attributesDataGridViewTextBoxColumn,
            this.combinedTransportDataGridViewTextBoxColumn,
            this.emissionsDataGridViewTextBoxColumn,
            this.startNodeIndexDataGridViewTextBoxColumn,
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn,
            this.endNodeIndexDataGridViewTextBoxColumn,
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.travelTimeDataGridViewTextBoxColumn,
            this.travelSpeedDataGridViewTextBoxColumn,
            this.violatedDataGridViewCheckBoxColumn});
            this.dataGridViewSegments.DataSource = this.segmentBindingSource;
            this.dataGridViewSegments.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewSegments.Name = "dataGridViewSegments";
            this.dataGridViewSegments.Size = new System.Drawing.Size(1144, 222);
            this.dataGridViewSegments.TabIndex = 24;
            // 
            // violatedDataGridViewCheckBoxColumn
            // 
            this.violatedDataGridViewCheckBoxColumn.DataPropertyName = "violated";
            this.violatedDataGridViewCheckBoxColumn.HeaderText = "violated";
            this.violatedDataGridViewCheckBoxColumn.Name = "violatedDataGridViewCheckBoxColumn";
            // 
            // travelSpeedDataGridViewTextBoxColumn
            // 
            this.travelSpeedDataGridViewTextBoxColumn.DataPropertyName = "travelSpeed";
            this.travelSpeedDataGridViewTextBoxColumn.HeaderText = "travelSpeed";
            this.travelSpeedDataGridViewTextBoxColumn.Name = "travelSpeedDataGridViewTextBoxColumn";
            // 
            // travelTimeDataGridViewTextBoxColumn
            // 
            this.travelTimeDataGridViewTextBoxColumn.DataPropertyName = "travelTime";
            this.travelTimeDataGridViewTextBoxColumn.HeaderText = "travelTime";
            this.travelTimeDataGridViewTextBoxColumn.Name = "travelTimeDataGridViewTextBoxColumn";
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // endNodeIndexSpecifiedDataGridViewCheckBoxColumn
            // 
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "endNodeIndexSpecified";
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn.HeaderText = "endNodeIndexSpecified";
            this.endNodeIndexSpecifiedDataGridViewCheckBoxColumn.Name = "endNodeIndexSpecifiedDataGridViewCheckBoxColumn";
            // 
            // endNodeIndexDataGridViewTextBoxColumn
            // 
            this.endNodeIndexDataGridViewTextBoxColumn.DataPropertyName = "endNodeIndex";
            this.endNodeIndexDataGridViewTextBoxColumn.HeaderText = "endNodeIndex";
            this.endNodeIndexDataGridViewTextBoxColumn.Name = "endNodeIndexDataGridViewTextBoxColumn";
            // 
            // startNodeIndexSpecifiedDataGridViewCheckBoxColumn
            // 
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn.DataPropertyName = "startNodeIndexSpecified";
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn.HeaderText = "startNodeIndexSpecified";
            this.startNodeIndexSpecifiedDataGridViewCheckBoxColumn.Name = "startNodeIndexSpecifiedDataGridViewCheckBoxColumn";
            // 
            // startNodeIndexDataGridViewTextBoxColumn
            // 
            this.startNodeIndexDataGridViewTextBoxColumn.DataPropertyName = "startNodeIndex";
            this.startNodeIndexDataGridViewTextBoxColumn.HeaderText = "startNodeIndex";
            this.startNodeIndexDataGridViewTextBoxColumn.Name = "startNodeIndexDataGridViewTextBoxColumn";
            // 
            // emissionsDataGridViewTextBoxColumn
            // 
            this.emissionsDataGridViewTextBoxColumn.DataPropertyName = "emissions";
            this.emissionsDataGridViewTextBoxColumn.HeaderText = "emissions";
            this.emissionsDataGridViewTextBoxColumn.Name = "emissionsDataGridViewTextBoxColumn";
            // 
            // combinedTransportDataGridViewTextBoxColumn
            // 
            this.combinedTransportDataGridViewTextBoxColumn.DataPropertyName = "combinedTransport";
            this.combinedTransportDataGridViewTextBoxColumn.HeaderText = "combinedTransport";
            this.combinedTransportDataGridViewTextBoxColumn.Name = "combinedTransportDataGridViewTextBoxColumn";
            // 
            // attributesDataGridViewTextBoxColumn
            // 
            this.attributesDataGridViewTextBoxColumn.DataPropertyName = "attributes";
            this.attributesDataGridViewTextBoxColumn.HeaderText = "attributes";
            this.attributesDataGridViewTextBoxColumn.Name = "attributesDataGridViewTextBoxColumn";
            // 
            // polylineDataGridViewTextBoxColumn
            // 
            this.polylineDataGridViewTextBoxColumn.DataPropertyName = "polyline";
            this.polylineDataGridViewTextBoxColumn.HeaderText = "polyline";
            this.polylineDataGridViewTextBoxColumn.Name = "polylineDataGridViewTextBoxColumn";
            // 
            // SegmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 246);
            this.Controls.Add(this.dataGridViewSegments);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SegmentsForm";
            this.Text = "SegmentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSegments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource segmentBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewSegments;
        private System.Windows.Forms.DataGridViewTextBoxColumn polylineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attributesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combinedTransportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startNodeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn startNodeIndexSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endNodeIndexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn endNodeIndexSpecifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn travelSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn violatedDataGridViewCheckBoxColumn;
    }
}