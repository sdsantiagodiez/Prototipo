using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Models;

namespace Controlador
{
    class Controlador
    {
        public void buscarArticulos(string pCodDes)
        {
            string[][] respuesta = new string[5][];

            CatalogoArticulos ca = new CatalogoArticulos();

            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();

            List<ModeloArticulos> aEncontrados = new List<ModeloArticulos>();

            List<ModeloArticulos> aAll = new List<ModeloArticulos>();
            aAll = ca.getAll();

            List<ModeloArticuloProveedores> apAll = new List<ModeloArticuloProveedores>();
            apAll = cap.getAll();
            ModeloArticuloProveedores ap = new ModeloArticuloProveedores();

            int i = 0;

            if (pCodDes.Length <= 10)
            {
                #region Busca en los Articulos si el parametro pasado coincide con alguno y lo agrega a aEncontrados
                foreach (ModeloArticulos modArt in aAll) // el parametro es codigo original o descripcion
                {
                    if (pCodDes.Equals(modArt.codigoOriginalArt) == true || pCodDes.Equals(modArt.codigoOriginalArt) == true)
                    {
                        aEncontrados.Add(modArt);
                    }
                    else
                    {
                        if (pCodDes.CompareTo(modArt.codigoOriginalArt) < 10 || pCodDes.CompareTo(modArt.codigoOriginalArt) < 100)
                        {
                            aEncontrados.Add(modArt);
                        }

                    }

                }

                #endregion
            }
            else
            {


                foreach (ModeloArticuloProveedores modArtProv in apAll)
                {
                    if (modArtProv.codigoArProveedor.Equals(pCodDes) == true)
                    {
                        ap = modArtProv;
                    }
                }
            }


            if (aEncontrados.Count != 0)
            {
                foreach (ModeloArticulos ae in aEncontrados)
                {
                    List<ModeloArticuloProveedores> AEncontrados = new List<ModeloArticuloProveedores>();

                    foreach (ModeloArticuloProveedores apr in apAll)
                    {
                        if (apr.codigoOriginalArt.Equals(ae.codigoOriginalArt) == true)
                        {
                            AEncontrados.Add(apr);
                        }
                    }

                    foreach (ModeloArticuloProveedores arp in AEncontrados)
                    {
                        respuesta[0][i] = arp.codigoOriginalArt;
                        respuesta[0][i] = arp.descripArPro;
                        respuesta[0][i] = arp.codigoArProveedor;
                        respuesta[0][i] = arp.razonSocialProv;
                        //respuesta[0][i] = falta valor venta. Agregar clase a models**
                        i++;
                    }


                }

            }
            else if (ap.codigoArProveedor != "")
            { /*
               Falta ultimo bucle DSD CUS 1.1
               */
            }
        }
    }
}
