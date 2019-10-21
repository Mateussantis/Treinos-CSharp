using System;
using DesafioDupla.Model;
namespace DesafioDupla.Controller {
    public class PersonagensController {
        PersonagensModel personagem = new PersonagensModel ();

        public void Jogador () {
            System.Console.WriteLine ("1- Homem de Ferro || 2- Capitão América");
            System.Console.Write ("Com qual Super Herói deseja jogar: ");
            string escolha = System.Console.ReadLine ();

            if (escolha == "1") {
                HomemdeferroController homemdeferro = new HomemdeferroController ();
                System.Console.WriteLine ("Você esolheu Homem de Ferro ");
                homemdeferro.Comandos ();
            } else if (escolha == "2") {
                CapitaoamericaController capitaoamerica = new CapitaoamericaController ();
                System.Console.WriteLine ("Você escolheu Capitão América ");
                capitaoamerica.Comandos ();
            }
        }     
    }
}