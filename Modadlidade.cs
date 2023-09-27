using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class Modadlidade
    {
        private String Descricao;
        private float Preco;
        private int qtde_alunos, qtde_aulas;


        public string Descricao1 { get => Descricao; set => Descricao = value; }
        public int Qtde_alunos { get => Qtde_alunos; set => Qtde_alunos = value; }
        public float Preco1 { get => Preco; set => Preco = value; }
        public int Qtde_aulas { get => qtde_aulas; set => qtde_aulas = value; }

        public Modadlidade(String descricao, float preco, int qtde_alunos, int qtde_aulas)
        {

        }

        public Modadlidade(String descricao)
        {

        }

        public Modadlidade()
        {

        }

        public bool cadastrarModalidade()
        {

            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '" + Descricao + "', precoModalidade = '" + Preco + "', qtdeAlunos = '" + qtde_alunos + "', qtdeAulas = '" + qtde_aulas);
                MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '" + Descricao + "', precoModalidade = '" + Preco + "', qtdeAlunos = '" + qtde_alunos + "', qtdeAulas = '" + qtde_aulas, DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return cad;
        }

        public MySqlDataReader consultarModalidade()
        {
            MySqlDataReader resultado = null;
            //bool cons = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Modalidade where  descricaoModalidade = '" + Descricao + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    //cons = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return resultado;
        }

        public MySqlDataReader consultarTodasModalidade()
        {
            //bool cons = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Estudio_Modalidade ", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                   // cons = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }

            return resultado;
        }


        public bool atualizarModalidade()
        {
            {
                bool exc = false;
                try
                {
                    DAO_Conexao.con.Open();
                    //Console.WriteLine("update Estudio_Modalidade set descricaoModalidade = '" + Descricao + "', precoModalidade = '" + Preco + "', qtdeAlunos = '" + qtde_alunos + "', qtdeAulas = '" +  qtde_aulas ); 
                    MySqlCommand atualiza = new MySqlCommand("update Estudio_Modalidade set descricaoModalidade = '" + Descricao + "', precoModalidade = '" + Preco + "', qtdeAlunos = '" + qtde_alunos + "', qtdeAulas = '" + qtde_aulas, DAO_Conexao.con);
                    atualiza.ExecuteNonQuery();
                    exc = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexao.con.Close();
                }
                return exc;
            }
            }

            public bool excluirModalidade()
            {
                bool exc = false;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand exclui = new MySqlCommand("update Estudio_Modalidade set ativo = 1 where descricaoModalidade='" + Descricao + "'", DAO_Conexao.con);
                    exclui.ExecuteNonQuery();
                    exc = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexao.con.Close();
                }
                return exc;
            }


        }
    } 
