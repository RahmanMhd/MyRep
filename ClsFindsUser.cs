using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace C11_Bank_Project_OOP
{
    internal class ClsFindsUser:ClsScreen
    {
        private static void _printUser(ClsUsers user)
        {
            Console.WriteLine("\t\t\t\t\t\t\t\tUser card : ");
            Console.WriteLine("\t\t\t\t\t___________________________________________________");
            Console.WriteLine("\t\t\t\t\t\t\tFirst Name :" + user.FirstName);
            Console.WriteLine("\t\t\t\t\t\t\tLast Name  :" + user.LastName);
            Console.WriteLine("\t\t\t\t\t\t\tFull Name  :" + user.FullName());
            Console.WriteLine("\t\t\t\t\t\t\tEmail      :" + user.Email);
            Console.WriteLine("\t\t\t\t\t\t\tPhone      :" + user.Phone);
            Console.WriteLine("\t\t\t\t\t\t\tUser Name  :" + user.Username);
            Console.WriteLine("\t\t\t\t\t\t\tPassword   :" + user.Password);
            Console.WriteLine("\t\t\t\t\t\t\tPermissins :" + user.Permissins);
            Console.WriteLine("\t\t\t\t\t___________________________________________________");
        }
        public static void PrintFindUser()
        {
            _drawScreenHeader("Find User Screen ");
            Console.Write("Enter User Name : ");
            string ac = clsValidation.readString();
            Console.Write("Enter Password : ");
            string pass = clsValidation.readString();
            while (!ClsUsers.isUserExist(ac,pass))
            {
                Console.WriteLine("User Name/Password not Valid try again : ");
                Console.Write("Enter User Name : ");
                ac = clsValidation.readString();
                Console.Write("Enter Password");
                pass = clsValidation.readString();
            }
            ClsUsers c = ClsUsers.Find(ac,pass);
            if (!c.IsEmpty())
            {
                Console.WriteLine("User found");
            }
            else { Console.WriteLine("Client Not found"); }
            _printUser(c);           
        }
    }
}
