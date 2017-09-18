using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarEntityModel;

public partial class CarEdit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack==false)
        {
            CarsInfoEntities db = new CarsInfoEntities();
            String index = Request.QueryString["index"];
            String id = Request.QueryString["id"];
            ddlBrand.SelectedValue = id;
            Car c = db.Cars.FirstOrDefault(m => m.Model == index);
            txtModel.Text=c.Model;
            txtCosts.Text=Convert.ToString(c.Costs);
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        String index = Request.QueryString["index"];
        String id = Request.QueryString["id"];
        CarsInfoEntities db = new CarsInfoEntities();
        Car c = db.Cars.FirstOrDefault(m => m.Model == index);
        c.Model = txtModel.Text;
        c.BrandId = int.Parse(ddlBrand.SelectedValue);
        c.Costs = int.Parse(txtCosts.Text);
        db.SaveChanges();
        ClientScript.RegisterClientScriptBlock(GetType(), "Javascript", "<script>alert('Car details have been successfully updated')</script>");
    
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("CarList.aspx");
    }
}