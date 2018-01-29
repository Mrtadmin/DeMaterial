using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MaterTypebll
    {
        public List<Model.Material> GetMater(int MaterialID = 0, int page = 0)
        {
            string where = "";
            if (MaterialID > 0)
                where += " and [MaterialID]=" + MaterialID;
            return new DAL.Materialdal().Getmaterial(where, (page + 1) * 10, (page + 2) * 10);
        }
        public Model.Material GetMAteri(string id)
        {
            return new DAL.Materialdal().Getmaterial(" and [MaterialID]='" + id + "'")[0];
        }
        public string DeleteMater(int id)
        {
            return "";
        }
    }
}
