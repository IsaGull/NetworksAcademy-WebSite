<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="EliminarRol.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModRoles.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/EliminarRol.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" style="width: 42%" > 
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Eliminar Rol" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
                            <br />
                            <br />
                            <br />
                        </td>
                       
                        
                    </tr>
                    <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label1" runat="server" Text="Rol: " CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ListarRol" DataTextField="nombre" DataValueField="nombre" Width="237px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="ListarRol" runat="server" ConnectionString="<%$ ConnectionStrings:FundanetConnectionString4 %>" SelectCommand="SELECT [nombre] FROM [rol]" OnSelecting="ListarRol_Selecting"></asp:SqlDataSource>
                            <br />
                        </td>
                        
                    </tr>

                     <tr>
                    <td colspan="2">
                    
                        <br />
                        <br />
                    
                        <asp:Button ID="Button1" runat="server" Text="Eliminar Rol" OnClick="Button1_Click" Width="146px" />

                        <br />
                        <br />

                    </td>
                  </tr> 

               <tr>
                    <td colspan="2">
                    
                        <br />
                        <br />
                    
                        <asp:Label ID="Label2" runat="server" Text="Label" Font-Names="Candara" Font-Size="Medium" Font-Bold="True" Visible="False"></asp:Label>

                        <br />
                        <br />

                    </td>
                  </tr> 

                    
                </table>


            </td>
        </tr>
        


    </table>








</asp:Content>
