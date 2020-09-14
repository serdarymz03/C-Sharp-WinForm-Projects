using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProjects_4_Basket
{
    public partial class Form1 : Form
    {
        List<Product> products;
        double total;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = new List<Product>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            products.Add(new Product(TxtName.Text, CmbCategory.Text, Convert.ToDouble(TxtPrice.Text)));
            ProductList();
        }

        void ProductList()
        {
            total = 0;
            DtgBasket.Rows.Clear();
            foreach (Product item in products)
            {
                DtgBasket.Rows.Add();
                int lastRow = DtgBasket.RowCount - 1;
                DtgBasket.Rows[lastRow].Cells["Product_Name"].Value = item.Name;
                //DtgBasket.Rows[lastRow].Cells["Product_Category"].Value = item.Category;
                DtgBasket.Rows[lastRow].Cells["Product_Price"].Value = item.Price;
                total += item.Price;
                DtgBasket.Rows[lastRow].Cells["Total_"].Value = total;
            }
        }
    }
    class Product
    {
        string name, category; double price;

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public double Price { get => price; set => price = value; }

        public Product(string name, string category, double price)
        {
            this.name = name;
            this.category = category;
            this.price = price;
        }
    }
}
