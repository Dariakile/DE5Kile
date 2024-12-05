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

namespace DE5Kile
{
    /// <summary>
    /// Логика взаимодействия для Avtorizacia.xaml
    /// </summary>
    public partial class Avtorizacia : Window
    {
        public Avtorizacia()
        {
            InitializeComponent();
        }
        private string A = "0000";
        private void Vhod_Click(object sender, RoutedEventArgs e)
        {
            if (TBPassword.Text == A)
            {
                var MyWindow = Window.GetWindow(this);
                MainWindow mainwindow = new MainWindow();
                mainwindow.Show(); 
                MyWindow.Close();
            }
            else if (A == (""))
            {
                MessageBox.Show("Введите Email");
            }
            else if (TBPassword.Text != A)
            {
                MessageBox.Show("fgreg");
            }
          
        }   

    }
}
