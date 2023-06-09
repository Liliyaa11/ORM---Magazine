using ORM___Magazine.Controller;
using ORM___Magazine.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORM___Magazine
{
    public partial class Magazin : Form
    {
        ProductLogic productController = new ProductLogic();
        ProductTypeLogic productTypeController = new ProductTypeLogic();
        public Magazin()
        {
            InitializeComponent();
        }

        private void Magazin_Load(object sender, EventArgs e)
        {
            List<ProductType> allProductTypes = productTypeController.GetAllProductTypes();
            cmbBoxType.DataSource = allProductTypes;
            cmbBoxType.DisplayMember = "Brand";
            cmbBoxType.ValueMember = "Id";

            btnSelectAll_Click(sender, e);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {

        }
    }
}
