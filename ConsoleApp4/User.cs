using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class User
    {
       static private List<User> users = new List<User>();
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public User(string name,string email,string phonenumber)
        {
            Name = name;
            Email = email;
            PhoneNumber = phonenumber;
            users.Add(this);
        }
       static public User Search (string phonenumber)
        {
            foreach (var user in users)
            {
               if( user.PhoneNumber == phonenumber)
                    return user;
            }
            Console.WriteLine("invalied User");
            return null;
        }
        
        static public void EditPhone(User user,string phonenumber)
        {
            user.PhoneNumber = phonenumber;
        }
        static public void EditName(User user, string name)
        {
            user.Name = name;
        }
        static public void EditEmail(User user, string email)
        {
            user.Email = email;
        }
        static public void Delete(User user)
        {
            users.Remove(user);
        }
        public static void show() {
            if(users.Count == 0) { Console.WriteLine("We dont have users");return;}
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.PhoneNumber);
                Console.WriteLine("-----------------------------------------");
            }
        }
    }
}
