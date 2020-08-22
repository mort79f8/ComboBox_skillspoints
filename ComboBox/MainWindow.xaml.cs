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

namespace ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int str, wis, intel = 0;        
        private void strCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cmdItem = strCombo.SelectedItem as ComboBoxItem;
            str = int.Parse(cmdItem.Content.ToString());
            CalcStatsRemaining();
        }

        private void wisCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cmdItem = wisCombo.SelectedItem as ComboBoxItem;
            wis = int.Parse(cmdItem.Content.ToString());
            CalcStatsRemaining();
        }

        private void intCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cmdItem = intCombo.SelectedItem as ComboBoxItem;
            intel = int.Parse(cmdItem.Content.ToString());
            CalcStatsRemaining();
        }

        public MainWindow()
        {
            InitializeComponent();
        }


        private void CalcStatsRemaining()
        {
            int spRemaining = 10 - (str + wis + intel);
            if (spRemaining < 0)
            {
                MessageBox.Show("Du har ikke nok Skill points til det, check dine stats igen");
            }
            spRemain.Content = spRemaining;
        }
    }
}
