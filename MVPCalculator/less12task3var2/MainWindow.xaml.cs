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

namespace less12task3var2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presenter(this);
        }
        public event EventHandler AddEvent = null;
        public event EventHandler MulEvent = null;
        public event EventHandler RezzEvent = null;
        public event EventHandler DivEvent = null;


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddEvent.Invoke(sender, e); 
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            DivEvent.Invoke(sender, e);
        }

        private void Rezz_Click(object sender, RoutedEventArgs e)
        {
            RezzEvent.Invoke(sender, e);
        }

        private void Mull_Click(object sender, RoutedEventArgs e)
        {
            MulEvent.Invoke(sender, e);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
