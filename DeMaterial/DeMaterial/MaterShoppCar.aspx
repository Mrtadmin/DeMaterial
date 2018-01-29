<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterShoppCar.aspx.cs" Inherits="DeMaterial.MaterShoppCar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align:center;">
    <br /><br />
        <p>
            <span style="font-family:方正舒体; font-size:40px;">购物车</span>
        </p>
        <p>
            <table style="padding:5px; width:100%; background-color:#00ffff;">
                <asp:Repeater ID="dgdShoppCar" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td style="width:110px;">
                                 <a href='<%# "Material.aspx?ID="+Eval("MaterialID") %>'>w
                                     <asp:Image ID="imageMater" Width="140" Height="140" ImageUrl='<%# Eval ("ImageURL")%>' runat="server" /></a>
                            </td>
                            <td style="text-align:left;">
                                <a href='<%# "../Material.aspx?ID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a></td>
                            <td>
                                 <%# Eval("MaterialPrice","{0:C}") %>
                            </td>
                          <td style="text-align:left;">
                              <asp:Button ID="bthMove" runat="server" Text="-" CommandName="Show" CommandArgument='<%# Eval("MaterialID") %>' />
                              <asp:TextBox ID="txtMaterialPrice" runat="server" Width="30"></asp:TextBox>
                              <asp:Button ID="bthForward" runat="server" Text="+" CommandName="Forword" CommandArgument='<%# Eval("MaterialID") %>' />
                          </td>
                            <td style="text-align:right;">
                            <asp:LinkButton ID="linkMater" CommandArgument='<%# Eval("MaterialID") %>'  OnClientClick="return confirm('从购物车中移除材料？');" runat="server">删除</asp:LinkButton>
                                </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td colspan="6" style="text-align:right;">
                        <asp:Label ID="lbMater" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="5" style="text-align:right;"></td>
                    <asp:Button ID="bthShow" runat="server" Text="生成订单" />
                </tr>
            </table>
        </p>
        
    </div>
    </form>
</body>
</html>
