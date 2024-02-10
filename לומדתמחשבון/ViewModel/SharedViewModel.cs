using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using לומדתמחשבון.Model;

namespace לומדתמחשבון.ViewModel
{
    public class SharedViewModel
    {
        private List<user> _usersList;

        public SharedViewModel()
        {
            _usersList = new List<user>();
        }

        public List<user> UsersList
        {
            get { return _usersList; }
            set { _usersList = value; }
        }
    }
}
