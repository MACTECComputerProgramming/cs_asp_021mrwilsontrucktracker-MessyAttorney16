using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _021_Challenge
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        
       

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //driver name
            string name = string.Format("Driver - {0}", textName.Text);
            nameLabel.Content = name;

            //SSN
            int ss = int.Parse(textSS.Text);
            string SS = string.Format("Social Security Number: {0:000-00-0000}", ss);
            SSlabel.Content = SS;

            //phone #
            int pNumber = int.Parse(textPhone.Text);
            string phone = string.Format("Phone Number: {0:(000)000-0000}", pNumber);
            phoneLabel.Content = phone;

            //driver distance
            int sMiles, eMiles;

            sMiles = Convert.ToInt32(textStartMiles.Text);
            eMiles = Convert.ToInt32(textEndMiles.Text);

            totalMileLabel.Content = "Total Miles: " + (eMiles - sMiles);

            //total pay
            int tMiles = eMiles - sMiles;
            double tPay = 0;
                        
            if (checkRefrigerated.IsChecked == true)
            {
                tPay = tMiles * .37;
            }
            else
            {
                tPay = tMiles * .25;
            }

            string pay = string.Format("Total Pay: ${0}", tPay);
            payLabel.Content = pay;

            //days out
            DateTime dayLeft = (DateTime)calendarLeft.SelectedDate, dayReturn = (DateTime)calendarReturn.SelectedDate;
            TimeSpan daysOut = dayReturn - dayLeft;

            string outDays = string.Format("Number of Days Out: {0}", daysOut.TotalDays);
            daysOutLabel.Content = outDays;

            //vaca days

            double vacaDays = 0;

            int timeSpan = int.Parse(daysOut.TotalDays.ToString());

            vacaDays = ((timeSpan - (timeSpan % 5)) / 5) * 2;

            vacationDaysLabel.Content = "Days of Vacation Earned: " + vacaDays;
            


        }
    }
}
