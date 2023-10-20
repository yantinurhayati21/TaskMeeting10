using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMeeting10.Controller
{
    internal class PegawaiController:Model.Coonection
    {
        public DataTable tampilPegawai()
        {
            DataTable dataPegawai = new DataTable();
            try
            {
                string tampilPegawai = "SELECT * FROM pegawai";
                da = new MySqlConnector.MySqlDataAdapter(tampilPegawai, GetConn());
                da.Fill(dataPegawai);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataPegawai;
        }
    }
}
