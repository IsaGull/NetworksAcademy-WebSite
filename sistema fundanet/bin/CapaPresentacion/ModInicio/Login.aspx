<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaLogin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModInicio.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    <table  >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/IniciarSesion.png" class="img" />
            </td>


            <td>


                <table style="width:100%; text-align:center;" >
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label1" runat="server" Text="Usuario" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px" Width="237px"></asp:TextBox> </td>
                        
                    </tr>
                    <tr>
                        <td colspan="1" style="width: 42%"><asp:Label ID="Label2" runat="server" Text="Contrasena" Font-Bold="True" Font-Names="Candara"  ></asp:Label></td>
                        <td>&nbsp;<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 0px" Width="237px" TextMode="Password"></asp:TextBox> </td>
                    </tr>
                   
                    <tr colspan:"2">
                        
                         <td colspan="2" style="width: 100%" >
                             <br />
                             <asp:Button ID="Button1" runat="server" Text="Enviar" Width="156px" OnClick="Button1_Click" />  


                         </td>
                    </tr>

                     <tr colspan:"1">
                        <asp:Label ID="Label3" runat="server" Text="" Visible="true"></asp:Label>

                        </tr>
                    
                </table>


            </td>
        </tr>
        <tr>
            <td>

                <p>


                    <b>El sistema Administrativo y Académico de la academia de redes Cisco Fundanet </b>tiene 
                                            <br>
                    como finalidad la automatización de procesos fundamentales para la academia,
                    <br>
                    como lo son:
                    <br>
                    <br>
                    -	La gestión de personal, roles y usuarios.
                    <br>
                    -	La gestión de cursos y secciones
                    .<br>
                    -	La automatización del proceso de inscripción y pago.
                    <br>
                    -	La gestión de alumnos, carga de notas y envío de notificaciones.
                    <br>
                    -	La generación de documentos como certificados y constancias.
                    <br>
                </p>

            </td>
        </tr>


    </table>



   

    </td>
</tr>



   

</asp:Content>
