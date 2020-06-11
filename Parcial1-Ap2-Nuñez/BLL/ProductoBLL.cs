using Microsoft.EntityFrameworkCore;
using Parcial1_Ap2_Nuñez.DAL;
using Parcial1_Ap2_Nuñez.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Nuñez.BLL
{
    public class ProductoBLL
    {
        public static bool Guardar(Producto producto)
        {
            if (!Existe(producto.ArticulosId))
            {
                return Insertar(producto);
            }
            else
            {
                return Modificar(producto);
            }
        }
        public static bool Insertar(Producto producto)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.productos.Add(producto);
                paso = contexto.SaveChanges() > 0;
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static bool Modificar(Producto producto)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                
              
                contexto.Entry(producto).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }
        public static Producto Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Producto producto;

            try
            {
                producto = contexto.productos.Find(id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return producto;
        }
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var encontrado = contexto.productos.Find(id);
                if (encontrado != null)
                {
                    contexto.productos.Remove(encontrado);
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }

        public static List<Producto> GetList(Expression<Func<Producto,bool>> criterio)
        {
            List<Producto> lista = new List<Producto>();
            Contexto contexto = new Contexto();
            

            try
            {
                lista = contexto.productos.Where(criterio).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.productos.Any(e => e.ArticulosId==id);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return encontrado;
        }
    }
}
