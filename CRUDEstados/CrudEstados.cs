using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEstados
{
    public class CrudEstados
    {
        private static Dictionary<int, Estado> _estados = new Dictionary<int, Estado>();

        Estado objEstado = new Estado();

        public static Dictionary<int, Estado> ConsultarTodos()
        {
            return _estados;
        }
        public static Estado ConsultarUno(int id)
        {
            Estado estado = new Estado();
            if (_estados.ContainsKey(id))
            {
                estado = _estados[id];

            }
            return estado;
        }
        public static void Agregar(Estado estado)
        {
            _estados.Add(estado.id, estado);
        }
        public static void Actualizar(Estado estado)
        {
            _estados[estado.id] = estado;
        }
        public static void Eliminar(int id)
        {
            _estados.Remove(id);
        }
    }

}
