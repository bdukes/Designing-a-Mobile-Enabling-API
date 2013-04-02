// <copyright file="MessagesController.cs" company="Engage Software">
// EngageServicesFrameworkExampleImplementation
// Copyright (c) 2004-2013
// by Engage Software ( http://www.engagesoftware.com )
// </copyright>
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

namespace Engage.Dnn.ServicesFrameworkExampleImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Runtime.Serialization;

    using DotNetNuke.Common.Utilities;
    using DotNetNuke.Security;
    using DotNetNuke.Security.Roles;
    using DotNetNuke.Services.Exceptions;
    using DotNetNuke.Services.Messaging;
    using DotNetNuke.Services.Messaging.Data;
    using DotNetNuke.Services.Social.Messaging.Internal;
    using DotNetNuke.Services.Social.Notifications;
    using DotNetNuke.Web.Api;

    [SupportedModules("DotNetNuke.Modules.CoreMessaging,Engage: ServicesFrameworkExampleImplementation")]
    [DnnModuleAuthorize(AccessLevel = SecurityAccessLevel.View)]
    public class MessagesController : DnnApiController
    {    
        /// <summary>The messaging controller to use to get access to messages</summary>
        private readonly IMessagingController messagingController;

        public MessagesController()
            : this(new MessagingController(new MessagingDataService()))
        {
        }

        public MessagesController(IMessagingController messagingController)
        {
            this.messagingController = messagingController;
        }

        public HttpResponseMessage Get()
        {
            try
            {
                var messages = from c in InternalMessagingController.Instance.GetRecentInbox(this.UserInfo.UserID, Null.NullInteger, 15).Conversations
                               select new MessagesResponse.Message
                                {
                                    ReplyAllAllowed = c.ReplyAllAllowed,
                                    Body = c.Body,
                                    ConversationId = c.ConversationId,
                                    From = c.From,
                                    MessageDate = c.DisplayDate,
                                    MessageId = c.MessageID,
                                    Subject = c.Subject,
                                    To = c.To
                                };
                return this.Request.CreateResponse(HttpStatusCode.OK, new MessagesResponse { Messages = messages });
            }
            catch (Exception exc)
            {
                Exceptions.LogException(exc);
                return this.Request.CreateErrorResponse(HttpStatusCode.InternalServerError, exc);
            }
        }

        [DataContract]
        private class MessagesResponse
        {
            [DataMember]
            public IEnumerable<Message> Messages { get; set; }

            [DataContract]
            public class Message
            {
                [DataMember]
                public int MessageId { get; set; }
                [DataMember]
                public string Body { get; set; }
                [DataMember]
                public string Subject { get; set; }
                [DataMember]
                public int ConversationId { get; set; }
                [DataMember]
                public string From { get; set; }
                [DataMember]
                public string To { get; set; }
                [DataMember]
                public string MessageDate { get; set; }
                [DataMember]
                public bool ReplyAllAllowed { get; set; }
            }
        }
    }
}