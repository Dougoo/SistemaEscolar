using System;
using System.Collections.Generic;

namespace SistemaEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listaAlunos = new List<Aluno>();
            string continuar = "s";

            Console.WriteLine("=== Sistema de Cadastro de Alunos ===");

            while (continuar.ToLower() == "s")
            {
                Console.Write("\nNome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Idade: ");
                int idade = int.Parse(Console.ReadLine());

                Console.Write("Sala: ");
                string sala = Console.ReadLine();

                Console.Write("Professor: ");
                string professor = Console.ReadLine();

                Console.Write("Matéria: ");
                string materia = Console.ReadLine();

                // Instancia o novo aluno e adiciona à lista
                Aluno novoAluno = new Aluno(nome, idade, sala, professor, materia);
                listaAlunos.Add(novoAluno);

                Console.Write("\nDeseja cadastrar outro aluno? (s/n): ");
                continuar = Console.ReadLine();
            }

            Console.WriteLine("\n--- Relatório de Alunos Cadastrados ---");
            foreach (var aluno in listaAlunos)
            {
                aluno.ExibirDados();
            }

            Console.WriteLine("\nFim do programa. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}