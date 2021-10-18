using Infrastructure.Models;
using Infrastructure.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryProducto : IRepositoryProducto
    {
        public Producto GetProductoByID(int id)
        {
            Producto oProducto = null;

            using (MainContext ctx = new MainContext())
            {
                ctx.Configuration.LazyLoadingEnabled = false;
                oProducto = ctx.Producto.
                Where(l => l.IdProducto == id).
                Include(a => a.Nombre_Producto).
                Include(d => d.Descripcion).
                 Include(p => p.Precio).
                  Include(c => c.CantidadDisponible).
                FirstOrDefault();
            }
            return oProducto;
        }

        public IEnumerable<Producto> GetProductos()
        {
            
            try
            {
                IEnumerable<Producto> lista = null;
                using (MainContext ctx = new MainContext())
                {
                    ctx.Configuration.LazyLoadingEnabled = false;

                    lista = ctx.Producto.ToList<Producto>();
                }
                return lista;
            }

            catch (DbUpdateException dbEx)
            {
                string mensaje = "";
                Log.Error(dbEx, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw new Exception(mensaje);
            }
            catch (Exception ex)
            {
                string mensaje = "";
                Log.Error(ex, System.Reflection.MethodBase.GetCurrentMethod(), ref mensaje);
                throw;
            }
        }
    }
}
