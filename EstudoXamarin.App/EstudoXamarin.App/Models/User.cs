using System.ComponentModel;

namespace EstudoXamarin.App.Models
{
    public class User: INotifyPropertyChanged
    {
        private int _id;
        public int id
        {
            get { return _id;  }
            set {
                _id = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_id)));
            }
        }

        private string _primeiroNome;
        public string first_name
        {
            get { return _primeiroNome; }
            set
            {
                _primeiroNome = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_primeiroNome)));
            }
        }

        private string _ultimoNome;
        public string last_name
        {
            get { return _ultimoNome; }
            set
            {
                _ultimoNome = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_ultimoNome)));
            }
        }

        private string _imageUrl;
        public string ImageUrl
        {
            get { return _imageUrl; }
            set
            {
                _imageUrl = value;
                this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_imageUrl)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}