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

namespace WpfMaPremiereApplication
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            #region code chloé
            // LinearGradientBrush brush = new LinearGradientBrush();
            // GradientStopCollection mesStopDeGradient = new GradientStopCollection
            //{
            //    new GradientStop(Colors.Orange, 0.5),
            //    new GradientStop(Colors.HotPink, 1)
            //};
            // brush.GradientStops = mesStopDeGradient;

            // TextBlock monTexte = new TextBlock
            // {
            //     Text = "Affichage de text à partir de code C#",
            //     HorizontalAlignment = HorizontalAlignment.Center,
            //     VerticalAlignment = VerticalAlignment.Center,
            //     Foreground = brush
            // };

            // var _grid = new Grid();
            // _grid.Children.Add(monTexte);

            // this.Content = _grid;
            #endregion
            InitializeComponent();
            //var flexblox = new TextBlock()
            //{
            //    Text = "test du code behind",
            //    TextAlignment = TextAlignment.Left,
                
            //    //Foreground=BorderBrush
            //};

            //var grid1 = new Grid();
            //grid1.Children.Add(flexblox);
            //this.Content = grid1;
            //Grid.SetRow(flexblox, 0);
            //grid1.Children.Add(flexblox);
            //this.Content = grid1;

            //Grid.SetColumn(flexblox, 0);
            #region ajouter des lignes
            //var grid2 = new Grid();
            //RowDefinition gridRow = new RowDefinitionCollection();
            //gridRow.Height = new GridLength(10.0,GridUnitType.Star);
            //grid2.RowDefinitions.Add(gridRow);
            #endregion

            #region ajouter des lignes codes godwin
            //var _grid = new Grid();
            //var _texBlock = new TextBlock();
            //RowDefinition _GridRow = new RowDefinition();
            //_GridRow.Height = new GridLength(10.0, GridUnitType.);
            //_grid.RowDefinitions.Add(_GridRow);


            //RowDefinition _GridRow2 = new RowDefinition();
            //_GridRow.Height = new GridLength(10.0, GridUnitType.Star);
            //_grid.RowDefinitions.Add(_GridRow);

            //RowDefinition _GridRow3 = new RowDefinition();
            //_GridRow.Height = new GridLength(17.0, GridUnitType.Star);
            //_grid.RowDefinitions.Add(_GridRow);
            //Grid.SetRow(_texBlock, 0);
            //Grid.SetColumn(_texBlock, 1);
            //_grid.Children.Add(_texBlock);
            #endregion

            LinearGradientBrush brush = new LinearGradientBrush();
            GradientStop gradientStop1 = new GradientStop();
            gradientStop1.Offset = 0;
            gradientStop1.Color = Colors.Black;
            brush.GradientStops.Add(gradientStop1);

            GradientStop gradientStop2 = new GradientStop();
            gradientStop2.Offset = 0.5;
            gradientStop2.Color = Colors.Indigo;
            brush.GradientStops.Add(gradientStop2);

            GradientStop gradientStop3 = new GradientStop();
            gradientStop3.Offset = 1;
            gradientStop3.Color = Colors.Violet;
            brush.GradientStops.Add(gradientStop3);

            this.FirstTextB.Foreground = brush;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Tout va bien");


        }

        }
    }

