using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstadosBrasil.Models
{
    public class Previsao
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }        
        public string Atualizado_em {  get; set; }
        public List<Clima> Clima { get; set; }
    }
}
