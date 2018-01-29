using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DeMaterial
{
    public partial class MaterShoppCar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                MaterShow();
        }
        protected void MaterShow()
        {
            List <Model.ShoppCar > list= (List<Model.ShoppCar>)Session["ShoppCar"];
            List<Model.Material> materialList=new List<Model.Material>();
            foreach (Model.ShoppCar item in list)
            {
                materialList.Add(new BLL.Materialbll().GetMaterial("and MaterialID='" + item.MaterialID.ToString()+ "'")[0]);
            }

            dgdShoppCar.DataSource = materialList ;
            dgdShoppCar.DataBind();

            decimal mater = 0;

            foreach (Model.ShoppCar s in (List<Model.ShoppCar>)Session["ShoppCar"])
                mater += s.MaterialNumCar * s.MaterialID;
                
            
        }
    }
}