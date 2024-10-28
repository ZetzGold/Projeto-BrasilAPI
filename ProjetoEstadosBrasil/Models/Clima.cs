using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstadosBrasil.Models
{
    public class ClimaResponse
    {
        public string? Cidade { get; set; }
        public string? Estado { get; set; }
        public DateTime? AtualizadoEm { get; set; }
        public List<Clima> Clima { get; set; }
    }

    public class Clima
    {
        public string? Data { get; set; }
        public string? Condicao { get; set; }
        public string? Condicao_desc { get; set; }
        public object? Min { get; set; }
        public object? Max { get; set; }
        public object? Indice_uv { get; set; }

    }
}
