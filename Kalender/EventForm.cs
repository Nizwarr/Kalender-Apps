using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqliClient;

namespace Kalender
{
    public partial class EventForm : Form
    {
        //create connection string
        string connString = "server=localhost;user id=root;database=db_kalender;sslmode=none";
        //

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            string sql = "INSERT INTO tbl_kalender(date,event)values(?,?)";
            MysqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("tanggal",txtanggal.Text);
            cmd.Parameters.AddWithValue("acara", txacara.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil tersimpan");
            cmd.Dispose();
            conn.Close();
        }
    }
}
