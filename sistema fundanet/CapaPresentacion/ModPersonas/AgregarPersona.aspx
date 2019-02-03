<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarPersona.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModPersonas.AgregarPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



       <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/AgregarPersona.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="Label2" runat="server" Text="Agregar Personal" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
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
                            <asp:TextBox ID="LabelApellido" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label5" runat="server" Text="Correo:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="LabelCorreo" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label6" runat="server" Text="Telefono:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="LabelTelefono" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label7" runat="server" Text="Cedula:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:TextBox ID="LabelCedula" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> 
                            <br />
                        </td>
                        
                    </tr>

                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label8" runat="server" Text="Tipo De Persona" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:DropDownList ID="DropDownListTipo" runat="server"></asp:DropDownList>
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

                            <asp:Label ID="LabelNotificacion" runat="server" Text="Label" Font-Bold="True" Font-Names="Candara" Visible="False"></asp:Label>

                            <br />

                        </td>
                        
                    </tr>
                                        
                </table>
                
            </td>
        </tr>
        
    </table>





</asp:Content>
