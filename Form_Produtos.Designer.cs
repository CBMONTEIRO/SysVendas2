namespace SysVendas2
{
	partial class Form_Clientes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DGV_ListaPodutos = new System.Windows.Forms.DataGridView();
			this.Btn_EXCLUIR = new System.Windows.Forms.Button();
			this.Btn_ATUALIZAR = new System.Windows.Forms.Button();
			this.Btn_INSERIR = new System.Windows.Forms.Button();
			this.Txt_PRECO = new System.Windows.Forms.TextBox();
			this.Txt_UNIDADE = new System.Windows.Forms.TextBox();
			this.Txt_DESCRICAO = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Txt_IDProduto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ListaPodutos)).BeginInit();
			this.SuspendLayout();
			// 
			// DGV_ListaPodutos
			// 
			this.DGV_ListaPodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_ListaPodutos.Location = new System.Drawing.Point(39, 128);
			this.DGV_ListaPodutos.Name = "DGV_ListaPodutos";
			this.DGV_ListaPodutos.Size = new System.Drawing.Size(725, 211);
			this.DGV_ListaPodutos.TabIndex = 43;
			// 
			// Btn_EXCLUIR
			// 
			this.Btn_EXCLUIR.Location = new System.Drawing.Point(645, 389);
			this.Btn_EXCLUIR.Name = "Btn_EXCLUIR";
			this.Btn_EXCLUIR.Size = new System.Drawing.Size(119, 40);
			this.Btn_EXCLUIR.TabIndex = 31;
			this.Btn_EXCLUIR.Text = "EXCLUIR";
			this.Btn_EXCLUIR.UseVisualStyleBackColor = true;
			this.Btn_EXCLUIR.Click += new System.EventHandler(this.Btn_EXCLUIR_Click);
			// 
			// Btn_ATUALIZAR
			// 
			this.Btn_ATUALIZAR.Location = new System.Drawing.Point(149, 389);
			this.Btn_ATUALIZAR.Name = "Btn_ATUALIZAR";
			this.Btn_ATUALIZAR.Size = new System.Drawing.Size(106, 40);
			this.Btn_ATUALIZAR.TabIndex = 30;
			this.Btn_ATUALIZAR.Text = "ATUALIZAR";
			this.Btn_ATUALIZAR.UseVisualStyleBackColor = true;
			this.Btn_ATUALIZAR.Click += new System.EventHandler(this.Btn_ATUALIZAR_Click);
			// 
			// Btn_INSERIR
			// 
			this.Btn_INSERIR.Location = new System.Drawing.Point(39, 389);
			this.Btn_INSERIR.Name = "Btn_INSERIR";
			this.Btn_INSERIR.Size = new System.Drawing.Size(104, 40);
			this.Btn_INSERIR.TabIndex = 29;
			this.Btn_INSERIR.Text = "INSERIR";
			this.Btn_INSERIR.UseVisualStyleBackColor = true;
			this.Btn_INSERIR.Click += new System.EventHandler(this.Btn_INSERIR_Click);
			// 
			// Txt_PRECO
			// 
			this.Txt_PRECO.Location = new System.Drawing.Point(458, 64);
			this.Txt_PRECO.Name = "Txt_PRECO";
			this.Txt_PRECO.Size = new System.Drawing.Size(105, 20);
			this.Txt_PRECO.TabIndex = 26;
			this.Txt_PRECO.TextChanged += new System.EventHandler(this.Txt_PRECO_TextChanged);
			// 
			// Txt_UNIDADE
			// 
			this.Txt_UNIDADE.Location = new System.Drawing.Point(130, 64);
			this.Txt_UNIDADE.Name = "Txt_UNIDADE";
			this.Txt_UNIDADE.Size = new System.Drawing.Size(104, 20);
			this.Txt_UNIDADE.TabIndex = 25;
			this.Txt_UNIDADE.TextChanged += new System.EventHandler(this.Txt_UNIDADE_TextChanged);
			// 
			// Txt_DESCRICAO
			// 
			this.Txt_DESCRICAO.Location = new System.Drawing.Point(458, 21);
			this.Txt_DESCRICAO.Name = "Txt_DESCRICAO";
			this.Txt_DESCRICAO.Size = new System.Drawing.Size(306, 20);
			this.Txt_DESCRICAO.TabIndex = 24;
			this.Txt_DESCRICAO.TextChanged += new System.EventHandler(this.Txt_DESCRICAO_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(354, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 13);
			this.label4.TabIndex = 26;
			this.label4.Text = "PREÇO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 25;
			this.label3.Text = "UNIDADE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(354, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 24;
			this.label2.Text = "DESCRIÇÃO";
			// 
			// Txt_IDProduto
			// 
			this.Txt_IDProduto.Location = new System.Drawing.Point(130, 21);
			this.Txt_IDProduto.Name = "Txt_IDProduto";
			this.Txt_IDProduto.Size = new System.Drawing.Size(104, 20);
			this.Txt_IDProduto.TabIndex = 23;
			this.Txt_IDProduto.TextChanged += new System.EventHandler(this.Txt_IDProduto_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "ID";
			// 
			// Form_Produtos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DGV_ListaPodutos);
			this.Controls.Add(this.Btn_EXCLUIR);
			this.Controls.Add(this.Btn_ATUALIZAR);
			this.Controls.Add(this.Btn_INSERIR);
			this.Controls.Add(this.Txt_PRECO);
			this.Controls.Add(this.Txt_UNIDADE);
			this.Controls.Add(this.Txt_DESCRICAO);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Txt_IDProduto);
			this.Controls.Add(this.label1);
			this.Name = "Form_Produtos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form_Produtos";
			this.Load += new System.EventHandler(this.Form_Produtos_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_ListaPodutos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DGV_ListaPodutos;
		private System.Windows.Forms.Button Btn_EXCLUIR;
		private System.Windows.Forms.Button Btn_ATUALIZAR;
		private System.Windows.Forms.Button Btn_INSERIR;
		private System.Windows.Forms.TextBox Txt_PRECO;
		private System.Windows.Forms.TextBox Txt_Preco;
		private System.Windows.Forms.TextBox Txt_UNIDADE;
		private System.Windows.Forms.TextBox Txt_DESCRICAO;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Txt_IDProduto;
		private System.Windows.Forms.Label label1;
	}
}