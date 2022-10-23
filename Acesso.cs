using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjContaBancaria
{
    public class Acesso
    {
        public static void Login()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao banco do pobre, vamos criar sua conta ? Digite sim para continuar!");
            var confirmar = Console.ReadLine();
            if (confirmar == "sim")
            {
                Console.Clear();
                Console.WriteLine("Vamos prosseguir com a criação da usa conta digite os dados a seguir solicitados.");
                Console.WriteLine("Aperte qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Digite seu nome completo");
                string nomeCompleto = Console.ReadLine();
                Console.WriteLine("Digite seu Cpf");
                string Cpf = Console.ReadLine();
                Console.WriteLine("Digite seu Rg");
                string Rg = Console.ReadLine();
                Console.WriteLine($"{nomeCompleto}, {Cpf}, {Rg}");

                Random random = new Random();
                int numeroConta = random.Next(10000, 30000);
                ContaCorrente contaCorrente = new ContaCorrente(numeroConta, 0, new Cliente(nomeCompleto, Cpf, Rg));
                Console.Clear();
                Console.WriteLine("Conta Criada com sucesso!");
                Console.WriteLine("Aperte qualquer tecla para acessar");
                Console.ReadKey();
                var operacao = string.Empty;
                while (operacao != "4")
                {
                    Console.Clear();
                    Console.WriteLine("Qual operação deseja fazer a seguir ? Digite a desejada.");
                    Console.WriteLine("1 = Depositar");
                    Console.WriteLine("2 = Sacar");
                    Console.WriteLine("3 = Saldo");
                    Console.WriteLine("4 = Sair");
                    operacao = Console.ReadLine();
                    switch (operacao)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("Digite o valor a depositar");
                            decimal deposito = Convert.ToDecimal(Console.ReadLine());
                            contaCorrente.Depositar(deposito);
                            Console.WriteLine("Aperte qualquer tecla para voltar o menu");
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Digite o valor a sacar");
                            decimal saque = Convert.ToDecimal(Console.ReadLine());
                            contaCorrente.Sacar(saque);
                            Console.WriteLine("Aperte qualquer tecla para voltar o menu");
                            Console.ReadKey();
                            break;
                        case "3":
                            Console.Clear();
                            contaCorrente.MeuSaldo();
                            Console.WriteLine("Aperte qualquer tecla para voltar o menu");
                            Console.ReadKey();
                            break;
                        case "4":
                            Console.Clear();
                            Console.WriteLine("Muito obrigado por usar o Banco do Pobre!!");
                            break;
                    }


                }



            }
            else
            {
                Console.WriteLine("Até logo...");
            }
        }
    }
}