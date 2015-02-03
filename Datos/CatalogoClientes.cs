using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace Controlador
{
    class CatalogoClientes
    {

        public bool validarDatos(string[] pDatos)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(string[] pDatos)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloPersonas> listPer = this.getAll();
            
            foreach (ModeloPersonas modPer in listPer)
            {
                if (pDatos[1] == modPer.dniPers)// Se busca si la persona ya existe comparando el dni
                {
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }

        public List<ModeloPersonas> getAll()
        { 
            List<ModeloPersonas>allArts = new List<ModeloPersonas>();
            
            ModeloPersonas modArt = new ModeloPersonas();
            
            
            allArts.Add(modArt);

            return allArts;
        }

        public void agregarNuevaEntidad(ModeloPersonas pModPer)
            { 
            //Insertar un nueva Persona/Cliente
            }
            

        }



    }

