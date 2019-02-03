<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="AgregarCurso.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModCursos.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <table>
      
        <tr>

            <td width="100" height="307" rowspan="2">
            </td>

            <td width="430" height="307" class="imagen2" rowspan="2">
                <img src="../Imagenes/ImagenInicio.png" class="img" />
            </td>
            
             <td style="width: 454px">

                  <table style="width:100%; text-align:center;">
                      <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="LabelTitulo" runat="server" Text="Agregar Curso" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                      </tr>
                      <tr>
                           <td colspan="1" style="width: 42%" > <asp:Label ID="LabelNombre" runat="server" Text="Nombre:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td> 
                              <br />
                              <asp:TextBox ID="TBNombre" runat="server" style="margin-left: 0px" Width="237px" MaxLength="10"></asp:TextBox> 
                              <br />
                           </td>
                      </tr>
                      <tr>
                          <td colspan="1" style="width: 42%" > <asp:Label ID="LabelModulo" runat="server" Text="Modulo:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td> 
                              <br />
                              <asp:TextBox ID="TBModulo" runat="server" style="margin-left: 0px" Width="237px" MaxLength="2"></asp:TextBox> 
                              <br />
                           </td>
                      </tr>
                      <tr colspan:"2">
                           <td colspan="2" style="width: 100%" >
                             <br />                       
                             <asp:Button ID="BAgregar" runat="server" Text="Agregar" Width="90px" OnClick="BAceptar_Click" />   
                                                 
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                                                 
                             <asp:Button ID="BVolver" runat="server" Text="Volver" Width="95px" PostBackUrl="../ModInicio/Inicio.aspx" />   
                             <br />
                             <br />
                         </td>
                      </tr>
                      <tr>                        
                        <td colspan="2" style="width: 42%" > <asp:Label ID="LMensaje" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                      </tr>
                  </table>

             </td>

        </tr>
            
    </table>


</asp:Content>
