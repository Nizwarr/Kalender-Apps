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
    public partial class UserControlHari : UserControl
    {
        public static string static_hari;
        public static UserControlHari instance;
        public Label lba;

        public UserControlHari()
        {
            InitializeComponent();
            lba = lbacara;
        }

        private void UserControlHari_Load(object sender, EventArgs e)
        {
            //lbacara = EventForm.instance.tb1.Text.ToString();
        }
        public void days(int numday)
        {
            lbhari.Text = numday + "";
        }

        private void UserControlHari_Click(object sender, EventArgs e)
        {
            static_hari = lbhari.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }

    }
}
