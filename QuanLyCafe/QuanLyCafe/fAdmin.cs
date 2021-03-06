﻿using QuanLyCafe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            LoadDateTimePickerBill();

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        void LoadDateTimePickerBill()
        {

            DateTime today = DateTime.Now;

            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);

            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);

        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);

        }

    }
}
