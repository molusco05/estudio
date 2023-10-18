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
        private String turma, professor, diaSemana, hora, modalidade;


        public string Modalidades { get => modalidade; set => modalidade = value; }
        public string Professor { get => Professor1; set => Professor1 = value; }
        public string Professor1 { get => Professor2; set => Professor2 = value; }
        public string Professor2 { get => professor; set => professor = value; }

        public Turma(String turma, String modalidades,String professor, String diaSemana, String hora )
        {
            this.turma = turma;
            this.modalidade = modalidades;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.hora = hora;
        }
        public Turma(String modalidades, String professor, String diaSemana, String hora)
        {
           
            this.modalidade = modalidades;
            this.professor = professor;
            this.diaSemana = diaSemana;
            this.hora = hora;
        }

        public Turma(String modalidades)
        {
            this.modalidade = modalidades;
        }

        public Turma(String modalidades, String diaSemana)
        {
            this.modalidade = modalidades;
            this.diaSemana = diaSemana;
        }

        public Turma()
        {
           
        }
        public Turma(String modalidades,String diaSemana, String hora)
        {
            this.modalidade = modalidades;
            this.diaSemana = diaSemana;
            this.hora = hora;
        }

        public bool cadastrarTurma()
        {

            bool cad = false;

            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Turma (idModalidade, professorTurma, diaSemanaTurma, horaTurma) values('" + modalidade + "','" + professor + "','" + diaSemana + "','" + hora + "')", DAO_Conexao.con);
                Console.WriteLine("insert into Turma (idModalidade, professorTurma, diaSemanaTurma, horaTurma) values('" + modalidade + "','" + professor + "','" + diaSemana + "','" + hora + "')");
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
        public bool verificaTurma()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma where idModalidade='" + modalidade + "' and diaSemanaTurma='" + diaSemana + "' and horaTurma='" + hora + "' and professorTurma='"+ Professor +"'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
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
            return existe;
        }
        public bool excluirTurma()
        {

            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Turma set ativa = 1 where idModalidade='" + modalidade + "' and diaSemanaTurma='" + diaSemana + "' and horaTurma='" + hora + "' and professorTurma='" + Professor + "'", DAO_Conexao.con);

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


        public MySqlDataReader consultarTodasTurmas()
        {
            //bool cons = false;
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma ", DAO_Conexao.con);
                Console.WriteLine("select idModalidade from Turma ");
                resultado = consulta.ExecuteReader();
               
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
                MySqlCommand consulta = new MySqlCommand("select * from Turma ", DAO_Conexao.con);
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

        public bool atualizarTurma()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
               
                MySqlCommand atualiza = new MySqlCommand($"update Turma set idModalidade = '{modalidade}', professorTurma = ' {professor} ', diaSemanaTurma = ' {diaSemana} ', horaTurma = ' {hora} ' where idTurma = '{turma}'", DAO_Conexao.con);
                Console.WriteLine("update Turma set idModalidade = '" + modalidade + "','" + professor + "','" + diaSemana + "','" + hora + "'");
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

        public MySqlDataReader consultarTurma(String idTurma)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"select * from Turma where idTurma = '{idTurma}' ", DAO_Conexao.con);
                Console.WriteLine($"select * from Turma where idTurma = '{idTurma}'");
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
                    return resultado;
        }
        public MySqlDataReader consultarTurma()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand($"select * from Turma where idModalidade = '{modalidade}' AND professorTurma = '{professor}' AND diaSemanaTurma = '{diaSemana}' AND horaTurma = '{hora}'", DAO_Conexao.con);
                Console.WriteLine($"select * from Turma where idModalidade = '{modalidade}', professorTurma = '{professor}', diaSemanaTurma = '{diaSemana}', horaTurma = '{hora}'");             
                resultado = consulta.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }




    };
}
