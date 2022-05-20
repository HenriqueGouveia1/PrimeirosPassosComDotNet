using System;
namespace revisao_curso_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            int indiceAluno = 0;
            string opcao = ObterOpcao();

            while (opcao.ToUpper() != "X")
            {
                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Informe o nome: ");
                        Aluno a = new Aluno();
                        a.Nome = Console.ReadLine(); 
                        
                        Console.WriteLine("Informe o nome: ");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            a.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor deve ser decimal");    
                        }

                        alunos[indiceAluno] = a;
                        indiceAluno++;
                        
                        break;

                    case "2":
                        foreach (var item in alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"Aluno: {item.Nome} - Nota: {item.Nota}");
                            }
                        }
                        break;
                    case "3":

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine();
                opcao = ObterOpcao();
            }

        }

        private static string ObterOpcao()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Calcular");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
