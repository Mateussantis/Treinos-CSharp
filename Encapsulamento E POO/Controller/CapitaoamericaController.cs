using System;
using DesafioDupla.Model;
namespace DesafioDupla.Controller
{
    public class CapitaoamericaController : PersonagensController
    {
        CaptaoamericaModel capitao = new CaptaoamericaModel();

        public void Bater () {
            System.Console.WriteLine ("Você está lancando o Escudo. ");
        }
        public void Defender () {
            System.Console.WriteLine ("Você está se defendendo com o Escudo");
        }
        public void Pular () {
            System.Console.WriteLine ("Você está pulando. ");
        }

        public void Comandos () {
            string sair = "";
            while (sair != "sair") {
                Console.ForegroundColor = ConsoleColor.Blue;
                System.Console.Write ("O que deseja fazer? || Para sair do jogo, digite sair! ");
                sair = System.Console.ReadLine ();
                System.Console.Clear ();
                    if (sair == "1") {
                        Pular ();
                    } else if (sair == "2") {
                        Bater ();
                    } else if (sair == "3") {
                        Defender ();
                    }
                    else {
                    System.Console.WriteLine ("Digite um comando válido");
                }
            }     
            Console.ForegroundColor = ConsoleColor.Gray;
        }


        }
    }
