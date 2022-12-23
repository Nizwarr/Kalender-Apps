using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender
{
    public partial class EventForm : Form
    {
        //create connection string
        string connString = "server=localhost;user id=root;database=db_kalender;sslmode=none";
        //
        public static EventForm instance;
        public TextBox tb1;

        public EventForm()
        {
            InitializeComponent();
            tb1 = textBox1;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtanggal.Text = UserControlHari.static_hari + "/" + Form1.static_month + "/" + Form1.static_year;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            UserControlHari.instance.lba.Text = textBox1.Text.ToString();
        }

        private void tx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
