using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeMaterial
{
    public partial class MaterPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

        protected void buRepwd_Click(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {


        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Model.MaterUser mater = new Model.MaterUser();
            mater.UserName = txtName.Text.Trim();
            mater.UserAccout = txtUid.Text.Trim().ToLower();
            mater.Password = txtPwd.Text;
            mater.Password = txtRepwd.Text;
            int count = new BLL.MaterUserbll().InsertMaterUser(mater);
            switch (count)
            {
                case -3:
                    lblMsg.Text = "你的账号已经存在！<br/>请重新选择！";
                    break;
                case -2:
                    lblMsg.Text = "数据库连接失败！<br/>请检查你的数据库或者联系管理员！";
                    break;
                case -1:
                    lblMsg.Text = "数据库操作失败！<br/>请检查你输入的数据或者联系管理员！";
                    break;
                case 0:
                    lblMsg.Text = "注册失败！<br/>请检查你的输入的数据！";
                    break;
                default:
                    Session["MaterUser"] = mater;
                    Session["ShoppCar"] = new List<Model.ShoppCar>();
                    lblMsg.Text = "注册成功！";
                    break;

            }
        }
    }
}
