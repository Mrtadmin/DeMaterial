using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeMaterial
{
    public partial class MaterLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Request.Cookies.Count > 0) && (Request.Cookies["LoginName"] != null))
                    txtUid.Text = Request.Cookies["LoginName"].Value as string;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.MaterUser materuser = new BLL.MaterUserbll().Login(txtUid.Text.Trim().ToLower(), txtPwd.Text);

            if (string.IsNullOrEmpty(materuser.UserAccout))
            {
                lblMsg.Text = "你的密码不正确,请呼叫机主";
            }
            else
            {
                new BLL.MaterUserbll().UpdateMaterUser(new Model.MaterUser { UserID = materuser.UserID, UserBirthday = DateTime.Now });

                //保存用户登录状态
                Session["MaterUser"] = materuser;
                //创建购物车
                Session["ShoppCar"] = new List<Model.ShoppCar>();
                Response.Redirect("MaterDefault.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("MaterDefault.aspx");
        }
    }
}