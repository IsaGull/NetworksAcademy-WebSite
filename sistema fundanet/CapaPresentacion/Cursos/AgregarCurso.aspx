<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/-Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.Cursos.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">





    <p>
        <asp:Label ID="LMensaje" runat="server" Text=""></asp:Label>
    </p>
    <p>
        Agregar Curso
    </p>
    <p>
        Nombre del Curso :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBNombre" runat="server"></asp:TextBox>
    </p>
    <p>
        Modulo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TBModulo" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 160px">
        <asp:Button ID="BAceptar" runat="server" Text="Aceptar" OnClick="BAceptar_Click" />
    </p>





</asp:Content>
