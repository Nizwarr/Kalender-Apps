using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalender
{
    public partial class Form1 : Form
    {
        int month, year;
        public static int static_month, static_year;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            displayHari();
        }
        private void displayHari()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string namabulan = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtanggal.Text = namabulan + " " + year;


            static_month = month;
            static_year = year;

            //First day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //Get the count of days 
            int days = DateTime.DaysInMonth(year, month);
            
            //Convert to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //Usercontrol blank
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                containerhari.Controls.Add(ucblank);
            }

            //Usercontrol for day
            for (int i = 1; i <= days; i++)
            {
                UserControlHari uchari = new UserControlHari();
                uchari.days(i);
                containerhari.Controls.Add(uchari);
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //clear container
            containerhari.Controls.Clear();

            //previous month
            if (month == 1)
            {
                month = 13;
                year--;
            }
            month--;
            static_month = month;
            static_year = year;
            string namabulan = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtanggal.Text = namabulan + " " + year;

            //First day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //Get the count of days 
            int days = DateTime.DaysInMonth(year, month);

            //Convert to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //Usercontrol blank
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                containerhari.Controls.Add(ucblank);
            }

            //Usercontrol for day
            for (int i = 1; i <= days; i++)
            {
                UserControlHari uchari = new UserControlHari();
                uchari.days(i);
                containerhari.Controls.Add(uchari);
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //clear container
            containerhari.Controls.Clear();

            //next month
            if (month == 12)
            {
                month = 0;
                year++;
            }
            month++;
            static_month = month;
            static_year = year;
            string namabulan = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbtanggal.Text = namabulan + " " + year;

            //First day of the month
            DateTime startofthemonth = new DateTime(year, month, 1);

            //Get the count of days 
            int days = DateTime.DaysInMonth(year, month);

            //Convert to integer
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;

            //Usercontrol blank
            for (int i = 1; i < dayoftheweek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                containerhari.Controls.Add(ucblank);
            }

            //Usercontrol for day
            for (int i = 1; i <= days; i++)
            {
                UserControlHari uchari = new UserControlHari();
                uchari.days(i);
                containerhari.Controls.Add(uchari);
            }
        }
    }
}
