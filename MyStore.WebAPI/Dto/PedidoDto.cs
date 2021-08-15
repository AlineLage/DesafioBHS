using System;

namespace MyStore.WebAPI.Dto
{
    public class PedidoDto
    {
        public int Codigo { get; set; }
        public int QtdItens { get; set; }
        public int ValorTotal { get; set; }
        public DateTime DataPedido { get; set; }
        public bool Ativo { get; set; }
    }
}