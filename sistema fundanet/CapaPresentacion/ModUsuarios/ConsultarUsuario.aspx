<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ConsultarUsuario.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModUsuarios.ConsultarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



       <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/ConsultarUsuario.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" > <asp:Label ID="Label2" runat="server" Text="Consultar Usuario" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                       
                        </tr>
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label7" runat="server" Text="Nombre de Usuario a buscar:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td style="width: 253px"> 
                            <br />
                            <asp:TextBox ID="LabelBuscar" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                            <br />
                        </td>
                        
                    </tr>

                    </tr>
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label3" runat="server" Text="Nombre de Usuario:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td style="width: 253px"> 
                            <asp:Label ID="LabelNombre" runat="server" Text="" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label>
                            <br />
                        </td>
                        
                    </tr>

            

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label5" runat="server" Text="Pregunta Secreta:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td style="width: 253px"> 
                            <asp:Label ID="LabelPregunta" runat="server" Text=""  CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label>
                            <br />
                        </td>
                        
                    </tr>

                                     

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label8" runat="server" Text="Persona Asociada: " CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td style="width: 253px"> 
                            <asp:Label ID="LabelPersona" runat="server" Text=""  CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label>
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label1" runat="server" Text="Rol del Usuario:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td style="width: 253px"> 
                            <asp:Label ID="LabelRol" runat="server" Text=""  CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label>
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="2">

                            <br />

                            <asp:Button ID="Button1" runat="server" Text="Consultar" OnClick="Button1_Click" Width="115px" />

                            <br />

                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="2">

                            <br />

                            <asp:Label ID="LabelNotificacion" runat="server" Text="Label" Font-Bold="True" Font-Names="Candara" Visible="False"></asp:Label>

                            <br />

                        </td>
                        
                    </tr>
                                        
                </table>
                
            </td>
        </tr>
        
    </table>












</asp:Content>
