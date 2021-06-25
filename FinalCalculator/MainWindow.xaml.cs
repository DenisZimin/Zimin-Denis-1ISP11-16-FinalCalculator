using System;
using System.Data;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();


            foreach (UIElement element in Calculator.Children)
            {
                if (element is Button)
                {
                    ((Button)element).Click += Button_Click;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string stroka = (string)((Button)e.OriginalSource).Content;

            if (stroka == "Сброс")
            {
                tbOkno.Text = "";
            }
            else if (stroka == "=")
            {
                if (tbOkno.Text == "/" && tbOkno.Text == "0")
                {
                    tbOkno.Text = "0";
                }
                else
                {
                    string itog = new DataTable().Compute(tbOkno.Text, null).ToString();
                    tbOkno.Text = itog;
                }
            }
            else
            {
                tbOkno.Text += stroka;
            }

        }
    }
}
