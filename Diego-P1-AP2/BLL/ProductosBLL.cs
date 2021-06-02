using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Diego_P1_AP2.Models;
using Diego_P1_AP2.DAL;
using Microsoft.EntityFrameworkCore;

namespace Diego_P1_AP2.BLL
{
    public class ProductosBLL
    {
        public static bool Guardar(Productos Producto)
        {
            if (!Existe(Producto.ProductoId))
                return Insertar(Producto);
            else
                return Modificar(Producto);
        }
        private static bool Insertar(Productos Producto)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                context.Producto.Add(Producto);
                found = context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }
        public static bool Modificar(Productos Producto)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                context.Entry(Producto).State = EntityState.Modified;
                found = context.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }
        public static bool Eliminar(int id)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                var productos = context.Producto.Find(id);

                if (productos != null)
                {
                    context.Producto.Remove(productos);
                    found = context.SaveChanges() > 0;
                }

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }
        public static Productos Buscar(int id)
        {
            Contexto context = new Contexto();
            Productos productos;

            try
            {
                productos = context.Producto.Find(id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return productos;
        }
        public static bool Existe(int id)
        {
            Contexto context = new Contexto();
            bool found = false;

            try
            {
                found = context.Producto.Any(p => p.ProductoId == id);

            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                context.Dispose();
            }

            return found;
        }


    }
}
