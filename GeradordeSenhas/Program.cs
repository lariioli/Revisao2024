using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== Gerador de Senhas ===");
        Console.ResetColor();

        Console.Write("Informe o tamanho da Senha: ");
        int tamanho = int.Parse(Console.ReadLine());

        Console.Write("Incluir letras? (s/n): ");
        bool incluirLetras = Console.ReadLine().ToLower() == "s";

        Console.Write("Incluir caracteres especiais? (s/n): ");
        bool incluirCaracteres = Console.ReadLine().ToLower() == "s";

        string senha = GerarSenha(tamanho, incluirLetras, incluirCaracteres);
         Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("A senha gerada é: " + senha);
        Console.ResetColor();

        SalvarSenha(senha);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Senha salva no arquivo 'bkp.TXT'.");
        Console.ResetColor();

        Console.Write("Deseja ver as senhas salvas? (s/n): ");
        if (Console.ReadLine().ToLower() == "s")
        {
            RecuperarSenhas();
        }

