namespace CoachManagement
{
    partial class frmTicketAdd
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
            this.checkedListBoxSeats = new System.Windows.Forms.CheckedListBox();
            this.txtPassengerId = new System.Windows.Forms.TextBox();
            this.txtTripId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSeachTrip = new System.Windows.Forms.Button();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchPassenger = new System.Windows.Forms.Button();
            this.txtDepart = new System.Windows.Forms.DateTimePicker();
            this.lbAddPassenger = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxSeats
            // 
            this.checkedListBoxSeats.CheckOnClick = true;
            this.checkedListBoxSeats.FormattingEnabled = true;
            this.checkedListBoxSeats.Location = new System.Drawing.Point(12, 189);
            this.checkedListBoxSeats.MultiColumn = true;
            this.checkedListBoxSeats.Name = "checkedListBoxSeats";
            this.checkedListBoxSeats.Size = new System.Drawing.Size(613, 130);
            this.checkedListBoxSeats.TabIndex = 0;
            // 
            // txtPassengerId
            // 
            this.txtPassengerId.Location = new System.Drawing.Point(411, 12);
            this.txtPassengerId.Name = "txtPassengerId";
            this.txtPassengerId.Size = new System.Drawing.Size(121, 23);
            this.txtPassengerId.TabIndex = 14;
            // 
            // txtTripId
            // 
            this.txtTripId.Location = new System.Drawing.Point(89, 12);
            this.txtTripId.Name = "txtTripId";
            this.txtTripId.Size = new System.Drawing.Size(121, 23);
            this.txtTripId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Passenger ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Trip ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Seats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(89, 41);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.ReadOnly = true;
            this.txtFrom.Size = new System.Drawing.Size(121, 23);
            this.txtFrom.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "To";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Depart Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Price";
            // 
            // btnSeachTrip
            // 
            this.btnSeachTrip.Location = new System.Drawing.Point(216, 12);
            this.btnSeachTrip.Name = "btnSeachTrip";
            this.btnSeachTrip.Size = new System.Drawing.Size(75, 23);
            this.btnSeachTrip.TabIndex = 20;
            this.btnSeachTrip.Text = "Search";
            this.btnSeachTrip.UseVisualStyleBackColor = true;
            this.btnSeachTrip.Click += new System.EventHandler(this.btnSeachTrip_Click);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(89, 70);
            this.txtTo.Name = "txtTo";
            this.txtTo.ReadOnly = true;
            this.txtTo.Size = new System.Drawing.Size(121, 23);
            this.txtTo.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(89, 128);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(121, 23);
            this.txtPrice.TabIndex = 15;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(411, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 23);
            this.txtName.TabIndex = 15;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(411, 70);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 23);
            this.txtPhone.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Phone";
            // 
            // btnSearchPassenger
            // 
            this.btnSearchPassenger.Location = new System.Drawing.Point(538, 12);
            this.btnSearchPassenger.Name = "btnSearchPassenger";
            this.btnSearchPassenger.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPassenger.TabIndex = 20;
            this.btnSearchPassenger.Text = "Search";
            this.btnSearchPassenger.UseVisualStyleBackColor = true;
            this.btnSearchPassenger.Click += new System.EventHandler(this.btnSearchPassenger_Click);
            // 
            // txtDepart
            // 
            this.txtDepart.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.txtDepart.Enabled = false;
            this.txtDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDepart.Location = new System.Drawing.Point(89, 99);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(148, 23);
            this.txtDepart.TabIndex = 21;
            // 
            // lbAddPassenger
            // 
            this.lbAddPassenger.AutoSize = true;
            this.lbAddPassenger.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAddPassenger.ForeColor = System.Drawing.Color.Red;
            this.lbAddPassenger.Location = new System.Drawing.Point(331, 109);
            this.lbAddPassenger.Name = "lbAddPassenger";
            this.lbAddPassenger.Size = new System.Drawing.Size(173, 13);
            this.lbAddPassenger.TabIndex = 19;
            this.lbAddPassenger.Text = "*A new passenger will be added";
            this.lbAddPassenger.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(344, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(216, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTicketAdd
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(637, 367);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.btnSearchPassenger);
            this.Controls.Add(this.btnSeachTrip);
            this.Controls.Add(this.txtPassengerId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTripId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAddPassenger);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxSeats);
            this.Name = "frmTicketAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBoxSeats;
        private TextBox txtPassengerId;
        private TextBox txtTripId;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtFrom;
        private Label label3;
        private Label label6;
        private Label label7;
        private Button btnSeachTrip;
        private TextBox txtTo;
        private TextBox txtPrice;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label label8;
        private Label label9;
        private Button btnSearchPassenger;
        private DateTimePicker txtDepart;
        private Label lbAddPassenger;
        private Button btnCancel;
        private Button btnSave;
    }
}