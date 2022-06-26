
using ExComposicao3.Entidades.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExComposicao3.Entidades
{
    public class Pedido
    {
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Itens { get; set; } = new List<PedidoItem>();

        public Pedido(DateTime momento, PedidoStatus status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(PedidoItem item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(PedidoItem item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (PedidoItem item in Itens)
                sum += item.CalcularSubTotal();
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Hora da venda: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status Pedido: " + Status);
            sb.AppendLine("Cliente: " + Cliente.Nome);
            sb.AppendLine("Pedido itens:");
            foreach (PedidoItem item in Itens)
            {
                sb.AppendLine(item.Produto.Nome + ", ");
                sb.Append(item.Preco + ", ");
                sb.Append(item.Quantidade + ", ");
                sb.Append(item.CalcularSubTotal());
            }
            sb.AppendLine("Valor Total: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
