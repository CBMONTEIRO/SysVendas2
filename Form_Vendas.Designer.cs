namespace SysVendas2 {
	partial class Form_Vendas {
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Btn_EXCLUIR = new System.Windows.Forms.Button();
			this.Btn_ATUALIZAR = new System.Windows.Forms.Button();
			this.Btn_INSERIR = new System.Windows.Forms.Button();
			this.Txt_PRECO = new System.Windows.Forms.TextBox();
			this.Txt_CLIENTE = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Txt_IDProduto = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Txt_QTD = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(39, 193);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(725, 162);
			this.dataGridView1.TabIndex = 55;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Btn_EXCLUIR
			// 
			this.Btn_EXCLUIR.Location = new System.Drawing.Point(645, 389);
			this.Btn_EXCLUIR.Name = "Btn_EXCLUIR";
			this.Btn_EXCLUIR.Size = new System.Drawing.Size(119, 40);
			this.Btn_EXCLUIR.TabIndex = 54;
			this.Btn_EXCLUIR.Text = "EXCLUIR";
			this.Btn_EXCLUIR.UseVisualStyleBackColor = true;
			this.Btn_EXCLUIR.Click += new System.EventHandler(this.Btn_EXCLUIR_Click);
			// 
			// Btn_ATUALIZAR
			// 
			this.Btn_ATUALIZAR.Location = new System.Drawing.Point(149, 389);
			this.Btn_ATUALIZAR.Name = "Btn_ATUALIZAR";
			this.Btn_ATUALIZAR.Size = new System.Drawing.Size(106, 40);
			this.Btn_ATUALIZAR.TabIndex = 53;
			this.Btn_ATUALIZAR.Text = "ATUALIZAR";
			this.Btn_ATUALIZAR.UseVisualStyleBackColor = true;
			this.Btn_ATUALIZAR.Click += new System.EventHandler(this.Btn_ATUALIZAR_Click);
			// 
			// Btn_INSERIR
			// 
			this.Btn_INSERIR.Location = new System.Drawing.Point(39, 389);
			this.Btn_INSERIR.Name = "Btn_INSERIR";
			this.Btn_INSERIR.Size = new System.Drawing.Size(104, 40);
			this.Btn_INSERIR.TabIndex = 52;
			this.Btn_INSERIR.Text = "INSERIR";
			this.Btn_INSERIR.UseVisualStyleBackColor = true;
			this.Btn_INSERIR.Click += new System.EventHandler(this.Btn_INSERIR_Click);
			// 
			// Txt_PRECO
			// 
			this.Txt_PRECO.Location = new System.Drawing.Point(132, 60);
			this.Txt_PRECO.Name = "Txt_PRECO";
			this.Txt_PRECO.Size = new System.Drawing.Size(460, 20);
			this.Txt_PRECO.TabIndex = 51;
			this.Txt_PRECO.TextChanged += new System.EventHandler(this.Txt_PRECO_TextChanged);
			// 
			// Txt_CLIENTE
			// 
			this.Txt_CLIENTE.Location = new System.Drawing.Point(598, 21);
			this.Txt_CLIENTE.Name = "Txt_CLIENTE";
			this.Txt_CLIENTE.Size = new System.Drawing.Size(166, 20);
			this.Txt_CLIENTE.TabIndex = 50;
			this.Txt_CLIENTE.TextChanged += new System.EventHandler(this.Txt_CLIENTE_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(36, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(61, 13);
			this.label4.TabIndex = 48;
			this.label4.Text = "PRODUTO";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(540, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 47;
			this.label3.Text = "CLIENTE";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(219, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 46;
			this.label2.Text = "DATA";
			// 
			// Txt_IDProduto
			// 
			this.Txt_IDProduto.Location = new System.Drawing.Point(80, 21);
			this.Txt_IDProduto.Name = "Txt_IDProduto";
			this.Txt_IDProduto.Size = new System.Drawing.Size(104, 20);
			this.Txt_IDProduto.TabIndex = 45;
			this.Txt_IDProduto.TextChanged += new System.EventHandler(this.Txt_IDProduto_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 44;
			this.label1.Text = "ID";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(285, 21);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 56;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(36, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 57;
			this.label5.Text = "UNIDADE";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label6.Location = new System.Drawing.Point(132, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(31, 13);
			this.label6.TabIndex = 58;
			this.label6.Text = "UND";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(282, 113);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 59;
			this.label7.Text = "PREÇO";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label8.Location = new System.Drawing.Point(333, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(21, 13);
			this.label8.TabIndex = 60;
			this.label8.Text = "R$";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(514, 113);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(78, 13);
			this.label9.TabIndex = 61;
			this.label9.Text = "QUANTIDADE";
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// Txt_QTD
			// 
			this.Txt_QTD.Location = new System.Drawing.Point(599, 106);
			this.Txt_QTD.Name = "Txt_QTD";
			this.Txt_QTD.Size = new System.Drawing.Size(165, 20);
			this.Txt_QTD.TabIndex = 62;
			this.Txt_QTD.TextChanged += new System.EventHandler(this.Txt_QTD_TextChanged);
			// 
			// Form_Vendas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Txt_QTD);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.Btn_EXCLUIR);
			this.Controls.Add(this.Btn_ATUALIZAR);
			this.Controls.Add(this.Btn_INSERIR);
			this.Controls.Add(this.Txt_PRECO);
			this.Controls.Add(this.Txt_CLIENTE);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Txt_IDProduto);
			this.Controls.Add(this.label1);
			this.Name = "Form_Vendas";
			this.Text = "Form_Vendas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Btn_EXCLUIR;
		private System.Windows.Forms.Button Btn_ATUALIZAR;
		private System.Windows.Forms.Button Btn_INSERIR;
		private System.Windows.Forms.TextBox Txt_PRECO;
		private System.Windows.Forms.TextBox Txt_CLIENTE;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Txt_IDProduto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Txt_QTD;
	}
}