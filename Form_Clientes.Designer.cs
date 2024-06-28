namespace SysVendas2 {
	partial class Form_Clientes {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Txt_NOME = new System.Windows.Forms.TextBox();
			this.Txt_CPF = new System.Windows.Forms.TextBox();
			this.Txt_RG = new System.Windows.Forms.TextBox();
			this.Txt_ENDERECO = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Txt_EMAIL = new System.Windows.Forms.TextBox();
			this.Txt_TELEFONE = new System.Windows.Forms.TextBox();
			this.Btn_INSERIR = new System.Windows.Forms.Button();
			this.Btn_ATUALIZAR = new System.Windows.Forms.Button();
			this.Btn_EXCLUIR = new System.Windows.Forms.Button();
			this.DGV_ListaClientes = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.Txt_IDCliente = new System.Windows.Forms.TextBox();
			this.DTP_Nascimento = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.DGV_ListaClientes)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "NOME";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "CPF";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(328, 73);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "RG";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(557, 73);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(78, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "NASCIMENTO";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(29, 121);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "ENDERECO";
			this.label6.Click += new System.EventHandler(this.label6_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 161);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(42, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "E-MAIL";
			// 
			// Txt_NOME
			// 
			this.Txt_NOME.Location = new System.Drawing.Point(123, 30);
			this.Txt_NOME.Name = "Txt_NOME";
			this.Txt_NOME.Size = new System.Drawing.Size(634, 20);
			this.Txt_NOME.TabIndex = 1;
			// 
			// Txt_CPF
			// 
			this.Txt_CPF.Location = new System.Drawing.Point(123, 73);
			this.Txt_CPF.Name = "Txt_CPF";
			this.Txt_CPF.Size = new System.Drawing.Size(183, 20);
			this.Txt_CPF.TabIndex = 2;
			this.Txt_CPF.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Txt_RG
			// 
			this.Txt_RG.Location = new System.Drawing.Point(371, 73);
			this.Txt_RG.Name = "Txt_RG";
			this.Txt_RG.Size = new System.Drawing.Size(139, 20);
			this.Txt_RG.TabIndex = 3;
			// 
			// Txt_ENDERECO
			// 
			this.Txt_ENDERECO.Location = new System.Drawing.Point(123, 114);
			this.Txt_ENDERECO.Name = "Txt_ENDERECO";
			this.Txt_ENDERECO.Size = new System.Drawing.Size(387, 20);
			this.Txt_ENDERECO.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(29, 192);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "TELEFONE";
			// 
			// Txt_EMAIL
			// 
			this.Txt_EMAIL.Location = new System.Drawing.Point(123, 154);
			this.Txt_EMAIL.Name = "Txt_EMAIL";
			this.Txt_EMAIL.Size = new System.Drawing.Size(387, 20);
			this.Txt_EMAIL.TabIndex = 6;
			// 
			// Txt_TELEFONE
			// 
			this.Txt_TELEFONE.Location = new System.Drawing.Point(123, 192);
			this.Txt_TELEFONE.Name = "Txt_TELEFONE";
			this.Txt_TELEFONE.Size = new System.Drawing.Size(153, 20);
			this.Txt_TELEFONE.TabIndex = 7;
			// 
			// Btn_INSERIR
			// 
			this.Btn_INSERIR.Location = new System.Drawing.Point(32, 398);
			this.Btn_INSERIR.Name = "Btn_INSERIR";
			this.Btn_INSERIR.Size = new System.Drawing.Size(104, 40);
			this.Btn_INSERIR.TabIndex = 11;
			this.Btn_INSERIR.Text = "INSERIR";
			this.Btn_INSERIR.UseVisualStyleBackColor = true;
			this.Btn_INSERIR.Click += new System.EventHandler(this.Btn_INSERIR_Click);
			// 
			// Btn_ATUALIZAR
			// 
			this.Btn_ATUALIZAR.Location = new System.Drawing.Point(142, 398);
			this.Btn_ATUALIZAR.Name = "Btn_ATUALIZAR";
			this.Btn_ATUALIZAR.Size = new System.Drawing.Size(106, 40);
			this.Btn_ATUALIZAR.TabIndex = 12;
			this.Btn_ATUALIZAR.Text = "ATUALIZAR";
			this.Btn_ATUALIZAR.UseVisualStyleBackColor = true;
			this.Btn_ATUALIZAR.Click += new System.EventHandler(this.Btn_ATUALIZAR_Click);
			// 
			// Btn_EXCLUIR
			// 
			this.Btn_EXCLUIR.Location = new System.Drawing.Point(638, 398);
			this.Btn_EXCLUIR.Name = "Btn_EXCLUIR";
			this.Btn_EXCLUIR.Size = new System.Drawing.Size(119, 40);
			this.Btn_EXCLUIR.TabIndex = 13;
			this.Btn_EXCLUIR.Text = "EXCLUIR";
			this.Btn_EXCLUIR.UseVisualStyleBackColor = true;
			this.Btn_EXCLUIR.Click += new System.EventHandler(this.Btn_EXCLUIR_Click);
			// 
			// DGV_ListaClientes
			// 
			this.DGV_ListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGV_ListaClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.DGV_ListaClientes.Location = new System.Drawing.Point(32, 237);
			this.DGV_ListaClientes.MultiSelect = false;
			this.DGV_ListaClientes.Name = "DGV_ListaClientes";
			this.DGV_ListaClientes.ReadOnly = true;
			this.DGV_ListaClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DGV_ListaClientes.Size = new System.Drawing.Size(725, 122);
			this.DGV_ListaClientes.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(557, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "ID";
			this.label1.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// Txt_IDCliente
			// 
			this.Txt_IDCliente.Location = new System.Drawing.Point(581, 173);
			this.Txt_IDCliente.Name = "Txt_IDCliente";
			this.Txt_IDCliente.Size = new System.Drawing.Size(100, 20);
			this.Txt_IDCliente.TabIndex = 15;
			this.Txt_IDCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// DTP_Nascimento
			// 
			this.DTP_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.DTP_Nascimento.Location = new System.Drawing.Point(641, 73);
			this.DTP_Nascimento.Name = "DTP_Nascimento";
			this.DTP_Nascimento.Size = new System.Drawing.Size(116, 20);
			this.DTP_Nascimento.TabIndex = 16;
			// 
			// Form_Clientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DTP_Nascimento);
			this.Controls.Add(this.Txt_IDCliente);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DGV_ListaClientes);
			this.Controls.Add(this.Btn_EXCLUIR);
			this.Controls.Add(this.Btn_ATUALIZAR);
			this.Controls.Add(this.Btn_INSERIR);
			this.Controls.Add(this.Txt_TELEFONE);
			this.Controls.Add(this.Txt_EMAIL);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Txt_ENDERECO);
			this.Controls.Add(this.Txt_RG);
			this.Controls.Add(this.Txt_CPF);
			this.Controls.Add(this.Txt_NOME);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "Form_Clientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Cadrasto de Clientes";
			this.Load += new System.EventHandler(this.Form_Clientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.DGV_ListaClientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Txt_NOME;
		private System.Windows.Forms.TextBox Txt_ClienteId;
		private System.Windows.Forms.TextBox Txt_Name_Cliente;
		private System.Windows.Forms.TextBox Txt_NOME_CLIENTE;
		private System.Windows.Forms.TextBox Txt_CPF;
		private System.Windows.Forms.TextBox Txt_RG;
		private System.Windows.Forms.TextBox Txt_ENDERECO;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Txt_EMAIL;
		private System.Windows.Forms.TextBox Txt_TELEFONE;
		private System.Windows.Forms.Button Btn_INSERIR;
		private System.Windows.Forms.Button Btn_ATUALIZAR;
		private System.Windows.Forms.Button Btn_EXCLUIR;
		private System.Windows.Forms.DataGridView DGV_ListaClientes;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Txt_IDCliente;
		private System.Windows.Forms.DateTimePicker DTP_Nascimento;
	}
}