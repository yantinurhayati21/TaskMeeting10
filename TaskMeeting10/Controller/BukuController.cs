using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskMeeting10.Controller
{
    internal class BukuController:Model.Coonection
    {
        public DataTable tampilBuku()
        {
            DataTable dataBuku = new DataTable();
            try
            {
                string tampilBuku = "SELECT * FROM buku";
                da = new MySqlConnector.MySqlDataAdapter(tampilBuku, GetConn());
                da.Fill(dataBuku);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataBuku;
        }
    }
}
