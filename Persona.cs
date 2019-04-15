using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    public class Persona : Mamifero, IComportamientoHumano, IProgramar
    {
        public void Conversar(Persona persona)
        {
            throw new NotImplementedException();
        }

        public void EscribeHelloWorld()
        {
            Console.WriteLine("print('hello world')");
        }

        public void Pensar()
        {
            // implementar
        }

        public void Programa()
        {
            throw new NotImplementedException();
        }
    }
}
