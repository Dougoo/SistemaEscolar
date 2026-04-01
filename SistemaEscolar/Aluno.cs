namespace SistemaEscolar
{
    public class Aluno
    {
        // Propriedades da classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sala { get; set; }
        public string Professor { get; set; }
        public string Materia { get; set; }

        // Construtor para facilitar a criação do objeto
        public Aluno(string nome, int idade, string sala, string professor, string materia)
        {
            Nome = nome;
            Idade = idade;
            Sala = sala;
            Professor = professor;
            Materia = materia;
        }

        // Método para exibir os dados do aluno formatados
        public void ExibirDados()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Aluno: {Nome}");
            Console.WriteLine($"Idade: {Idade} anos");
            Console.WriteLine($"Sala: {Sala}");
            Console.WriteLine($"Professor: {Professor}");
            Console.WriteLine($"Matéria: {Materia}");
            Console.WriteLine("------------------------------");
        }
    }
}