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

namespace WpfApplicationBoule
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TextBlock _textBlock2 = new TextBlock() { Text = "" };
        public MainWindow()
        {
            
            InitializeComponent();
            var _grid = new Grid();
            RowDefinitionCollection mesLignes = _grid.RowDefinitions;
            mesLignes.Add(new RowDefinition() { Height = new GridLength(40, GridUnitType.Star) });
            mesLignes.Add(new RowDefinition() { Height = new GridLength(20, GridUnitType.Star) });
            mesLignes.Add(new RowDefinition() { Height = new GridLength(40, GridUnitType.Star) });
            
           
            var _texBox = new TextBox() { Text = "Saisisser votre question ici", };
           Grid.SetRow(_texBox, 0);
            _grid.Children.Add(_texBox);
            this.Content = _grid;

            var bouton = new Button() { Content = "Ask the Eight Ball" };
            Grid.SetRow(bouton, 1);
            _grid.Children.Add(bouton);
            this.Content = _grid;
            bouton.Click += Button_Click;

            
            Grid.SetRow(_textBlock2, 2);
            _grid.Children.Add(_textBlock2);
            this.Content = _grid;
            


        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            List<string> mesReponses = new List<string>();
            mesReponses.Add("Essaye plus tard"); mesReponses.Add("Essaye encore"); mesReponses.Add("Pas d'avis"); mesReponses.Add("C'est ton destin");
            mesReponses.Add("Le sort en est jeté"); mesReponses.Add("Une chance sur deux"); mesReponses.Add("Repose ta question");
            mesReponses.Add("D'après moi oui"); mesReponses.Add("C'est certain"); mesReponses.Add("Oui absolument");
            mesReponses.Add("Tu peux compter dessus"); mesReponses.Add("Sans aucun doute"); mesReponses.Add("Très probable");
            mesReponses.Add("Très probableC'est non "); mesReponses.Add("Peu probable"); mesReponses.Add("Faut pas rêver");
            mesReponses.Add("N'y compte pas"); mesReponses.Add("Impossible ");
            int nombre = new Random().Next(0,(int)mesReponses.LongCount());
           _textBlock2.Text= mesReponses[nombre];
            
        }
    }
}
