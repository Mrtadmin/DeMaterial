using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Materialsbll
    {
        public List<Model.Material> GetMaterials(int MaterialID = 0)
        {
            string where = "";
            if (MaterialID > 0)
                where += " and [MaterialID]=" + MaterialID;

            return new DAL.Materialdal().Getmaterial(where);
        }
        public Model.Material GetMaterials(string id)
        {
            return new DAL.Materialdal().Getmaterial(" and [MaterialID]='" + id + "'")[0];
        }
    }
}
