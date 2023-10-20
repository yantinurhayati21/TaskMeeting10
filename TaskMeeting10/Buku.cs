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
    public partial class Buku : Form
    {
        private BukuController bukuController;
        public Buku()
        {
            bukuController = new BukuController();
            InitializeComponent();
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            segarkanBuku();
        }
        private void segarkanBuku()
        {
            dataGridViewBuku.DataSource = bukuController.tampilBuku();
            dataGridViewBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
