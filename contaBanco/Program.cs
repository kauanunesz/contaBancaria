using Banco;
using System.Runtime.CompilerServices;

Cliente cliente01 = new Cliente();

Console.WriteLine("Olá, seja bem-vindo(a) ao banco.");

//Teste do GitHub

bool opc = true;
while (opc)
{
    Console.WriteLine("Insira uma opção");
    Console.WriteLine("1 - Cadastrar Conta");
    Console.WriteLine("2 - Movimentar Conta");
    Console.WriteLine("3 - Sair");
    int escolha = int.Parse(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Olá! Insira suas informações para criação da sua Conta: ");
            cliente01.cadastrarConta();
            break;

        case 2:
            cliente01.movimentarConta();
            break;

        case 3:
            Console.WriteLine("Fim do programa");
            opc = false;
            break;

        default:
            Console.WriteLine("Número inválido. Insira um valor válido: ");
            break;
    }


}