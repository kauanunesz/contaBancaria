using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        private string nome;
        private DateTime nasc;
        private string cpf;
        private float saldo;
        private string password;


        public string Nome { get => nome; set => nome = value; }
        public DateTime Nasc { get => nasc; set => nasc = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public string Password { get => password; set => password = value; }

        public void cadastrarConta()
        {
            
            Console.WriteLine("Qual o seu nome?");
            this.Nome = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Qual a sua data de nascimento?");
            this.Nasc = DateTime.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Insira seu cpf:");
            this.Cpf = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Insira sua senha: ");
            this.Password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Seja bem-vindo(a), {this.Nome}\n");
        }

        public void movimentarConta()
        {
            if (this.Nome == null)
            {
                Console.Clear();
                Console.WriteLine("Sua conta ainda não foi cadastrada. Cadastre uma conta");
                cadastrarConta();
            }

            bool conf = true;
            Console.Clear();
            this.Saldo = 0.0f;
            Console.WriteLine("Saldo inicial:" + this.Saldo);
            while (conf)
            {
                Console.WriteLine("\nInsira uma opção: ");
                Console.WriteLine("1 - Ver Saldo");
                Console.WriteLine("2 - Adicionar Valor");
                Console.WriteLine("3 - Sacar Valor");
                Console.WriteLine("4 - Voltar ao menu inicial");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        this.verSaldo();
                        break;

                    case 2:
                        Console.Clear();
                        this.adicionarValor();
                        break;

                    case 3:
                        Console.Clear();
                        this.sacar();
                        break;

                    case 4:
                        Console.Clear();
                        conf = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Número inválido!");
                        break;
                }
            }
        }

        public void verSaldo()
        {
            Console.WriteLine($"Seu saldo atual é {Saldo}");
        }

        public void adicionarValor()
        {
            float valor;
            Console.WriteLine("Insira um valor:");
            valor = float.Parse(Console.ReadLine());
            Saldo += valor;
            Console.WriteLine($"Seu saldo atual é {Saldo}");
        }

        public void sacar()
        {
            float saque;
            bool val = true;

            while (val)
            {
                Console.WriteLine("Insira o valor do saque:");
                saque = float.Parse(Console.ReadLine());

                if (saque <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Valor inválido. Insira um valor maior que zero.");
                }
                else if (saque > Saldo)
                {
                    Console.Clear();
                    Console.WriteLine($"Saldo insuficiente. Seu saldo atual é: {Saldo:c}");
                }
                else
                {
                    Saldo -= saque;
                    Console.Clear();
                    Console.WriteLine($"Saque realizado com sucesso. Seu saldo atual é: {Saldo:c}");
                    val = false; 
                }
            }
        }

    }
}
