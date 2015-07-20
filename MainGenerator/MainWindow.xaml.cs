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

namespace MainGenerator
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

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            bool ba_sill = Convert.ToBoolean(cbAllBA.IsChecked);
            bool finalize = Convert.ToBoolean(cbSyllFin.IsChecked);
            int count = Convert.ToInt16(sldCounSyll.Value);
            generator Gnr = new generator();
            string word = Gnr.Generate(count, ba_sill, finalize);
            txt_password.Text = word;
        }

        private void radioPack2_Checked(object sender, RoutedEventArgs e)
        {
            letterData.LoadPack2();
        }

        private void radioPack1_Checked(object sender, RoutedEventArgs e)
        {
            letterData.LoadPack1();
        }

        private void cbSyllAA_Checked(object sender, RoutedEventArgs e)
        {
            try
            {
                radioSyllAAMax.IsEnabled = true;
                radioSyllAAMin.IsEnabled = true;
            }
            catch
            {

            }
        }

        private void cbSyllAA_Unchecked(object sender, RoutedEventArgs e)
        {
            radioSyllAAMax.IsEnabled = false;
            radioSyllAAMin.IsEnabled = false;
        }

        private void cbAllBA_Unchecked(object sender, RoutedEventArgs e)
        {
            
            cbSyllAA.IsEnabled = true;
        }

        private void cbAllBA_Checked(object sender, RoutedEventArgs e)
        {
            cbSyllAA.IsChecked = false;
            cbSyllAA.IsEnabled = false;
        }
    }
}
