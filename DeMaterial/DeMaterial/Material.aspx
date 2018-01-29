<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Material.aspx.cs" Inherits="DeMaterial.Material" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style30 {
            height: 20px;
            width: 77px;
        }
        .auto-style31 {
            height: 20px;
            width: 80px;
            text-align:start;
        }
        #h1{
            text-align:left;
        }
       .title{
           float:left;
           padding-top:0px;
           padding-bottom:20px;
           padding-left:0px;
           width:286px;
            padding-right: 20px;
        }
       .rathing{
          
           margin:0;
           padding:0;
           width:100%;

       }
       .auto-style20{
           width:300px;
           height:340px;
       }
        .auto-style32 {
            width: 74px;
        }
        .auto-style33 {
            height: 20px;
            width: 74px;
        }
        .auto-style34 {
            height: 18px;
            width: 74px;
        }
        .auto-style35 {
            height: 9px;
            width: 123px;
        }
        .auto-style36 {
            height: 20px;
            width: 123px;
        }
        .auto-style37 {
            height: 18px;
            width: 123px;
        }
        .auto-style38 {
            height: 9px;
            width: 66px;
        }
        .auto-style39 {
            height: 20px;
            width: 66px;
        }
        .auto-style40 {
            height: 18px;
            width: 66px;
        }
        .auto-style41 {
            height: 9px;
            width: 77px;
        }
        .auto-style42 {
            height: 18px;
            width: 77px;
        }
        .auto-style43 {
            height: 9px;
            width: 49px;
        }
        .auto-style44 {
            height: 20px;
            width: 49px;
        }
        .auto-style45 {
            height: 18px;
            width: 49px;
        }
        .auto-style46 {
            height: 9px;
            width: 80px;
        }
        .auto-style47 {
            height: 18px;
            width: 80px;
        }
        .textLink{
            text-decoration:none;
            border:1px solid #ffffff;
            width: 286px;
            height: 135px;
            margin-top:auto;
            font-family:Arial;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="rathing">
            <div style="text-align:left; width: 300px;  height:340px;float:left;">
                <td colspan="2" class="auto-style20">
                <asp:Image ID="imageCover"  Width="300" Height="340" runat="server"  />
                    </td>
                
            </div>
            
            <table   style="width:797px; padding:5px;  height: 200px; text-align:right; margin-left: 305px;">
        <tr >
        <td style="text-align:right;" class="auto-style32" >名称：
        </td>

            <td style="text-align:left; " class="auto-style35">
                <asp:Label ID="lbMaterName" runat="server" Text=""></asp:Label>
            &nbsp;
            </td>
            <td style="text-align:right; " class="auto-style38">数量：
            </td>
            <td style="text-align:left; " class="auto-style41">
            <asp:Label ID="lbMaternum" runat="server" Text=""></asp:Label>
                </td>
            
            <td style="text-align:right; " class="auto-style43">价格：
        </td>
            <td style="text-align:left; " class="auto-style46">
            <asp:Label ID="lbMaterPrice" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        <tr>
            <td style="text-align:right; " class="auto-style33">产地：
            </td>
            <td style="text-align:left; " class="auto-style36">
                <asp:Label ID="lbOrign" runat="server" Text=""></asp:Label>
            </td>
             <td style="text-align:right; " class="auto-style39">品牌：
            </td>
            <td style="text-align:left; " class="auto-style30">
                <asp:Label ID="lbBrand" runat="server" Text=""></asp:Label>
            </td>
              <td style="text-align:right; " class="auto-style44">型号：
            </td>
            <td style="text-align:left; " class="auto-style31">
                <asp:Label ID="lbModel" runat="server" Text=""></asp:Label>
                </td>
        </tr>
        <tr>
            <td style="text-align:right; " class="auto-style34">规格：
            </td>
            <td style="text-align:left; " class="auto-style37">
                <asp:Label ID="lbsperication" runat="server" Text=""></asp:Label>
                <td style="text-align:right; " class="auto-style40">风格：
            </td>
            <td style="text-align:left; " class="auto-style42">
                <asp:Label ID="lbStyle" runat="server" Text=""></asp:Label>
            </td>
                 <td style="text-align:right; " class="auto-style45">等级：
            </td>
            <td style="text-align:left; " class="auto-style47">
                <asp:Label ID="lbLevel" runat="server" Text=""></asp:Label>
            </td>
            </td>
        </tr>
    </table>
            <div class="textLink">
                <asp:Button ID="btRead" Width="120px" Height="40px" Font-Size="18px" BackColor="#ff5050"  CommandName='<%# Eval("MaterialID") %>' runat="server" Text="加入购物车" OnClick="btRead_Click" OnCommand="btRead_Command" />
                
        <asp:LinkButton id="linkShop" PostBackUrl="~/MaterShoppCar.aspx" Width="120px" Height="40px" Font-Size="15" runat="server" >购物车[0]</asp:LinkButton>
            </div>
            <%--<div style="border:solid 1px white;width:473px; height:39px; font-size:30px; float:left">鑫诺伟天全屋定制现代北欧风橱柜</div>--%>
            <%--<div class="title" style="flex:1;"></div>--%>
        </div>
     
    </form>
</body>
</html>
