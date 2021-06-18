using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoDeGastosApp.Models
{
    public class Gasto
    {
        public DateTime DataDeRegistro { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }

        public Gasto(decimal preco, string descricao)
        {
            Preco = preco;
            Descricao = descricao;
            DataDeRegistro = DateTime.Now;
        }
    }
}
