﻿namespace CoachManagement.TripUI
{
    partial class frmTripAdd
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
            this.txtDepart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTripId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.ComboBox();
            this.txtNumberPlate = new System.Windows.Forms.ComboBox();
            this.btnDepart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepart
            // 
            this.txtDepart.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.txtDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDepart.Location = new System.Drawing.Point(405, 12);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(148, 23);
            this.txtDepart.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 32;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(325, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Depart Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 36;
            this.label1.Text = "From";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "Status";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(405, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 23);
            this.txtPrice.TabIndex = 6;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "NotDepart",
            "Departed",
            "Completed",
            "Canceled"});
            this.cbStatus.Location = new System.Drawing.Point(405, 70);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 23);
            this.cbStatus.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(336, 153);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 45;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(197, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 15);
            this.label2.TabIndex = 47;
            this.label2.Text = "Number Plate";
            // 
            // txtTripId
            // 
            this.txtTripId.Location = new System.Drawing.Point(125, 12);
            this.txtTripId.Name = "txtTripId";
            this.txtTripId.ReadOnly = true;
            this.txtTripId.Size = new System.Drawing.Size(121, 23);
            this.txtTripId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 49;
            this.label4.Text = "Trip ID";
            // 
            // txtFrom
            // 
            this.txtFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFrom.FormattingEnabled = true;
            this.txtFrom.Location = new System.Drawing.Point(125, 41);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(165, 23);
            this.txtFrom.TabIndex = 2;
            // 
            // txtTo
            // 
            this.txtTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Location = new System.Drawing.Point(125, 70);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(165, 23);
            this.txtTo.TabIndex = 3;
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.FormattingEnabled = true;
            this.txtNumberPlate.Location = new System.Drawing.Point(125, 99);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(121, 23);
            this.txtNumberPlate.TabIndex = 4;
            // 
            // btnDepart
            // 
            this.btnDepart.Location = new System.Drawing.Point(451, 102);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(75, 23);
            this.btnDepart.TabIndex = 50;
            this.btnDepart.Text = "Depart";
            this.btnDepart.UseVisualStyleBackColor = true;
            this.btnDepart.Visible = false;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // frmTripAdd
            // 
            this.AcceptButton = this.btnCancel;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(587, 210);
            this.Controls.Add(this.btnDepart);
            this.Controls.Add(this.txtTripId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDepart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Name = "frmTripAdd";
            this.Text = "Add Trip";
            this.Load += new System.EventHandler(this.frmTripAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker txtDepart;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label9;
        private TextBox txtPrice;
        private ComboBox cbStatus;
        private Button btnCancel;
        private Button btnSave;
        private Label label2;
        private TextBox txtTripId;
        private Label label4;
        private ComboBox txtFrom;
        private ComboBox txtTo;
        private ComboBox txtNumberPlate;
        private Button btnDepart;
    }
}