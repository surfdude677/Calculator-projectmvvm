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

namespace לומדתמחשבון
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n1;
        int n2;
        private string firstName = "";
        private string lastName = "";
        
        public MainWindow()
        {
            InitializeComponent();
            musicia.Play();
          
        }

        private void OnTextBoxTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!(sender is TextBox box))
                return;

            TextBox textBoxFirst = FindName("textBoxFirst") as TextBox;
            TextBox textBoxLast = FindName("textBoxLast") as TextBox;
            if ((textBoxFirst is null) || (textBoxLast is null))
                return;

            if (!string.IsNullOrEmpty(textBoxFirst.Text))
            {
                this.firstName = textBoxFirst.Text;
            }
            if (!string.IsNullOrEmpty(textBoxLast.Text))
            {
                this.lastName = textBoxLast.Text;
            }

            string fullname = this.firstName+ " " + this.lastName;

        }




        private void startclick(object sender, RoutedEventArgs e)
        {
            Window2 Sec_window = new Window2(this.firstName, this.lastName);
            Sec_window.Show();
            this.Close();
        }
    }

   
}
