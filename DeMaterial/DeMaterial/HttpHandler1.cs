using System;
using System.Web;
using System.IO;
using System.Drawing;
namespace DeMaterial
{
    public class HttpHandler1 : IHttpHandler
    {
        /// <summary>
        /// 您将需要在网站的 Web.config 文件中配置此处理程序 
        /// 并向 IIS 注册它，然后才能使用它。有关详细信息，
        /// 请参见下面的链接: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // 如果无法为其他请求重用托管处理程序，则返回 false。
            // 如果按请求保留某些状态信息，则通常这将为 false。
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //在此处写入您的处理程序实现。
            string path = context.Server.MapPath(context.Request.Params["MaterialID"]);
            if (File.Exists(path))
            {
                Image image = Image.FromFile(path);
                Graphics gs = Graphics.FromImage(image);
                SolidBrush brush = new SolidBrush(Color.Red);
                gs.DrawString("材料淘购网", new Font("方正舒体", 15f), brush, 30, 30);
                context.Request.ContentType = "image/jpeg";
                image.Save(context.Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                context.Response.End();
            }
        }
     
        #endregion
    }
}
