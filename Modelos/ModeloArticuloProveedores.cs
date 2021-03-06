﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Serializable]
    public class ModeloArticuloProveedores : ModeloArticulos
    {
        #region Constructores
        public ModeloArticuloProveedores()
        {
            this.valorVenta = new ModeloValorArticulo();
            this.valorCompra = new ModeloValorArticulo();
            this.descuentos = new List<ModeloDescuentoArticuloProveedor>();
        }

        public ModeloArticuloProveedores(ModeloArticulos p_mod_articulo) : this()
        {
            this.codigoOriginal = p_mod_articulo.codigoOriginal;
            this.descripcion = p_mod_articulo.descripcion;
            this.modelos = p_mod_articulo.modelos;
            this.observaciones = p_mod_articulo.observaciones;
        }
        #endregion

        public string getDescripciones()
        {
            string lcl_descripcion = this.descripcion;
            lcl_descripcion += String.IsNullOrWhiteSpace(this.descripcionArticuloProveedor) ? null : " (" + this.descripcionArticuloProveedor + ")";
            return lcl_descripcion;
        }

        public string getObservaciones()
        {
            string lcl_observacion_articulo = String.IsNullOrWhiteSpace(this.observaciones) ? null : "Artículo: "+this.observaciones;
            
            string lcl_observaciones_articuloProveedor = String.IsNullOrWhiteSpace(this.observacionesArticuloProveedor) ? null : "Artículo Proveedor: "+this.observacionesArticuloProveedor;
            
            if (lcl_observacion_articulo != null && lcl_observaciones_articuloProveedor != null)
            {
                return lcl_observacion_articulo + System.Environment.NewLine + lcl_observaciones_articuloProveedor;
            }
            else
            {
                return lcl_observacion_articulo + lcl_observaciones_articuloProveedor;
            }
        }

        #region Atributos

        #region Variables de Proveedor al que pertenece Artículo Proveedor
        int _codigoEntidad;
        public int codigoEntidad
        {
            get { return _codigoEntidad; }
            set { this._codigoEntidad = value; }
        }

        string _razonSocialProveedor;
        public string razonSocialProveedor
        {
            get { return _razonSocialProveedor; }
            set { this._razonSocialProveedor = ModeloProveedor.validarRazonSocial(value) ? value : null; }
        }
        #endregion

        string _codigoArticuloProveedor;
        public string codigoArticuloProveedor
        {
            get { return _codigoArticuloProveedor; }
            set { this._codigoArticuloProveedor = value; }
        }

        string _descripcionArticuloProveedor;
        public string descripcionArticuloProveedor
        {
            get { return _descripcionArticuloProveedor; }
            set { this._descripcionArticuloProveedor = convertirString(value); }
        }

        string _observacionesArticuloProveedor;
        public string observacionesArticuloProveedor
        {
            get { return _observacionesArticuloProveedor; }
            set { this._observacionesArticuloProveedor = !string.IsNullOrWhiteSpace(value) ? value : null; }
        }

        List<ModeloDescuentoArticuloProveedor> _descuentos;
        public List<ModeloDescuentoArticuloProveedor> descuentos
        {
            get { return _descuentos; }
            set { _descuentos = value; }
        }

        ModeloValorArticulo _valorVenta;
        public ModeloValorArticulo valorVenta
        {
            get { return _valorVenta; }
            set { this._valorVenta =  value; }
        }
        
        ModeloValorArticulo _valorCompra;
        public ModeloValorArticulo valorCompra
        {
            get { return _valorCompra; }
            set { this._valorCompra = value; }
        }
        
        //int nullable en caso de que este definido NULL en la base de datos
        int? _stockMinimo;
        public int? stockMinimo
        {
            get { return _stockMinimo; }
            set { this._stockMinimo = value; }
        }
        //int nullable en caso de que este definido NULL en la base de datos
        int? _stockActual;
        public int? stockActual
        {
            get { return _stockActual; }
            set 
            { 
                this._stockActual = value;
            }
        }
        
        string _ubicacion;
        public string ubicacion
        {
            get { return _ubicacion; }
            set { this._ubicacion = value; }
        }

        //DateTime nullable en caso de que este definido NULL en la base de datos
        DateTime? _fechaActualizacion;
        public DateTime? fechaActualizacion
        {
            get { return _fechaActualizacion; }
            set { this._fechaActualizacion = value; }
        }

        bool _activo;
        public bool activo
        {
            get { return _activo; }
            set { this._activo = value; }
        }
        #endregion

        #region Descuentos
        private bool existeDescuento(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            foreach (ModeloDescuentoArticuloProveedor d in this.descuentos)
            {
                if (d.Equals(p_mod_descuento as object))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Válida si es posible agregar descuento a artículo.
        /// </summary>
        /// <param name="p_mod_descuento">Descuento a validar</param>
        /// <param name="p_error">Mensaje de error si agregar descuento no es válido</param>
        /// <returns></returns>
        public bool validarAgregarDescuento(ModeloDescuentoArticuloProveedor p_mod_descuento, out string p_error)
        {
            p_mod_descuento.asignarDatosArticuloProveedor(this);
            p_error = "";
            if(!p_mod_descuento.validar())
            {
                p_error = "Descuento no válido";
                return false;
            }
            if (this.existeDescuento(p_mod_descuento))
            {
                p_error = "El descuento ya existe en el artículo "+this.codigoOriginal+", "+this.codigoArticuloProveedor+", "+this.descripcionArticuloProveedor;
                return false;
            }
            
            return true;
        }
        /// <summary>
        /// Válida si es posible agregar descuento a artículo
        /// </summary>
        /// <param name="p_mod_descuento">Descuento a validar</param>
        /// <returns></returns>
        public bool validarAgregarDescuento(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            string error;
            return this.validarAgregarDescuento(p_mod_descuento, out error);
        }
        /// <summary>
        /// Agrega descuento a la lista de descuentos
        /// </summary>
        /// <param name="p_mod_descuento"></param>
        /// <returns></returns>
        public bool agregarDescuento(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            p_mod_descuento.asignarDatosArticuloProveedor(this);
            if (!this.validarAgregarDescuento(p_mod_descuento))
            {
                return false;
            }
            
            descuentos.Add(p_mod_descuento);
            return true;
        }
        /// <summary>
        /// Quita descuento de la lista de descuentos
        /// </summary>
        /// <param name="p_mod_descuento"></param>
        /// <returns></returns>
        public bool eliminarDescuento(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            foreach (ModeloDescuentoArticuloProveedor d in descuentos)
            {
                if (d.Equals(p_mod_descuento))
                {
                    this.descuentos.Remove(p_mod_descuento);
                    return true;
                }
            }
            return false;
        }
        public void eliminarDescuentosAll()
        {
            this.descuentos = new List<ModeloDescuentoArticuloProveedor>();
        }
        /// <summary>
        /// Elimina los descuentos que existan donde la DateTime.Today este contenido en fecha desde y hasta de descuento
        /// </summary>
        /// <returns></returns>
        public bool eliminarDescuentosVigentes()
        {
            return true;
        }
        /// <summary>
        /// Retorna si tiene descuentos vigentes al día de hoy
        /// </summary>
        /// <returns></returns>
        public bool tieneDescuentosVigentes()
        {
            return this.tieneDescuentosVigentes(DateTime.Today.Date);
        }
        /// <summary>
        /// Retorna si hay descuentos vigentes para la fecha ingresada
        /// </summary>
        /// <param name="p_dia"></param>
        /// <returns></returns>
        public bool tieneDescuentosVigentes(DateTime p_dia)
        {
            foreach (ModeloDescuentoArticuloProveedor d in descuentos)
            {
                if (d.esVigente(p_dia.Date))
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Retorna el descuento vigente más alto para al día de hoy
        /// </summary>
        /// <returns>null si no hay descuento vigente</returns>
        public ModeloDescuento getDescuentoVigente()
        {
            return this.getDescuentoVigente(DateTime.Today.Date);
        }
        /// <summary>
        /// Retorna el descuento vigente más alto para la fecha ingresada
        /// </summary>
        /// <param name="p_dia"></param>
        /// <returns>null si no hay descuento vigente</returns>
        public ModeloDescuento getDescuentoVigente(DateTime p_dia)
        {
            List<ModeloDescuentoArticuloProveedor> lcl_lst_descuentosVigentes = new List<ModeloDescuentoArticuloProveedor>();
            foreach (ModeloDescuentoArticuloProveedor d in descuentos)
            {
                if (d.esVigente(p_dia.Date))
                {
                    lcl_lst_descuentosVigentes.Add(d);
                }
            }

            if (lcl_lst_descuentosVigentes.Count == 0)
            {
                return null;
            }

            ModeloDescuentoArticuloProveedor lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();
            
            lcl_mod_descuento = lcl_lst_descuentosVigentes[0];
            foreach (ModeloDescuentoArticuloProveedor d in lcl_lst_descuentosVigentes)
            {
                if (lcl_mod_descuento.porcentaje < d.porcentaje)
                {
                    lcl_mod_descuento = d;
                }
            }

            return lcl_mod_descuento;
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloArticuloProveedores == false)
                return false;
            return Equals((ModeloArticuloProveedores)p_objeto);
        }

        public override bool Equals(ModeloArticulos p_mod_articulo)
        {
            return base.Equals(p_mod_articulo)
                && this.Equals(p_mod_articulo as ModeloArticuloProveedores);
        }

        public virtual bool Equals(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            return this.Equals(this.codigoArticuloProveedor, p_mod_articuloProveedor.codigoArticuloProveedor)
                && this.Equals(this.codigoEntidad, p_mod_articuloProveedor.codigoEntidad)
                && this.Equals(this.stockActual, p_mod_articuloProveedor.stockActual)
                && this.Equals(this.stockMinimo, p_mod_articuloProveedor.stockMinimo)
                && this.Equals(this.descuentos, p_mod_articuloProveedor.descuentos)
                && this.Equals(this.activo, p_mod_articuloProveedor.activo)
                && this.Equals(this.descripcionArticuloProveedor,p_mod_articuloProveedor.descripcionArticuloProveedor)
                && this.Equals(this.ubicacion,p_mod_articuloProveedor.ubicacion)
                && this.Equals(this.observacionesArticuloProveedor, p_mod_articuloProveedor.observacionesArticuloProveedor)
                && this.Equals(this.valorCompra.valorArticulo,p_mod_articuloProveedor.valorCompra.valorArticulo)
                && this.Equals(this.valorVenta.valorArticulo,p_mod_articuloProveedor.valorVenta.valorArticulo);
        }
        #endregion
    }

  
}
