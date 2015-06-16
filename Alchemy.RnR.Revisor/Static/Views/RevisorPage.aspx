<%@ Page Language="C#" AutoEventWireup="true" Inherits="Tridion.Web.UI.Editors.CME.Views.Page"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" ng-app="AlchemyFindAndReplace">
<head id="Head1" runat="server">
    <title></title>
    <cc:TridionManager runat="server" Editor="CME">
		<dependencies runat="server"> 
			<dependency runat="server">Tridion.Web.UI.Editors.CME</dependency>
			<dependency runat="server">Tridion.Web.UI.Editors.CME.commands</dependency>
			<dependency runat="server">Tridion.Web.UI.Editors.CME.Views.Sites</dependency>
            <dependency runat="server">Alchemy.Plugins.Revisor.Resources.PageView</dependency>
		</dependencies>
	</cc:TridionManager>
</head>
	<body>
        <h1 id="username" style="margin:20px">
            
        </h1>
    </body>
</html>