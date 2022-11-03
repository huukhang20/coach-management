using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoachManagement.TicketUI
{
    public partial class frmTickertDetail : Form
    {
        Ticket? ticket = new Ticket();

        ITicketRepository ticketRepository = new TicketRepository();

        IPassengerRepository passengerRepository = new PassengerRepository();  

        ITripRepository tripRepository = new TripRepository();

        PrintDocument printdoc1 = new PrintDocument();
        
        PrintPreviewDialog previewdlg = new PrintPreviewDialog();
        
        Panel pannel = null;

        public frmTickertDetail(Ticket? ticket)
        {
            InitializeComponent();
            this.ticket = ticket;
            printdoc1.PrintPage += new PrintPageEventHandler(printdoc1_PrintPage);
        }

        private void frmTickertDetail_Load(object sender, EventArgs e)
        {
            if (ticket != null)
            {
                Passenger? passenger = passengerRepository.GetById(ticket.PassengerId);    
                Trip? trip = tripRepository.GetById(ticket.TripId);

                txtPassengerName.Text = passenger.Name;
                txtTicketID.Text = ticket.Id.ToString();
                txtFrom.Text = trip.From;
                txtTo.Text = trip.To;
                txtSeatNumber.Text = ticket.SeatNumber.ToString();
                txtNumberPlate.Text = trip.NumberPlate;
                txtDepartTime.Text = trip.DepartTime.ToString();
                txtPrice.Text = trip.Price.ToString();  
            }
        }

        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (MemoryImage != null)
            {
                e.Graphics.DrawImage(MemoryImage, 0, 0);
                base.OnPaint(e);
            }
        }
        void printdoc1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.pnBody.Width / 2), this.pnBody.Location.Y);
        }
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            previewdlg.Document = printdoc1;
            previewdlg.ShowDialog();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Print(pnBody);
        }
    }
}
