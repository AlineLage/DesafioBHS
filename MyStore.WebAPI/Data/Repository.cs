using System.Linq;
using Microsoft.EntityFrameworkCore;
using MyStore.WebAPI.Models;

namespace MyStore.WebAPI.Data
{
    public class Repository : IRepository
    {
        private readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() > 0);
        }

        public Pedido[] GetAllPedidos(bool includeItem = false)
        {
            IQueryable<Pedido> query = _context.Pedidos; //Interface de Consulta

            if (includeItem)
            {
                query = query.Include(a => a.PedidosItens)
                              .ThenInclude(ad => ad.Item);
            }

            query = query.AsNoTracking().OrderBy(p => p.Codigo);

            return query.ToArray();
        }

        public Pedido[] GetAllPedidosByItemCodigo(int itemCodigo, bool includeItem = false)
        {
            IQueryable<Pedido> query = _context.Pedidos; //Interface de Consulta

            if (includeItem)
            {
                query = query.Include(p => p.PedidosItens)
                              .ThenInclude(pi => pi.Item);
            }

            query = query.AsNoTracking()
                         .OrderBy(p => p.Codigo)
                         .Where(pedido => pedido.PedidosItens.Any(pi => pi.ItemCodigo == itemCodigo));

            return query.ToArray();
        }

        public Pedido GetPedidoByCodigo(int pedidoCodigo, bool includePedido = false)
        {
            IQueryable<Pedido> query = _context.Pedidos; //Interface de Consulta

            if (includePedido)
            {
                query = query.Include(p => p.PedidosItens)
                              .ThenInclude(pi => pi.Item);
            }

            query = query.AsNoTracking()
                        .OrderBy(p => p.Codigo)
                        .Where(pedido => pedido.Codigo == pedidoCodigo);

            return query.FirstOrDefault();
        }

        
    }
}