using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using System.Text.RegularExpressions;


namespace Controladores
{
    public class ControladorAlta : Controlador
    {
        /*
         * Revisar
        public string altaEntidad(string[] pParametros)//pParametros esta conformado en primer lugar con 0-Articulos, 1-Proveedor, 2 Articulo Proveedor, 3 Cliente
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
                    Modelos.ModeloArticulos nuevaEnti = new Modelos.ModeloArticulos();// Pasarle parametros
                    ca.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente";

                }
            }
            break;
#endregion
            
               case '1'://nuevo Proveedor
            CatalogoProveedores cp = new CatalogoProveedores();
            #region Alta Proveedor
            bool rtaprov = cp.validarDatos(pParametros);

            if (rtaprov == false)//Validamos que los datos ingresados sean correctos
            {
                respuesta = "Los parametros ingresados no son válidos"; 
            }
            else
            {
                bool rta2 = cp.existeEntidad(pParametros);

                if (rta2 == true)
                { respuesta = "Entidad ya existente";  }
                else
                {
                    Modelos.ModeloProveedores nuevaEnti = new Modelos.ModeloProveedores();// Pasarle parametros
                    cp.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente"; 

                }
            }
            break;
#endregion

               case '2'://nuevo Articulo Proveedor
           CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
            #region Alta Articulo Proveedor
            bool rtaartprov = cap.validarDatos(pParametros);

            if (rtaartprov == false)//Validamos que los datos ingresados sean correctos
            {
                respuesta = "Los parametros ingresados no son válidos";
            }
            else
            {
                bool rta2 = cap.existeEntidad(pParametros[2]);

                if (rta2 == true)
                { respuesta = "Entidad ya existente"; }
                else
                {
                    Modelos.ModeloArticuloProveedores nuevaEnti = new Modelos.ModeloArticuloProveedores();// Pasarle parametros
                    cap.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente";

                }
            }
            break;
            #endregion

               case '3'://nuevo Cliente
            CatalogoPersonas cc = new CatalogoPersonas();
            #region Alta Cliente
            bool rtacli = cc.validarDatos(pParametros);

            if (rtacli == false)//Validamos que los datos ingresados sean correctos
            {
                respuesta = "Los parametros ingresados no son válidos";
            }
            else
            {
                bool rta2 = cc.existeEntidad(pParametros);

                if (rta2 == true)
                { respuesta = "Entidad ya existente"; }
                else
                {
                    Modelos.ModeloPersonas nuevaEnti = new Modelos.ModeloPersonas();// Pasarle parametros
                    cc.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente";

                }
            }
            break;
            #endregion


               default: respuesta = "Error entidad"; break;
           }
            
            
            return respuesta;

        }
        */
        
        /// <summary>
        /// Genera nombre de usuario (REVISAR si es buena idea)
        /// </summary>
        /// <param name="pCodigoEntidad"></param>
        /// <returns></returns>
        public string generarNombreUsuario(string pNombre, string pApellido)
        {
            string nombreDeUsuario = null;
            
            nombreDeUsuario = "";
            //se elimina del nombre y apellido todos los caracteres no alfanuméricos
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            string nombre = rgx.Replace(pNombre, "");
            string apellido = rgx.Replace(pApellido, "");
            nombreDeUsuario = (pApellido[0] + pNombre).ToLower();

            //Si nombreDeUsuario existe, se entra en la iteración para agregar un número al final
            //del usuario hasta que usuario no exista
            CatalogoPersonas cp = new CatalogoPersonas();
            for (int i = 1; cp.getOnePorUsuario(nombreDeUsuario) != null; i++)
            {
                //se vuelve a instanciar para que sólo cambie el número al final
                nombreDeUsuario = "";
                nombreDeUsuario = (pApellido[0] + pNombre + i.ToString()).ToLower();
            }
            
            return nombreDeUsuario;
        }
    }
}
