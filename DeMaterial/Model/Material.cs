using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //材料信息类
    public class Material
    {
        public Material() { }

        public Material(int materialid, string materialname, string imageURL, int materialunm, decimal materialPrice, int materialTypeID, string origin, string brand, string model, string specifications, string stype, string level, int partsTypeID, int State)
        {
            this.MaterialID = materialid;
            this.MaterialName = materialname;
            this.ImageURL = imageURL;
            this.Materialnum = materialunm;
            this.MaterialPrice = materialPrice;
            this.MaterialTypeID = materialTypeID;
            this.Origin = origin;
            this.Brand = brand;
            this.Model = model;
            this.specifications = specifications;
            this.Style = stype;
            this.level = level;
            this.PartsTypeID = partsTypeID;
            this.State = State;
        }
        public int MaterialID { get; set; }  //主键ID
        public string MaterialName { get; set; }  //材料名称
        public string ImageURL { get; set; }   //图片路径
        public int Materialnum { get; set; }  //材料数量
        public decimal MaterialPrice { get; set; }  //材料价格
        public int MaterialTypeID { get; set; }  // 标准类型
        public string Origin { get; set; }   //产地
        public string Brand { get; set; }  //品牌
        public string Model { get; set; }  //型号
        public string specifications { get; set; }  //规格
        public string Style { get; set; }   //风格
        public string level { get; set; }  //产品等级
        public int PartsTypeID { get; set; }
        public int State { get; set; }  //状态
    }
}
