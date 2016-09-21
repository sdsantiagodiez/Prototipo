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
        private static string _pathLogotipo;
        public static string pathLogotipo
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(_pathLogotipo))
                {
                    return _pathLogotipo;
                }
                else
                {
                    return @"sin imagen";
                }
            }
            set { _pathLogotipo = value; }
        }
        private static string _nombreEmpresa;
        public static string nombreEmpresa
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(_nombreEmpresa))
                {
                    return _nombreEmpresa;
                }
                else
                {
                    return "<nombre empresa>";
                }
            }
            set { _nombreEmpresa = value; }
        }
        private static string _direccionEmpresa;
        public static string direccionEmpresa
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(_direccionEmpresa))
                {
                    return _direccionEmpresa;
                }
                else
                {
                    return "<domicilio>";
                }
            }
            set { _direccionEmpresa = value; }
        }
        private static string _telefonoEmpresa;
        public static string telefonoEmpresa
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(_telefonoEmpresa))
                {
                    return _telefonoEmpresa;
                }
                else
                {
                    return "<teléfono>";
                }
            }
            set { _telefonoEmpresa = value; }
        }
        private static string _razonSocial;
        public static string razonSocial
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(_razonSocial))
                {
                    return _razonSocial;
                }
                else
                {
                    return "<razón social>";
                }
            }
            set { _razonSocial = value; }
        }
        private static string _ingresosBrutos;
        public static string ingresosBrutos
        {
            get
            {
                if (!String.IsNullOrWhiteSpace(_ingresosBrutos))
                {
                    return _ingresosBrutos;
                }
                else
                {
                    return "000-00000-00";
                }
            }
            set { _ingresosBrutos = value; }
        }
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
