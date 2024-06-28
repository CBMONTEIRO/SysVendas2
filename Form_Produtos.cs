using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using SysVendas2;

namespace SysVendas2
{
	public partial class Form_Clientes : Form
	{
		private Contexto contexto;

		int estadoUsuario = 0;

		Cliente cliente;

		List<Cliente> clientes;

		int clienteId = 0;

		public Form_Clientes()
		{
			InitializeComponent();
			contexto = new Contexto();

			clientes = new List<Cliente>();

			using (var clienteCxt = new Contexto())
			{
				clientes = clienteCxt.Clientes.ToList();
			}

			DGV_ListaClientes.DataSource = clientes;

		}
		private void Form_Clientes_Load(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}
		private void label1_Click_1(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Txt_NASCIMENTO_TextChanged(object sender, EventArgs e)
		{

		}
		private void Txt_CELULAR_TextChanged(object sender, EventArgs e)
		{

		}

		private void Btn_INSERIR_Click(object sender, EventArgs e)
		{

			//Coversão em formato de data
			//DateTime dataNascimento;
			//DateTime.TryParseExact(Txt_NASCIMENTO.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascimento);

			//Criação do objeto cliente responsavel em carregar os dados que irão 
			Cliente novocliente = new Cliente()
			{
				//ClienteId = Txt_IDCliente.Text;
				Nome = Txt_NOME.Text,
				RG = Txt_RG.Text,
				CPF = Txt_CPF.Text,
				Nascimento = DTP_Nascimento.Value,
				Endereco = Txt_ENDERECO.Text,
				Fone = Txt_TELEFONE.Text,
				Email = Txt_EMAIL.Text
			};

			//Inserção no bancos de dados
			contexto.Clientes.Add(novocliente);
			contexto.SaveChanges();

			clientes = new List<Cliente>();

			using (var clienteCxt = new Contexto())
			{
				clientes = clienteCxt.Clientes.ToList();
			}

			DGV_ListaClientes.DataSource = clientes;



			//Limpeza das caixas de texto
			Txt_IDCliente.Text = "";
			Txt_NOME.Text = "";
			Txt_RG.Text = "";
			Txt_CPF.Text = "";
			Txt_ENDERECO.Text = "";
			Txt_TELEFONE.Text = "";
			Txt_EMAIL.Text = "";
			DTP_Nascimento.Value = DateTime.Parse("01/06/2000");

			MessageBox.Show("Clientes adicionados com sucesso! 🎉");
		}

		private void label5_Click(object sender, EventArgs e)
		{
			clientes = new List<Cliente>();

			using (var clienteCxt = new Contexto())
			{
				clientes = clienteCxt.Clientes.ToList();
			}

			//Preeche os dados dos clientes para o DateGridview
			DGV_ListaClientes.DataSource = clientes;

		}

		private void Txt_IDCliente_TextChanged(object sender, EventArgs e)
		{

		}

		private void Btn_ATUALIZAR_Click(object sender, EventArgs e)
		{

			if (estadoUsuario == 2)
			{
				using (var contexto = new Contexto())
				{
					var clienteRegistrado = contexto.Clientes.FirstOrDefault(
						c => c.ClienteId == clienteId);

					if (clienteRegistrado != null && Txt_NOME != null)
					{
						clienteRegistrado.Nome = Txt_NOME.Text;
						clienteRegistrado.RG = Txt_RG.Text;
						clienteRegistrado.CPF = Txt_CPF.Text;
						//clienteRegistrado.Endereco = Txt_ENDERECO.Text = "";
						clienteRegistrado.Fone = Txt_TELEFONE.Text;
						clienteRegistrado.Email = Txt_EMAIL.Text;
						clienteRegistrado.Nascimento = DTP_Nascimento.Value;

						contexto.Clientes.Update(clienteRegistrado);
						contexto.SaveChanges();

						estadoUsuario = 1;

						MessageBox.Show("Clientes Atualizado!");


					}
					else
					{
						MessageBox.Show("Cliente não encontrado ou campos inválidos.");

					}
					clientes = new List<Cliente>();
					clientes = contexto.Clientes.ToList();
					DGV_ListaClientes.DataSource = clientes;
				}

			}
			else
			{
				if (DGV_ListaClientes.SelectedRows.Count > 0)
				{
					Cliente clienteSelected = DGV_ListaClientes.SelectedRows[0].DataBoundItem as Cliente;

					clienteId = clienteSelected.ClienteId;
					Txt_NOME.Text = clienteSelected.Nome;
					Txt_RG.Text = clienteSelected.RG;
					Txt_CPF.Text = clienteSelected.CPF;
					Txt_ENDERECO.Text = clienteSelected.Endereco;
					Txt_TELEFONE.Text = clienteSelected.Fone;
					Txt_EMAIL.Text = clienteSelected.Email;
					DTP_Nascimento.Value = clienteSelected.Nascimento;

					estadoUsuario = 2;
				}
			}
		}

		private void Btn_EXCLUIR_Click(object sender, EventArgs e)
		{
			if (DGV_ListaClientes.SelectedRows.Count > 0)
			{
				Cliente clientesSelected = DGV_ListaClientes.SelectedRows[0].DataBoundItem as Cliente;

				using (var clientesCxt = new Contexto())
				{
					var clienteParaDeletar = clientesCxt.Clientes.FirstOrDefault(
						c => c.ClienteId == clientesSelected.ClienteId);

					clientesCxt.Clientes.Remove(clienteParaDeletar);
					clientesCxt.SaveChanges();

					clientes = new List<Cliente>();
					clientes = clientesCxt.Clientes.ToList();
					DGV_ListaClientes.DataSource = clientes;

					MessageBox.Show("Cliente Excluido!");

				}

			}
		}

		private void Txt_NOME_TextChanged(object sender, EventArgs e)
		{

		}
	}
}