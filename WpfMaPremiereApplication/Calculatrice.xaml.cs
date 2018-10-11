using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace WpfMaPremiereApplication
{
   
    /// <summary>
    /// Logique d'interaction pour Calsulatrice.xaml
    /// </summary>
    public partial class Calsulatrice : Window
    {
        public Calsulatrice()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {  montexte.Text = null; }
          
        private void Button_Clicknombre(object sender, RoutedEventArgs e)
        {
            
            var monboutton = (string)(sender as Button).Content;
            montexte.Text = montexte.Text + monboutton;
            
        }

        private void Button_Clickopertion(object sender, RoutedEventArgs e)
        {
            var monbouttonop = (string)(sender as Button).Content;
            montexte.Text = montexte.Text + monbouttonop;
            

        }

        private void Button_ClickEqual(object sender, RoutedEventArgs e)
        {

            string tobeComputed = montexte.Text;
            DataTable dt = new DataTable();
            var answer = dt.Compute(tobeComputed, "");
            montexte.Text = answer.ToString().Replace(',', '.');

        }
    }
}
