using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Cliente
    {
        /*Atributos*/
        private string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private int _cuentaBancaria;
        private int _cuit;
        private int _edad;
        private string _nombre;

        /*Propiedades*/
        

        /*Métodos*/
        public void GuardarEnDisco()
        { }

        public void ValidarCUIT()
        { }
    }
}
