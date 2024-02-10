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
using לומדתמחשבון.ViewModel;
using לומדתמחשבון.Model;
namespace לומדתמחשבון.View
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private SharedViewModel _sharedViewModel;
        private UserViewModel _userViewModel;
        public MainPage(SharedViewModel sharedViewModel)
        {
            InitializeComponent();

            _sharedViewModel = sharedViewModel;
            _userViewModel = new UserViewModel(_sharedViewModel);
            

            DataContext = _userViewModel;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
