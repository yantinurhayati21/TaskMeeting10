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
    public partial class Anggota : Form
    {
        private AnggotaController anggotaController;
        public Anggota()
        {
            anggotaController = new AnggotaController();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            segarkanAnggota();
        }

        public void segarkanAnggota()
        {
            dataGridViewAnggota.DataSource = anggotaController.tampilAnggota();
            dataGridViewAnggota.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        
    }
}
