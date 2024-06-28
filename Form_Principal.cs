using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysVendas2 {
	public partial class Form_Principal : Form {
		public Form_Principal() {
			InitializeComponent();
		}

		private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e) {
			new Form_Clientes().Show();
			
		}

		private void cADRASTOToolStripMenuItem_Click(object sender, EventArgs e) {
			
		}

		private void pRODUTOToolStripMenuItem_Click(object sender, EventArgs e) {
			new Form_Produtos().Show();
		}

		private void vENDASToolStripMenuItem_Click(object sender, EventArgs e) {
			new Form_Vendas().Show();
		}
	}
}
