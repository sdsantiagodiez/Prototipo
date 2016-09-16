using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public static class ControladorParametrosGenerales
    {
        #region atributos
        public static string pathLogotipo;
        public static string nombreEmpresa;
        public static string direccionEmpresa;
        public static string telefonoEmpresa;
        public static string razonSocial;
        public static string ingresosBrutos;
        public static DateTime inicioActividades;
        
        #endregion

        #region metodos
        public static void Iniciar()
        {
            IFormatProvider cultura = new System.Globalization.CultureInfo("es-AR", true);

            pathLogotipo = Properties.Settings.Default.pGeneral_pathLogotipo;
            nombreEmpresa = Properties.Settings.Default.pGeneral_nombreEmpresa;
            direccionEmpresa = Properties.Settings.Default.pGeneral_direccionEmpresa;
            telefonoEmpresa = Properties.Settings.Default.pGeneral_telefonoEmpresa;
            razonSocial = Properties.Settings.Default.pGeneral_razonSocial;
            ingresosBrutos = Properties.Settings.Default.pGeneral_ingresosBrutos;
            inicioActividades = DateTime.Parse((String.IsNullOrEmpty(Properties.Settings.Default.pGeneral_inicioActividades) != true)?Properties.Settings.Default.pGeneral_inicioActividades:"01/01/2016", cultura, System.Globalization.DateTimeStyles.AssumeLocal);

        }
        public static bool Validar()
        {
            if (String.IsNullOrEmpty(pathLogotipo) ||
                String.IsNullOrEmpty(nombreEmpresa) ||
                String.IsNullOrEmpty(direccionEmpresa) ||
                String.IsNullOrEmpty(telefonoEmpresa) ||
                String.IsNullOrEmpty(razonSocial) ||
                String.IsNullOrEmpty(ingresosBrutos))
            {
                return false;
            }

            return true;
        }
        public static bool GuardarCambios()
        {
            if (!Validar())
            {
                //Restauramos los valores válidos
                ControladorParametrosGenerales.Iniciar();
                return false;
            }

            Properties.Settings.Default.pGeneral_pathLogotipo = pathLogotipo;
            Properties.Settings.Default.pGeneral_nombreEmpresa = nombreEmpresa;
            Properties.Settings.Default.pGeneral_direccionEmpresa = direccionEmpresa;
            Properties.Settings.Default.pGeneral_telefonoEmpresa = telefonoEmpresa;
            Properties.Settings.Default.pGeneral_razonSocial = razonSocial;
            Properties.Settings.Default.pGeneral_ingresosBrutos =ingresosBrutos;
            Properties.Settings.Default.pGeneral_inicioActividades = inicioActividades.ToShortDateString();
            Properties.Settings.Default.Save();
            
            return true;
        }

        #endregion

    }
}
