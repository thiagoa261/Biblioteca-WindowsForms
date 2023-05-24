
namespace Biblioteca
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.DataGrid = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTitulo = new System.Windows.Forms.TextBox();
			this.txtAutor = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtAno = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnPesquisa = new System.Windows.Forms.Button();
			this.btnLista = new System.Windows.Forms.Button();
			this.btnEdita = new System.Windows.Forms.Button();
			this.txtPesquisa = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// DataGrid
			// 
			this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.autor,
            this.ano});
			this.DataGrid.Location = new System.Drawing.Point(12, 61);
			this.DataGrid.MultiSelect = false;
			this.DataGrid.Name = "DataGrid";
			this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGrid.Size = new System.Drawing.Size(640, 331);
			this.DataGrid.TabIndex = 0;
			this.DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellClick);
			// 
			// id
			// 
			this.id.HeaderText = "Id";
			this.id.Name = "id";
			// 
			// titulo
			// 
			this.titulo.HeaderText = "Título";
			this.titulo.Name = "titulo";
			// 
			// autor
			// 
			this.autor.HeaderText = "Autor";
			this.autor.Name = "autor";
			// 
			// ano
			// 
			this.ano.HeaderText = "Ano Publicação";
			this.ano.Name = "ano";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(670, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Título:";
			// 
			// txtTitulo
			// 
			this.txtTitulo.Location = new System.Drawing.Point(674, 85);
			this.txtTitulo.Name = "txtTitulo";
			this.txtTitulo.Size = new System.Drawing.Size(255, 20);
			this.txtTitulo.TabIndex = 3;
			// 
			// txtAutor
			// 
			this.txtAutor.Location = new System.Drawing.Point(674, 147);
			this.txtAutor.Name = "txtAutor";
			this.txtAutor.Size = new System.Drawing.Size(255, 20);
			this.txtAutor.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(670, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Autor:";
			// 
			// txtAno
			// 
			this.txtAno.Location = new System.Drawing.Point(674, 206);
			this.txtAno.Name = "txtAno";
			this.txtAno.Size = new System.Drawing.Size(255, 20);
			this.txtAno.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(670, 180);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(171, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Ano de Publicação:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(674, 260);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(125, 63);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "ADICIONAR";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(804, 260);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(125, 63);
			this.btnDelete.TabIndex = 9;
			this.btnDelete.Text = "EXCLUIR";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnPesquisa
			// 
			this.btnPesquisa.Location = new System.Drawing.Point(522, 15);
			this.btnPesquisa.Name = "btnPesquisa";
			this.btnPesquisa.Size = new System.Drawing.Size(130, 29);
			this.btnPesquisa.TabIndex = 10;
			this.btnPesquisa.Text = "PESQUISAR";
			this.btnPesquisa.UseVisualStyleBackColor = true;
			this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
			// 
			// btnLista
			// 
			this.btnLista.Location = new System.Drawing.Point(804, 329);
			this.btnLista.Name = "btnLista";
			this.btnLista.Size = new System.Drawing.Size(125, 63);
			this.btnLista.TabIndex = 11;
			this.btnLista.Text = "LISTAR TODOS";
			this.btnLista.UseVisualStyleBackColor = true;
			this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
			// 
			// btnEdita
			// 
			this.btnEdita.Location = new System.Drawing.Point(673, 329);
			this.btnEdita.Name = "btnEdita";
			this.btnEdita.Size = new System.Drawing.Size(125, 63);
			this.btnEdita.TabIndex = 12;
			this.btnEdita.Text = "EDITAR";
			this.btnEdita.UseVisualStyleBackColor = true;
			this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click);
			// 
			// txtPesquisa
			// 
			this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPesquisa.Location = new System.Drawing.Point(12, 15);
			this.txtPesquisa.Name = "txtPesquisa";
			this.txtPesquisa.Size = new System.Drawing.Size(504, 29);
			this.txtPesquisa.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(946, 408);
			this.Controls.Add(this.txtPesquisa);
			this.Controls.Add(this.btnEdita);
			this.Controls.Add(this.btnLista);
			this.Controls.Add(this.btnPesquisa);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtAno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtAutor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtTitulo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DataGrid);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(962, 447);
			this.MinimumSize = new System.Drawing.Size(962, 447);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Biblioteca";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView DataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
		private System.Windows.Forms.DataGridViewTextBoxColumn autor;
		private System.Windows.Forms.DataGridViewTextBoxColumn ano;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTitulo;
		private System.Windows.Forms.TextBox txtAutor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtAno;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnPesquisa;
		private System.Windows.Forms.Button btnLista;
		private System.Windows.Forms.Button btnEdita;
		private System.Windows.Forms.TextBox txtPesquisa;
	}
}

