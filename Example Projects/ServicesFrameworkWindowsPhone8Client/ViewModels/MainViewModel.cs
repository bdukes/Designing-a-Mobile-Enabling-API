namespace ServicesFrameworkWindowsPhone8Client.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Net.Http;

    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.Messages = new ObservableCollection<MessageViewModel>();
        }

        public ObservableCollection<MessageViewModel> Messages { get; private set; }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public async void LoadData()
        {
            var response = await new HttpClient().GetAsync(new Uri("http://dnn7.dev/DesktopModules/Engage/MyMessagesInbox/API/Messages"));
            var messageJson = await response.Content.ReadAsStringAsync();
            var messages = Newtonsoft.Json.JsonConvert.DeserializeObject<MessagesResponse>(messageJson);

            this.Messages.Clear();
            foreach (var message in messages.Messages)
            {
                this.Messages.Add(new MessageViewModel { Body = message.Body, FromUserName = message.FromUserName, ID = message.MessageId, Subject = message.Subject, ToUserName = message.ToUserName ?? message.ToRoleName });   
            }

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            var handler = this.PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}