using System;
using c05___CHARP_POO.Models;

namespace c05___CHARP_POO.Controller
{
    public class LoginController
    {
        public Login CadastrarUsusario()
        {

            Console.WriteLine($"Digite seu Email");
            string email = Console.ReadLine();

            Console.WriteLine($"Digite sua senha");
            string senha = Console.ReadLine();


            Login login = new Login(email, senha);

            return login;
        }
    }
}