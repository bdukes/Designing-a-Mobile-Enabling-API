namespace ServicesFrameworkWindowsPhone8Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MessagesResponse
    {
        public IEnumerable<Message> Messages { get; set; }

        public string Error { get; set; }

        public class Message
        {
            public int MessageId { get; set; }
            public string Body { get; set; }
            public string Subject { get; set; }
            public int ConversationId { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public string MessageDate { get; set; }
            public bool ReplyAllAllowed { get; set; }
        }
    }
}
