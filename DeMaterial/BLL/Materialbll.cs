using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
namespace BLL
{
    public class Materialbll
    {
        public List<Model.Material> GetMaterial(string whereStr = null)
        {
            return new DAL.Materialdal().Getmaterial(whereStr);
        }
        public int InsertMaterial(Model.Material material)
        {
            if (new Rule.MaterialRule().TestInsert(material.MaterialName))
                return new DAL.Materialdal().InsertMaterial(material);
            else
                return -5;
        }
        public int UpdateMaterial(Model.Material material)
        {
            if (new Rule.MaterialRule().TestUpdate(material.MaterialName, material.MaterialID))
                return new DAL.Materialdal().UpdateMaterial(material);
            else
                return -5;
        }
        public int DeleteMaterial(Model.Material material)
        {
            if (new Rule.MaterialRule().TestDelete(material.MaterialID))
                return new DAL.Materialdal().DeleteMaterial(material.MaterialID.ToString());
            else
                return -5;
        }
        public int DeleteMaterial(int mareialID)
        {
            if (new Rule.MaterialRule().TestDelete(mareialID))
                return new DAL.Materialdal().DeleteMaterial(mareialID.ToString());
            else
                return -5;
        }
        public int DeleteMaterial(string id)
        {
            return new DAL.Materialdal().DeleteMaterial(id);
        }
    }
}
