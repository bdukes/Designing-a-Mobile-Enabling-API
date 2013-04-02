namespace ServicesFrameworkWindowsPhone8Client.ViewModels
{
    using System;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Net;
    using System.Net.Http;

    using Newtonsoft.Json;

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
            var httpClient = new HttpClient(new HttpClientHandler { Credentials = new NetworkCredential("host", "pass") });
            var requestUri = new Uri("http://dnn7.dev/DesktopModules/Engage/ServicesFrameworkExampleImplementation/API/Messages");
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            request.Headers.Add("ModuleId", "1740");
            request.Headers.Add("TabId", "56");

            var response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var messageJson = await response.Content.ReadAsStringAsync();
                var messages = JsonConvert.DeserializeObject<MessagesResponse>(messageJson);

                this.Messages.Clear();
                foreach (var message in messages.Messages)
                {
                    this.Messages.Add(new MessageViewModel(message.MessageId, message.Subject, message.From, message.To));
                }
            }
            else
            {
                this.Messages.Add(new MessageViewModel(0, "ERROR: " + response.StatusCode + response.ReasonPhrase, string.Empty, string.Empty));
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

        public class MessageViewModel
        {
            public MessageViewModel(int id, string subject, string @from, string to)
            {
                this.ID = id;
                this.Subject = subject;
                this.From = @from;
                this.To = to;
            }

            public int ID { get; private set; }

            public string Subject { get; private set; }

            public string From { get; private set; }

            public string To { get; private set; }
        }
    }
}