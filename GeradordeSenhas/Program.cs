using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Gerador de Senhas ===");

        Console.Write("Informe o tamanho da Senha: ");
        int tamanho = int.Parse(Console.ReadLine());

        Console.Write("Incluir letras? (s/n): ");
        bool incluirLetras = Console.ReadLine().ToLower() == "s";

        Console.Write("Incluir caracteres especiais? (s/n): ");
        bool incluirCaracteres = Console.ReadLine().ToLower() == "s";

        string senha = GerarSenha( tamanho, incluirLetras, incluirCaracteres);
        Console.WriteLine("A senha gerada é : " + senha);

        SalvarSenha(senha);
        Console.WriteLine("Senha salva no arquivo no arquivo 'bkp.TXT'.");

        Console.WriteLine("Deseja ver as senhas salvas? (s/n): ");

        if(Console.ReadLine().ToLower() == "s")
        {
            RecuperarSenhas();
        }
    }
}
