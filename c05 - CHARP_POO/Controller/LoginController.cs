using System;
using System.Collections.Generic;
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


        public void ListarLista(List<Login> listLogin)
        {
            foreach (var item in listLogin)
            {
                Console.WriteLine($" Email : {item.Email} Senha ********");
            }
        }

        public Login BuscarUsuario(string usuarioPesquisado, List<Login> lista)
        {
            Login usuarioRetornado = lista.Find(login => login.Email == usuarioPesquisado);
            return usuarioRetornado;
        }

        public void RemoverUsuario(string usuarioPesquisado, List<Login> listLogin)
        {
            Login removerUsuario = listLogin.Find(usuario => usuario.Email == usuarioPesquisado);
            listLogin.Remove(removerUsuario);
        }

        public Login ConsultaUsuario(string email, List<Login> listLogin)
        {
            Login emailEncontrado = listLogin.Find(usuario => usuario.Email == email);
            return emailEncontrado;
        }


    }
}