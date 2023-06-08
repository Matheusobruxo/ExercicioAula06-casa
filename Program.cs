using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula06_casa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int agosto = 8, setembro = 9, outubro = 10;            
            int mEscolhido, dEscolhido;                            //D de day  // M de month
            string manha = "manha", tarde = "tarde", noite = "noite",
                choiseP;                                                      //periodo escolhido choise period
            string data = DateTime.Now.ToString("yyyy-MM-dd");


            Console.WriteLine("********************************************************");
            Console.WriteLine("Bem vindo a PombaTur!");
            Console.WriteLine("********************************************************");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Atualmente temos passagens poucas passagens disponíveis!");
            Console.WriteLine("Escolha o mês pretendido:");
            Console.WriteLine($"{agosto}- Agosto \n{setembro}- Setembro\n{outubro}- Outubro");
            mEscolhido = int.Parse(Console.ReadLine());
            Console.Clear();

            if (mEscolhido != agosto && mEscolhido != setembro && mEscolhido != outubro)
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("******************************************************");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

            Console.WriteLine("Temos passagens disponíveis para esse mês!!");
            Console.WriteLine($"Escolha um dia entre 06/{mEscolhido} e 21/{mEscolhido}. ");
            dEscolhido = int.Parse(Console.ReadLine());
            Console.Clear();

            if (dEscolhido < 6 || dEscolhido > 21)
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("Opção inválida!");
                Console.WriteLine("******************************************************");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }
            Console.WriteLine("******************************************************");
            Console.WriteLine("**********ESCOLHA O PERIODO DA SUA PASSAGEM***********");
            Console.WriteLine("******************************************************");
            Console.WriteLine("1 - manhã \n2 - Tarde \n3 - Noite ");
            choiseP = Console.ReadLine();
            Console.Clear();

            if (choiseP != manha && choiseP != tarde && choiseP != noite)
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("Periodo inválido!");
                Console.WriteLine("******************************************************");
                Console.ReadKey();
                Console.Clear();
                Main(null);
                return;
            }

             
            Console.WriteLine("**************A passagem foi comprada com sucesso!!*************");
            Console.WriteLine("**************************** Recibo ****************************\n\n");
            Console.WriteLine($"Compra efetuada na data: {data}");
            Console.WriteLine($"Viagem agendada para o dia {dEscolhido}/{mEscolhido}!!");
            Console.WriteLine($"No periodo da {choiseP}!!");
            Console.ReadKey();


            Console.Clear();
        }
    }
}
