using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliativo28_11.Model
{
    
        [Table("Vendas")]
        public class Vendas
        {
            public int VendasId { get; set; }

            [Column("Produto")]
            public string Produto { get; set; }
            [Required]

            [Column("Descricao")]
            public string Descricao { get; set; }
            [Required]

            [Column("dataVenda")]
            public DateTime DataVenda { get; set; }

            [Column("Valor")]
            public decimal Valor { get; set; }
        }
    }

