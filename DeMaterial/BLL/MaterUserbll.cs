using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MaterUserbll
    {
        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <param name="pageNumber"></param>
        /// <returns>用户信息集合</returns>
        public List<Model.MaterUser> GetMaterUser(int pageNumber = 0)
        {
            return new DAL.MaterUserdal().user("", (pageNumber * 10 + 1), (pageNumber * 10 + 10));
        }
        /// <summary>
        /// 获取用户的数量
        /// </summary>
        /// <returns>用户的数量</returns>
        public int GetMater()
        {
            return new DAL.MaterUserdal().GetMater();
        }
        /// <summary>
        /// 根据用户编号获取用户的信息
        /// </summary>
        /// <param name="id">用户编号</param>
        /// <returns>用户信息</returns>
        public Model.MaterUser GetMaterial(string id)
        {
            return new DAL.MaterUserdal().user(" and[UserID]='" + id + "'")[0];
        }
        /// <summary>
        /// 找回用户登录密码
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <param name="answer">答案</param>
        /// <returns>操作结果</returns>
        public Model.MaterUser MaterPassword(string loginName, string answer = null)
        {
            Model.MaterUser materuser = new Model.MaterUser();
            List<Model.MaterUser> mater = new DAL.MaterUserdal().user(" and LoginName='" + loginName + "'");

            if (mater.Count == 0)
            {
                materuser.UserName = "账号不存在！";
                return materuser;
            }
            if (answer != null)
            {
                if (mater[0].Password != answer)
                    materuser.UserName = "答案错误！";
                else
                {
                    if (new DAL.MaterUserdal().UpdateMaterUser(new Model.MaterUser() { UserID = mater[0].UserID, Password = Encryption("12345") }) > 0)
                    {
                        materuser.UserName = "密码重置成功！";
                        materuser.State = 1;
                    }
                    else
                        materuser.UserName = "密码重置失败！ 请联系管理员或者再次尝试充值！";
                }
                return materuser;
            }
            return mater[0];
        }
        public Model.MaterUser Login(string userid, string userpwd)
        {
            userpwd = Encryption(userpwd);

                if(new Rule.MaterUserRule().TestInsert(userid)){
                    return new Model.MaterUser() { UserID = "", UserName = "用户名错误！" };
                }
                List<Model.MaterUser> mater = new List<Model.MaterUser>();
                mater = new DAL.MaterUserdal().user(" and [UserAccout]='" + userid + "' and [Password]='" + userpwd + "'");

                if (mater.Count != 1)
                {
                    return new Model.MaterUser() { UserID = "", Password = "密码错误！" };
                }
                else
                    return mater[0];
        }
        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="materuser">用户对象</param>
        /// <returns>添加操作结果</returns>
        public int InsertMaterUser(Model.MaterUser materuser)
        {
            if (!new Rule.MaterUserRule().TestInsert(materuser.UserAccout))
                return -3;

            materuser.Password = Encryption(materuser.Password);
            return new DAL.MaterUserdal().InserMaterialUser(materuser);
        }
        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="mater">用户对象</param>
        /// <returns>更新操作结果</returns>
        public string UpdateMaterUser(Model.MaterUser mater)
        {
            if (!string.IsNullOrEmpty(mater.Password))
                mater.Password = Encryption(mater.Password);

            return Option(new DAL.MaterUserdal().UpdateMaterUser(mater), "更新");
        }

        private string Option(int count, string type)
        {
            switch (count)
            {
                case-2:
                    return "数据库连接异常！ 请检查你的数据库或者联系管理员！";
                case-1:
                    return "数据操作异常！ 请检查你的数据或者联系管理员！";
                case 0:
                    return "没有"+type+"任何数据";
                default:
                    return "成功" + type + count.ToString() + "条数据！";
            }
        }
        /// <summary>
        /// 对密码进行MD5加密
        /// </summary>
        /// <param name="pwd"></param>
        /// <returns></returns>
        private string Encryption(string pwd)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(pwd);
            bytes = md5.ComputeHash(bytes);
            return BitConverter.ToString(bytes);
        }
    }
}
