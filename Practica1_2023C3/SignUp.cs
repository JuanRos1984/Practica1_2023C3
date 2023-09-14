using Newtonsoft.Json;
using Practica1_2023C3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1_2023C3
{
    internal static class SignUp
    {
        static string filePath = "../AuthRepo/auth.json";
        static List<User> usersList = new List<User>();
        public static List<User> GetUsers()
        {
            try
            {
                string fileContent = File.ReadAllText(filePath);
                usersList = JsonConvert.DeserializeObject<List<User>>(fileContent);
            }
            catch (Exception)
            {
                throw;
            }
            return usersList;
        }
        public static bool RegisterUser(User model)
        {
            bool result;
            try
            {
                usersList = GetUsers();
                var user = new User 
                {
                    UserName= model.UserName,
                    Password= model.Password
                };
                usersList.Add(user);
                var fileContent = JsonConvert.SerializeObject(usersList,Formatting.Indented);
                File.WriteAllText(filePath, fileContent);
                result = true;
            }
            catch(Exception ex) 
            {
                result = false;
            }
            return result;
        }
        
    }
}
