namespace ExercícioContaCorrente.ConsoleApp1
{
    public class Menu
    {
        public void MenuCriarConta()
        {
            Console.Clear();
            contaCorrente conta = new contaCorrente();
            Console.WriteLine("Digite o ID da conta:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do cliente:");
            string cpf = Console.ReadLine();
            conta.conta(id, nome, cpf);
            Console.WriteLine("Conta criada com sucesso!");
            Console.WriteLine("Saldo inicial: " + conta.saldo);
            Console.WriteLine("Limite de crédito: " + conta.limite);
            Console.WriteLine("O que quer fazer?");
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();
            conta.Senhas();
        }
        
        public void opcaoDaConta()
        {
            Console.Clear();
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    MenuDepositar();
                    break;
                case "2":
                    MenuSacar();
                    break;
                case "3":
                    MenuVerSaldo();
                    break;
                case "4":
                    MenuVerLimite();
                    break;
                case "5":
                    MenuVerDebito();
                    break;
                case "6":
                    MenuSair();
                    break;
                case "s":

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            Console.WriteLine("1 - Depositar");
            Console.WriteLine("2 - Sacar");
            Console.WriteLine("3 - Ver saldo");
            Console.WriteLine("4 - Ver limite de crédito");
            Console.WriteLine("5 - Ver saldo de débito");
            Console.WriteLine("6 - Sair");

        }
        public void MenuDepositar()
        {
            Console.Clear();
            contaCorrente conta = new contaCorrente();
            Console.WriteLine("Digite o valor que quer depositar:");
            double valor = double.Parse(Console.ReadLine());
            conta.Depositar(valor);
            Console.WriteLine("Valor depositado com sucesso!");
            Console.WriteLine("Saldo atual: " + conta.saldo);
        }
        public void MenuSacar()
        {
            Console.Clear();
            contaCorrente conta = new contaCorrente();
            Console.WriteLine("Digite o valor que quer sacar:");
            double valor = double.Parse(Console.ReadLine());
            conta.Sacar(valor);
            Console.WriteLine("Valor sacado com sucesso!");
            Console.WriteLine("Saldo atual: " + conta.saldo);
        }
        public void MenuVerSaldo()
        {
            Console.Clear();
            contaCorrente conta = new contaCorrente();
            Console.WriteLine("Saldo atual: " + conta.saldo);
        }
        public void MenuVerLimite()
        {
            Console.Clear();
            contaCorrente conta = new contaCorrente();
            Console.WriteLine("Limite de crédito: " + conta.limite);
        }
        public void MenuVerDebito()
        {
            Console.Clear();
            contaCorrente conta = new contaCorrente();
            Console.WriteLine("Saldo de débito: " + conta.saldo);
        }
        public void MenuSair()
        {
            Console.Clear();
            SairDaConta sairDaConta = new SairDaConta();
            sairDaConta.Sair();
        }
    }
}
