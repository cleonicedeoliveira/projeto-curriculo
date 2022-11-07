using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curriculo_projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String sobrenome;
            String sexo;
            String telefone;
            String CPF;
            String endereço;
            String cidade;
            String escolaridade;
            String nascimento;
            Console.WriteLine("Digte seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Digite seu sexo ");
            sexo = Console.ReadLine();
            Console.WriteLine("Digite seu telefone");
            telefone = Console.ReadLine();
            Console.WriteLine("Digite seu CPF");
            CPF = Console.ReadLine();
            Console.WriteLine("Digite seu endereço");
            endereço = Console.ReadLine();
            Console.WriteLine("Digite sua cidade");
            cidade = Console.ReadLine();
            Console.WriteLine("escreva seu grau de escolaridade");
            escolaridade = Console.ReadLine();
            Console.WriteLine("Insira sua data de nascimento");
            nascimento = Console.ReadLine();
            Console.WriteLine("_________________________________Informações do candidato_______________________________________");
            Console.WriteLine("Nome completo:" + " " + nome + "" + sobrenome);
            Console.WriteLine("Número de telefone:" + " " + telefone);
            Console.WriteLine("Seu CPF:" + " " + CPF);
            Console.WriteLine("Seu endereço:" + " " + endereço + " " + cidade);
            Console.WriteLine(escolaridade);
            Console.WriteLine(nascimento);

            Console.ReadKey();
        }
    }
}
