using System;
using System.Collections.Generic;
using CadastroDeProdutos.Controller;
using CadastroDeProdutos.Models;

namespace cadastrodeprodutos
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionariosController funcionario = new FuncionariosController();
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            funcionario.CadastroDeFuncionarios(listaFuncionarios);
            funcionario.LoginFuncionario(listaFuncionarios);


        }
    }
}
