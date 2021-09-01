using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Consulta
{
    //INICIANDO A CONEXAO COM O SQL
    public partial class Form1 : Form
    {
        SqlConnection conexao;
        SqlCommand comando;
        SqlDataAdapter da;
        SqlDataReader dr;

        string strSQL;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {

            try // BLOCO DE TRY/CATCH PRA VERIFICAR ERROS NA TENTATIVA DE CONEXAO COM O BANCO
            {
                 // instância do banco de dados + banco de dados    + usuario super do sql + senha
                conexao = new SqlConnection(@"Server=JARVIS\SQLEXPRESS ;Database=presidioSantaHelena ;User Id=sa ;Password = 220145; ");

                //PASSANDO ATRIBUTOS PARA RECEBER NOVOS VALORES
                strSQL = "INSERT INTO PRESO (NOME_PRESO, RG_PRESO, ENDERECO_PRESO, TEMPO_PENA, DT_ENTRADA, GRAU_PRESO, CRIME_PRESO, SITUACAO_ATUAL)" +
                       " VALUES (@NOME_PRESO, @RG_PRESO, @ENDERECO_PRESO, @TEMPO_PENA, @DT_ENTRADA, @GRAU_PRESO, @CRIME_PRESO, @SITUACAO_ATUAL)";

                comando = new SqlCommand(strSQL, conexao);

                //ATRIBUINDO OS VALORES
                comando.Parameters.AddWithValue("@NOME_PRESO", txtNome.Text);
                comando.Parameters.AddWithValue("@RG_PRESO", txtRg.Text);
                comando.Parameters.AddWithValue("@ENDERECO_PRESO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@TEMPO_PENA", txtPena.Text);
                comando.Parameters.AddWithValue("@DT_ENTRADA", txtData.Text);
                comando.Parameters.AddWithValue("@GRAU_PRESO", txtGrau.Text);
                comando.Parameters.AddWithValue("@CRIME_PRESO", txtCrime.Text);
                comando.Parameters.AddWithValue("@SITUACAO_ATUAL", txtSituacao.Text);

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally //FECHANDO CONEXAO
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }

        }

        //CRIANDO CONEXAO COM O BOTAO DE EXIBIR VALORES
        private void BtnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=JARVIS\SQLEXPRESS ;Database=presidioSantaHelena ;User Id=sa ;Password = 220145; ");

                strSQL = "SELECT * FROM PRESO"; //COMANDO DE SELECT GERAL NA TABELA PRESO DO BANCO DE DADOS 

                DataSet ds = new DataSet();

                da = new SqlDataAdapter(strSQL, conexao); 
               
                conexao.Open();

                da.Fill(ds);

                dgvDados.DataSource = ds.Tables[0]; //SETANDO DATA SET PARA EXIBIÇÃO NO PAINEL
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        //CRIANDO CONEXAO COM O BOTAO DE CONSULTAR VALORES
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=JARVIS\SQLEXPRESS ;Database=presidioSantaHelena ;User Id=sa ;Password = 220145; ");

                strSQL = "SELECT * FROM PRESO WHERE ID_PRESO = @ID_PRESO"; //COMANDO DE SELECT NO BANCO APENAS NA TABELA PRESO

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID_PRESO", txtID.Text); // CONSULTA É FEITA APENAS ATRAVÉS DO ID_PRESO
                                
                conexao.Open();
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    txtNome.Text = (string)dr["NOME_PRESO"];
                    txtRg.Text = Convert.ToString(dr["RG_PRESO"]);
                    txtEndereco.Text = (string)dr["ENDERECO_PRESO"];
                    txtPena.Text = Convert.ToString(dr["TEMPO_PENA"]);
                    txtData.Text = (string)dr["DT_ENTRADA"];
                    txtGrau.Text = Convert.ToString(dr["GRAU_PRESO"]);
                    txtCrime.Text = Convert.ToString(dr["CRIME_PRESO"]);
                    txtSituacao.Text = Convert.ToString(dr["SITUACAO_ATUAL"]);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        //CRIANDO CONEXAO COM O BOTAO DE EDITAR VALORES
        private void BtEditar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=JARVIS\SQLEXPRESS ;Database=presidioSantaHelena ;User Id=sa ;Password = 220145; ");

                strSQL = "UPDATE PRESO SET NOME_PRESO = @NOME_PRESO, RG_PRESO = @RG_PRESO, ENDERECO_PRESO = @ENDERECO_PRESO, " +
                    "TEMPO_PENA = @TEMPO_PENA, DT_ENTRADA = @DT_ENTRADA , GRAU_PRESO = @GRAU_PRESO, CRIME_PRESO =  @CRIME_PRESO, SITUACAO_ATUAL = @SITUACAO_ATUAL  WHERE ID_PRESO = @ID_PRESO";
                //COMANDO DE UPDATE NO BANCO 

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID_PRESO", txtID.Text);
                comando.Parameters.AddWithValue("@NOME_PRESO", txtNome.Text);
                comando.Parameters.AddWithValue("@RG_PRESO", txtRg.Text);
                comando.Parameters.AddWithValue("@ENDERECO_PRESO", txtEndereco.Text);
                comando.Parameters.AddWithValue("@TEMPO_PENA", txtPena.Text);
                comando.Parameters.AddWithValue("@DT_ENTRADA", txtData.Text);
                comando.Parameters.AddWithValue("@GRAU_PRESO", txtGrau.Text);
                comando.Parameters.AddWithValue("@CRIME_PRESO", txtCrime.Text);
                comando.Parameters.AddWithValue("@SITUACAO_ATUAL", txtSituacao.Text);


                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }

        //CRIANDO CONEXAO COM O BOTAO DE EXCLUIR VALORES
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection(@"Server=JARVIS\SQLEXPRESS ;Database=presidioSantaHelena ;User Id=sa ;Password = 220145; ");

                strSQL = "DELETE PRESO WHERE ID_PRESO = @ID_PRESO"; // EXCLUINDO APENAS OS DADOS DA TABELA PRESO

                comando = new SqlCommand(strSQL, conexao);

                comando.Parameters.AddWithValue("@ID_PRESO", txtID.Text);
                

                conexao.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
                conexao = null;
                comando = null;
            }
        }
    }
}
