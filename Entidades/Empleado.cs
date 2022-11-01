using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTuLuz.Entidades
{
    class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _tipo_doc;
        private string _num_doc;
        private string _direccion;
        private int _id_barrio;
        private string _telefono;
        private int _jefe_id;
        private bool _activo;

        public Empleado(string nombre, string apellido, string tipo_doc, string num_doc, string direccion,int id_barrio, string telefono, int jefe_id, bool activo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _tipo_doc = tipo_doc;
            _num_doc = num_doc;
            _direccion = direccion;
            _id_barrio = id_barrio;
            _telefono = telefono;
            _jefe_id = jefe_id;
            _activo = activo;
        }

        public Empleado()
        {

        }

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public string TipoDoc { get { return _tipo_doc; } set { _tipo_doc = value; } }
        public string NumDoc { get { return _num_doc; } set { _num_doc = value; } }
        public string Direccion { get { return _direccion; } set { _direccion = value; } }
        public int IdBarrio { get { return _id_barrio; } set { _id_barrio = value; } }
        public string Telefono { get { return _telefono; } set { _telefono = value; } }
        public int JefeId { get { return _jefe_id; } set { _jefe_id = value; } }
        public bool Activo { get { return _activo; } set { _activo = value; } }

    }
}
