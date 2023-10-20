using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMeeting10.Controller
{
    internal class AnggotaController:Model.Coonection
    {
        public DataTable tampilAnggota()
        {
            DataTable dataAnggota = new DataTable();
            try
            {
                string tampilAnggota = "SELECT * FROM anggota";
                da = new MySqlConnector.MySqlDataAdapter(tampilAnggota, GetConn());
                da.Fill(dataAnggota);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataAnggota;
        }
    }
}
