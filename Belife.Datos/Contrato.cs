//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Belife.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contrato
    {
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
    
        public virtual Cliente Cliente { get; set; }
        public virtual Plan Plan { get; set; }
    }
}
