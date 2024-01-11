
using System.ComponentModel;

namespace ExemploAplicativo.ViewModels
{
    internal class DetalhesFuncionarioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string nomePropriedade)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nomePropriedade));
        }

        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set
            {
                _nome = value;
                OnPropertyChanged(nameof(Nome));
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        private bool _ativo;
        public bool Ativo
        {
            get { return _ativo; }
            set
            {
                _ativo = value;
                OnPropertyChanged(nameof(Ativo));
            }
        }
    }
}
