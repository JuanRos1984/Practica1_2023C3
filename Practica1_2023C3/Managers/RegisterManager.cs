using Practica1_2023C3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_2023C3.Menus
{
    static internal class RegisterManager
    {
        static List<User> users = SignUp.GetUsers();
        public static bool RequestUserData()
        {
            Console.Clear();
            Console.WriteLine("Escriba su nombre de usuario:");
            string userName = Console.ReadLine();
            if (users.Any(a => a.UserName == userName))
            { 
                Console.WriteLine("Nombre de usuario no disponible... Presione una tecla para continuar");
                Console.ReadKey();
                RequestUserData();
            } 
            Console.WriteLine("Escriba su contraseña:");
            string password = Console.ReadLine();

            var newUser = new User { UserName = userName, Password = password };
            return SignUp.RegisterUser(newUser);
        }
    }
}
