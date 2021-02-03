using System;
using System.IO;
using TxtCounterStream.Properties;

namespace TxtCounterStream
{
    public class Program
    {
        static void Main(string[] args)
        {
            var msg = @"Resources\message.txt";
            Counter c1 = new Counter(File.ReadAllText(msg), 0);
            Console.WriteLine("CounterToTxt v1.0 by Klashiin");
            Console.WriteLine("COPIA NÃO COMÉDIA");
            Console.WriteLine($"{Environment.NewLine}" +
                "'-add': Adiciona +1 ao contador");
            Console.WriteLine("'-sub': Reduz -1 do contador");
            Console.WriteLine("'-reset': Reinicia o contador para 0");
            Console.WriteLine("'-message': Personaliza a mensagem do contador");
            for(int i = 1; i > 0; i++)
            {
                string input = Console.ReadLine();
                switch(input)
                {
                    case "-add":
                        c1.GenerateFile(new Add());
                        break;

                    case "-sub":
                        c1.GenerateFile(new Sub());
                        break;

                    case "-reset":
                        c1.GenerateFile(new Reset());
                        break;

                    case "-message":
                        Console.WriteLine($"Mensagem atual: '{c1.Message}'. Deseja alterar? (S/N) ");
                        string s = Console.ReadLine();
                        if(s.ToLower() == "s")
                        {
                            Console.WriteLine("Insira a nova mensagem:");
                            string a = Console.ReadLine();
                            File.WriteAllText(msg, a);
                            Console.WriteLine("Mensagem atualizada.");
                        }
                        break;

                    default:
                        Console.WriteLine("Comando inválido.");
                        break;
                }
                c1.Message = File.ReadAllText(msg);
            }
            Console.ReadLine();
        }
    }
}
