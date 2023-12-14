using System.Diagnostics;
using System.IO.Compression;

namespace Banco
{
    public abstract class CadastroAbs
    {
    public string Nome {get; set;}
    public string  Cpf {get; set;}
    public string DataNasc {get; set;}
    public string Senha {get; set;}
    public double escolha {get; set;}
    public double escolha2 {get; set;}
    public double Saldo {get; set;}
    public double Deposito {get; set;}
    public double Saque {get; set;}
    public double Emprestimo {get; set;}
    public double SaldoTotal {get; set;}
    
    public abstract void ReceberDados();

    }
    public class Cadastro: CadastroAbs
    {
      public bool x = false;
      public bool y = false;
      public bool z = false;
      
     public override void ReceberDados()
     {
         SaldoTotal += Saldo + Emprestimo + Deposito - Saque;
        Console.Clear();
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("CADASTRO");
        Console.WriteLine("------------------");
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
        Console.WriteLine("Digite sua data de nascimento [Sem barras, ex.01072005]: ");
        DataNasc = Console.ReadLine();
         Console.WriteLine("Digite a senha que deseja: ");
        Senha = Console.ReadLine();
       
        Console.Clear();
         
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("USUÁRIO CADASTRADO");
        Console.WriteLine("------------------");
        Console.WriteLine("Escolha uma das opcões de 1 à 2:");
        Console.WriteLine();
        Console.WriteLine("1 - Fazer Login");
        Console.WriteLine("2 - Encerrar Aplicação");
        Console.WriteLine();
        Console.Write("Sua escolha: ");


        escolha = Convert.ToDouble(Console.ReadLine());
        
      
        switch (escolha)
        {
            
            case 1:
            Console.Clear();
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("LOGIN");
        Console.WriteLine("------------------");
        Console.Write("Digite seu nome: ");
        Nome1 = Console.ReadLine();
        if (Nome1 != Nome)
        {
             Console.WriteLine("Usuário Inexistente");
             break;
        } else
        {
            y = false;
        }
        do {
             Console.Write("Digite sua Senha: ");
             Senha1 = Console.ReadLine();
        if (Senha1 != Senha)
        {
        Console.WriteLine("Senha Incorreta");
        }else
        {
            y = true;
        }
        } while (y == false );
            
        Console.Clear();
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("USUÁRIO");
        Console.WriteLine("------------------");
        Console.WriteLine("Nome: "+ Nome);
        Console.Write("Data de Nascimento: ");
        Console.WriteLine(Convert.ToUInt64(DataNasc).ToString(@"00\/00\/0000"));
         Console.Write("CPF: ");
        Console.WriteLine(Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00")); 
        Console.WriteLine("Seu Saldo: R$"+SaldoTotal);
        Console.WriteLine("------------------");
        Console.WriteLine("Escolha uma das opcões de 1 à 3:");
        Console.WriteLine();
        Console.WriteLine("1 - Fazer Depósito");
        Console.WriteLine("2 - Fazer Saque");
        Console.WriteLine("3 - Encerrar Aplicação");
        Console.WriteLine();
        Console.Write("Sua escolha: ");
        escolha2 = Convert.ToDouble(Console.ReadLine());

        switch (escolha2)
        {
            case 1: 
            Console.Clear();
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("USUÁRIO");
        Console.WriteLine("------------------");
        Console.WriteLine("Nome: "+ Nome);
        Console.Write("Data de Nascimento: ");
        Console.WriteLine(Convert.ToUInt64(DataNasc).ToString(@"00\/00\/0000"));
        Console.Write("CPF: ");
        Console.WriteLine(Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00")); 
        Console.WriteLine("Seu Saldo: R$"+SaldoTotal);
        Console.WriteLine("------------------");

            Console.Write("Digite o valor do depósito: R$");
            Deposito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Depósito realizado com sucesso!!!");
        
    
            break;

            case 2: 
            Console.Clear();
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("USUÁRIO");
        Console.WriteLine("------------------");
        Console.WriteLine("Nome: "+ Nome);
        Console.Write("Data de Nascimento: ");
        Console.WriteLine(Convert.ToUInt64(DataNasc).ToString(@"00\/00\/0000"));
        Console.Write("CPF: ");
        Console.WriteLine(Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00")); 
        Console.WriteLine("Seu Saldo: R$"+SaldoTotal);
        Console.WriteLine("------------------");

            Console.Write("Digite o valor do Saque: R$");
            Saque = Convert.ToDouble(Console.ReadLine());
            if (Saque > SaldoTotal)
            {
                Console.WriteLine("Saque não pode ser realizado");
            }else
            {
                Console.WriteLine("Saque realizado com sucesso!!!");
    
            }
             break;

            case 3:Console.Clear();
            Console.WriteLine("Programa finalizado");
            break;

            default: Console.Clear();
            Console.WriteLine("Opcão inválida");
            break;
        }

        break;

            case 2:
            Console.Clear();
            Console.WriteLine("Programa finalizado");
            break;


            default:
            Console.Clear();
            Console.WriteLine("Opcão inválida");
            
            break;
        }
        

        
     }
     public void intoducao()
     {
        do 
        { 
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("Escolha uma das opcões de 1 à 3:");
        Console.WriteLine();
        Console.WriteLine("1 - Fazer Cadastro");
        Console.WriteLine("2 - Fazer Login");
        Console.WriteLine("3 - Encerrar Aplicação");
        Console.WriteLine();
        Console.Write("Sua escolha: ");


        escolha = Convert.ToDouble(Console.ReadLine());
        switch (escolha)
        {
            case 1:
            Cadastro cadastro2 = new Cadastro();
        cadastro2.ReceberDados();
        break;

            case 2:
            Console.Clear();
             Cadastro cadastro3 = new Cadastro();
        cadastro3.Entrar();
        break;

            case 3:
            Console.Clear();
            Console.WriteLine("Programa finalizado");
            break;


            default:
            Console.Clear();
            Console.WriteLine("Opcão inválida");
            
            break;
        }
            
        } while (escolha > 3);
    
     } 
     public string Nome1;
     public string Senha1;
     public void Entrar()
     {
        Console.WriteLine("***********************");
        Console.WriteLine("Banco da China");
        Console.WriteLine("***********************");
        Console.WriteLine("LOGIN");
        Console.WriteLine("------------------");
        Console.Write("Digite seu nome: ");
        Nome1 = Console.ReadLine();
        if (Nome != Nome1)
        {
             Console.Write("Usuário Inexistente");
        }
     }
    
 class Program
 {
    static void Main(string[] args)
    {
    
     Cadastro cadastro1 = new Cadastro();
        cadastro1.intoducao();
     
    }
  }
 }
}
