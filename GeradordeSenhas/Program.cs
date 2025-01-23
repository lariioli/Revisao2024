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
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Programa encerrado.");
        Console.ResetColor();
    }

    static string GerarSenha(int tamanho, bool incluirLetras, bool incluirEspeciais)
    {
        string numeros = "0123456789";
        string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string especiais = "@#$%&*";
        string caracteres = numeros;

        if (incluirLetras) caracteres += letras;
        if (incluirEspeciais) caracteres += especiais;

        Random random = new Random();
        string senha = "";
        for (int i = 0; i < tamanho; i++)
        {
            senha += caracteres[random.Next(caracteres.Length)];
        }

        return senha;
    }

    static void SalvarSenha(string senha)
    {
        string caminho = "bkp.TXT";
        File.AppendAllText(caminho, senha + Environment.NewLine);
    }

    static void RecuperarSenhas()
    {
        string caminho = "bkp.TXT";

        if (File.Exists(caminho))
        {
            string[] senhas = File.ReadAllLines(caminho);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Senhas salvas:");
            foreach (string senha in senhas)
            {
                Console.WriteLine(senha);
            }
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nenhuma senha encontrada.");
            Console.ResetColor();
        }
    }
}


