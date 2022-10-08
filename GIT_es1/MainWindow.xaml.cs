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

namespace GIT_es1
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
        //Mularoni Luca 4G 2022-10-08
        //esercizio per vedere come lavorare con git
        //Bottone per il calcolo della media
        private void btnMedia_Click(object sender, RoutedEventArgs e)
        {
            
            double[] v = new double[10];
            Random rnd = new Random();
            //genera 10 numeri random e li mette nell'array double v
            for (int i = 0; i < 10; i++)
                v[i] = rnd.Next(0, 100);
            double somma = 0;
            //somma tutti i numeri 
            for (int i = 0; i < 10; i++)
                somma += v[i];
            //scrive la media nella label
            lblMedia.Content = somma / 10;
        }
        
    }
}
