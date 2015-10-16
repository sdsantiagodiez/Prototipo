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

        #region script Valores
        /*
            --Ejecutar insert hasta obtener cantidad deseada
            Insert into Valores_Venta(codigoArticuloProveedor, codigoOriginal) (
            Select codigoArticuloProveedor, codigoOriginal from Articulos_Proveedores
            );

            declare @FromDate date = '2011-01-01'
            declare @ToDate date = '2014-12-31'

            update Valores_Venta 
            set fechaValor = dateadd(day, 
                           rand(checksum(newid()))*(1+datediff(day, @FromDate, @ToDate)), 
                           @FromDate);

            update Valores_Venta
            SET valor = (ABS(CHECKSUM(NewId())) % 500);
         */
        #endregion
        static void Main(string[] args)
        {
            TestingCatalogo tc = new TestingCatalogo();
            //////////////////////////////////
            //tc.generarPersonas(1500,"CLI");
            //tc.generarArticulosProveedores();
            //tc.generarProveedores();
            //tc.actualizarProveedores();
           // tc.generarArticulos(600);
            tc.generarArticulosProveedores(5000);

            /////////////////////////////////
            tc.salir();
        }

        private void salir()
        {
            Console.Write("Presione tecla para finalizar: ");
            Console.ReadKey();
        }

        //private void generarDatos(int cantidad)
        //{
        //    this.generarPersonas(cantidad);
        //    this.generarProveedores();
        //    this.generarArticulos(cantidad*5);
        //    this.generarPedidos();
        //}
        
        #region Personas
        #region Generar Personas
        private void generarPersonas(int cantidadPersonas,string tipoPersona)
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            ModeloPersonas persona = new ModeloPersonas();
            List<string> apellidos = getApellidos();
            List<string> nombres = getNombres();
            List<string> dnis = getDNIs(cantidadPersonas);
            List<string> observaciones = getObservaciones();
            List<string> cuits = getCUITs(cantidadPersonas);

            List<string> domiciliosCalles = getDomiciliosCalles();
            List<string> domiciliosCiudades = getCiudades();
            List<string> domiciliosPisos = getDomiciliosPisos();
            List<string> domiciliosDepartamentos = getDomiciliosDepartamentos();

            int longApellidos = apellidos.Count;
            int longNombres = nombres.Count;
            int longDomiciliosCalles = domiciliosCalles.Count;
            int longCiudades = domiciliosCiudades.Count;
            int longObservaciones = observaciones.Count;
            int longDomiciliosPisos = domiciliosPisos.Count;
            int longDomiciliosDepartamentos = domiciliosDepartamentos.Count;

            Random rnd = new Random();
            for (int i = 0; i < cantidadPersonas; i++)
            {
                int ape = rnd.Next(longApellidos);
                int nom = rnd.Next(longNombres);
                int dir = rnd.Next(longDomiciliosCalles);
                int ciu = rnd.Next(longCiudades);
                int obs = rnd.Next(longObservaciones);
                int pis = rnd.Next(longDomiciliosPisos);
                int dpt = rnd.Next(longDomiciliosDepartamentos);
                persona = new ModeloPersonas();
                
                persona.apellido = apellidos[ape];
                persona.nombre = nombres[nom];
                persona.dni = dnis[i];
                persona.cuit = cuits[i];
                
                ModeloDomicilio md = new ModeloDomicilio();
                //para que cada tanto alguno no tenga domicilio
                
                int seguirDomicilio = rnd.Next(1, 100);
                if(seguirDomicilio < 5)
                {
                    //para que cada tanto alguno tenga más de un domicilio
                    seguirDomicilio = 46;
                    while (seguirDomicilio > 45)
                    {
                        md = new ModeloDomicilio();
                        md.calle = domiciliosCalles[dir];
                        md.numero = rnd.Next(50, 5000).ToString();
                        md.ciudad = domiciliosCiudades[ciu];
                        md.piso = domiciliosPisos[pis];
                        md.departamento = domiciliosPisos[dpt];
                        md.codigoPostal = "2132";
                        if (rnd.Next(1, 11) > 5)
                        {
                            md.provincia = "Santa Fe";
                        }
                        else
                        {
                            md.provincia = "Buenos Aires";
                        }
                        
                        md.pais = "Argentina";
                        persona.domicilios.Add(md);
                        seguirDomicilio = rnd.Next(1, 50);
                    }
                }
                persona.tipoPersona = tipoPersona;
                persona.observaciones = observaciones[obs];

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
        private List<string> getDNIs(int cantidad)
        {
            List<string> lista = new List<string>();

            int dni = 20000000;
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add((dni + i).ToString());
            }

                return lista;
        }
        private List<string> getCUITs(int cantidad)
        {
            List<string> lista = new List<string>();
            int dni = 20000000;
            string prefijo = "21";
            string sufijo = "4";
            for (int i = 0; i < cantidad; i++)
            {
                lista.Add(prefijo+"-"+(dni + i).ToString()+"-"+sufijo);
            }
            return lista;
        }
        private List<string> getDomiciliosCalles()
        {
            List<string> lista = new List<string>();

            lista.Add("Buenos Aires");
            lista.Add("Tucumán");
            lista.Add("General Paz");
            lista.Add("Villegaz");
            lista.Add("Montevideo");
            lista.Add("San Martín");
            lista.Add("Corrientes");
            lista.Add("Independencia");
            lista.Add("Esclavitud");
            lista.Add("Dermatitis");
            lista.Add("Paloma");
            lista.Add("Uriburu");
            lista.Add("San Pedro");
            lista.Add("El Loco");
            lista.Add("El Loro");
            lista.Add("La Cuñada");
            lista.Add("Martinez");
            lista.Add("Falsa");

            return lista;
        }
        private List<string> getDomiciliosPisos()
        {
            List<string> lista = new List<string>();

            lista.Add("PB");
            lista.Add("1");
            lista.Add("2");
            lista.Add("3");
            lista.Add(null);
            lista.Add(null);

            return lista;
        }
        private List<string> getDomiciliosDepartamentos()
        {
            List<string> lista = new List<string>();

            lista.Add("A");
            lista.Add("B");
            lista.Add("C");
            lista.Add("D");
            lista.Add(null);
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
        private void bajaPersonas()
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
        private void actualizarEntidad(int codigoEntidad)
        {
            ModeloPersonas mp = new ModeloPersonas();
            CatalogoPersonas cp = new CatalogoPersonas();
            mp = cp.getOnePorCodigo(codigoEntidad);
            mp.nombre = "Santiago";
            cp.actualizarEntidad(mp);
        }
        #endregion
        #endregion
        
        #region Proveedores
        private void generarProveedores()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            ModeloProveedor proveedor = new ModeloProveedor();

            List<string> razonesSociales = getRazonSocial();
            List<string> observaciones = getObservaciones();
            List<string> cuits = getCUITs(razonesSociales.Count);

            List<string> domiciliosCalles = getDomiciliosCalles();
            List<string> domiciliosCiudades = getCiudades();
            List<string> domiciliosPisos = getDomiciliosPisos();
            List<string> domiciliosDepartamentos = getDomiciliosDepartamentos();

            int longDomiciliosCalles = domiciliosCalles.Count;
            int longCiudades = domiciliosCiudades.Count;
            int longObservaciones = observaciones.Count;
            int longDomiciliosPisos = domiciliosPisos.Count;
            int longDomiciliosDepartamentos = domiciliosDepartamentos.Count;
            

            Random rnd = new Random();
            for (int i = 0; i < razonesSociales.Count; i++)
            {
                int dir = rnd.Next(longDomiciliosCalles);
                int ciu = rnd.Next(longCiudades);
                int obs = rnd.Next(longObservaciones);
                int pis = rnd.Next(longDomiciliosPisos);
                int dpt = rnd.Next(longDomiciliosDepartamentos);
                proveedor = new ModeloProveedor();

                proveedor.razonSocial = razonesSociales[i];
                proveedor.cuit = cuits[i];
                proveedor.observaciones = observaciones[obs];

                ModeloDomicilio md = new ModeloDomicilio();
                //para que cada tanto alguno no tenga domicilio
                int seguirDomicilio = rnd.Next(1, 100);
                if (seguirDomicilio < 5)
                {
                    //para que cada tanto alguno tenga más de un domicilio
                    seguirDomicilio = 46;
                    while (seguirDomicilio > 45)
                    {
                        md = new ModeloDomicilio();
                        md.calle = domiciliosCalles[dir];
                        md.numero = rnd.Next(50, 5000).ToString();
                        md.ciudad = domiciliosCiudades[ciu];
                        md.piso = domiciliosPisos[pis];
                        md.departamento = domiciliosPisos[dpt];
                        md.codigoPostal = "2132";
                        if (rnd.Next(1, 11) > 5)
                        {
                            md.provincia = "Santa Fe";
                        }
                        else
                        {
                            md.provincia = "Buenos Aires";
                        }
                        md.pais = "Argentina";
                        proveedor.domicilios.Add(md);
                        seguirDomicilio = rnd.Next(1, 50);
                    }
                }
                

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
        private void bajaProveedores()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            List<ModeloProveedor> provs = new List<ModeloProveedor>();
            provs = cp.getAll();
            foreach(ModeloProveedor p in provs)
            {
                cp.bajaEntidad(p);
            }
        }
        private void actualizarProveedores()
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            List<ModeloProveedor> provs = new List<ModeloProveedor>();
            provs = cp.getAll();
            foreach (ModeloProveedor p in provs)
            {
                p.observaciones = "sin";
                cp.actualizarEntidad(p);
            }
        }
        #endregion
       
        #region Articulos
        private void generarArticulos(int cantidadArticulos)
        {
            CatalogoArticulos ca = new CatalogoArticulos();
            ModeloArticulos ma;
            int cantCodigosOriginales = cantidadArticulos;
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
        private void generarArticulosProveedores(int cantidadArticulosProveedores)
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            CatalogoArticulos ca = new CatalogoArticulos();
            CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();
            List<ModeloProveedor> proveedores = cp.getAll();
            int cantProveedores = proveedores.Count;
            List<ModeloArticulos> articulos = ca.getAll();
            int cantArticulos = articulos.Count;
            Random rnd = new Random();
            ModeloArticuloProveedores map = new ModeloArticuloProveedores();

            int cantModelos = 50;
            int cantDescripciones = 250;
            List<string> descripciones = getDescripciones(cantDescripciones);
            List<string> modelos = getModelos(cantModelos);
            List<string> observaciones = getObservaciones();
            int cantObservaciones = observaciones.Count;
            for (int i = 0; i < cantidadArticulosProveedores; i++)
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
                map.codigoEntidad = proveedores[prov].codigo;
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
