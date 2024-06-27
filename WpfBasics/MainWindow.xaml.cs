using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.DescriptionText.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = false;
            this.AssemblyCheckBox.IsChecked = false;
            this.PlasmaCheckBox.IsChecked = false;
            this.LaserCheckBox.IsChecked = false;
            this.PurchaseCheckBox.IsChecked = false;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((string)((CheckBox)sender).Content + " ");
        }

        private void Purchase_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.Note == null) { return; }
            
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.Note.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Purchase_SelectionChanged(this.Purchase, null);
        }
    }
}
