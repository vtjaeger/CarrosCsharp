using System;
using System.Collections.Generic;
using System.Threading;
using Carros.Funcoes;

public class FuncaoCarro
{
    public static void MostraTexto(Dictionary<string, double> listaCarros)
    {
        FuncaoSleep.Intervalo();
        Console.Clear();
        Console.WriteLine("Bem vindo a biblioteca de carros da familia Toldo Jaeger!\n\nSe deseja adicionar um carro, clique 1.");
        Console.WriteLine("Se desejada mostrar os carros, clique 2");
        int opcao = Convert.ToInt32(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                Console.WriteLine($"\nOpcao escolhida numero {opcao}.\n");
                AdicionarCarro(listaCarros);
                return;

            case 2:
                Console.WriteLine($"\nOpcao escolhida numero {opcao}.\n");
                MostraCarros(listaCarros);
                return;
        }
    }

    public static void AdicionarCarro(Dictionary<string, double> listaCarros)
    {
        Console.WriteLine("Informe o carro que deseja adicionar:");
        string modeloCarroAtual = Console.ReadLine()!;

        Console.WriteLine($"Informe o valor do carro {modeloCarroAtual}:");
        double precoCarroAtual = Convert.ToDouble(Console.ReadLine()!);

        listaCarros[modeloCarroAtual] = precoCarroAtual;

        Console.WriteLine($"\nConfirmando o carro adicionado.\n Modelo: {modeloCarroAtual}");
        Console.WriteLine($" Preco: {precoCarroAtual}\n");

        FuncaoSleep.Intervalo();

        Console.WriteLine("Voltando ao menu principal...");
        MostraTexto(listaCarros);
    }

    public static void MostraCarros(Dictionary<string, double> listaCarros)
    {
        if (listaCarros.Count == 0)
        {
            Console.WriteLine("0 carros cadastrados.");
        }
        else
        {
            Console.WriteLine("Carros cadastrados:");
            foreach (var carro in listaCarros)
            {
                Console.WriteLine($"Modelo: {carro.Key}\nPreço: {carro.Value}\n\n");
            }
        }

        FuncaoSleep.Intervalo();

        Console.WriteLine("Pressione Enter para voltar ao menu principal...");
        ConsoleKeyInfo chaveApertada = Console.ReadKey();

        if(chaveApertada.Key == ConsoleKey.Enter)
        {
            MostraTexto(listaCarros);
        }
    }
}