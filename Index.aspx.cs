using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarSales.Model;

namespace CarSales
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        protected void LoadData()
        {
            DbConnection con = new DbConnection();
            DataTable dt = con.LoadDb();
            GvTable.DataSource = dt;
            GvTable.DataBind();
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            DbConnection con = new DbConnection();
            CarProperty car = new CarProperty();
            car.CarModel = txtCarModel.Text;
            car.Category = txtCategory.Text;
            car.Price = Convert.ToInt32(txtPrice.Text);
            car.YearOfModel = Convert.ToInt32(DDYearOfModel.SelectedValue);
            car.Description = txtDescription.Text;

            string msg = con.SaveDb(car);
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            DbConnection con = new DbConnection();
            CarProperty car = new CarProperty();
            car.CarModel = txtCarModel.Text;
            car.Category = txtCategory.Text;
            car.Price = Convert.ToInt32(txtPrice.Text);
            car.YearOfModel = Convert.ToInt32(DDYearOfModel.SelectedValue);
            car.Description = txtDescription.Text;

            string msg = con.UpdateDb(car);
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DbConnection con = new DbConnection();
            CarProperty car = new CarProperty();
            car.CarModel = txtCarModel.Text;
           
            string msg = con.DeleteDb(car);
            Response.Write($"<script>alert('{msg}')</script>");
            LoadData();
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtCarModel.Text = "";
            txtCategory.Text = "";
            txtDescription.Text = "";
            txtPrice.Text = "";
        }
    }
}