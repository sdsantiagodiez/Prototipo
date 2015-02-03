using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controlador
{
    public class CatalogoProveedores
    {
        public bool existeEntidad(string[] pDatos)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloProveedores> listProv = this.getAll();

            foreach (ModeloProveedores modPro in listProv)
            {
                if (pDatos[1] == modPro.cuitProv) /*|| (pDatos[2] = modPro.razonSocialProv)*/// Se busca si el proveedor ya existe comparando el codigo original
                {// ver como pasar los parametros
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }


        public bool validarDatos(string[] pDatos)
        {
            //Valida que los parametros sean Validos en el dominio
            bool rta = false;
            return rta;
        }
        public List<ModeloProveedores> getAll()
        {
            List<ModeloProveedores> allProvs = new List<ModeloProveedores>();

            ModeloProveedores modPro = new ModeloProveedores();
            allProvs.Add(modPro);

            return allProvs;
        }

        public void agregarNuevaEntidad(ModeloProveedores pModArt)
        {
            //Insertar un nuevo Articulo
        }

    }
}
