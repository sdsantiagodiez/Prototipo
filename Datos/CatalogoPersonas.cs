using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoPersonas : CatalogoEntidades
    {
        public bool validarDatos(ModeloPersonas p_mod_persona)
        {
            // Validar si los datos son correctos?
            return true;
        }

        protected ModeloPersonas leerDatosPersonas(SqlDataReader p_drPersonas)
        {
            ModeloPersonas lcl_mod_persona = new ModeloPersonas(this.leerDatosEntidades(p_drPersonas));
            
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_persona.dni = (p_drPersonas["dni"] != DBNull.Value) ? (string)p_drPersonas["dni"] : null;
            lcl_mod_persona.nombre = (p_drPersonas["nombre"] != DBNull.Value) ? (string)p_drPersonas["nombre"] : null;
            lcl_mod_persona.apellido = (p_drPersonas["apellido"] != DBNull.Value) ? (string)p_drPersonas["apellido"] : null;
            lcl_mod_persona.tipoPersona = (p_drPersonas["tipo_persona"] != DBNull.Value) ? (string)p_drPersonas["tipo_persona"] : null;
            
            return lcl_mod_persona;
        }
        
        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_persona">modeloPersona con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        protected string getCondicionBusqueda(ModeloPersonas p_mod_persona, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Entidades.Personas.Dni:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
                    return " dni = @dni ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Nombre:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_persona.nombre), "@nombre"));
                    return " nombre LIKE @nombre ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Apellido:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_persona.apellido), "@apellido"));
                    return " apellido LIKE @apellido ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.TipoPersona:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));
                    return " tipo_persona = @tipo_persona ";
                case Constantes.ParametrosBusqueda.Any:
                    string queryBase = base.getCondicionBusqueda(p_mod_persona, p_parametroBusqueda, ref p_comando);

                    string dni = (p_mod_persona.dni == "") ? null : p_mod_persona.dni;
                    p_comando.Parameters.Add(this.instanciarParametro(dni, "@dni"));
                    string dniQuery = " (@dni is null OR dni = @dni) ";
                    //string dniQuery = this.parametroBusqueda("@dni", "dni","=");
                    
                    string nombre = (p_mod_persona.nombre == "") ? null : p_mod_persona.nombre;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(nombre), "@nombre"));
                    string nombreQuery = " (@nombre is null OR nombre LIKE @nombre) ";    
                //string nombreQuery = this.parametroBusqueda("@nombre", "nombre","LIKE");
                    
                    string apellido = (p_mod_persona.apellido == "") ? null : p_mod_persona.apellido;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(apellido), "@apellido"));
                    string apellidoQuery = " (@apellido is null OR apellido LIKE @apellido) ";
                    //string apellidoQuery = this.parametroBusqueda("@apellido", "apellido", "LIKE");
                    
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));
                    string tipoPersonaQuery = @" (@tipo_persona IS NULL OR @tipo_persona = tipo_persona) ";

                    return queryBase + " AND " + dniQuery + " AND " + nombreQuery + " AND " + apellidoQuery + " AND " + tipoPersonaQuery;

                default:
                    //prueba condiciones de búsqueda propias de modeloEntidad
                    return base.getCondicionBusqueda(p_mod_persona, p_parametroBusqueda, ref p_comando);
            }
        }

        public override IEnumerable<ModeloEntidad> buscar(ModeloEntidad p_mod_entidad, string p_parametroBusqueda)
        {
            IEnumerable<ModeloPersonas> lcl_lst_mod_personas = this.buscar(p_mod_entidad as ModeloPersonas, p_parametroBusqueda);
            IEnumerable<ModeloEntidad> lcl_lst_mod_entidades = lcl_lst_mod_personas;
            return lcl_lst_mod_entidades;
        }

        public virtual IEnumerable<ModeloPersonas> buscar(ModeloPersonas p_mod_persona,string p_parametroBusqueda)
        {
            return this.buscarPersonas(p_mod_persona,p_parametroBusqueda);
        }


        /// <summary>
        /// Busca personas en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_persona">modeloPersona con variables posiblemente inicializadas</param>
        /// <param name="p_paramentroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas</param>
        /// <returns></returns>
        public List<ModeloPersonas> buscarPersonas(ModeloPersonas p_mod_persona, string p_paramentroBusqueda)
        {
            List<ModeloPersonas> lcl_lst_mod_persona = new List<ModeloPersonas>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = this.getCondicionBusqueda(p_mod_persona,p_paramentroBusqueda,ref comando);
            
            comando.CommandText =
                "SELECT [entidades].codigo as codigo_entidad,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad " +
                    "WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            while (drPersonas.Read())
            {
                p_mod_persona = new ModeloPersonas();
                p_mod_persona = this.leerDatosPersonas(drPersonas);

                lcl_lst_mod_persona.Add(p_mod_persona);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return lcl_lst_mod_persona;
        }
        
        /// <summary>
        /// Ver si sacarBusca persona de acuerdo a código de entidad
        /// </summary>
        /// <param name="p_codigoEntidad">codigo entidad de la persona a buscar</param>
        /// <returns>ModeloPersona si encuentra, null si no encuentra resultado</returns>
        public override ModeloEntidad getOne(int p_codigoEntidad)
        {
            ModeloPersonas lcl_mod_persona = new ModeloPersonas();
            List<ModeloPersonas> lcl_lst_mod_persona = new List<ModeloPersonas>();
            lcl_mod_persona.codigo = p_codigoEntidad;
            lcl_lst_mod_persona = this.buscarPersonas(lcl_mod_persona, Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad);

            if (lcl_lst_mod_persona.Count > 0)
            {
                return lcl_lst_mod_persona[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Busca todas las personas que se encuentren en la base de datos
        /// </summary>
        /// <returns></returns>
        public new List<ModeloPersonas> getAll()
        {
            return this.buscarPersonas(null, Constantes.ParametrosBusqueda.All);
        }
        #endregion

        #region Alta/Baja/Modificación

        public override bool add(ref ModeloEntidad p_mod_entidad)
        {
            if (base.add(ref p_mod_entidad) && this.add(p_mod_entidad as ModeloPersonas))
            {
                return true;
            }
            throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar persona.");
        }

        public virtual bool add(ModeloPersonas p_mod_persona)
        {
            return this.addPersona(p_mod_persona);
        }

        private bool addPersona(ModeloPersonas p_mod_persona)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "INSERT INTO [Personas]([codigo_entidad],[dni],[nombre],[apellido],[tipo_persona]) " +
                "VALUES (@codigo_entidad, @dni, @nombre, @apellido, @tipo_persona)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.nombre, "@nombre"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.apellido, "@apellido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public override bool update(ModeloEntidad p_mod_entidad_original, ModeloEntidad p_mod_entidad_nueva)
        {
            if (!p_mod_entidad_original.Equals(p_mod_entidad_nueva))
            {
                if (!this.updatePersona(p_mod_entidad_nueva as ModeloPersonas))
                {
                    return false;
                }
            }
            return base.update(p_mod_entidad_original, p_mod_entidad_nueva);
        }

        private bool updatePersona(ModeloPersonas p_mod_persona)
        { 
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "UPDATE [personas] SET [dni]=@dni,[nombre]=@nombre, [apellido]=@apellido "+
                "WHERE [Personas].codigo_entidad=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.nombre, "@nombre"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.apellido, "@apellido"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();           
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                return true;
            }
            else
            {
                throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar persona.");
            }
        }

        public override bool remove(ModeloEntidad p_mod_entidad)
        {
            return this.remove(p_mod_entidad as ModeloPersonas);
        }

        public virtual bool remove(ModeloPersonas p_mod_persona)
        {
            //INCOMPLETO
            //Incompleto. ver Constrains, eliminar persona de tabla personas y seguir con base.remove
            //remove(ModeloPersona)
            //La idea seria un metodo CheckConstrains en cada nivel catalogo que vea si es posible eliminar (Cliente -> Persona -> Entidad). Si da OK, eliminar
            return base.remove(p_mod_persona);
        }
        #endregion  
     }
}

