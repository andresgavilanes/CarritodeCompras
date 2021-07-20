using Entidades;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CategoriaNE
    {
        CategoriaDAO cdao = new CategoriaDAO();

        public string InsertarCategoria(Categoria cat)
        {
            return cdao.InsertarCategoria(cat);
        }
        public string ActualizarCategoria(Categoria cat)
        {
            return cdao.ActualizarCategoria(cat);
        }
        public List<Categoria> ListarCategoria()
        {
            return cdao.ListarCategoria();
        }
        public Categoria BuscarCategoriaById(int id)
        {
            return cdao.BuscarCategoriaById(id);
        }
        public int CodCatgeoria()
        {
            return cdao.CodCategoria();
        }
    }
}
