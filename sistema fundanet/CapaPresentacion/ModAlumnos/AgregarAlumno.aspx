<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarAlumno.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModAlumnos.AgregarAlumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/AgregarAlumno.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="Label2" runat="server" Text="Agregar Alumno" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                       
                        
                    </tr>
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label3" runat="server" Text="Nombre:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="Label1Nombre" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                   <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label4" runat="server" Text="Apellido:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="Label1Apellido" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label5" runat="server" Text="Correo:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="Label1Correo" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label6" runat="server" Text="Telefono:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="Label1Telefono" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label7" runat="server" Text="Cedula:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="Label1Cedula" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>


                    <tr>
                        <td colspan="2">

                            <br />

                            <asp:Button ID="Button1" runat="server" Text="Agregar" OnClick="Button1_Click" />

                            <br />

                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="2">

                            <br />

                            <asp:Label ID="Label1Notificacion" runat="server" Text="Label" Font-Bold="True" Font-Names="Candara" Visible="False"></asp:Label>

                            <br />

                        </td>
                        
                    </tr>
                                        
                </table>
                
            </td>
        </tr>
        
    </table>




</asp:Content>
