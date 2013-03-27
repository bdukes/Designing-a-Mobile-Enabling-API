// <copyright file="ItemsController.cs" company="Engage Software">
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
    using System.Net;
    using System.Net.Http;
    using System.Runtime.Serialization;
    using System.Web.Http;

    using DotNetNuke.Web.Api;

    [AllowAnonymous]
    public class ItemsController : DnnApiController
    {
        [DataContract]
        private class Item
        {
            [DataMember]
            public string LineOne { get; private set; }

            [DataMember]
            public string LineTwo { get; private set; }

            [DataMember]
            public string LineThree { get; private set; }

            public Item(string lineOne, string lineTwo, string lineThree)
            {
                this.LineOne = lineOne;
                this.LineTwo = lineTwo;
                this.LineThree = lineThree;
            }
        }

        [HttpPost]
        public HttpResponseMessage Get()
        {
            var data = new[]
                           {
                               new Item("runtime one", "Maecenas praesent accumsan bibendum", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"),
                               new Item("runtime two", "Dictumst eleifend facilisi faucibus", "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"),
                               new Item("runtime three", "Habitant inceptos interdum lobortis", "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"),
                               new Item("runtime four", "Nascetur pharetra placerat pulvinar", "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"),
                               new Item("runtime five", "Maecenas praesent accumsan bibendum", "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"),
                               new Item("runtime six", "Dictumst eleifend facilisi faucibus", "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"),
                               new Item("runtime seven", "Habitant inceptos interdum lobortis", "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"),
                               new Item("runtime eight", "Nascetur pharetra placerat pulvinar", "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"),
                               new Item("runtime nine", "Maecenas praesent accumsan bibendum", "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"),
                               new Item("runtime ten", "Dictumst eleifend facilisi faucibus", "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"),
                               new Item("runtime eleven", "Habitant inceptos interdum lobortis", "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"),
                               new Item("runtime twelve", "Nascetur pharetra placerat pulvinar", "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"),
                               new Item("runtime thirteen", "Maecenas praesent accumsan bibendum", "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"),
                               new Item("runtime fourteen", "Dictumst eleifend facilisi faucibus", "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"),
                               new Item("runtime fifteen", "Habitant inceptos interdum lobortis", "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"),
                               new Item("runtime sixteen", "Nascetur pharetra placerat pulvinar", "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"),
                           };
            return this.Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}