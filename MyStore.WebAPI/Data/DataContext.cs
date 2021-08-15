using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MyStore.WebAPI.Models;

namespace MyStore.WebAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Item> Itens { get; set; }        
        public DbSet<PedidoItem> PedidosItens { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PedidoItem>()
                .HasKey(AD => new {AD.PedidoCodigo, AD.ItemCodigo});

            builder.Entity<Item>()
                .HasData(new List<Item>{
                    new Item(143.00, "20000100001Item do Pedido", 20000100001),
                    new Item(0.00, "20000200001Item do Pedido", 20000200001),
                    new Item(0.00, "20000300001Item do Pedido", 20000300001),
                    new Item(0.00, "20000400001Item do Pedido", 20000400001),
                    new Item(0.00, "20000500001Item do Pedido", 20000500001),
                    new Item(0.00, "20000600001Item do Pedido", 20000600001),
                    new Item(0.00, "20000700001Item do Pedido", 20000700001),
                    new Item(0.00, "20000800001Item do Pedido", 20000800001),
                    new Item(0.00, "20000900001Item do Pedido", 20000900001),
                    new Item(0.00, "20000100001Item do Pedido", 20000100001),
                    new Item(0.00, "20000110001Item do Pedido", 20000110001),
                    new Item(3.00, "20000120001Item do Pedido", 20000120001),
                    new Item(106.00, "20000130001Item do Pedido", 20000130001),
                    new Item(6.00, "20000140001Item do Pedido", 20000140001),
                    new Item(19.00, "20000150001Item do Pedido", 20000150001),
                    new Item(8.00, "20000160001Item do Pedido", 20000160001),
                    new Item(1.00, "20000170001Item do Pedido", 20000170001),
                    new Item(1.00, "20000180001Item do Pedido", 20000180001),
                    new Item(0.00, "20000190001Item do Pedido", 20000190001),
                    new Item(0.00, "20000200001Item do Pedido", 20000200001),
                    new Item(0.00, "20000210001Item do Pedido", 20000210001),
                    new Item(18.00, "20000220001Item do Pedido", 20000220001),
                    new Item(5.00, "20000230001Item do Pedido", 20000230001),
                    new Item(2.00, "20000240001Item do Pedido", 20000240001),
                    new Item(0.00, "20000250001Item do Pedido", 20000250001),
                    new Item(0.00, "20000260001Item do Pedido", 20000260001),
                    new Item(0.00, "20000270001Item do Pedido", 20000270001),
                    new Item(0.00, "20000280001Item do Pedido", 20000280001),
                    new Item(0.00, "20000290001Item do Pedido", 20000290001),
                    new Item(0.00, "20000300001Item do Pedido", 20000300001),
                    new Item(0.00, "20000310001Item do Pedido", 20000310001),
                    new Item(3.00, "20000320001Item do Pedido", 20000320001)
                });

                builder.Entity<Pedido>()
                    .HasData(new List<Pedido>(){
                        new Pedido(100001, 10, 143, DateTime.Parse("20191212185527")),
                        new Pedido(100002, 09, 144, DateTime.Parse("20191205185527")),
                        new Pedido(100003, 09, 25, DateTime.Parse("20191205185527")),
                        new Pedido(100004, 09, 92, DateTime.Parse("20191205185527"))
                });

                builder.Entity<PedidoItem>()
                .HasData(new List<PedidoItem>() {
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000100001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000200001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000300001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000400001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000500001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000600001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000700001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000800001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20000900001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20001000001},
                    new PedidoItem() {PedidoCodigo = 00001, ItemCodigo = 20001100001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001200001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001300001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001400001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001500001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001600001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001700001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001800001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20001900001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20002000001},
                    new PedidoItem() {PedidoCodigo = 00002, ItemCodigo = 20002100001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002200001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002300001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002400001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002500001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002600001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002700001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002800001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20002900001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20003000001},
                    new PedidoItem() {PedidoCodigo = 00003, ItemCodigo = 20003100001},
                    new PedidoItem() {PedidoCodigo = 00004, ItemCodigo = 20003200001}
                });
        }
    }
}