namespace CoachManagement
{
    partial class frmCoach
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbNumberPlate = new System.Windows.Forms.Label();
            this.dgvCoachs = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(529, 30);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(121, 23);
            this.txtBrand.TabIndex = 14;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(176, 59);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(121, 23);
            this.txtSeat.TabIndex = 12;
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(176, 30);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(121, 23);
            this.txtNumberPlate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Location";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Location = new System.Drawing.Point(400, 33);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(38, 15);
            this.lbBrand.TabIndex = 17;
            this.lbBrand.Text = "Brand";
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(61, 62);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(29, 15);
            this.lbSeat.TabIndex = 19;
            this.lbSeat.Text = "Seat";
            // 
            // lbNumberPlate
            // 
            this.lbNumberPlate.AutoSize = true;
            this.lbNumberPlate.Location = new System.Drawing.Point(61, 33);
            this.lbNumberPlate.Name = "lbNumberPlate";
            this.lbNumberPlate.Size = new System.Drawing.Size(80, 15);
            this.lbNumberPlate.TabIndex = 20;
            this.lbNumberPlate.Text = "Number Plate";
            // 
            // dgvCoachs
            // 
            this.dgvCoachs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoachs.Location = new System.Drawing.Point(12, 220);
            this.dgvCoachs.Name = "dgvCoachs";
            this.dgvCoachs.ReadOnly = true;
            this.dgvCoachs.RowTemplate.Height = 25;
            this.dgvCoachs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoachs.Size = new System.Drawing.Size(724, 198);
            this.dgvCoachs.TabIndex = 21;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(608, 182);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 25;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 182);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 182);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 23);
            this.txtSearch.TabIndex = 22;
            // 
            // cbFilter
            // 
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(481, 182);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(121, 23);
            this.cbFilter.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(406, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(269, 110);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 26;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(529, 59);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(121, 23);
            this.txtLocation.TabIndex = 28;
            // 
            // frmCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 442);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.dgvCoachs);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.lbSeat);
            this.Controls.Add(this.lbNumberPlate);
            this.Name = "frmCoach";
            this.Text = "Coach";
            this.Load += new System.EventHandler(this.frmCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoachs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBrand;
        private TextBox txtSeat;
        private TextBox txtNumberPlate;
        private Label label5;
        private Label lbBrand;
        private Label lbSeat;
        private Label lbNumberPlate;
        private DataGridView dgvCoachs;
        private Button btnFilter;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbFilter;
        private Button btnDelete;
        private Button btnNew;
        private TextBox txtLocation;
    }
}