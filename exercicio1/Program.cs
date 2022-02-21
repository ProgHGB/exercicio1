using System;

namespace exercicio1 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("PROGRAMA PARA CALCULAR IDADE MÉDIA DE CINCO ALUNOS");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");

            double idade1, idade2, idade3, idade4, idade5 = 0;
            double idadeMedia;
            
            

            
            Console.WriteLine("Digite a idade do Primeiro Aluno:");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do Segundo Aluno:");
            idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do Terceiro Aluno:");
            idade3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do Quarto Aluno:");
            idade4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a idade do Quinto Aluno:");
            idade5 = int.Parse(Console.ReadLine());

            idadeMedia = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine(idadeMedia);

            Console.WriteLine("Fim do Programa");
            Console.ReadKey();
        }
    }
}
