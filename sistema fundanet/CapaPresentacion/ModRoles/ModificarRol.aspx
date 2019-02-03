<%@ Page Title="" Language="C#" MasterPageFile="~/CapaPresentacion/Master/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="ModificarRol.aspx.cs" Inherits="Sistema_Fundanet.CapaPresentacion.ModRoles.ModificarRol" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


           <table >


        <tr>

            <td width="100" height="307" rowspan="2"></td>
            <td width="430" height="307" class="imagen2" rowspan="2">

                <img src="../Imagenes/ModificarRol.png" class="img" />
            </td>


            <td style="width: 454px">


                <table style="width:100%; text-align:center;">
                    <tr>
                        <td colspan="2" style="width: 42%" > <asp:Label ID="Label3" runat="server" Text="Modificar Rol" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Larger"></asp:Label>
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

                        <td colspan="1" style="width: 42%" >

                            <br />

                            <asp:Label ID="Label6" runat="server" Text="Nombre: " Font-Names="Candara" Font-Size="Medium" Font-Bold="True"></asp:Label>

                        </td>

                        <td>


                            <br />


                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


                            <br />


                        </td>

                    </tr>

                     <tr>
                        <td colspan="1" style="width: 42%" > <asp:Label ID="Label4" runat="server" Text="Funciones:" CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre" DataValueField="nombre" Width="237px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FundanetConnectionString2 %>" SelectCommand="SELECT [nombre] FROM [funcion]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
                        </td>

                        
                    </tr>
                    <tr>
                          <td colspan="1" style="width: 42%" > <asp:Label ID="Label5" runat="server" Text="Funciones Del Rol: " CssClass="MiLabel" Font-Bold="True" Font-Names="Candara" Font-Size="Medium"></asp:Label></td>
                        <td> 
                            <br />
                            <asp:ListBox ID="ListBox1" runat="server" BackColor="#99CCFF" Font-Names="Candara" Font-Size="Medium" Width="199px"></asp:ListBox>

                            
                            <br />

                            
                            <br />

                            
                          </td>

                     </tr>

                     <tr>

                         <td colspan="1">

                             <asp:Button ID="Button2" runat="server" Text="Limpiar Lista de Funciones" OnClick="Button2_Click" Width="180px" />

                             <br />

                             <br />

                         </td>
                         
                         <td colspan="1">

                             <asp:Button ID="Button1" runat="server" Text="Modificar Rol" OnClick="Button1_Click" Width="161px" />

                             <br />

                             <br />

                         </td>


                     </tr>

                   

                    <tr>

                         <td colspan="2">

                             <br />

                             <asp:Label ID="Label2" runat="server" Text="Label" Visible="False" Font-Bold="True" Font-Names="Candara" Font-Size="Large"></asp:Label>

                         </td>


                     </tr>
           
                  

                   

                    
                </table>


            </td>
        </tr>
        


    </table>



   


















</asp:Content>
