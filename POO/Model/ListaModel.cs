namespace t1.Model
{
    public class ListaModel
    {
        public string nome{get; set;}
        public int idade{get; set;}

        public ListaModel(string nome = "Usuario", int idade = 0) {
            this.nome = nome;
            this.idade = idade;
        }
        
    }
}