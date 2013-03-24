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
            public string Conversation { get; set; }
            public string FromUserName { get; set; }
            public string ToUserName { get; set; }
            public string ToRoleName { get; set; }
            public DateTimeOffset MessageDate { get; set; }
            public string Status { get; set; }
            public bool AllowReply { get; set; }
        }
    }
}
