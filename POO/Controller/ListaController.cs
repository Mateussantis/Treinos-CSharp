using t1.Model;
using System;
using System.Collections.Generic;

namespace t1.Controller
{
    public class ListaController
    {

        ListaModel obj = new ListaModel();
        List<ListaModel> lista = new List<ListaModel>();

        public void Receber() {
            
            string sair = "";

            while (sair != "sair") {

                System.Console.Write("Digite o Nome: ");
                obj.nome = Console.ReadLine();
                
                System.Console.Write("Digite a Idade: ");
                obj.idade = int.Parse(Console.ReadLine());

                lista.Add(new ListaModel(obj.nome, obj.idade));

                System.Console.Write("\nDesja continuar? : ");
                sair = Console.ReadLine();

                System.Console.WriteLine();
            }
        }

        public void Monstrar(){
            Console.Clear();
            System.Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach(ListaModel obj in lista) {
                System.Console.WriteLine(obj.nome);
                System.Console.WriteLine(obj.idade);
                System.Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}