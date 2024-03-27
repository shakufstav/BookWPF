using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace WPF
{
    public class UserService
    {
        private User currentUser;
        public void SetCurrentUser(User user)
        {
            currentUser = user;
        }

    }
}
