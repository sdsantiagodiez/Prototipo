using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace Controlador
{
    class ControladorAlta
    {
        public string altaEntidad(string[] pParametros)//pParametros esta conformado en primer lugar con 0-Articulos, 1-Proveedor
        {
            string respuesta;
            //Se crea el Catalogo de Articulos para interactuar con los Articulos
           switch(Convert.ToChar(pParametros[0]))
           {
            case '0': //nuevo Articulo
           CatalogoArticulos ca = new CatalogoArticulos();
            #region Alta Articulo        
           bool rta = ca.validarDatos(pParametros);

            if (rta == false)//Validamos que los datos ingresados sean correctos
            {
                respuesta = "Los parametros ingresados no son válidos";
            }
            else
            {
                bool rta2 = ca.existeEntidad(pParametros);

                if (rta2 == true)
                { respuesta = "Entidad ya existente"; }
                else
                {
                    Models.ModeloArticulos nuevaEnti = new Models.ModeloArticulos();// Pasarle parametros
                    ca.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente";

                }
            }
            break;
#endregion
            
               case '1'://nuevo Proveedor
            CatalogoProveedores cap = new CatalogoProveedores();
            #region Alta Proveedor
            bool rtaprov = cap.validarDatos(pParametros);

            if (rtaprov == false)//Validamos que los datos ingresados sean correctos
            {
                respuesta = "Los parametros ingresados no son válidos";
            }
            else
            {
                bool rta2 = cap.existeEntidad(pParametros);

                if (rta2 == true)
                { respuesta = "Entidad ya existente"; }
                else
                {
                    Models.ModeloProveedores nuevaEnti = new Models.ModeloProveedores();// Pasarle parametros
                    cap.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente";

                }
            }
#endregion
            break;

               default: respuesta = "Error entidad"; break;
           }
            //Validamos los datos como parametros
            
            return respuesta;

        }

    }
}
