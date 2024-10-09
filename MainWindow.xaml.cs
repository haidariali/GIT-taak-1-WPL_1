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

namespace film_app_project_code_ali
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DateTime lastClickTime;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void imgdune2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeBetweenClicks = now - lastClickTime;

            if (timeBetweenClicks.TotalMilliseconds <= 500) // 500 ms voor een dubbele klik omdat er geeen doublecklike optie voor een afbeelding bestaat dus doe ik op deze manier 
            {
                
                beschrijvingVanFilms.Text = "Dune: Part Two\r\nPaul Atreides unites with Chani and the Fremen while seeking revenge against the conspirators who destroyed his family.\r\n";
            }

            lastClickTime = now;
        }

        private void imgthesubstance_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeBetweenClicks = now - lastClickTime;

            if (timeBetweenClicks.TotalMilliseconds <= 500) 
            {

                beschrijvingVanFilms.Text = "The Substance\r\nA fading celebrity decides to use a black-market drug, a cell-replicating substance that temporarily creates a younger, better version of herself.\r\n";
            }

            lastClickTime = now;
        }

        private void imgforiosa_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTime now = DateTime.Now;
            TimeSpan timeBetweenClicks = now - lastClickTime;

            if (timeBetweenClicks.TotalMilliseconds <= 500)
            {

                beschrijvingVanFilms.Text = "Furiosa: A Mad Max Saga\r\nThe origin story of renegade warrior Furiosa before her encounter and teamup with Mad Max.";
            }

            lastClickTime = now;
        }
    }
}
