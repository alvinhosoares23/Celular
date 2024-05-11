using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Celurar.Models
    // TODO: Herdar da classe "Smartphone"
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo,string imei, int memoria) : base(numero,modelo, imei,memoria)
        {
  
        }

        public override void InstalarAplicativo(string nomeApp)
        {
           Console.WriteLine($"Instalando {nomeApp}...");
           Console.WriteLine($"{nomeApp} Instalado com Exito no Seu IPhone!");

        }
    }
}