using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
-Aluno: Thiago Aio
-https://github.com/thiagoa261/Biblioteca-WindowsForms
*/

namespace Biblioteca
{
	public partial class Form1 : Form
	{
		private string BaseDados;
		private string Conexao;

		public Form1()
		{
			InitializeComponent();

			DataGrid.AllowUserToAddRows = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Criar o banco e a tabela ao carregar o formulário

			BaseDados = Application.StartupPath + @"\db\database.db";
			Conexao = @"Data Source=" + BaseDados + "; Version = 3";

			if (!File.Exists(BaseDados))
			{
				SQLiteConnection.CreateFile(BaseDados);
			}

			SQLiteConnection conect = new SQLiteConnection(Conexao);

			try {
				conect.Open();
				SQLiteCommand comando = new SQLiteCommand();
				comando.Connection = conect;

				comando.CommandText = "CREATE TABLE IF NOT EXISTS livros " +
					"(id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL," +
					"titulo VARCHAR(50) NOT NULL," +
					"autor VARCHAR(50) NOT NULL," +
					"ano INTEGER NOT NULL);";
				comando.ExecuteNonQuery();

				comando.Dispose();
			}
			catch (Exception ex) {
				MessageBox.Show("Erro: \n" + ex);
			}
			finally {
				conect.Close();
				btnLista_Click(sender, EventArgs.Empty);
			}
		}

		private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (DataGrid.SelectedRows[0].Cells[0].Value != null)
			{
				txtTitulo.Text = DataGrid.SelectedRows[0].Cells[1].Value.ToString();
				txtAutor.Text = DataGrid.SelectedRows[0].Cells[2].Value.ToString();
				txtAno.Text = DataGrid.SelectedRows[0].Cells[3].Value.ToString();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string titulo = txtTitulo.Text;
			string autor = txtAutor.Text;
			string ano = txtAno.Text;

			if (titulo == "" || autor == "" || ano == "") {
				MessageBox.Show("Por favor, preencha todos os campos para adicionar um livro.");
			}
			else {
				try {
					int anoPublicacao = int.Parse(ano);

					SQLiteConnection conect = new SQLiteConnection(Conexao);
					conect.Open();

					SQLiteCommand comando = new SQLiteCommand();
					comando.Connection = conect;

					comando.CommandText = "INSERT INTO livros (titulo, autor, ano) VALUES ('" + titulo + "', '" + autor + "'," + anoPublicacao + ");";
					comando.ExecuteNonQuery();

					comando.Dispose();
					conect.Close();

					btnLista_Click(sender, EventArgs.Empty);

					MessageBox.Show("Livro registrado com sucesso!");
				}
				catch(Exception ex) {
					MessageBox.Show("Erro: \n" + ex);
				}
				finally {
					txtAno.Clear();
					txtAutor.Clear();
					txtTitulo.Clear();
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (DataGrid.SelectedRows.Count == 1) {
				SQLiteConnection conect = new SQLiteConnection(Conexao);

				try
				{
					conect.Open();

					SQLiteCommand comando = new SQLiteCommand();
					comando.Connection = conect;

					int id = Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value);

					DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir o livro selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

					if (confirmacao == DialogResult.Yes)
					{
						comando.CommandText = "DELETE from livros WHERE id ='" + id + "';";
						comando.ExecuteNonQuery();

						comando.Dispose();

						MessageBox.Show("Registro Excluído com Sucesso!");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: \n" + ex);
				}
				finally
				{
					conect.Close();
					txtTitulo.Clear();
					txtAutor.Clear();
					txtAno.Clear();
					btnLista_Click(sender, EventArgs.Empty);
				}
			}
			else {
				MessageBox.Show("Impossível fazer exclusão, nenhum livro selecionado.");
			}
		}

		private void btnLista_Click(object sender, EventArgs e)
		{
			DataGrid.Rows.Clear();

			SQLiteConnection conect = new SQLiteConnection(Conexao);

			try
			{
				string query = "SELECT * FROM livros;";

				DataTable dados = new DataTable();
				SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, Conexao);

				conect.Open();

				adaptador.Fill(dados);

				foreach (DataRow l in dados.Rows)
				{
					DataGrid.Rows.Add(l.ItemArray);
				}
			}
			catch (Exception ex)
			{
				DataGrid.Rows.Clear();
				MessageBox.Show("Erro: \n" + ex);
			}
			finally {
				conect.Close();
				txtAno.Clear();
				txtAutor.Clear();
				txtTitulo.Clear();
				txtPesquisa.Clear();
			}

			DataGrid.ClearSelection();
		}

		private void btnEdita_Click(object sender, EventArgs e)
		{
			if (DataGrid.SelectedRows.Count == 1) {
				SQLiteConnection conect = new SQLiteConnection(Conexao);

				try
				{
					conect.Open();

					SQLiteCommand comando = new SQLiteCommand();
					comando.Connection = conect;

					int id = Convert.ToInt32(DataGrid.SelectedRows[0].Cells[0].Value);

					string tit = txtTitulo.Text;
					string aut = txtAutor.Text;
					int ano = int.Parse(txtAno.Text);

					comando.CommandText = "UPDATE livros SET titulo = '" + tit + "', " +
						"autor = '" + aut + "', ano = " + ano + " WHERE id = '" + id + "';";
					comando.ExecuteNonQuery();

					comando.Dispose();
					txtAno.Clear();
					txtAutor.Clear();
					txtTitulo.Clear();

					btnLista_Click(sender, EventArgs.Empty);

					MessageBox.Show("Registro alterado com sucesso!");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: \n" + ex);
				}
				finally
				{
					conect.Close();
				}
			}
			else {
				MessageBox.Show("Por favor, selecione um livro para poder editá-lo.");
			}
		}

		private void btnPesquisa_Click(object sender, EventArgs e)
		{
			string filtro = txtPesquisa.Text;

			if (filtro == "")
			{
				MessageBox.Show("Por favor, digite algo no campo para efetuar uma pesquisa.");
				txtPesquisa.Focus();
			}
			else
			{
				SQLiteConnection conect = new SQLiteConnection(Conexao);

				try
				{
					string query = "SELECT * FROM livros WHERE " +
						"titulo LIKE '%" + filtro + "%' OR " +
						"autor LIKE '%" + filtro + "%' OR " +
						"CAST(ano AS VARCHAR) LIKE '%" + filtro + "%';";

					DataTable dados = new DataTable();
					SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conect);

					conect.Open();
					adaptador.Fill(dados);

					DataGrid.Rows.Clear();

					foreach (DataRow l in dados.Rows)
					{
						DataGrid.Rows.Add(l.ItemArray);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Erro: \n" + ex);
				}
				finally
				{
					conect.Close();
					txtPesquisa.Clear();
					DataGrid.ClearSelection();
				}
			}
		}
	}
}
