using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeMaterial
{
    public partial class MaterFinPwd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                lblMsg.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.MaterUser Mateuser = new BLL.MaterUserbll().MaterPassword(txtUid.Text.Trim(), txtPwd.Text);
            lblMsg.Text = Mateuser.UserName;
            if (Mateuser.State == 1)
            {
                lblMsg.Text += "<br/>为了你的账号安全，请立刻使用<strong>初始密码</strong><a href='MaterLogin.aspx'>重新登录</a>系统<br/>并尽快<strong>修改密码</strong>!";
            }
        }
    }
}