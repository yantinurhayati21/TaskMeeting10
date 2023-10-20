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
    public partial class Pegawai : Form
    {
        private PegawaiController pegawaiController;
        public Pegawai()
        {
            pegawaiController = new PegawaiController();
            InitializeComponent();
        }

        private void Pegawai_Load(object sender, EventArgs e)
        {
            segarkanPegawai();
        }

        private void segarkanPegawai()
        {
            dataGridViewPegawai.DataSource = pegawaiController.tampilPegawai();
            dataGridViewPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
