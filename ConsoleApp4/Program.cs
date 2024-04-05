using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1- Add User");
                Console.WriteLine("2- Edit User");
                Console.WriteLine("3-Delete User");
                Console.WriteLine("4-Show");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.WriteLine("Enter The User Data");
                            Console.Write("Name:");
                            string name = Console.ReadLine();
                            Console.Write("PhoneNumber:");
                            string phonenumber = Console.ReadLine();
                            Console.Write("Email:");
                            string email = Console.ReadLine();
                            User user = new User(name, email, phonenumber);
                            Console.WriteLine("Done");
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Enter The User PhoneNumber ");
                            string phonenumber = Console.ReadLine();
                            var user = User.Search(phonenumber);
                            if (user != null)
                            {
                                Console.WriteLine("What Do You Want To Edit");
                                Console.WriteLine("1- Name");
                                Console.WriteLine("2- Email");
                                Console.WriteLine("3- PhoneNumber");
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        Console.Write("New Name:");
                                        string name = Console.ReadLine();
                                        User.EditName(user, name);
                                        Console.WriteLine("Done");
                                        break;
                                    case "2":
                                        Console.Write("New Email:");
                                        string email = Console.ReadLine();
                                        User.EditEmail(user, email);
                                        Console.WriteLine("Done");
                                        break;
                                    case "3":
                                        Console.Write("New PhoneNumber:");
                                        string phoneNumber = Console.ReadLine();
                                        User.EditPhone(user, phoneNumber);
                                        Console.WriteLine("Done");
                                        break;
                                    default:
                                        Console.WriteLine("invalid option");
                                        break;
                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Enter The User PhoneNumber ");
                            string phonenumber = Console.ReadLine();
                            var user = User.Search(phonenumber);
                            if (user != null)
                            {
                                User.Delete(user);
                                Console.WriteLine("Done");
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("-----------------------------------------");
                            User.show();
                            break;
                        }
                    default:
                        Console.WriteLine("invalid Option");
                        break;
                }
                Console.WriteLine("Again??");
                if (Console.ReadLine().ToLower() !="y")break;
            }
            Console.WriteLine("thanks ;) ");
        }
    }
}
