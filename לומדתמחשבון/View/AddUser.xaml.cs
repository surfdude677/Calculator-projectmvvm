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
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Page
    {
        private SharedViewModel _sharedViewModel;
        private UserViewModel _userViewModel;
        public AddUser(SharedViewModel sharedViewModel)
        {
            InitializeComponent();
            _sharedViewModel = sharedViewModel;

        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string username = (txtUsername.Text);
                string firstName = txtFname.Text;
                string lastName = txtLname.Text;
                string childfirstname = txtChidFirstN.Text;
                string email = txtEmail.Text;
                string childlastname = txtChidlastN.Text;
                string password = txtpassword.Text;
                int childage = int.Parse(txtChildAge.Text);
                // Create a new user
                user newUser = new user
                {
                    Username = username,
                    FirstName = firstName,
                    LastName = lastName,
                    ChildFirstName = childfirstname,
                    ChildLastName = childlastname,
                    ChildAge = childage,
                    Email = email,
                    Password = password,


                };

                _sharedViewModel.UsersList.Add(newUser);
                MessageBox.Show("User added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                Loginpage gol = new Loginpage(_sharedViewModel);
                NavigationService.GoBack();
            }

            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            txtUsername.Clear();
            txtpassword.Clear();
            txtLname.Clear();
            txtFname.Clear();
            txtEmail.Clear();
            txtChildAge.Clear();
            txtChidlastN.Clear();
            txtChidFirstN.Clear();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (NavigationService != null)
                {
                    NavigationService.GoBack();
                }
                else
                {
                    MessageBox.Show("NavigationService is null.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error hh", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }   }


        
        
           



     