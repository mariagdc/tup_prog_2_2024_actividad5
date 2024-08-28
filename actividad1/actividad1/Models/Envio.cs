using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad1.Models
{
    internal class Envio
    {


        public int id { get; set;}
        public double Valor_total { get; set;}
        List<Costo> costos { get; set; } = new List<Costo>();
    }
}
