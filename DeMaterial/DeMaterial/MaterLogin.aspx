<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaterLogin.aspx.cs" Inherits="DeMaterial.MaterLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
    <style type="text/css">
		body{
			background-image: url("../Image/3D立体墙纸蒲公英无缝墙布.jpg");
			background-repeat: no-repeat;
			background-size: cover;
            
		}
		#d{
			margin: auto;
			text-align: center;
			width: 363px;
			height: 357px;
		}
		input{
			font-size: 20px;
			margin-top: 15px;
            
		}
		#upleft{
			float: left;
		}
		#upright{
			float:right;
		}
		#down{
			background:#ffffff;
			width: 343px;
			height:354px;
			float: left;
        }
        .title{
            font-size:22px;
            color:#ff6c00;
        }
        
      
	    .auto-style1 {
            width: 235px;
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
       .Link{
           background-image:url('../Image/123.jpg');
       }
	</style>
    
	<script language="JavaScript">
	    function cbk() {
	        var inp = document.getElementById("mob");
	        if (inp == "") {
	            document.getElementById("showmob").innerHTML = "电话号码不能为空！";
	        }
	    }
	    function GD2() {
	        document.getElementById("img").src = "../GD2Code/getGD2.php?" + Math.random();;
	    }


	</script>
	<body >
        <div class="Link" style="border:solid 1px rgba(242, 235, 235, 0.00); width:300px; height:103px; background-image:url('../Image/123.jpg')">
        </div>
        <div  style="color:#808080; width:550px;height:400px; background:#eee8e8; text-align:center;overflow:hidden;margin:0 auto;">
             <br /><br />
            
        <form runat="server" >
        <p class="auto-style1"  style="background-image:url('Image/123456.jpg')">
            <span style="background-position:center;  font-size:x-large; font-family: 方正兰亭超细黑简体; background-image: url('Image/123456.jpg'); background-repeat: no-repeat;"></span>
        </p>
        <p style="width: 640px">
            <tr>
            <td class="auto-style1">&nbsp;&nbsp; <asp:TextBox ID="txtUid" Width="240px" Text="zhang"   runat="server" placeholder="账号" type="text"></asp:TextBox>
				
			</td>
        </tr>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUid"  ErrorMessage="请输入您的账号！">*</asp:RequiredFieldValidator>
            &nbsp;<asp:HyperLink ID="hylRegist" NavigateUrl="~/MaterPassword.aspx" runat="server">用户注册></asp:HyperLink>
        </p>
        <p style="width: 640px">
           <tr>
		<td class="auto-style1">&nbsp;&nbsp;<asp:TextBox ID="txtPwd" Width="240px" Text="123" runat="server" placeholder="密码" type="password"></asp:TextBox>
           </td>
	   </tr>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd" ErrorMessage="请输入您的密码！">*</asp:RequiredFieldValidator>
            &nbsp;<asp:HyperLink ID="hylFindPwd" NavigateUrl="~/MaterFinPwd.aspx" runat="server">找回密码></asp:HyperLink>
        </p>
        <p style="text-align:center;">
            <asp:Button ID="btnLogin" Width="240px" BackColor="#eee8e8"  runat="server" Text="登录" OnClick="btnLogin_Click" />
        </p>
        <p>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red" Text="" />
            <asp:ValidationSummary ID="ValidationSummary1" HeaderText="发现以下错误：" ShowMessageBox="true"  ShowSummary="false" runat="server" />
            </form>
        </div>
    
        
</body>
    </html>

