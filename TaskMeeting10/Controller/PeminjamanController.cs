using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMeeting10.Controller
{
    internal class PeminjamanController:Model.Coonection
    {
        public DataTable tampilPeminjaman()
        {
            DataTable dataPeminjaman = new DataTable();
            try
            {
                string tampilPeminjaman = "SELECT * FROM peminjaman";
                da = new MySqlConnector.MySqlDataAdapter(tampilPeminjaman, GetConn());
                da.Fill(dataPeminjaman);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataPeminjaman;
        }
    }
}
