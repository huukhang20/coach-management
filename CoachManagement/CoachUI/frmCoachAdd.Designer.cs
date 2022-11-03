namespace CoachManagement.CoachUI
{
    partial class frmCoachAdd
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtSeat = new System.Windows.Forms.TextBox();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSeat = new System.Windows.Forms.Label();
            this.lbNumberPlate = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(278, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(148, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(331, 12);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(121, 23);
            this.txtBrand.TabIndex = 25;
            // 
            // txtSeat
            // 
            this.txtSeat.Location = new System.Drawing.Point(104, 41);
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.Size = new System.Drawing.Size(121, 23);
            this.txtSeat.TabIndex = 23;
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(104, 12);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(121, 23);
            this.txtNumberPlate.TabIndex = 22;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(244, 44);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(53, 15);
            this.lbLocation.TabIndex = 27;
            this.lbLocation.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Brand";
            // 
            // lbSeat
            // 
            this.lbSeat.AutoSize = true;
            this.lbSeat.Location = new System.Drawing.Point(18, 44);
            this.lbSeat.Name = "lbSeat";
            this.lbSeat.Size = new System.Drawing.Size(29, 15);
            this.lbSeat.TabIndex = 30;
            this.lbSeat.Text = "Seat";
            // 
            // lbNumberPlate
            // 
            this.lbNumberPlate.AutoSize = true;
            this.lbNumberPlate.Location = new System.Drawing.Point(18, 15);
            this.lbNumberPlate.Name = "lbNumberPlate";
            this.lbNumberPlate.Size = new System.Drawing.Size(80, 15);
            this.lbNumberPlate.TabIndex = 31;
            this.lbNumberPlate.Text = "Number Plate";
            // 
            // txtLocation
            // 
            this.txtLocation.FormattingEnabled = true;
            this.txtLocation.Location = new System.Drawing.Point(331, 41);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(150, 23);
            this.txtLocation.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.AutoCheck = false;
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(104, 74);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(59, 19);
            this.cbStatus.TabIndex = 34;
            this.cbStatus.Text = "Active";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // frmCoachAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(506, 154);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSeat);
            this.Controls.Add(this.lbNumberPlate);
            this.Name = "frmCoachAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Coach";
            this.Load += new System.EventHandler(this.frmCoachAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtBrand;
        private TextBox txtSeat;
        private TextBox txtNumberPlate;
        private Label lbLocation;
        private Label label4;
        private Label lbSeat;
        private Label lbNumberPlate;
        private ComboBox txtLocation;
        private Label label1;
        private CheckBox cbStatus;
    }
}