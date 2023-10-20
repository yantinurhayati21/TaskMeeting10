using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMeeting10.Controller;

namespace TaskMeeting10
{
    public partial class Peminjaman : Form
    {
       private PeminjamanController peminjamanController;
        public Peminjaman()
        {
            peminjamanController = new PeminjamanController();
            InitializeComponent();
        }

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            segarkanPeminjaman();
        }
        private void segarkanPeminjaman()
        {
            dataGridViewPeminjaman.DataSource = peminjamanController.tampilPeminjaman();
            dataGridViewPeminjaman.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
