using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserSignup.Models
{
    public class UserData
    {
        static private List<User> users = new List<User>();

        // GetAll
        public static List<User> GetAll()
        {
            return users;
        }

        // Add
        public static void Add(User newUser)
        {
            users.Add(newUser);
        }
    }
}
