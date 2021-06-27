using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TxtCounterStream.Properties;

namespace TxtCounterStream
{
    public class Counter
    {
        private int number = 0;
        public int Number
        {
            get { return number; }
            set { number = value; number = number < 0 ? 0 : value; }
        }
        public string Message { get; set; }
        public Counter(string msg, int n) 
        {
            Message = msg;
            Number = n;
        }
        string path = @"Resources\counter.txt";
        public void GenerateFile(IOperation op)
        {
            op.Operate(this);
            File.WriteAllText(path, $"{Message} {Number.ToString()}");
            Console.WriteLine($"Novo arquivo gerado no caminho {path} em {DateTime.Now}." +
                $" Conteúdo: {Message} {Number}");
        }
    }
}
