using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysVendas2.Entidades {
	internal class Venda {
		public int VendaId { get; set; }
		public int ClinteId { get; set; }
		public int ProdutoId { get; set; }
		public DateTime DataVenda { get; set; }
		public int Quantidade { get; set; }

		public Cliente Cliente { get; set; }
		public Produto Produto { get; set; }
	}
}
