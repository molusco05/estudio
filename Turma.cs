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


       // public bool cadastrarTurma()
       // {
       //
      //  }

       // public bool excluirTurma()
       // {
            
       // }

       // public MySqlDataReader consultar


       

    }
}
