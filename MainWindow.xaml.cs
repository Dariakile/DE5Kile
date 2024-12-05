using DE5Kile.ApplicationData;
using DE5Kile.MainPage;
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

namespace DE5Kile
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppConnect.modelOdb = new SchoolEntities();
            AppFrame.frameMain = MainFrame;
            MainFrame.Navigate(new Page());
        }

        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            var MyWindow = Window.GetWindow(this);
            Avtorizacia avtorizacia1 = new Avtorizacia();
            avtorizacia1.Show();
            MyWindow.Close();
        }

        private void BtnUslugi_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.frameMain.Navigate(new Uslugi());
            
        }
    }
}
