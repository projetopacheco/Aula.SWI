namespace Conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio Conta bancária Etec MCM");
        Conta conta = new Conta();

        conta.nomeCliente = "Anderson Vanin";
        
        conta.limite = 1800;

        conta.depositar(200);

        conta.sacar(50);

        double saldo = conta.ConsultaSaldo();
        Console.WriteLine("Seu saldo é de: " + saldo);
    }
}
