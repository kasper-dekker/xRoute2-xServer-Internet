namespace xS2Development
{
    partial class SearchResultsWithScore
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
            this.dataGridViewFieldScores = new System.Windows.Forms.DataGridView();
            this.matchQualityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceFieldScores = new System.Windows.Forms.BindingSource(this.components);
            this.countryScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalCodeScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNumberScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFieldScores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchQualityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFieldScores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFieldScores
            // 
            this.dataGridViewFieldScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFieldScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryScore,
            this.stateScore,
            this.postalCodeScore,
            this.cityScore,
            this.streetScore,
            this.houseNumberScore});
            this.dataGridViewFieldScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFieldScores.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFieldScores.Name = "dataGridViewFieldScores";
            this.dataGridViewFieldScores.Size = new System.Drawing.Size(654, 55);
            this.dataGridViewFieldScores.TabIndex = 0;
            // 
            // matchQualityBindingSource
            // 
            //this.matchQualityBindingSource.DataSource = typeof(xS2Development.xLocateWSService.MatchQuality);
            // 
            // bindingSourceFieldScores
            // 
            //this.bindingSourceFieldScores.DataSource = typeof(xS2Development.xLocateWSService.FieldScore);
            // 
            // countryScore
            // 
            this.countryScore.HeaderText = "Country";
            this.countryScore.Name = "countryScore";
            // 
            // stateScore
            // 
            this.stateScore.HeaderText = "State";
            this.stateScore.Name = "stateScore";
            // 
            // postalCodeScore
            // 
            this.postalCodeScore.HeaderText = "Postalcode";
            this.postalCodeScore.Name = "postalCodeScore";
            // 
            // cityScore
            // 
            this.cityScore.HeaderText = "City";
            this.cityScore.Name = "cityScore";
            // 
            // streetScore
            // 
            this.streetScore.HeaderText = "Street";
            this.streetScore.Name = "streetScore";
            // 
            // houseNumberScore
            // 
            this.houseNumberScore.HeaderText = "Housenumber";
            this.houseNumberScore.Name = "houseNumberScore";
            // 
            // SearchResultsWithScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 55);
            this.Controls.Add(this.dataGridViewFieldScores);
            this.Name = "SearchResultsWithScore";
            this.Text = "SearchResultsWithScore";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFieldScores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchQualityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFieldScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFieldScores;
        private System.Windows.Forms.BindingSource matchQualityBindingSource;
        private System.Windows.Forms.BindingSource bindingSourceFieldScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalCodeScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNumberScore;
    }
}