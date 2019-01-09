using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace EstudoXamarin.App.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public ICommand CarregarCommand { get; set; }

        private ObservableCollection<Models.User> _users;
        public ObservableCollection<Models.User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Users)));
            }
        }

        private bool _isLoading;

        public bool IsLoading
        {
            get { return _isLoading; }
            set
            {
                _isLoading = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLoading)));
            }
        }

        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsEnabled)));
            }
        }

        public UserViewModel()
        {
            IsEnabled = true;

            CarregarCommand = new Xamarin.Forms.Command(async() => {
                IsEnabled = false;
                IsLoading = true;

                var users = await Services.UserService.GetAsync();
                Users = new ObservableCollection<Models.User>(users);

                IsEnabled = true;
                IsLoading = false;
              });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}