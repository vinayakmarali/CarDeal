using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarEntityModel;

public partial class BrandList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CarsInfoEntities db = new CarsInfoEntities();
        var result = from a in db.Brands
                   select new {a.BrandName};
        GridView1.DataSource = result;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        CarsInfoEntities db = new CarsInfoEntities();
        var data =
            from c in db.Brands
            where c.BrandName == txtSearch.Text
            select new { c.BrandName };
        GridView1.Visible = false;
        GridView2.DataSource = data;
        GridView2.DataBind();
    }
    protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
    {
            String index = GridView1.DataKeys[e.NewEditIndex].Value.ToString();
            Server.Transfer("BrandEdit.aspx?index=" + index);
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        String s = GridView1.DataKeys[e.RowIndex].Value.ToString();
        CarsInfoEntities db = new CarsInfoEntities();
        Brand br = db.Brands.FirstOrDefault(m => m.BrandName == s);
        db.DeleteObject(br);
        try
        {
            db.SaveChanges();
            
        }
        catch (Exception)
        {
            ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Cannot delete record. Foreign key constraint violated.')</script>");
        }
        
        ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Record has been deleted successfully')</script>");

        var data = from a in db.Brands
                     select new { a.BrandName };
        GridView1.DataSource = data;
        GridView1.DataBind();

    }
    protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
    {
        String index = GridView2.DataKeys[e.NewEditIndex].Value.ToString();
        Server.Transfer("BrandEdit.aspx?index=" + index);
    }
    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        String s = GridView2.DataKeys[e.RowIndex].Value.ToString();
        CarsInfoEntities db = new CarsInfoEntities();
        Brand br = db.Brands.FirstOrDefault(m => m.BrandName == s);
        db.DeleteObject(br);
        db.SaveChanges();
        ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Record has been deleted successfully')</script>");

        var data = from a in db.Brands
                   select new { a.BrandName };
        GridView1.Visible = true;
        GridView2.Visible = false;
        GridView1.DataSource = data;
        GridView1.DataBind();
    }
}