using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.Entidades
{
    class Cliente
    {
        private int _cliente_cuit;
        private string _nombre;
        private string _apellido;
        private bool _activo;

        public Cliente(int cuit, string nombre, string apellido, bool activo)
        {
            _cliente_cuit= cuit;
            _nombre=nombre;
            _apellido=apellido;
            _activo=activo;
    }

        public Cliente()
        {

        }

        public int Cuit { get { return _cliente_cuit; } set { _cliente_cuit = value; } }
        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public bool Activo { get { return _activo; } set { _activo = value; } }
    }
}
