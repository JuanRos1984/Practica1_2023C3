using Practica1_2023C3.Menus;
using Practica1_2023C3.Models;
using System;
namespace Practica1_2023C3
{
    internal class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("[1]Iniciar sesión [2]Registrarse");
            int option = int.Parse(Console.ReadLine());
            if (option == 2)
            { 
              bool result =  RegisterManager.RequestUserData();
                if(result)
                    Main();
            }
            else
                Console.WriteLine("Nada");
                //
        }
    }
}
