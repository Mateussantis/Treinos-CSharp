using System;
using DesafioDupla.Model;
namespace DesafioDupla.Controller

{
    public class HomemdeferroController : PersonagensController {
        HomemdeferroModel homem = new HomemdeferroModel ();
        
        public void Pular () {
            System.Console.WriteLine ("Você está pulando. ");
        }
        public void Defender () {
            System.Console.WriteLine ("Você está voando. ");
        }
        public void Bater () {
            System.Console.WriteLine ("Você está atirando");
        }

        public void Comandos () {
            string sair = "";
            while (sair != "sair") {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.Write ("O que deseja fazer? || Para sair do jogo, digite sair! ");
                sair = System.Console.ReadLine ();
                System.Console.Clear ();
                    if (sair == "1") {
                        Pular ();
                    } else if (sair == "2") {
                        Defender ();
                    } else if (sair == "3") {
                        Bater ();
                    }
                    else {
                    System.Console.WriteLine ("Digite um comando válido");
                }
            }     
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}