namespace SysVendas2 {
	partial class Form_Principal {
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.cADRASTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pRODUTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADRASTOToolStripMenuItem,
            this.vENDASToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// cADRASTOToolStripMenuItem
			// 
			this.cADRASTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.pRODUTOToolStripMenuItem});
			this.cADRASTOToolStripMenuItem.Name = "cADRASTOToolStripMenuItem";
			this.cADRASTOToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
			this.cADRASTOToolStripMenuItem.Text = "CADRASTO";
			this.cADRASTOToolStripMenuItem.Click += new System.EventHandler(this.cADRASTOToolStripMenuItem_Click);
			// 
			// cLIENTEToolStripMenuItem
			// 
			this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
			this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cLIENTEToolStripMenuItem.Text = "CLIENTES";
			this.cLIENTEToolStripMenuItem.Click += new System.EventHandler(this.cLIENTEToolStripMenuItem_Click);
			// 
			// pRODUTOToolStripMenuItem
			// 
			this.pRODUTOToolStripMenuItem.Name = "pRODUTOToolStripMenuItem";
			this.pRODUTOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pRODUTOToolStripMenuItem.Text = "PRODUTOS";
			this.pRODUTOToolStripMenuItem.Click += new System.EventHandler(this.pRODUTOToolStripMenuItem_Click);
			// 
			// vENDASToolStripMenuItem
			// 
			this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
			this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
			this.vENDASToolStripMenuItem.Text = "VENDAS";
			this.vENDASToolStripMenuItem.Click += new System.EventHandler(this.vENDASToolStripMenuItem_Click);
			// 
			// Form_Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form_Principal";
			this.Text = "SysVendas V 1.0";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem cADRASTOToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
	}
}

