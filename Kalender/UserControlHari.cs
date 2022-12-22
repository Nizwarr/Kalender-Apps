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
        public UserControlHari()
        {
            InitializeComponent();
        }

        private void UserControlHari_Load(object sender, EventArgs e)
        {

        }
        public void days(int numday)
        {
            lbhari.Text = numday + "";
        }
    }
}
