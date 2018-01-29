using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace Model
{
    //用户信息类
    public class MaterUser
    {
        //public MaterUser() { }

        //public MaterUser(string userid, string username, string useraccout, string password, DateTime userBirthday, string userGender, string address, string userRemark, int state)
        //{
        //    this.UserID = userid;
        //    this.UserName = username;
        //    this.UserAccout = useraccout;
        //    this.Password = password;
        //    this.UserBirthday = userBirthday;
        //    this.UserGender = userGender;
        //    this.Address = address;
        //    this.UserRemark = userRemark;
        //}
        public string  UserID { get; set; }   //主键ID
        public string UserName { get; set; }  //用户名称
        public string UserAccout { get; set; } //账号
        public string Password { get; set; }  //密码
        public DateTime UserBirthday { get; set; } //出生日期
        public string UserGender { get; set; }  //性别
        public string Address { get; set; }   //籍贯
        public string UserRemark { get; set; }  //自我描述
        public int State { get; set; }  //状态

    }
}
