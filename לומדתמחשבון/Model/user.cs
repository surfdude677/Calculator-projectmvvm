using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace לומדתמחשבון.Model
{
   
    
        public class user : INotifyPropertyChanged
        {
            private string username;
            private string firstName;
            private string lastName;
            private string childfirstName;
            private string childlastName;
            private int childAge;
            private string eMail;
            private string password;

            public string Email
            {
                get
                {
                    return eMail;
                }
                set
                {
                    eMail = value;
                    OnPropertyChanged("Email");
                }
            }
            public string Password
            {
                get
                {
                    return password;
                }
                set
                {
                    password = value;
                    OnPropertyChanged("Password");
                }
            }

            public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
                OnPropertyChanged("Username");
            }
        }

        public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                    OnPropertyChanged("FirstName");
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                    OnPropertyChanged("LastName");
                }
            }

            public string ChildFirstName
            {
                get
                {
                    return childfirstName;
                }
                set
                {
                    childfirstName = value;
                    OnPropertyChanged("ChildFirstName");
                }
            }

            public int ChildAge
            {
                get
                {
                    return childAge;
                }
                set
                {
                    childAge = value;
                    OnPropertyChanged("ChildAge");
                }
            }

            public string ChildLastName
            {
                get
                {
                    return childlastName;
                }
                set
                {
                    childlastName = value;
                    OnPropertyChanged("ChildLastName");
                }
            }

            #region INotifyPropertyChanged Members

            public event PropertyChangedEventHandler PropertyChanged;

            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
                }
            }

            #endregion
        }
    }

