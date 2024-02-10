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
using לומדתמחשבון.Model;
using לומדתמחשבון.ViewModel;
namespace לומדתמחשבון.View
{
    /// <summary>
    /// Interaction logic for Loginpage.xaml
    /// </summary>
    public partial class Loginpage : Page
    {
        private SharedViewModel _sharedViewModel;
        private UserViewModel _userViewModel;

       
        public Loginpage(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;
            
        }
        private void UsrTxtBox_GotFocus(object sender, RoutedEventArgs e)
        {

            UsrTxtBox.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get the entered email and password 
                string enteredEmail = UsrTxtBox.Text;
                string enteredPassword = PwdBox.Password;

                // Search for a match in the list
                user matchedUser = null;

                foreach (user user in _sharedViewModel.UsersList)
                {
                    if (user.Email == enteredEmail && user.Password == enteredPassword)
                    {
                        matchedUser = user;
                        break; // Found a match, exit the loop
                    }
                }
                if (matchedUser != null)
                {  // show the main page
                    Window2 MainPage = new Window2(enteredEmail,"3");
                    NavigationService.Navigate(MainPage);
                }

                else
                {
                    // No match found, display an error message
                    MessageBox.Show("Invalid email or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Register_click(object sender, RoutedEventArgs e)
        {
            AddUser reg = new AddUser(_sharedViewModel);
            NavigationService.Navigate(reg);
        }

    }
}
