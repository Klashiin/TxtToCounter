using System;
using System.Collections.Generic;
using System.Text;

namespace TxtCounterStream
{
    public interface IOperation
    {
        void Operate(Counter c1);
    }
    public class Add : IOperation
    {
        public void Operate(Counter c1)
        {
            c1.Number++;
        }
    }
    public class Sub : IOperation
    {
        public void Operate(Counter c1)
        {
            c1.Number--;
        }
    }
    public class Reset : IOperation
    {
        public void Operate(Counter c1)
        {
            c1.Number = 0;
        }
    }

}
