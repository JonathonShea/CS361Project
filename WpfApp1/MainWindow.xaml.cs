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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int partyLevel= 0;
        int partySize = 0;
        public MainWindow()
        {
            InitializeComponent();
            EncounterItem item1 = new EncounterItem("thing1", "5", "creature");
            EncounterItem item2 = new EncounterItem("thing2", "4", "creature");
            EncounterItem item3 = new EncounterItem("thing3", "6", "hazard");
            AvailableItems.Items.Add(item1);
            AvailableItems.Items.Add(item2);
            AvailableItems.Items.Add(item3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = "Party level set to:" + partyLevel.ToString() + "\nParty size set to: " + partySize.ToString();
            MessageBox.Show(message);
        }

        private void LevelSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            partyLevel = Convert.ToInt32(LevelSlider.Value);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int.TryParse(PartySizeBox.Text, out partySize);

            
        }
    }
}
