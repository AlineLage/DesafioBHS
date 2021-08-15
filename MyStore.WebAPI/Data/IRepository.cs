using MyStore.WebAPI.Models;

namespace MyStore.WebAPI.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         bool SaveChanges();

        // Pedido
         Pedido[] GetAllPedidos(bool includeItem = false);
         Pedido[] GetAllPedidosByItemCodigo(int itemCodigo, bool includeItem = false);
         Pedido GetPedidoByCodigo(int pedidoCodigo, bool includePedido = false);
    }
}