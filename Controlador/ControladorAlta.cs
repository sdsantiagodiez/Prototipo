using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Models;


namespace Controlador
{
    class ControladorAlta
    {
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
                    Models.ModeloArticulos nuevaEnti = new Models.ModeloArticulos();// Pasarle parametros
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
                    Models.ModeloProveedores nuevaEnti = new Models.ModeloProveedores();// Pasarle parametros
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
                    Models.ModeloArticuloProveedores nuevaEnti = new Models.ModeloArticuloProveedores();// Pasarle parametros
                    cap.agregarNuevaEntidad(nuevaEnti);
                    respuesta = "Entidad Creada satisfactoriamente";

                }
            }
            break;
            #endregion

               case '3'://nuevo Cliente
            CatalogoClientes cc = new CatalogoClientes();
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
                    Models.ModeloPersonas nuevaEnti = new Models.ModeloPersonas();// Pasarle parametros
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

        public ModeloProveedores buscarProveedor(string pProveedor)
        { 
        //Codificar
            ModeloProveedores modProv = new ModeloProveedores();
            return modProv;
        }

        public string[] buscarArticulo(string pAarticulo)
        { 
            //Codificar
            string[] articulo = new string[0]{};
            return articulo;
        }
    }
}
