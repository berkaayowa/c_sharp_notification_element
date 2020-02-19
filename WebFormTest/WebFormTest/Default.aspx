<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormTest._Default" %>
<%@ Register Namespace="CustomElement" Assembly="CustomElement" TagPrefix="axz" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <axz:Notify ID="notification" Title="Notification" />
</asp:Content>
