namespace ExercícioContaCorrente.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Bem-vindo ao sistema de conta corrente!");


            Menu menu = new Menu();

            SairDaConta SairDaconta = new SairDaConta();
            Console.ReadLine();
        }
    }
}
