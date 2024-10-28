using System.ComponentModel;
using System.Text.Json.Serialization;

namespace ProjetoEstadosBrasil.Models
{
    public class Cidade : INotifyPropertyChanged
    {
        private string _nome;
        private string _estado;
        private int _id;

        [JsonPropertyName("id")]
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        [JsonPropertyName("nome")]
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        [JsonPropertyName("estado")]
        public string Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
                OnPropertyChanged(nameof(Estado));
            }
        }

        public Clima clima { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}