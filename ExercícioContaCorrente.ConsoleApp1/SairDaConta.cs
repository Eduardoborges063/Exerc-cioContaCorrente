namespace ExercícioContaCorrente.ConsoleApp1
{
    public class SairDaConta
    {
        public string Sair()
        {
            string Sair;
            Console.WriteLine("Você quer sair? (s/n)");
            Sair = Console.ReadLine();
            Console.WriteLine("Saindo...");
            Environment.Exit(0);

            if (Sair == "s")
            {
                Console.WriteLine("Saindo...");
                Environment.Exit(0);
            }
            else if (Sair == "n")
            {
                Console.WriteLine("Continuando...");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }
            return Sair;
        }
    }
}
