<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="EliminarCurso.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModCursos.EliminarCurso" %>
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
                        <td colspan="4" style="width: 42%" > <asp:Label ID="LabelTitulo" runat="server" Text="Eliminar Curso" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                      </tr>
                      <tr>
                           <td colspan="1" style="width: 42%" > <asp:Label ID="LabelCurso" runat="server" Text="Nombre:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td>
                               <asp:DropDownList ID="DDLCurso" runat="server" DataTextField="nombre" DataValueField="nombre" OnSelectedIndexChanged="DDLCurso_SelectedIndexChanged1" AutoPostBack="true">
                               </asp:DropDownList>
                               <br />

                           </td>
                          <td colspan="1" style="width: 42%" > <asp:Label ID="LabelModuloD" runat="server" Text="Módulo:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td>
                               <asp:DropDownList ID="DDLModulo" runat="server" OnSelectedIndexChanged="DDLModulo_SelectedIndexChanged" AutoPostBack="true">
                               </asp:DropDownList>
                               <br />

                           </td>
                      </tr>
                      <tr>
                           <td colspan="1" style="width: 42%" > <asp:Label ID="LabelNombre" runat="server" Text="Nombre:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td colspan="3"> 
                              <br />
                               <asp:Label ID="LNombre" runat="server" Text="" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label> 
                              <br />
                           </td>
                      </tr>
                      <tr>
                          <td colspan="1" style="width: 42%" > <asp:Label ID="LabelModulo" runat="server" Text="Modulo:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                           <td colspan="3"> 
                              <br />
                               <asp:Label ID="LModulo" runat="server" Text="" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label> 
                              <br />
                           </td>
                      </tr>
                      <tr >
                           <td colspan="4" style="width: 100%" >
                             <br />                       
                             <asp:Button ID="BEliminar" runat="server" Text="Eliminar" Width="90px" OnClick="BEliminar_Click"  />   
                                                 
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
                                                 
                             <asp:Button ID="BVolver" runat="server" Text="Volver" Width="95px" PostBackUrl="../ModInicio/Inicio.aspx"/>   
                             <br />
                             <br />
                         </td>
                      </tr>
                      <tr>                        
                        <td colspan="4" style="width: 42%" > <asp:Label ID="LMensaje" runat="server" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                      </tr>
                  </table>

             </td>

        </tr>
            
    </table>

</asp:Content>
