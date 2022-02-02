using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace CarSales.Model
{
    public class DbConnection
    {
        string ConnectionString = "Data Source=100.72.130.5;Initial Catalog=Training;Persist Security Info=True;User ID=TrainingUsr;Password=Tr@ininGU$r@#321";

        public string SaveDb(CarProperty car)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SkCarSale values('" + car.CarModel + "','" + car.Category + "'," + car.Price + "," + car.YearOfModel + ",'" + car.Description + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Saved Successfully";
        }

        public string UpdateDb(CarProperty car)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("update SkCarSale set Category='"+car.Category+"', Price= "+car.Price+" , YeatOfModel="+car.YearOfModel+" ,Description = '"+car.Description+"' where CarModel = '"+car.CarModel+"'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Updated Successfully";
        }

        public string DeleteDb(CarProperty car)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand($"Delete from SkCarSale where CarModel = '{car.CarModel}'",con);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Deleted Successfully";
        }

        public DataTable LoadDb()
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from SkCarSale", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}