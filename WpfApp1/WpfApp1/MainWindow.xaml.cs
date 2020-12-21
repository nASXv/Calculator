using System;
using System.Collections.Generic;
using System.Globalization;    //
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
using Calculator;


namespace WpfApp1
{           
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string language; //
        public MainWindow()
        {
            InitializeComponent();
            language = "ru-RU";
        }
        private void TBclosed_TextChanged(object sender, TextChangedEventArgs e)
        {
            TBclosed.IsReadOnly = true;
        }
        private void Use_count(object sender, RoutedEventArgs e)
        {

            Logarithm answ = new Logarithm(TBa.Text, TBb.Text);
            answer.Content = answ.getLogarithm();
        }
        private void TBa_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }
        private void TBb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void cbLanguage_SelectionChanged(object sender, SelectionChangedEventArgs e)  //
        {

            ComboBox cb = sender as ComboBox;
            language = (cb.SelectedItem as ComboBoxItem).Tag.ToString();

            if (language != null)
            {
                CultureInfo lang = new CultureInfo(language);

                if (lang != null)
                {
                    App.Language = lang;
                }

            }
        }                   //
    }
}