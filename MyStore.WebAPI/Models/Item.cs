using System.Collections.Generic;

namespace MyStore.WebAPI.Models
{
    public class Item
    {
        public Item() { }
        public Item(double valor, string descricao, long codigo)
        {            
            this.Valor = valor;
            this.Descricao = descricao;  
            this.Codigo = codigo;
        }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public long Codigo { get; set; }

        public IEnumerable<PedidoItem> PedidosItens { get; set; }
    }
}