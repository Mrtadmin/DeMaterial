using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
     public class ParteType
    {
         public List<Model.PartsType> GetPartsType()
         {
             return new DAL.PartsTypedll().GetPartsType();
         }
    }
}
