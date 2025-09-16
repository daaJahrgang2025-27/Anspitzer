using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anspitzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(1, 1));

            int[] test = { 1, 2, 3, 4, 5 };
        }
        private static int Add(int a, int b)
        {
            return a + b;
        }
    }

    public class fetteListe
    {

        private int index;

        public class dickesElement
        {
            private dickesElement nextElement;
            private dickesElement previousElement;
            public dickesElement getElement()
            {
                return this;
            }
            public dickesElement getNext()
            {
                return this.nextElement.getElement();
            }
        }



    }
}

namespace Test
{
    public class Testing
    {

        private static int amountOfTests = 0;
        private Testing self;

        public Testing()
        {
            amountOfTests++;
            this.self = this;
        }

        public Testing getThis(int index)
        {
            switch (index)
            {

                case 0:
                    return this;
                    break;
                case 1:
                    return this;
                    break;
                default:
                    return null;
                    break;
            }
        }

    }

}
