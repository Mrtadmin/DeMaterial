using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeMaterial
{
    public partial class Material : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                MaterialShow();
        }
        protected void MaterialShow()
        {
            Model.Material mater = new BLL.Materialsbll().GetMaterials(Request.QueryString["ID"]);

            if (mater != null)
            {
                imageCover.ImageUrl = "~/" + mater.ImageURL;
                lbMaterName.Text = mater.MaterialName;
                lbMaternum.Text = mater.Materialnum.ToString();
                lbMaterPrice.Text = string.Format("{0:C}", mater.MaterialPrice);
                lbOrign.Text = mater.Origin;
                lbBrand.Text = mater.Brand;
                lbModel.Text = mater.Model;
                lbsperication.Text = mater.specifications;
                lbStyle.Text = mater.Style;
                lbLevel.Text = mater.level;
            }
        }

        protected void btRead_Click(object sender, CommandEventArgs e)
        {
            
        }
        protected void btRead_Command(object sender, CommandEventArgs e)
        {
            Model.MaterUser materuser = Session["MaterUser"] as Model.MaterUser;
            if (materuser == null)
            {
                Response.Write("<script>alert('请先登录后再购买图书！');</script>");
                return;
            }
            Model.Material material = new BLL.MaterTypebll().GetMAteri(Request.QueryString["ID"]);
            if (material != null)
            {
                if (((List<Model.ShoppCar>)Session["ShoppCar"]).Count > 0)
                {
                    foreach (Model.ShoppCar s in (List<Model.ShoppCar>)Session["ShoppCar"])
                    {
                        if (s.MaterialID == material.MaterialID)
                        {
                            s.MaterialNumCar += 1;
                            return;
                        }
                    }
                }
                ((List<Model.ShoppCar>)Session["ShoppCar"]).Add(new Model.ShoppCar() { MaterialID = material.MaterialID, MaterialNumCar = 1, });
                List<Model.ShoppCar>modellist=(List<Model.ShoppCar>)Session["ShoppCar"];
                linkShop.Text = "购物车[" + modellist.Count + "]|";
            }
            
        }

        protected void btRead_Click(object sender, EventArgs e)
        {

        }
    }
}