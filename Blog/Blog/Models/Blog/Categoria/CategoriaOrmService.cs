using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models.Blog.Postagem.Categoria;
using Microsoft.EntityFrameworkCore;

namespace Blog.Models.Blog.Categoria
{
    public class CategoriaOrmService
    {
        private readonly DatabaseContext _databaseContext;

        public CategoriaOrmService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public List<CategoriaEntity> ObterCategorias()
        {
            // INÍCIO DOS EXEMPLOS

            /**********************************************************************************************************/
            /*** OBTER UM ÚNICO OBJETO                                                                                */
            /**********************************************************************************************************/

            // First = Obter a primeira categoria retornada pela consulta
            var primeiraCategoria = _databaseContext.categorias.First();

            // FirstOrDefault = Mesmo do First, porém retorna nulo caso não encontre nenhuma
            var primeiraCategoriaOuNulo = _databaseContext.categorias.FirstOrDefault();

            // Single = Obter um único registro do banco de dados
            var algumaCategoriaEspecifica = _databaseContext.categorias.Single(c => c.Id == 3);

            // SingleOrDefault = Mesmo do Sigle, porém retorna nulo caso não encontre nenhuma
            var algumaCategoriaOuNulo = _databaseContext.categorias.SingleOrDefault(c => c.Id == 3);

            // Find = Equivalente ao SingleOrDefault, porém fazendo uma busca por uma propriedade chave
            var encontrarCategoria = _databaseContext.categorias.Find(3);


            /**********************************************************************************************************/
            /*** OBTER MÚLTIPLOS OBJETOS                                                                              */
            /**********************************************************************************************************/

            // ToList
            var todasCategorias = _databaseContext.categorias.ToList();


            /***********/
            /* FILTROS */
            /***********/

            var categoriasComALetraG = _databaseContext.categorias.Where(c => c.Nome.StartsWith("G")).ToList();
            var categoriasComALetraMouL = _databaseContext.categorias
                .Where(c => c.Nome.StartsWith("M") || c.Nome.StartsWith("L"))
                .ToList();


            /*************/
            /* ORDENAÇÃO */
            /*************/

            var categoriasEmOrdemAlfabetica = _databaseContext.categorias.OrderBy(c => c.Nome).ToList();
            var categoriasEmOrdemAlfabeticaInversa =
                _databaseContext.categorias.OrderByDescending(c => c.Nome).ToList();


            /**************************/
            /* ENTIDADES RELACIONADAS */
            /**************************/

            var categoriasESuasEtiquetas = _databaseContext.categorias
                .Include(c => c.Etiquetas)
                .ToList();

            var categoriasSemEtiquetas = _databaseContext.categorias
                .Where(c => c.Etiquetas.Count == 0)
                .ToList();

            var categoriasComEtiquetas = _databaseContext.categorias
                .Where(c => c.Etiquetas.Count > 0)
                .ToList();

            // FIM DOS EXEMPLOS


            // Código de fato necessário para o método
            return _databaseContext.categorias
                .Include(c => c.Etiquetas)
                .ToList();
        }

        public CategoriaEntity ObterCategoriaPorId(int idCategoria)
        {
            var categoria = _databaseContext.categorias.Find(idCategoria);

            return categoria;
        }

        public List<CategoriaEntity> PesquisarCategoriasPorNome(string nomeCategoria)
        {
            return _databaseContext.categorias.Where(c => c.Nome.Contains(nomeCategoria)).ToList();
        }

        public CategoriaEntity CriarCategoria(string nome)
        {
            var novaCategoria = new CategoriaEntity { Nome = nome };
            _databaseContext.categorias.Add(novaCategoria);
            _databaseContext.SaveChanges();

            return novaCategoria;
        }

        public CategoriaEntity EditarCategoria(int id, string nome)
        {
            var categoria = _databaseContext.categorias.Find(id);

            if (categoria == null)
            {
                throw new Exception("Categoria não encontrada!");
            }

            categoria.Nome = nome;
            _databaseContext.SaveChanges();

            return categoria;
        }

        public bool RemoverCategoria(int id)
        {
            var categoria = _databaseContext.categorias.Find(id);

            if (categoria == null)
            {
                throw new Exception("Categoria não encontrada!");
            }

            _databaseContext.categorias.Remove(categoria);
            _databaseContext.SaveChanges();

            return true;
        }
    }

}
