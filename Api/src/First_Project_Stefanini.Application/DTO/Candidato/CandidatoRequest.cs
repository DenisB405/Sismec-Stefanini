using System;
using System.Collections.Generic;
using System.Text;

namespace First_Project_Stefanini.Application.DTO.Candidato
{
    public class CandidatoRequest : EntidadeRequestBase
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string telefonePrimario { get; set; }
        public string telefoneSecundario { get; set; }
        public string CPF { get; set; }
        public DateTime Datalog { get; set; }
        public string Usuario { get; set; }
    }
}
