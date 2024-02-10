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
using לומדתמחשבון.Model;
using לומדתמחשבון.ViewModel;
namespace לומדתמחשבון.View
{
    /// <summary>
    /// Interaction logic for mainFrame.xaml
    /// </summary>
    public partial class mainFrame : Window
    {
        private SharedViewModel _sharedViewModel;
        private UserViewModel _userViewModel;

        public mainFrame()
        {
            InitializeComponent();
            _sharedViewModel = new SharedViewModel();

            
            _userViewModel = new UserViewModel(_sharedViewModel);

         
            DataContext = _userViewModel;

          
            mainFrame.Navigate(new Loginpage(_sharedViewModel));

        }
        private void ClickAdd(object sender, RoutedEventArgs e)
        {

            if (mainFrame != null)
            {
                mainFrame.Visibility = Visibility.Visible;
                mainFrame.Navigate(new AddUser(_sharedViewModel));
            }
        }

        private void ClickClose(object sender, RoutedEventArgs e)
        {
            // Close the window
            System.Windows.Application.Current.Shutdown();
            this.Close();
        }
    }
}
