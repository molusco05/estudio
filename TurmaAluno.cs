using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class TurmaAluno
    {

        private int Cpf, IdModalidade, descricao;

        public int Cpf1 { get => Cpf; set => Cpf = value; }
        public int IdModalidade1 { get => IdModalidade; set => IdModalidade = value; }
        public int Descricao { get => descricao; set => descricao = value; }

        public bool cadastrarTurmaAluno()
        {

            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Turma (idModalidade, Cpf) values('" + IdModalidade + "','" + Cpf + "') ", DAO_Conexao.con);
                Console.WriteLine("insert into idEstudio_TurmaAluno (idModalidade, Cpf) values('" + IdModalidade + "','" + Cpf + "')");
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
    }
}


    

