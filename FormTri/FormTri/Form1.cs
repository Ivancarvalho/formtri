using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

// Sql Server CE
using System.Data.SqlServerCe;

namespace FormTri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = "+baseDados+"; Password = '1234'";

            SqlCeEngine db = new SqlCeEngine(strConection);

            if (!File.Exists(baseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            SqlCeConnection conexao = new SqlCeConnection(strConection);
            //conexao.ConnectionString = strConection;
                   
                      

            try
            {
                conexao.Open();

                labelResultado.Text = "Conectado ao banco de dados";
            }
            catch (Exception ex)
            {
                labelResultado.Text = "Erro ao conectar ao banco de dados \n" + ex;
            }
            finally
            {
                conexao.Close();
            }                        
        }

        private void btncriartabela_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE cadastroc(id INT NOT NULL PRIMARY KEY, nome NVARCHAR(100), email NVARCHAR(80), telefone DECIMAL(20,0), celular DECIMAL(20,0), cpf DECIMAL(20,2), cnpj DECIMAL(20,2), razaosocial NVARCHAR(100), classificacao NVARCHAR(10), rua NVARCHAR(50), numero DECIMAL(20,0), bairro NVARCHAR(50), cidade NVARCHAR(50), estado NVARCHAR(20), cep DECIMAL(20,3))";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Tabela Criada no Banco de dados";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally 
            { 
                conexao.Close(); 
            }
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = new Random(DateTime.Now.Millisecond).Next(0,1000000000);
                string nome = txtnome.Text;
                string email = txtemail.Text;
                string telefone = txttelefone.Text;
                string celular = txtcelular.Text;
                string cpf = txtcpf.Text;
                string cnpj = txtcnpj.Text;
                string razaosocial = txtrazaosocial.Text;
                string classificacao = txtclassificacao.Text;
                string rua = txtrua.Text;
                string numero = txtnumero.Text;
                string bairro = txtbairro.Text;
                string cidade = txtcidade.Text;
                string estado = txtestado.Text;
                string cep = txtcep.Text;


                comando.CommandText = "INSERT INTO cadastroc VALUES("+id+", '"+nome+"', '"+email+"', '"+telefone+"', '"+celular+"', '"+cpf+"', '"+cnpj+"', '"+razaosocial+"', '"+classificacao+"', '"+rua+"', '"+numero+"', '"+bairro+"', '"+cidade+"', '"+estado+"', '"+cep+"')";
                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro inserido com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnprocurar_Click(object sender, EventArgs e)
        {
            labelResultado.Text = "";
            lista.Rows.Clear();

            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                string query = "SELECT * FROM cadastroc";

                if (txtnome.Text != "") 
                {
                    query = "SELECT * FROM cadastroc WHERE nome LIKE  '"+txtnome.Text+  "'";
                }

               DataTable dados = new DataTable();

               SqlCeDataAdapter adptador = new SqlCeDataAdapter(query, strConection);

                conexao.Open();

                adptador.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    lista.Rows.Add(linha.ItemArray);
                }
               
            }
            catch (Exception ex)
            {
                lista.Rows.Clear();
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;

                comando.CommandText = "DELETE FROM cadastroc WHERE id = '"+id+"'";


                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro apagado com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLServer.sdf";
            string strConection = @"DataSource = " + baseDados + "; Password = '1234'";

            SqlCeConnection conexao = new SqlCeConnection(strConection);

            try
            {
                conexao.Open();

                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                int id = (int)lista.SelectedRows[0].Cells[0].Value;
                string nome = txtnome.Text;
                string email = txtemail.Text;
                string telefone = txttelefone.Text;
                string celular = txtcelular.Text;
                string cpf = txtcpf.Text;
                string cnpj = txtcnpj.Text;
                string razaosocial = txtrazaosocial.Text;
                string classificacao = txtclassificacao.Text;
                string rua = txtrua.Text;
                string numero = txtnumero.Text;
                string bairro = txtbairro.Text;
                string cidade = txtcidade.Text;
                string estado = txtestado.Text;
                string cep = txtcep.Text;

                string query = "UPDATE cadastroc SET nome = '"+nome+"', email = '"+email+"' WHERE id LIKE '" + id + "'";

                comando.CommandText = query;

                comando.ExecuteNonQuery();

                labelResultado.Text = "Registro alterado com sucesso";
                comando.Dispose();
            }
            catch (Exception ex)
            {
                labelResultado.Text = ex.Message;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
