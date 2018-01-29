using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;
using System.IO;
using System.Data.SqlClient;
using System.Data;
namespace DeMaterial
{
    public partial class MaterDefault : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime time1 = DateTime.Now;
            if (!IsPostBack)
            {
                MaterShow();
                ViewState["pageIndex"] = 1;
                BindRepeater();
                lblRead.Text = "页面中的时间：" + DateTime.Now.ToLongTimeString();
            }
            
                DateTime time2 = DateTime.Now;//页面缓存
            TimeSpan ts = time2.Subtract(time1);
            lblTime.Text="页面加载耗时："+ts.TotalMilliseconds.ToString()+"毫秒";
        }
        
       protected void BindGer()//数据缓存
        {
            BLL.Materialbll Mater = new BLL.Materialbll();
            List<Model.Material> Metial = new List<Model.Material>();
            if (Cache["Material"] == null)
            {
                lblTime.Text = "数据来自缓存";
            }
            Metial = (List<Model.Material>)Cache["Material"];
            dgdDataList.DataSource = Metial;
            dgdDataList.DataBind();
        }
        public void BindRepeater()//分页
        {
            PagedDataSource pd = new PagedDataSource();
            pd.AllowPaging = true;
            pd.PageSize = 30;
            int index = (int)ViewState["pageIndex"];
            //BLL.Materialbll mater = new BLL.Materialbll();
            pd.DataSource = new BLL.Materialbll().GetMaterial();// mater.GetMaterial();
            if (index < 1)
                index = pd.PageCount;
            if (index > pd.PageCount)
                index = 1;
            pd.CurrentPageIndex = index - 1;
            ViewState["index"] = index;
            lblMsg.Text = "第" + (index ) + "页/共" + pd.PageCount + "页";
            dgdDataList.DataSource = pd;
            dgdDataList.DataBind();

        }
        protected void MaterShow(string str=null)
        {
        //    if (!rdofang.Checked)
            
                dgdDataList.Visible = false;
                dgdDataList.Visible = true;
                dgdDataList.DataSource = new BLL.Materialbll().GetMaterial(str);
                dgdDataList.DataBind();
            
            //else
            //{
            //    dgdDataList.Visible = true;
            //    ReMater.Visible = false;
            //    dgdDataList.DataSource = new BLL.Materialbll().GetMaterial(str);
            //    dgdDataList.DataBind();
            //}
        }

      

        protected void rdoliebiao_CheckedChanged(object sender, EventArgs e)
        {
            MaterShow();
        }

        protected void rdofang_CheckedChanged(object sender, EventArgs e)
        {
            MaterShow();
        }

       

        protected void ReMater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            
        }

        protected void bthPre_Click(object sender, EventArgs e)
        {
            ViewState["pageIndex"]=(int)ViewState["pageIndex"]-1;
            BindRepeater();
        }

        protected void bthNext_Click(object sender, EventArgs e)
        {
            ViewState["pageIndex"] = (int)ViewState["pageIndex"] + 1;
            BindRepeater();
        }

        protected void dgdDataList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MaterShow("and MaterialName like '%" + txtENd.Text + "%'");
            
              //MaterShow("select * from Material where MaterialName like'%'+@txtENd+'%'");
            
        }

        protected void dgdDataList_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void BuUloled_Click(object sender, EventArgs e)
        {
            if (fileText.HasFile)
            {
                try
                {
                    //将文件保存在服务器上
                    fileText.SaveAs("E:\\" + fileText.FileName);
                    //显示文件相关的信息
                    lblage.Text = "文件名：" + fileText.PostedFile.FileName + "<br/>" +
                        "文件大小：" + fileText.PostedFile.ContentLength + "<br/>" +
                        "文件类型：" + fileText.PostedFile.ContentType;
                }
                catch (Exception ex)
                {
                    lblage.Text = "异常：" + ex.Message;
                }
            }
                else{
                    lblage.Text="请选择一个文件";
                }
            }
     
        }

       
    }