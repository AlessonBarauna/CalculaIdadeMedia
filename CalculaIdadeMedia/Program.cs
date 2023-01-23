namespace CalculaIdadeMedia
{
    class programa
    {
        static void Main(string[] args)
        {
            double media = 0;
            double idade1 = 0;
            double idade2 = 0;
            double idade3 = 0;
            double idade4 = 0;
            double idade5 = 0;

            Console.WriteLine("Programa que calcula a idade média de 5 alunos");
            Console.WriteLine("Digite a idade do primeiro aluno: ");
            idade1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade do segundo aluno: ");
            idade2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade do terceiro aluno: ");
            idade3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade do quarto aluno: ");
            idade4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a idade do quinto aluno: ");
            idade5 = Convert.ToDouble(Console.ReadLine());

            media = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;

            Console.WriteLine("A ídade média dos alunos é " + media);
            Console.ReadKey();
        }
        
    }
}
