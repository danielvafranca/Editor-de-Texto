﻿// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.IO;

Menu();
static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que você quer fazer?");
    Console.WriteLine("[1] Abrir arquivo de texto \n[2] Criar novo arquivo \n[0] Sair \n");
    short option = short.Parse(Console.ReadLine()); 

    switch(option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Abrir(); break;
        case 2: Editar(); break;
        default: Menu(); break; 
    }

}
static void Abrir()
    {
        Console.Clear();
        Console.WriteLine(" Qual caminho do arquivo?");
        Console.WriteLine(" Ex: C:\\Users\\danie\\projetos\\Teste.txt ");
    string path = Console.ReadLine();

        using(var  file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
            Console.ReadLine();
            Menu();
        }
        Console.WriteLine(""); 
    }
static void Editar()

    {
        Console.Clear();
        Console.WriteLine("Digite seu texto a baixo:");
        Console.WriteLine("------------------------");
        Console.WriteLine("[Presione a tecla Esc para salvar]");
        string text = "";

    do
        {
            text += Console.ReadLine();
            text += Environment.NewLine; 
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape);
        
        Salvar(text);
    }
static void Salvar(string text)
{
    Console.Clear();
    Console.WriteLine(".Qual caminho para salvar o aqrquivo?");
    Console.WriteLine("[O arquivo tem que ser salvo como txt Ex: c:\\User\\teste.txt]");

    var path = Console.ReadLine(); 

    using(var file = new StreamWriter(path))
        {
            file.Write(text);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso");
        Console.ReadLine();
        Menu();


}