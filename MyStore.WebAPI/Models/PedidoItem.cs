using System;

namespace MyStore.WebAPI.Models
{
    public class PedidoItem
    {
        public PedidoItem() { }
        public PedidoItem(long itemCodigo, long pedidoCodigo)
        {
            this.ItemCodigo = itemCodigo;
            this.PedidoCodigo = pedidoCodigo;

        }
        public long ItemCodigo { get; set; }
        public Item Item { get; set; }
        public long PedidoCodigo { get; set; }
        public Pedido Pedido { get; set; }
        public DateTime DataPedido { get; set; }
    }
}