<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="ViewServicesFrameworkExampleImplementation.ascx.cs" Inherits="Engage.Dnn.ServicesFrameworkExampleImplementation.ViewServicesFrameworkExampleImplementation" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>

<dnn:DnnJsInclude runat="server" FilePath="knockout.js" PathNameAlias="SharedScripts" />
<asp:Label runat="server" ResourceKey="Hello World!" />

<div id="services-framework-example-data-holder">
    <h2>Messages:</h2>
    <ol data-bind="foreach:Messages">
        <li>
            <header>
                <h2 data-bind="text:Subject"></h2>
                <dl>
                    <dt>From</dt><dd data-bind="text: From"></dd>
                    <dt>To</dt><dd data-bind="text: To"></dd>
                </dl>
            </header>
            <footer>
                <time data-bind="text:MessageDate"></time>
            </footer>
        </li>
    </ol>
</div>

<script>
    jQuery(function ($) {
        var sf = $.ServicesFramework(<%:ModuleContext.ModuleId%>);
        $.ajax({
            type: 'GET',
            dataType: "json",
            url: sf.getServiceRoot('Engage/ServicesFrameworkExampleImplementation') + 'Messages',
            beforeSend: sf.setModuleHeaders,
            data: {}
        }).done(function (data) {
            console.log('Request succeeded', data);
            ko.applyBindings(data, document.getElementById('services-framework-example-data-holder'));
        }).fail(function (xhr, status) {
            console.error('Request failed', xhr, status);
        });
    })
</script>