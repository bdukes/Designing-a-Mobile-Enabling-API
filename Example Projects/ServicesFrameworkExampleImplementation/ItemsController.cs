// <copyright file="ItemsController.cs" company="Engage Software">
// EngageServicesFrameworkExampleImplementation
// Copyright (c) 2004-2012
// by Engage Software ( http://www.engagesoftware.com )
// </copyright>
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED 
// TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL 
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
// CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.

namespace Engage.Dnn.ServicesFrameworkExampleImplementation
{
    using System.Web.Mvc;

    using DotNetNuke.Web.Services;

    [DnnAuthorize(AllowAnonymous = true)]
    public class ItemsController : DnnController
    {
        public ActionResult Get()
        {
            return
                Json(
                    new[]
                        {
                            new
                                {
                                    LineOne = "runtime one",
                                    LineTwo = "Maecenas praesent accumsan bibendum",
                                    LineThree =
                                "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
                                },
                            new
                                {
                                    LineOne = "runtime two",
                                    LineTwo = "Dictumst eleifend facilisi faucibus",
                                    LineThree =
                                "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"
                                },
                            new
                                {
                                    LineOne = "runtime three",
                                    LineTwo = "Habitant inceptos interdum lobortis",
                                    LineThree =
                                "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"
                                },
                            new
                                {
                                    LineOne = "runtime four",
                                    LineTwo = "Nascetur pharetra placerat pulvinar",
                                    LineThree =
                                "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"
                                },
                            new
                                {
                                    LineOne = "runtime five",
                                    LineTwo = "Maecenas praesent accumsan bibendum",
                                    LineThree =
                                "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"
                                },
                            new
                                {
                                    LineOne = "runtime six",
                                    LineTwo = "Dictumst eleifend facilisi faucibus",
                                    LineThree =
                                "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"
                                },
                            new
                                {
                                    LineOne = "runtime seven",
                                    LineTwo = "Habitant inceptos interdum lobortis",
                                    LineThree =
                                "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"
                                },
                            new
                                {
                                    LineOne = "runtime eight",
                                    LineTwo = "Nascetur pharetra placerat pulvinar",
                                    LineThree =
                                "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"
                                },
                            new
                                {
                                    LineOne = "runtime nine",
                                    LineTwo = "Maecenas praesent accumsan bibendum",
                                    LineThree =
                                "Facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu"
                                },
                            new
                                {
                                    LineOne = "runtime ten",
                                    LineTwo = "Dictumst eleifend facilisi faucibus",
                                    LineThree =
                                "Suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus"
                                },
                            new
                                {
                                    LineOne = "runtime eleven",
                                    LineTwo = "Habitant inceptos interdum lobortis",
                                    LineThree =
                                "Habitant inceptos interdum lobortis nascetur pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent"
                                },
                            new
                                {
                                    LineOne = "runtime twelve",
                                    LineTwo = "Nascetur pharetra placerat pulvinar",
                                    LineThree =
                                "Ultrices vehicula volutpat maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos"
                                },
                            new
                                {
                                    LineOne = "runtime thirteen",
                                    LineTwo = "Maecenas praesent accumsan bibendum",
                                    LineThree =
                                "Maecenas praesent accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur"
                                },
                            new
                                {
                                    LineOne = "runtime fourteen",
                                    LineTwo = "Dictumst eleifend facilisi faucibus",
                                    LineThree =
                                "Pharetra placerat pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent"
                                },
                            new
                                {
                                    LineOne = "runtime fifteen",
                                    LineTwo = "Habitant inceptos interdum lobortis",
                                    LineThree =
                                "Accumsan bibendum dictumst eleifend facilisi faucibus habitant inceptos interdum lobortis nascetur pharetra placerat"
                                },
                            new
                                {
                                    LineOne = "runtime sixteen",
                                    LineTwo = "Nascetur pharetra placerat pulvinar",
                                    LineThree =
                                "Pulvinar sagittis senectus sociosqu suscipit torquent ultrices vehicula volutpat maecenas praesent accumsan bibendum"
                                },
                        }, JsonRequestBehavior.AllowGet);
        }
    }
}