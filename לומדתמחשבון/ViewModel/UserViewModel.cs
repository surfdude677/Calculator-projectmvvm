using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using לומדתמחשבון.Model;
using לומדתמחשבון.View;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace לומדתמחשבון.ViewModel

{
    class UserViewModel : INotifyPropertyChanged
    {
        private SharedViewModel _sharedViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RefreshUsers()
        {
            // Don't need to reload data, just notify UI
            OnPropertyChanged(nameof(Users));
        }
        public UserViewModel(SharedViewModel sharedViewModel)
        {
            _sharedViewModel = sharedViewModel;

            if (_sharedViewModel.UsersList == null || _sharedViewModel.UsersList.Count == 0)
            {
                _sharedViewModel.UsersList = new List<user>
{
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                 new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                 new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                 new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                 new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                 new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
                new user { Username = "ads", FirstName = "avigail", LastName = "cohen", ChildFirstName = " aviv", ChildLastName = "cohen", ChildAge = 12, Email = "t@test.com", Password = "1234" },
};

            }
        }

        public List<user> Users
        {
            get { return _sharedViewModel.UsersList; }
        }
    }
}


    

