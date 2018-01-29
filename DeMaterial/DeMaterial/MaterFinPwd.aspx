<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterFinPwd.aspx.cs" Inherits="DeMaterial.MaterFinPwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
    <style type="text/css">
        body{
            background-image:url('../Image/3D立体墙纸蒲公英无缝墙布.jpg');
            background-repeat:no-repeat;
            background-size:cover;
        }
        #d{
            margin:auto;
            text-align:center;
            width:366px;
            height:357px;
        }
        input{
            font-size:20px;
            margin-top:15px;
        }
        #upleft{
            float:left;
        }
        #upright{
            float:right;
        }
        #down{
            background:#ffffff;
            width:343px;
            height:354px;
        }
        .title{
            font-size:22px;
            color:#ff6c00;
        }
        .auto-style1{
            width:235px;
            height:59px;
            background-image:url('../Image/120212.jpg');
            text-align:center;
            margin:0 auto;
        }
        .auto-style2 input{
            background-color:orangered;
        }
        #linkOn{
            float:right;
        }
        .login-title{
            height:18px;
            line-height:18px;
            font-size:16px;
            color:#3c3c3c;
            margin-top:9px;
            padding-bottom:8px;
            font-weight:700;
            text-align:left;
        }
        .Pwds{
            background-image:url('../Iamge/123.jpg');
        }
        .auto-style1{
            width:235px;
            height:59px;
            background-image:url('../Image/120212.jpg');
            text-align:center;
            margin:0 auto;
        }
        .tcaptche-trigger{
            font-size:14px;
            height:16px;
            position:absolute;
            left:57px;
            line-height:16px;
            top:50%;
            margin-top:8px;
            color:#000;
        }
    </style>
   <script language="JavaScript">
       function pwd() {
           var img = document.getElementById("pwds");
           if (img == "") {
               document.getElementById("pwdoss").innerHTML = "电话号码不能为空";
           }
       }
       function GD2() {
           document.getElementById("img").src = "../GD2Code/getGD2.php?" + Math.random();
       }
   </script>
<body>
    <div class="Pwds" style="border:solid 1px rgba(242,235,235,0.00); width:300px; height:103px; background-image:url('../Image/123.jpg')">
    </div>
    <div style="color:#808080; width:500px; height:400px; background:#eee8e8; text-align:center;overflow:hidden; margin:0 auto;">
        <br /><br />
    
    <form runat="server" >
        <p class="auto-style1"  style="background-image:url('Image/123456.jpg')">
            <span style="background-position:center;  font-size:x-large; font-family: 方正兰亭超细黑简体; background-image: url('Image/123456.jpg'); background-repeat: no-repeat;"></span>
        </p>
        <p style="width: 493px">
            <tr>
            <td class="auto-style1">&nbsp;&nbsp; <asp:TextBox ID="txtUid" Width="240px"  runat="server" placeholder="账号" type="text"></asp:TextBox>
				
			</td>
        </tr>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUid" ErrorMessage="请输入您的账号！">*</asp:RequiredFieldValidator>
        </p>
       <p style="width: 492px">
           <tr>
		<td class="auto-style1">&nbsp;&nbsp;<asp:TextBox ID="txtPwd" Width="240px"  runat="server" placeholder="密码" type="password"></asp:TextBox>
           </td>
	   </tr>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="请输入您的密码！">*</asp:RequiredFieldValidator>
        </p>
        <p style="text-align:center;">
            <asp:Button ID="btnLogin" Width="240px" BackColor="#eee8e8"  runat="server" Text="提交" OnClick="btnLogin_Click" />
        </p>
        <p>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Text="" />
            <asp:ValidationSummary ID="ValidationSummary1" HeaderText="发现以下错误：" ShowMessageBox="true"  ShowSummary="false" runat="server" />
            </form>
        </div>
</body>
     
</html>
