using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DetailsForm : Form
    {
        public DetailsForm(Product[] products)
        {
            InitializeComponent();
            ProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductsDataGridView.DataSource = products;
        }
    }
}
