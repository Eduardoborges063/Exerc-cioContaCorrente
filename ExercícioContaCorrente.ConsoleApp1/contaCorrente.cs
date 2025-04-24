using System.Reflection.Metadata;

namespace ExercícioContaCorrente.ConsoleApp1
{
   public class contaCorrente
   {
        public double saldo;
        public double limite = 1000;
        public int ID;
        public string Nome;
        public string CPF;
       public string Senha;
        public void conta(int id, string nome, string cpf)
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
     
            Random random = new Random();
            saldo = random.Next(1000, 9999);

            Senha = random.Next(1000, 9999).ToString();
            Console.WriteLine("Senha gerada: " + Senha);
        }
        public void Senhas()
        {
            Console.WriteLine("Digite a senha: ");
            string senha = Console.ReadLine();
            if (senha == Senha)
            {
                Console.WriteLine("Senha correta!");
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
            }
        }
        public void metodoP()
        {
            string debito;
            string credito;
            

            if (saldo < 0)
            {
                debito = "Sim";
                credito = "Não";

            }
            else if (saldo == 0)
            {
                debito = "Não";
                credito = "Não";
                Console.WriteLine("Você não tem saldo nem limite de crédito");
            }
            else
            {
                debito = "Não";
                credito = "Sim";
            }
            Console.WriteLine("Limite de crédito: " + limite);
            Console.WriteLine("Saldo de débito: " + saldo);
        }
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (valor > saldo + limite)
            {
                Console.WriteLine("Valor maior que o saldo e o limite");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
        }
        public void Transferir(double valor, contaCorrente contaDestino)
        {
           metodoP();

            if (valor > saldo + limite)
            {
                Console.WriteLine("Valor maior que o saldo e o limite");
            }
            else
            {
                saldo -= valor;
                contaDestino.Depositar(valor);
                Console.WriteLine("Transferência realizada com sucesso");
            }
        }
        public void Extrato()
        {
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("CPF: " + CPF);
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("Limite: " + limite);
        }
   }
}
