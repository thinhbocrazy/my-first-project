using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCafe.DTO
{
    class BillInfo
    {
        public BillInfo(int id, int billID, int foodID, int count)
        {
            iD = id;
            BillID = billID;
            FoodID = FoodID;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            iD = (int)row["id"];
            BillID = (int)row["idbill"];
            FoodID = (int)row["idfood"];
            this.Count = (int)row["count"];
        }

        private int count;

        private int foodID;

        private int billID;

        private int iD;

        public int ID { get => iD; set => iD = value; }
        public int BillID { get => billID; set => billID = value; }
        public int FoodID { get => foodID; set => foodID = value; }
        public int Count { get => count; set => count = value; }

    }
}
