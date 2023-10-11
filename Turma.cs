using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudio
{
    class Turma
    {
        private String professor, diaSemana, hora;
        private int modalidades;

        public int Modalidades { get => modalidades; set => modalidades = value; }
        public string Professor { get => Professor1; set => Professor1 = value; }
        public string Professor1 { get => Professor2; set => Professor2 = value; }
        public string Professor2 { get => professor; set => professor = value; }

        public Turma(int modalidades,String professor, String diaSemana, String hora )
        {
            this.modalidades = modalidades;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.hora = hora;
        }

        public Turma(int modalidades)
        {
            this.modalidades = modalidades;
        }

        public Turma(int modalidades, String diaSemana)
        {
            this.modalidades = modalidades;
            this.diaSemana = diaSemana;
        }

        public Turma()
        {
           
        }


        public bool cadastrarTurma(String diaSemana, String hora, String professor)
        {

            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Turma (idModalidade, professorTurma, diaSemanaTurma, horaTurma) values('" + modalidades + "','" + professor + "','" + diaSemana + "','" + hora + "')", DAO_Conexao.con);
                Console.WriteLine("insert into Turma (idModalidade, professorTurma, diaSemanaTurma, horaTurma) values('" + modalidades + "','" + professor + "','" + diaSemana + "','" + hora + "')");
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

        public bool excluirTurma()
        {

            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Turma set ativa = 1 where idModalidade='" + modalidades + "' and diaSemanaTurma='" + diaSemana + "' and horaTurma='" + hora + "'", DAO_Conexao.con);

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

        public MySqlDataReader consultarHora()
        {
            //bool cons = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select horaTurma from Turma ", DAO_Conexao.con);
                Console.WriteLine("select horaTurma from Turma ");
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

            return resultado;
        }


        public MySqlDataReader consultarTodasModalidade()
        {
            //bool cons = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select idModalidade from Turma ", DAO_Conexao.con);
                Console.WriteLine("select idModalidade from Turma ");
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

            return resultado;
        }

        public MySqlDataReader consultarDiaSemana()
        {
            //bool cons = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select diaSemanaTurma from Turma ", DAO_Conexao.con);
                Console.WriteLine("select diaSemanaTurma from Turma ");
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

            return resultado;

        }





    };
}
