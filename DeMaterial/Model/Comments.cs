using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户评论类
    public class Comments
    {
        public Comments() { }
        public Comments(int commentsID, string content, int materialID, int userID, DateTime commenttime, int praise, int step, int state)
        {
            this.CommentsID = commentsID;
            this.content = content;
            this.MaterialID = materialID;
            this.UserID = userID;
            this.CommentTime = commenttime;
            this.praise = praise;
            this.Step = step;
            this.State = state;
        }
        public int CommentsID { get; set; }  //主键ID
        public string content { get; set; }  //内容
        public int MaterialID { get; set; }  //所属材料
        public int UserID { get; set; }    //所属用户
        public DateTime CommentTime { get; set; }  //时间
        public int praise { get; set; }   //赞
        public int Step { get; set; }  //踩
        public int State { get; set; }  //状态
    }
}
