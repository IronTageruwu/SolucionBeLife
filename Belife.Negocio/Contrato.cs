using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belife.Negocio
{
    class Contrato
    {
        //Atributos de la clase contrato
        public string Numero { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string RutCliente { get; set; }
        public string CodigoPlan { get; set; }
        public System.DateTime FechaInicioVigencia { get; set; }
        public System.DateTime FechaFinVigencia { get; set; }
        public bool Vigente { get; set; }
        public bool DeclaracionSalud { get; set; }
        public double PrimaAnual { get; set; }
        public double PrimaMensual { get; set; }
        public string Observaciones { get; set; }

    }
}
