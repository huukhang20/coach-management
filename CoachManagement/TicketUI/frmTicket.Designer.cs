namespace CoachManagement
{
    partial class frmTicket
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
            this.dgvTickets = new System.Windows.Forms.DataGridView();
            this.txtSeatNum = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPassengerId = new System.Windows.Forms.TextBox();
            this.btnReceipe = new System.Windows.Forms.Button();
            this.txtSearchTrip = new System.Windows.Forms.TextBox();
            this.txtSearchPassenger = new System.Windows.Forms.TextBox();
            this.txtTripId = new System.Windows.Forms.TextBox();
            this.txtBookTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTickets
            // 
            this.dgvTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTickets.Location = new System.Drawing.Point(12, 208);
            this.dgvTickets.Name = "dgvTickets";
            this.dgvTickets.ReadOnly = true;
            this.dgvTickets.RowTemplate.Height = 25;
            this.dgvTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTickets.Size = new System.Drawing.Size(724, 198);
            this.dgvTickets.TabIndex = 12;
            // 
            // txtSeatNum
            // 
            this.txtSeatNum.Location = new System.Drawing.Point(157, 70);
            this.txtSeatNum.Name = "txtSeatNum";
            this.txtSeatNum.Size = new System.Drawing.Size(146, 23);
            this.txtSeatNum.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(157, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 23);
            this.txtId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Passenger ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Trip ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Booking Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seat Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(244, 108);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(381, 108);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(225, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPassengerId
            // 
            this.txtPassengerId.Location = new System.Drawing.Point(510, 41);
            this.txtPassengerId.Name = "txtPassengerId";
            this.txtPassengerId.Size = new System.Drawing.Size(121, 23);
            this.txtPassengerId.TabIndex = 4;
            // 
            // btnReceipe
            // 
            this.btnReceipe.Location = new System.Drawing.Point(581, 155);
            this.btnReceipe.Name = "btnReceipe";
            this.btnReceipe.Size = new System.Drawing.Size(75, 23);
            this.btnReceipe.TabIndex = 11;
            this.btnReceipe.Text = "Receipe";
            this.btnReceipe.UseVisualStyleBackColor = true;
            this.btnReceipe.Click += new System.EventHandler(this.btnReceipe_Click);
            // 
            // txtSearchTrip
            // 
            this.txtSearchTrip.Location = new System.Drawing.Point(13, 156);
            this.txtSearchTrip.Name = "txtSearchTrip";
            this.txtSearchTrip.PlaceholderText = "Trip ID";
            this.txtSearchTrip.Size = new System.Drawing.Size(100, 23);
            this.txtSearchTrip.TabIndex = 8;
            // 
            // txtSearchPassenger
            // 
            this.txtSearchPassenger.Location = new System.Drawing.Point(119, 156);
            this.txtSearchPassenger.Name = "txtSearchPassenger";
            this.txtSearchPassenger.PlaceholderText = "Passenger ID";
            this.txtSearchPassenger.Size = new System.Drawing.Size(100, 23);
            this.txtSearchPassenger.TabIndex = 9;
            // 
            // txtTripId
            // 
            this.txtTripId.Location = new System.Drawing.Point(510, 12);
            this.txtTripId.Name = "txtTripId";
            this.txtTripId.Size = new System.Drawing.Size(121, 23);
            this.txtTripId.TabIndex = 4;
            // 
            // txtBookTime
            // 
            this.txtBookTime.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.txtBookTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtBookTime.Location = new System.Drawing.Point(157, 41);
            this.txtBookTime.Name = "txtBookTime";
            this.txtBookTime.Size = new System.Drawing.Size(146, 23);
            this.txtBookTime.TabIndex = 13;
            // 
            // frmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 442);
            this.Controls.Add(this.txtBookTime);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReceipe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchTrip);
            this.Controls.Add(this.txtSearchPassenger);
            this.Controls.Add(this.dgvTickets);
            this.Controls.Add(this.txtPassengerId);
            this.Controls.Add(this.txtTripId);
            this.Controls.Add(this.txtSeatNum);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTicket";
            this.Text = "Ticket List";
            this.Load += new System.EventHandler(this.frmDriver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView dgvTickets;
        private TextBox txtSeatNum;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnNew;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtPassengerId;
        private Button btnReceipe;
        private TextBox txtSearchTrip;
        private TextBox txtSearchPassenger;
        private TextBox txtTripId;
        private DateTimePicker txtBookTime;
    }
}