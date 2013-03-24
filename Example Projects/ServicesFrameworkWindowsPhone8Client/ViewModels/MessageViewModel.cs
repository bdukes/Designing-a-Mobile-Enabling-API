namespace ServicesFrameworkWindowsPhone8Client.ViewModels
{
    using System;
    using System.ComponentModel;

    public class MessageViewModel : INotifyPropertyChanged
    {
        private int id;
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                if (value != this.id)
                {
                    this.id = value;
                    this.NotifyPropertyChanged("ID");
                }
            }
        }

        private string subject;
        public string Subject
        {
            get
            {
                return this.subject;
            }
            set
            {
                if (value != this.subject)
                {
                    this.subject = value;
                    this.NotifyPropertyChanged("Subject");
                }
            }
        }

        private string body;
        public string Body
        {
            get
            {
                return this.body;
            }
            set
            {
                if (value != this.body)
                {
                    this.body = value;
                    this.NotifyPropertyChanged("Body");
                }
            }
        }

        private string fromUserName;
        public string FromUserName
        {
            get
            {
                return this.fromUserName;
            }
            set
            {
                if (value != this.fromUserName)
                {
                    this.fromUserName = value;
                    this.NotifyPropertyChanged("FromUserName");
                }
            }
        }

        private string toUserName;
        public string ToUserName
        {
            get
            {
                return this.toUserName;
            }
            set
            {
                if (value != this.toUserName)
                {
                    this.toUserName = value;
                    this.NotifyPropertyChanged("ToUserName");
                }
            }
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