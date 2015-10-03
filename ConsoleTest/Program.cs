using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using Datos;


namespace ConsoleTest
{
    public class TestingCatalogo
    {
        
        
        static void Main(string[] args)
        {
            TestingCatalogo tc = new TestingCatalogo();
            //////////////////////////////////

            tc.generarArticulosProveedores();
            
            /////////////////////////////////
            tc.salir();
        }

        private void salir()
        {
            Console.Write("Presione tecla para finalizar: ");
            Console.ReadKey();
        }

        private void generarDatos()
        {
            this.generarPersonas();
            this.generarProveedores();
            this.generarArticulos();
            this.generarPedidos();
        }
        
        #region Personas
        #region Generar Personas
        private void generarPersonas()
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            ModeloPersonas persona = new ModeloPersonas();
            List<string> apellidos = getApellidos();
            List<string> nombres = getNombres();
            List<string> dnis = getDNIs();
            List<string> direcciones = getDirecciones();
            List<string> ciudades = getCiudades();
            List<string> observaciones = getObservaciones();
            List<string> cuits = getCUITs();

            int longApellidos = apellidos.Count;
            int longNombres = nombres.Count;
            int longDirecciones = direcciones.Count;
            int longCiudades = ciudades.Count;
            int longObservaciones = observaciones.Count;

            Random rnd = new Random();
            for (int i = 0; i < 500; i++)
            {
                int ape = rnd.Next(longApellidos);
                int nom = rnd.Next(longNombres);
                int dir = rnd.Next(longDirecciones);
                int ciu = rnd.Next(longCiudades);
                int obs = rnd.Next(longObservaciones);
                persona = new ModeloPersonas();
                
                persona.apellido = apellidos[ape];
                persona.nombre = nombres[nom];
                persona.dni = dnis[i];
                persona.cuit = cuits[i];
                persona.direccion = direcciones[dir];
                persona.ciudad = ciudades[ciu];
                persona.observaciones = observaciones[obs];
                persona.codigoPostal = "2132";
                persona.provincia = "Santa Fe";

                cp.agregarNuevaEntidad(persona);
 
            }
        }
        private List<string> getApellidos()
        {
            List<string> apellidos = new List<string>();

            apellidos.Add("Alvarez");
            apellidos.Add("Acosta");
            apellidos.Add("Bal");
            apellidos.Add("Cornejo");
            apellidos.Add("Casciani");
            apellidos.Add("Diez");
            apellidos.Add("Diaz");
            apellidos.Add("Ferrero");
            apellidos.Add("Lopez");
            apellidos.Add("Martinez");
            apellidos.Add("Nuñez");
            apellidos.Add("De Paoli");
            apellidos.Add("D'Lorian");
            apellidos.Add("Bortolotto");
            apellidos.Add("Jaskowsky");
            apellidos.Add("Thruman");

            return apellidos;
        }
        private List<string> getNombres()
        {
            List<string> nombres = new List<string>();

            nombres.Add("Agustina");
            nombres.Add("Iliana");
            nombres.Add("Belén");
            nombres.Add("Berenice");
            nombres.Add("Bruno Jorge");
            nombres.Add("Javier");
            nombres.Add("Juan");
            nombres.Add("Celeste");
            nombres.Add("María Juana");
            nombres.Add("Juana");
            nombres.Add("Oliver");
            nombres.Add("Arya");
            nombres.Add("Jon");
            nombres.Add("Harry");
            nombres.Add("Neo");
            nombres.Add("Trinity");
            nombres.Add("Jack");
            nombres.Add("Jennifer");
            nombres.Add("Emma");
            nombres.Add("Alice");
            nombres.Add("Sofía");
            nombres.Add("Marcelo");
            nombres.Add("Leandro");

            return nombres;
        }
        private List<string> getDNIs()
        {
            List<string> lista = new List<string>();

            int dni = 20000000;
            for (int i = 0; i < 500; i++)
            {
                lista.Add((dni + i).ToString());
            }

                return lista;
        }
        private List<string> getCUITs()
        {
            List<string> lista = new List<string>();
            int dni = 20000000;
            string prefijo = "21";
            string sufijo = "4";
            for (int i = 0; i < 500; i++)
            {
                lista.Add(prefijo+"-"+(dni + i).ToString()+"-"+sufijo);
            }
            return lista;
        }
        private List<string> getDirecciones()
        {
            List<string> lista = new List<string>();

            lista.Add("Buenos Aires 13");
            lista.Add("Tucumán 1555");
            lista.Add("General Paz 412");
            lista.Add("Villegaz 444");
            lista.Add("Montevideo 240");
            lista.Add("San Martín 1");
            lista.Add("Corrientes 65");
            lista.Add("Independencia 77");
            lista.Add("Esclavitud 12312");
            lista.Add("Dermatitis 50");
            lista.Add("Paloma 12");
            lista.Add("Uriburu 0");
            lista.Add("San Pedro 21");
            lista.Add("El Loco 22");
            lista.Add("El Loro 99");
            lista.Add("La Cuñada 69");
            lista.Add("Martinez 1111");
            lista.Add("Falsa 123");
            lista.Add(null);

            return lista;
        }
        private List<string> getCiudades()
        {
            List<string> lista = new List<string>();

            lista.Add("Rosario");
            lista.Add("Funes");
            lista.Add("San Lorenzo");
            lista.Add("Carcaraña");
            lista.Add("San Nicolás");
            lista.Add(null);

            return lista;
        }
        private List<string> getObservaciones()
        {
            List<string> lista = new List<string>();

            lista.Add("Observaciones de prueba 1");
            lista.Add("Observaciones de prueba 2");
            lista.Add("Observaciones de prueba 3");
            lista.Add("Observaciones de prueba 4");
            lista.Add("Observaciones de prueba 5");
            lista.Add("Observaciones de prueba 6");
            lista.Add("Observaciones de prueba 7");
            lista.Add(null);

            return lista;
        }
        #endregion
        #region bajaEntidads
        private void bajaEntidads()
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            List<ModeloPersonas> personas = cp.getAll();
            foreach(ModeloPersonas p in personas)
            {
                cp.bajaEntidad(p);
            }
        }

        #endregion
        #region Actualizar
        private void actualizarEntidad()
        {
            ModeloPersonas mp = new ModeloPersonas();
            CatalogoPersonas cp = new CatalogoPersonas();
            mp = cp.getOnePorDNI("20000001");
            mp.nombre = "Santiago";
            cp.actualizarEntidad(mp);
        }
        #endregion
        #endregion
        #region Proveedores
        private void generarProveedores()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            ModeloProveedores proveedor = new ModeloProveedores();

            List<string> razonesSociales = getRazonSocial();
            List<string> direcciones = getDirecciones();
            List<string> ciudades = getCiudades();
            List<string> observaciones = getObservaciones();
            List<string> cuits = getCUITs();

            int longDirecciones = direcciones.Count;
            int longCiudades = ciudades.Count;
            int longObservaciones = observaciones.Count;

            Random rnd = new Random();
            for (int i = 0; i < razonesSociales.Count; i++)
            {
                int dir = rnd.Next(longDirecciones);
                int ciu = rnd.Next(longCiudades);
                int obs = rnd.Next(longObservaciones);
                proveedor = new ModeloProveedores();

                proveedor.razonSocial = razonesSociales[i];
                proveedor.cuit = cuits[i];
                proveedor.direccion = direcciones[dir];
                proveedor.ciudad = ciudades[ciu];
                proveedor.observaciones = observaciones[obs];
                proveedor.codigoPostal = "2132";
                proveedor.provincia = "Santa Fe";

                cp.agregarNuevaEntidad(proveedor);
            }
        }
        private List<string> getRazonSocial()
        {
            List<string> lista = new List<string>();
            lista.Add("Repuestos 01 SA");
            lista.Add("Repuestos 02 SA");
            lista.Add("Repuestos 03 SA");
            lista.Add("Repuestos 04 SA");
            lista.Add("Repuestos 05 SA");
            lista.Add("Repuestos 06 SA");
            lista.Add("Repuestos 07 SA");
            lista.Add("Repuestos 08 SA");
            lista.Add("Repuestos 09 SA");
            lista.Add("Repuestos 10 SA");
            lista.Add("Repuestos 11 SA");
            lista.Add("Repuestos 12 SA");
            lista.Add("Repuestos 13 SA");
            lista.Add("Repuestos 14 SA");
            lista.Add("Repuestos 15 SA");
            lista.Add("Repuestos 16 SA");
            lista.Add("Repuestos 17 SA");
            lista.Add("Repuestos 18 SA");
            lista.Add("Repuestos 19 SA");

            return lista;
        }
        private void bajaEntidades()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            List<ModeloProveedores> provs = new List<ModeloProveedores>();
            provs = cp.getAll();
            foreach(ModeloProveedores p in provs)
            {
                cp.bajaEntidad(p);
            }
        }
        private void actualizarEntidades()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            List<ModeloProveedores> provs = new List<ModeloProveedores>();
            provs = cp.getAll();
            foreach (ModeloProveedores p in provs)
            {
                p.observaciones = "sin";
                cp.actualizarEntidad(p);
            }
        }
        #endregion
        #region Articulos
        private void generarArticulos()
        {
            CatalogoArticulos ca = new CatalogoArticulos();
            ModeloArticulos ma;
            int cantCodigosOriginales = 1000;
            int cantDescripciones = 250;
            int cantModelos = 50;
            
            List<string> codigosOriginales = getCodigosOriginales(cantCodigosOriginales);
            List<string> descripciones = getDescripciones(cantDescripciones);
            List<string> modelos = getModelos(cantModelos);
            List<string> observaciones = getObservaciones();
            int cantObservaciones = observaciones.Count;

            Random rnd = new Random();
            for (int i = 0; i < cantCodigosOriginales; i++)
            {
                int desc = rnd.Next(cantDescripciones+1);
                int mod = rnd.Next(cantModelos+1);
                int obs = rnd.Next(cantObservaciones);
                ma = new ModeloArticulos();

                ma.codigoOriginal = codigosOriginales[i];
                ma.descripcion = descripciones[desc];
                ma.modelos = modelos[mod];
                ma.observaciones = observaciones[obs];
                
                ca.agregarNuevaEntidad(ma);
            }
        }
        private List<string> getCodigosOriginales(int cantidad)
        {
            List<string> lista = new List<string>();
            int prefijo = 0;
            string medio = "-ART-REN-";
            int sufijo = 0;
            for (int i = 0; i < cantidad; i++)
            {
                if (sufijo > 99)
                {
                    sufijo = 0;
                    prefijo = prefijo + 1;
                }
                lista.Add(prefijo.ToString("00") + medio + sufijo.ToString("00"));
                sufijo = sufijo + 1;
            }

                return lista;
        }
        private List<string> getDescripciones(int cantidad)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < cantidad; i++)
            {
                lista.Add("Descripción " + i.ToString("0000"));
            }
            lista.Add(null);

            return lista;
        }
        private List<string> getModelos(int cantidad)
        {
            List<string> lista = new List<string>();

            for (int i = 0; i < cantidad; i++)
            {
                lista.Add("Modelo "+ i.ToString("00"));
            }
            lista.Add(null);
            return lista;
        }
        #endregion

        #region ArticulosProveedores
        private void generarArticulosProveedores()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            CatalogoArticulos ca = new CatalogoArticulos();
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
            List<ModeloProveedores> proveedores = cp.getAll();
            int cantProveedores = proveedores.Count;
            List<ModeloArticulos> articulos = ca.getAll();
            int cantArticulos = articulos.Count;
            int cantArticulosProveedores = 5000;
            Random rnd = new Random();
            ModeloArticuloProveedores map = new ModeloArticuloProveedores();

            int cantModelos = 50;
            int cantDescripciones = 250;
            List<string> descripciones = getDescripciones(cantDescripciones);
            List<string> modelos = getModelos(cantModelos);
            List<string> observaciones = getObservaciones();
            int cantObservaciones = observaciones.Count;
            for (int i = 0; i < cantArticulosProveedores; i++)
            {
                int sufijo = 0;
                int prov = rnd.Next(cantProveedores);
                int art = rnd.Next(cantArticulos);
                map.codigoArticuloProveedor = getCodigosArticulosProveedores(prov, articulos[art].codigoOriginal, sufijo);
                while (cap.existeEntidad(map))
                {
                    sufijo = sufijo + 1;
                    map.codigoArticuloProveedor = getCodigosArticulosProveedores(prov, articulos[art].codigoOriginal, sufijo);
                }
                map.razonSocialProveedor = proveedores[prov].razonSocial;
                map.codigoOriginal = articulos[art].codigoOriginal;
                int desc = rnd.Next(cantDescripciones + 1);
                int mod = rnd.Next(cantModelos + 1);
                int obs = rnd.Next(cantObservaciones);

                map.descripcion = descripciones[desc];
                //map.modelos = modelos[mod];
                map.observaciones = observaciones[obs];

                cap.agregarNuevaEntidad(map);
            }
        }
        private string getCodigosArticulosProveedores(int prov, string art, int sufijo)
        {
            return "PROV-"+(prov+1).ToString("00")+"/"+art+"/"+sufijo.ToString("00");
        }
        #endregion

        private void generarPedidos()
        { 
        }       
    }

}
