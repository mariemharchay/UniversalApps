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
using System.Windows.Shapes;
using WpfMaPremiereApplication.Models;

namespace WpfMaPremiereApplication
{
    /// <summary>
    /// Logique d'interaction pour Formulaire.xaml
    /// </summary>
    public partial class Formulaire : Window
    {

        List<PersonneTp> ListeDePersonne = new List<PersonneTp>();
        PersonneTp personneCree = new PersonneTp();
        public Formulaire()
        {
            InitializeComponent();
            DataContext = personneCree;
        }

        private void Button_ClickValidate(object sender, RoutedEventArgs e)
        {
            personneCree =(PersonneTp) DataContext;
            //personneCree.AjouterPersonne(personneCree);
            if ((personneCree.Age <= 18) & (personneCree.Age >= 100))
            {
                ListeDePersonne.Add(personneCree);
            }
            else MessageBox.Show("Il faut saisir un age correct");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


        }
    }
}
