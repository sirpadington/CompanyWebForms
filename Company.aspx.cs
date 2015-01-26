using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebForms
{
    public partial class Company1 : System.Web.UI.Page
    {
        private CompanyService.CompanyServiceClient companyService = new CompanyService.CompanyServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int companyId;
            Int32.TryParse(Request.QueryString["Id"], out companyId);

            var employees = companyService.GetEmployeesForACompany(companyId);
            companyListRepeater.DataSource = employees;
            companyListRepeater.DataBind();

        }
    }
}