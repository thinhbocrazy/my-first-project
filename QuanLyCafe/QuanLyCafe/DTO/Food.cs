using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    public class Food
    {
        public Food(int id, string name, int categoryID, float price)
        {

            ID = id;
            Name = name;
            CategoryID = categoryID;
            Price = price;

        }

        public Food(DataRow row)
        {

            ID = (int)row["id"];
            Name = row["name"].ToString();
            CategoryID = (int)row["idcategory"];
            Price = (float)Convert.ToDouble(row["price"].ToString());

        }


        private float price;

        private int categoryID;

        private string name;

        private int iD;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int CategoryID { get => categoryID; set => categoryID = value; }
        public float Price { get => price; set => price = value; }
    }
}
