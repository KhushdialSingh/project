<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="project.login" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="log">
        <h1>Login</h1>
        <input type="text" style="width:100%" placeholder="username"/><br /><br />
        <input type="text" style="width:100%" placeholder="password"/><br /><br />
        <input type="submit" style="float:right" value="Sign in" /><br /><br />
        <a href="">Not registered? Sign up now!</a>
    </div>
</asp:Content>
