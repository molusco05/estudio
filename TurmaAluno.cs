using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estudio
{
    class TurmaAluno
    {

        private String Cpf, IdTurma, descricao;






        public string Cpf1 { get => Cpf; set => Cpf = value; }
        public string IdTurma1 { get => IdTurma; set => IdTurma = value; }
        public string Descricao { get => descricao; set => descricao = value; }



        public TurmaAluno(String IdTurmas, String Cpf)
        {
            this.IdTurma = IdTurmas;
            this.Cpf = Cpf;
        }
        public TurmaAluno()
        {


        }
        public TurmaAluno(String IdTurmas)
        {
            this.IdTurma = IdTurmas;
        }
        public bool cadastrarTurmaAluno()
        {

            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Estudio_TurmaAluno (IdTurma, Cpf) values('" + IdTurma + "','" + Cpf + "') ", DAO_Conexao.con);
                Console.WriteLine("insert into Estudio_TurmaAluno (IdTurma, Cpf) values('" + IdTurma + "','" + Cpf + "')");
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


        public MySqlDataReader consultaTurmaAluno()
        {

            MySqlDataReader result = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consult = new MySqlCommand("select * from Estudio_TurmaAluno", DAO_Conexao.con);
                result = consult.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }

        public bool excluirTurmaAluno()
        {

            bool result = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand excluir = new MySqlCommand("Delete from Estudio_TurmaAluno where Cpf ='" + Cpf + "' and IdTurma ='" + IdTurma + "'", DAO_Conexao.con);
                MySqlCommand update = new MySqlCommand(" update Turma set NalunosMatriculadosTurma = NalunosMatriculadosTurma - 1 where idTurma ='" + IdTurma + "'", DAO_Conexao.con);
                excluir.ExecuteNonQuery();
                update.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return result;
        }

        public MySqlDataReader consultaNomes()
        {

            MySqlDataReader result = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consult = new MySqlCommand("select nomealuno FROM Estudio_TurmaAluno ta inner join Estudio_Aluno a on ta.Cpf = a.CPFAluno where IdTurma = 11", DAO_Conexao.con);
                result = consult.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return result;
        }
    

    }
      




    } 


    

