using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Core;
using WpfApp1.MWM.Model;

namespace WpfApp1.MWM.ViewModel
{
    internal class MainViewModel: ObservableObject
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        /* Commands */

        public RelayCommand SendCommand { get; set; }

        private ContactModel _selectedContact;

        public ContactModel SelectedContact
        {
            get { return _selectedContact; }
            set { _selectedContact = value;
                OnPropertyChanged();
                    }

        }
        

        private string _message;

        public string Message
        {
            get { return _message; }
            set 
            { 
                _message = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();


            SendCommand = new RelayCommand(o => 
            {
                Messages.Add(new MessageModel
                {
                    Message = Message,
                    FirstMessage = false 
                });
                Message ="";

            });

            Messages.Add(new MessageModel
            {
                Username = "Kendrick",
                UsernameColor = "409aff",
                ImageSource = "https://www.zsk.poznan.pl/wp-content/uploads/2019/05/m_logo.png",
                Message = "Hello",
                Time = DateTime.Now,
                IsNativeOrgin = false,
                FirstMessage = true
            });

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel
                {
                    Username = "Rysiu",
                    UsernameColor = "409aff",
                    ImageSource = "https://www.zsk.poznan.pl/wp-content/uploads/2019/05/m_logo.png",
                    Message = "Hello",
                    Time = DateTime.Now,
                    IsNativeOrgin = false,
                });

            }
            Messages.Add(new MessageModel
            {
                Username = "Kumi",
                UsernameColor = "409aff",
                ImageSource = "https://www.zsk.poznan.pl/wp-content/uploads/2019/05/m_logo.png",
                Message = "Hello",
                Time = DateTime.Now,
                IsNativeOrgin = false,
            });

            for( int i=0; i < 5 ; i++)
            {
                Contacts.Add(new ContactModel
                {
                    Username = $"Kendrick",
                    ImageSource = "https://i.imgur.com/BDJnYrm.jpeg",
                    Messages = Messages
                });
            }

        }

    }
}
