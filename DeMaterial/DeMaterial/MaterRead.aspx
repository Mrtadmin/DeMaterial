<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterRead.aspx.cs" Inherits="DeMaterial.MaterRead" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
         .dropdown {
  position: relative;
  display: inline-block;
  font-size:20px;
}
.dropdown-content {
  display: none;
  position: absolute;
  background-color: #f9f9f9;
  min-width: 160px;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  padding: 12px 16px;
  font-size:20px;
}
.dropdown:hover .dropdown-content {
  display: block;
}
ul
{
	list-style-type:none;
	margin:0;
	padding:0;
    font-size:20px;
    text-align:right;
    margin:0 auto;
            width: 406px;
            height: 22px;
        }
li
{
display:inline;
}
    </style>
</head>
<body>
        <form runat="server">
        <div class="dropdown">
  <span>材料分类</span>
  <div class="dropdown-content">
    <p><a href='<%# "../Material.aspx?ID="+Eval("MaterialID") %>'>整体衣柜</p>
    <p><a href="Material.aspx">衣柜</a></p>
    <p><a href="Material.aspx">吊顶</a></p>   
    <p><a href="Material.aspx">淋浴</a></p>
    <p><a href="Material.aspx">门</a></p>
    <p><a href="Material.aspx">窗</a></p>

  
  </div>
            </div>
          

        
        <asp:HyperLink ID="hylink" NavigateUrl="~/MaterialLink.aspx" Font-Size="15" runat="server">预览图片></asp:HyperLink><br />
            <a href="CSS/张鹏.rar">下载</a>
    <div style="text-align:center">
        <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource1">
            <AlternatingItemTemplate>
                <tr style="background-color: #FAFAD2;color: #284775;">
                    <td>
                        <asp:Label ID="MaterialIDLabel" runat="server" Text='<%# Eval("MaterialID") %>' />
                    </td>
                    <td>
                        <a href='<%# "../Material.aspx?MaterialID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a>
                    </td>
                    <td>
                        <asp:Label ID="MaterialPriceLabel" runat="server" Text='<%# Eval("MaterialPrice") %>' />
                    </td>
                    <td>
                        <asp:Label ID="OriginLabel" runat="server" Text='<%# Eval("Origin") %>' />
                    </td>
                    <td>
                        <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ModelLabel" runat="server" Text='<%# Eval("Model") %>' />
                    </td>
                    <td>
                        <asp:Label ID="specificationsLabel" runat="server" Text='<%# Eval("specifications") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StyleLabel" runat="server" Text='<%# Eval("Style") %>' />
                    </td>
                    <td>
                        <asp:Label ID="levelLabel" runat="server" Text='<%# Eval("level") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                    </td>
                </tr>
            </AlternatingItemTemplate>
            <EditItemTemplate>
                <tr style="background-color: #FFCC66;color: #000080;">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="更新" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="取消" />
                    </td>
                    <td>
                        <asp:TextBox ID="MaterialIDTextBox" runat="server" Text='<%# Bind("MaterialID") %>' />
                    </td>
                    <td>
                        <a href='<%# "../Material.aspx?MaterialID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a>
                    </td>
                    <td>
                        <asp:TextBox ID="MaterialPriceTextBox" runat="server" Text='<%# Bind("MaterialPrice") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="OriginTextBox" runat="server" Text='<%# Bind("Origin") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="BrandTextBox" runat="server" Text='<%# Bind("Brand") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ModelTextBox" runat="server" Text='<%# Bind("Model") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="specificationsTextBox" runat="server" Text='<%# Bind("specifications") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="StyleTextBox" runat="server" Text='<%# Bind("Style") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="levelTextBox" runat="server" Text='<%# Bind("level") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                    </td>
                </tr>
            </EditItemTemplate>
            <EmptyDataTemplate>
                <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                    <tr>
                        <td>未返回数据。</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <InsertItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="插入" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="清除" />
                    </td>
                    <td>
                        <asp:TextBox ID="MaterialIDTextBox" runat="server" Text='<%# Bind("MaterialID") %>' />
                    </td>
                    <td>
                        <a href='<%# "../Material.aspx?MaterialID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a>
                    </td>
                    <td>
                        <asp:TextBox ID="MaterialPriceTextBox" runat="server" Text='<%# Bind("MaterialPrice") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="OriginTextBox" runat="server" Text='<%# Bind("Origin") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="BrandTextBox" runat="server" Text='<%# Bind("Brand") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="ModelTextBox" runat="server" Text='<%# Bind("Model") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="specificationsTextBox" runat="server" Text='<%# Bind("specifications") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="StyleTextBox" runat="server" Text='<%# Bind("Style") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="levelTextBox" runat="server" Text='<%# Bind("level") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="StateTextBox" runat="server" Text='<%# Bind("State") %>' />
                    </td>
                </tr>
            </InsertItemTemplate>
            <ItemTemplate>
                <tr style="background-color: #FFFBD6;color: #333333;">
                    <td>
                        <asp:Label ID="MaterialIDLabel" runat="server" Text='<%# Eval("MaterialID") %>' />
                    </td>
                    <td>
                        <a href='<%# "../Material.aspx?MaterialID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a>
                    </td>
                    <td>
                        <asp:Label ID="MaterialPriceLabel" runat="server" Text='<%# Eval("MaterialPrice") %>' />
                    </td>
                    <td>
                        <asp:Label ID="OriginLabel" runat="server" Text='<%# Eval("Origin") %>' />
                    </td>
                    <td>
                        <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ModelLabel" runat="server" Text='<%# Eval("Model") %>' />
                    </td>
                    <td>
                        <asp:Label ID="specificationsLabel" runat="server" Text='<%# Eval("specifications") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StyleLabel" runat="server" Text='<%# Eval("Style") %>' />
                    </td>
                    <td>
                        <asp:Label ID="levelLabel" runat="server" Text='<%# Eval("level") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                    </td>
                </tr>
            </ItemTemplate>
            <LayoutTemplate>
                <table runat="server">
                    <tr runat="server">
                        <td runat="server">
                            <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <tr runat="server" style="background-color: #FFFBD6;color: #333333;">
                                    <th runat="server">MaterialID</th>
                                    <th runat="server">MaterialName</th>
                                    <th runat="server">MaterialPrice</th>
                                    <th runat="server">Origin</th>
                                    <th runat="server">Brand</th>
                                    <th runat="server">Model</th>
                                    <th runat="server">specifications</th>
                                    <th runat="server">Style</th>
                                    <th runat="server">level</th>
                                    <th runat="server">State</th>
                                </tr>
                                <tr id="itemPlaceholder" runat="server">
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr runat="server">
                        <td runat="server" style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <SelectedItemTemplate>
                <tr style="background-color: #FFCC66;font-weight: bold;color: #000080;">
                    <td>
                        <a href="Material.aspx">

                        </a><asp:Label ID="MaterialIDLabel" runat="server" Text='<%# Eval("MaterialID") %>' />
                    </td>
                    <td>
                        <a href='<%# "../Material.aspx?MaterialID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a>
                    </td>
                    <td>
                        <asp:Label ID="MaterialPriceLabel" runat="server" Text='<%# Eval("MaterialPrice") %>' />
                    </td>
                    <td>
                        <asp:Label ID="OriginLabel" runat="server" Text='<%# Eval("Origin") %>' />
                    </td>
                    <td>
                        <asp:Label ID="BrandLabel" runat="server" Text='<%# Eval("Brand") %>' />
                    </td>
                    <td>
                        <asp:Label ID="ModelLabel" runat="server" Text='<%# Eval("Model") %>' />
                    </td>
                    <td>
                        <asp:Label ID="specificationsLabel" runat="server" Text='<%# Eval("specifications") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StyleLabel" runat="server" Text='<%# Eval("Style") %>' />
                    </td>
                    <td>
                        <asp:Label ID="levelLabel" runat="server" Text='<%# Eval("level") %>' />
                    </td>
                    <td>
                        <asp:Label ID="StateLabel" runat="server" Text='<%# Eval("State") %>' />
                    </td>
                </tr>
            </SelectedItemTemplate>

        </asp:ListView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetMaterial" TypeName="BLL.Materialbll">
            <SelectParameters>
                <asp:Parameter Name="whereStr" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
