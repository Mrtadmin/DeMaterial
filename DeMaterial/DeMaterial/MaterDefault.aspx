<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterDefault.aspx.cs"  Inherits="DeMaterial.MaterDefault"  EnableEventValidation="false" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
   <script type="text/javascript" src="js/jquery.js"></script>
<style type="text/css">
    .ReadLink{
        text-align:right;
    }
   
   </style>
</head>
<body>
    
    <form id="form1" runat="server">
    <%--<asp:RadioButton ID="rdoliebiao" runat="server" GroupName="List" Text="列表显示" Checked="true" AutoPostBack="true" OnCheckedChanged="rdoliebiao_CheckedChanged" />--%>
    <%--<asp:RadioButton ID="rdofang" runat="server" GroupName="List" AutoPostBack="true" OnCheckedChanged="rdofang_CheckedChanged" />--%>
      
                    <asp:TextBox ID="txtENd" runat="server" Text="" Height="30px" Width="260px" BorderColor="#ff0000" BorderStyle="Double" ></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="40px" Width="156px" ForeColor="White" Text="🔎淘购一下" Font-Size="15" BackColor="#ff3300" OnClick="Button1_Click" />
        
        <asp:Label ID="lblTime" runat="server" Text="Label"></asp:Label> 
        <asp:Label ID="lblRead" runat="server" Text="Label"></asp:Label><br />


        <div class="ReadLink">
        <asp:LinkButton ID="linkLogin" PostBackUrl="~/MaterLogin.aspx" Width="43px" Height="31px" Font-Size="15" runat="server">登录 </asp:LinkButton>
        <asp:LinkButton ID="linkPassword" Width="43px" Height="31px" Font-Size="15" runat="server">注册</asp:LinkButton>
        </div>
       <%-- <table style="text-align:center">
            <tr>
                <td><asp:LinkButton ID="linkLY" Text="淋浴" runat="server"  ></asp:LinkButton></td>
                <td><asp:LinkButton ID="LinkXDD" Text="吸顶灯" runat="server" ></asp:LinkButton></td>
                <td><asp:LinkButton ID="linkLYF" Text="淋浴房" runat="server" ></asp:LinkButton></td>
                <td><asp:LinkButton ID="LinkQZ" Text="3D墙纸" runat="server" ></asp:LinkButton></td>
                <td><asp:LinkButton ID="linkWWD" Text="户外地板" runat="server" ></asp:LinkButton></td>                
                <td><asp:LinkButton ID="linkBJ" Text="抛晶砖" runat="server" ></asp:LinkButton></td>
                <td><asp:LinkButton ID="linkKG" Text="开关" runat="server" ></asp:LinkButton></td>
                <td><asp:LinkButton ID="linkYQ" Text="油漆" runat="server" ></asp:LinkButton></td>
            </tr>
        </table>--%>
        <asp:FileUpload ID="fileText" runat="server" Height="28px" Width="269px" />
        <asp:Button ID="BuUloled" runat="server" Text="上传" Font-Size="15" BackColor="#ff3300"  ForeColor="White" OnClick="BuUloled_Click" Width="156px" Height="35px" />
        
        <asp:HyperLink ID="hylink" NavigateUrl="~/MaterRead.aspx" Font-Size="15" runat="server">查看></asp:HyperLink><br />
        <asp:Label ID="lblage" runat="server" ></asp:Label>
                
   <asp:DataList ID="dgdDataList" runat="server" RepeatColumns="6" Width="800px">
           
        <ItemTemplate>
            <table  style="width:147px; background-color:#00ffff;" onmouseover="this.style.backgroundColor='#00ffff';" onmouseout="this.style.backgroundColor='#00ffff';">
                <tr>
                    <td style="text-align:center; vertical-align:top;">
                        <a href='<%# "HttpHandler1.ashx?ID="+Eval("MaterialID") %>'>
                            <asp:Image xxcxID="imageMater" Width="220" Height="200" ImageUrl='<%# Eval ("ImageURL")%>' runat="server"></asp:Image>
                        </a>

                    </td>
                </tr>
                <tr>
                    <td>
                         <a href='<%# "../Material.aspx?ID="+Eval("MaterialID") %>'>
                             <asp:Label ID="lblMaterName" runat="server"  Text='<%# Eval("MaterialName").ToString().Length>9?Eval("MaterialName").ToString().Substring(0,8)+"..":Eval("MaterialName") %>'>'></asp:Label>
                        </a>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMaterPrice" runat="server" Text='<%# Eval("MaterialPrice","{0:C}") %>'>'></asp:Label>
                        
                    </td>
                </tr>
            </table>
        </ItemTemplate>
        </asp:DataList>
    <%--<asp:Repeater ID="ReMater" runat="server" OnItemCommand="ReMater_ItemCommand">
        <ItemTemplate>
            <table style="padding:5px; width:100%; background-color:#00ffff;">
                <tr>
                    <td rowspan="6" style="width:110px;">
                         <a href='<%# "Material.aspx?ID="+Eval("MaterialID") %>'>
                             <asp:Image ID="imageMater" Width="140" Height="140" ImageUrl='<%# Eval ("ImageURL")%>' runat="server" /></a>
                    </td>
                     <td style="text-align: left;">
                        材料名称：  <a href='<%# "../Material.aspx?ID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a></td>
                </tr>
             
                <tr>
                    <td style="text-align: left;">
                        材料价格：<%# Eval("MaterialPrice","{0:C}") %></td>
                </tr>
             
                <tr>
                    <td style="text-align: left;">
                        产地：<%# Eval("Origin") %></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        品牌：<%# Eval("Brand") %></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        型号：<%# Eval("Model") %></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        风格：<%# Eval("Style") %></td>
                    
                <td style="text-align:right;">
                    
<%--                    <asp:Button ID="Button2" Height="30" Width="60" Font-Size="15" BackColor="#ff6600"   runat="server" CommandName='<%# Eval("MaterialID") %>' Text="添加" />--%>
             <%--       </td>
                </tr>
             
                </tr>
            </table>
        </ItemTemplate>
        <AlternatingItemTemplate>--%>
            <%--<table style="padding:5px; width:100%; background-color:#00ffff;">
                <tr>
                    <td rowspan="6" style="width:110px;">
                         <a href='<%# "Material.aspx?ID="+Eval("MaterialID") %>'>
                             <asp:Image ID="imageMater" Width="140" Height="140" ImageUrl='<%# Eval ("ImageURL")%>' runat="server" /></a>
                    </td>
                     <td style="text-align: left;">
                        材料名称：  <a href='<%# "../Material.aspx?ID="+Eval("MaterialID") %>'><%# Eval("MaterialName") %></a></td>
                </tr>
            
                <tr>
                    <td style="text-align: left;">
                        材料价格：<%# Eval("MaterialPrice","{0:C}") %></td>
                </tr>
      
                <tr>
                    <td style="text-align: left;">
                        产地：<%# Eval("Origin") %></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        品牌：<%# Eval("Brand") %></td>
                </tr>
                <tr>
                    <td style="text-align: left;">
                        型号：<%# Eval("Model") %></td>
                
                    <tr>
                    <td style="text-align: left;">
                        风格：<%# Eval("Style") %></td>
            
                    
                <td style="text-align:right;">
                    
<%--                    <asp:Button ID="Button2" Height="30" Width="60" Font-Size="15" BackColor="#ff6600"  runat="server" CommandName='<%# Eval("MaterialID") %>' Text="添加"  />--%>
             <%--       </td>
                </tr>
            </table>
        </AlternatingItemTemplate>
        <SeparatorTemplate>
            <hr />
        </SeparatorTemplate>
    </asp:Repeater>--%>
        <div style="margin:0 auto;width:245px">
            <asp:Button ID="bthPre" runat="server" Text="上一页"  OnClick="bthPre_Click" Width="72px" Height="30px" />
            <asp:Label ID="lblMsg" runat="server" Text="" Height="30px"></asp:Label>
            <asp:Button ID="bthNext" runat="server" Text="下一页" OnClick="bthNext_Click" Width="72px" Height="30px" />
        </div>
    </form>
</body>
</html>
