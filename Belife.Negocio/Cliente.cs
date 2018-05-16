using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belife.Negocio
{
    class Cliente
    {
        //Atributos de la clase cliente
        public string RutCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public int IdSexo { get; set; }
        public int IdEstadoCivil { get; set; }

    }
}
