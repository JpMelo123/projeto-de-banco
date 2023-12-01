using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace Banco
{
    public abstract class CadastroAbs
    {
    public string Nome {get; set;}
    public string  Cpf {get; set;}
    public string DataNasc {get; set;}
    public double Saldo {get; set;}

    public abstract void ReceberDados();

    }
    public class Cadastro: CadastroAbs
    {
      public bool x = false;
     public override void ReceberDados()
     {
        
        Console.Write("Digite seu nome: ");
        Nome = Console.ReadLine();
         do {
        Console.Write("Digite seu CPF: ");
        Cpf = Console.ReadLine();
        if (Cpf.Length != 11)
        {
         Console.WriteLine("CPF Inválido"); 
        } else
        {
            x = true;
        }
          } while(x == false);

        Console.WriteLine("digite sua data de nascimento");

     }
  }
 class Program
 {
    static void Main(string[] args)
    {
        Cadastro cadastro1 = new Cadastro();
        cadastro1.ReceberDados();
    }
 }
}