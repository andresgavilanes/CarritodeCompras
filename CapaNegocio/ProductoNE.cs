using CapaDatos;
using Entidades;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class ProductoNE
    {
        ProductoDAO pdao = new ProductoDAO();

        public string InsertarProducto(Producto p)
        {
            return pdao.InsertarProducto(p);
        }
        public string ActualizarProducto(Producto p)
        {
            return pdao.ActualizarProducto(p);
        }
        public List<Producto> ListarPtoducto()
        {
            return pdao.ListarProducto();
        }
        public Producto BuscarProductoById(int id)
        {
            return pdao.BuscarProductoById(id);
        }
        public List<Producto> ListaCatalogoProductos()
        {
            return pdao.ListaCatalogoProductos();
        }

        public List<Producto> ListarProducto()
        {
            throw new NotImplementedException();
        }

        public int CodProducto()
        {
            return pdao.CodProducto();
        }
    }
}
