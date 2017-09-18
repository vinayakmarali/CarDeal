using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarEntityModel;

public partial class BrandEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack==false)
        {   
        String index = Request.QueryString["index"];
        CarsInfoEntities db = new CarsInfoEntities();
        Brand br = db.Brands.FirstOrDefault(m => m.BrandName == index);
        txtboxBrand.Text=br.BrandName;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String index = Request.QueryString["index"];
        CarsInfoEntities db = new CarsInfoEntities();
        Brand br = db.Brands.FirstOrDefault(m => m.BrandName == index);
        br.BrandName = txtboxBrand.Text;
        db.SaveChanges();
        ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Brand Name has been successfully updated')</script>");
    }
    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Server.Transfer("BrandList.aspx");
    }
}