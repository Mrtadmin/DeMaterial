using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;
namespace DAL
{
    public class Commentsdal
    {
        public List<Model.Comments> GetComment(string where = null)
        {
            List<Model.Comments> comment = new List<Comments>();
            if (SQLHelp.OpenConnection())
            {
                SqlDataReader dr = SQLHelp.ExecReader("select * from [Comments] where [Sate]=0" + where);
                if (dr != null)
                {
                    while (dr.Read())
                    {
                        comment.Add(new Comments()
                            {
                                CommentsID = (int)dr["CommentsID"],
                                content = dr["content"].ToString(),
                                MaterialID = (int)dr["MaterialID"],
                                UserID = (int)dr["UserID"],
                                CommentTime = (DateTime)dr["CommentTime"],
                                praise = (int)dr["praise"],
                                Step = (int)dr["Step"],
                                State = (int)dr["Sate"],
                            });
                    }
                    dr.Close();
                    SQLHelp.CloseConnection();
                }
            }
            return comment;
        }
        public int InsertComments(Model.Comments Comm)
        {
            return SQLHelp.ExecQuery("insert into [content],[MaterialID],[UserID],[CommentTime],[praise],[Step],[Sate]) values('" + Comm.content + "','" + Comm.MaterialID + "','" + Comm.UserID + "','" + Comm.CommentTime + "','" + Comm.praise + "','" + Comm.Step + "','" + Comm.State + "',0)");
        }
    }
}
