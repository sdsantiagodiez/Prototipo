﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorModificacion : Controlador
    {
        public string[] getDetalles(string pCuit)
        {
            string[] detallesproveedor = new string[9];

            CatalogoProveedores cp = new CatalogoProveedores();
            
            List<ModeloProveedores> pActuales = new List<ModeloProveedores>();

            pActuales = cp.buscarProveedores("cuit",pCuit);
            detallesproveedor[0] = pActuales[1].razonSocial;
            detallesproveedor[1] = pActuales[1].cuit;
            detallesproveedor[2]= pActuales[1].direccion;
            detallesproveedor[3] = pActuales[1].ciudad;
            detallesproveedor[4] = pActuales[1].provincia;
            detallesproveedor[5] = pActuales[1].codigoPostal;
            // detallesproveedor[6] = pActuales[1]. faltaria email;
            // detallesproveedor[7] = pActuales[1]. faltaria telefonos;
            detallesproveedor[8] = pActuales[1].observaciones;
            return detallesproveedor;
        }
    }
}
