﻿// <copyright file="ViewServicesFrameworkExampleImplementation.ascx.cs" company="Engage Software">
// Engage: ServicesFrameworkExampleImplementation
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
    using DotNetNuke.Framework;
    using DotNetNuke.Web.Mvp;

    using WebFormsMvp;

    /// <summary>
    /// </summary>
    [PresenterBinding(typeof(ViewServicesFrameworkExampleImplementationPresenter))]
    public partial class ViewServicesFrameworkExampleImplementation : ModuleView<ViewServicesFrameworkExampleImplementationViewModel>, IViewServicesFrameworkExampleImplementationView
    {
        protected ViewServicesFrameworkExampleImplementation()
        {
            ServicesFramework.Instance.RequestAjaxAntiForgerySupport();
        }
    }
}