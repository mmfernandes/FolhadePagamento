using System;

namespace ProjetoFaturamento.Models
{
    public class Colaborador
    {
        public Colaborador() //constructor
        { 
            CriadoEm = DateTime.Now;
        }
       //public string Colaboradores {get; set; }
        public string Login  {get; set; }
        public string Data_Nascimento  {get; set; }
        public string CriadoEm {get; set; }

    }
    
}