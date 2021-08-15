using System;
using System.Collections.Generic;

namespace MyStore.WebAPI.Models
{
    public class Pedido
    {
        public Pedido() { }
        public Pedido(int codigo, int qtdItens, int valorTotal, DateTime dataPedido)
        {
            this.Codigo = codigo;
            this.QtdItens = qtdItens;
            this.ValorTotal = valorTotal;
            this.DataPedido = DataPedido;

        }        
        public int Codigo { get; set; }
        public int QtdItens { get; set; }
        public int ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        public bool Ativo { get; set; }
        public IEnumerable<PedidoItem> PedidosItens { get; set; }

    }
}