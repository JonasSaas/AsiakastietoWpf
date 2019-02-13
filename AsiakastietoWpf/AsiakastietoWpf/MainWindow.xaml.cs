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

namespace AsiakastietoWpf
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

        private void BtnTervehdys_Click(object sender, RoutedEventArgs e)
        {
            if (txtNimi.Text == "" || txtHklkoti.Text == "")
            {
                MessageBox.Show("Anna molemmat tiedot!", "Otsikko", MessageBoxButton.OKCancel);
            }
            else
            {
                MessageBoxResult tulos = MessageBox.Show("Asiakas: " + txtNimi.Text + ", Osoite: " + txtHklkoti.Text, "Haluatko tallentaa nämä tiedot?", MessageBoxButton.YesNoCancel);
                switch(tulos)
                {
                    case MessageBoxResult.Yes:
                        txtNimi.Background = Brushes.Green;
                        txtHklkoti.Background = Brushes.Green;
                        break;
                    case MessageBoxResult.No:
                        txtHklkoti.Background = Brushes.White;
                        txtNimi.Background = Brushes.White;
                        txtNimi.Text = "";
                        txtHklkoti.Text = "";
                        break;
                    case MessageBoxResult.Cancel:
                        txtNimi.Background = Brushes.White;
                        txtHklkoti.Background = Brushes.White;
                        break;
                }
            }         
        }
    }
}
