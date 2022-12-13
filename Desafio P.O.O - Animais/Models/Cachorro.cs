using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_P.O.O___Animais.Models
{
    public class Cachorro: Animais
    {
        public override void EmitirSom(){
            Console.WriteLine("Som que emite: Au Au");
        }
    }
}