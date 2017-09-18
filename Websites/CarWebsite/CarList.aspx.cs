using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarEntityModel;

public partial class CarList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarsInfoEntities db = new CarsInfoEntities();

        var result = from t in db.Cars
                      join x in db.Brands on t.BrandId equals x.BrandId
                      select new { x.BrandName,t.Model,t.Costs };

        GridView1.DataSource = result;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Server.Transfer("CarEdit.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CarsInfoEntities db = new CarsInfoEntities();

        var result = from t in db.Cars
                     join x in db.Brands on t.BrandId equals x.BrandId
                     where t.Model == txtModel.Text
                     select new { x.BrandName, t.Model, t.Costs };
        GridView1.Visible = false;
        GridView2.DataSource = result;
        GridView2.DataBind();
    }
    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {
        String index = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
        CarsInfoEntities db = new CarsInfoEntities();
        var data =
            (from c in db.Cars
            where c.Model== index
            select new {c.BrandId}).ToList();
        String id = data.ElementAt(0).BrandId.ToString();
       Server.Transfer("CarEdit.aspx?index=" + index + "&id="+id);
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        String s = GridView1.DataKeys[e.RowIndex].Value.ToString();
        CarsInfoEntities db = new CarsInfoEntities();
        Car c = db.Cars.FirstOrDefault(m => m.Model == s);
        db.DeleteObject(c);
        db.SaveChanges();
        ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Record has been deleted successfully')</script>");

        var result = from t in db.Cars
                     join x in db.Brands on t.BrandId equals x.BrandId
                     select new { x.BrandName, t.Model, t.Costs };

        GridView1.DataSource = result;
        GridView1.DataBind();
    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.Visible = false;
        String index = GridView2.DataKeys[e.NewEditIndex].Value.ToString();
        CarsInfoEntities db = new CarsInfoEntities();
        var data =
            (from c in db.Cars
             where c.Model == index
             select new { c.BrandId }).ToList();
        String id = data.ElementAt(0).BrandId.ToString();
        Server.Transfer("CarEdit.aspx?index=" + index + "&id=" + id);
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        GridView1.Visible = false;
        String s = GridView2.DataKeys[e.RowIndex].Value.ToString();
        CarsInfoEntities db = new CarsInfoEntities();
        Car c = db.Cars.FirstOrDefault(m => m.Model == s);
        db.DeleteObject(c);
        db.SaveChanges();
        ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Record has been deleted successfully')</script>");

        var result = from t in db.Cars
                     join x in db.Brands on t.BrandId equals x.BrandId
                     select new { x.BrandName, t.Model, t.Costs };
        GridView1.Visible = true;
        GridView2.Visible = false;
        GridView1.DataSource = result;
        GridView1.DataBind();
    }
}