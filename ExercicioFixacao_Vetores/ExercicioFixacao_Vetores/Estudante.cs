using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao_Vetores
{
    internal class Estudante
    {
        public string NomeEstu { get; set; }
        public string EmailEstu { get; set; }

        public Estudante(string nome, string email) { 
            NomeEstu = nome;
            EmailEstu = email;
        }

        public override string ToString() {
            return NomeEstu + ", " + EmailEstu;
        }
    }
}
