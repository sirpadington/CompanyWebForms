using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebForms
{
    public partial class _Default : Page
    {
        private CompanyService.CompanyServiceClient companyService = new CompanyService.CompanyServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var companies = companyService.GetAllCompanies();
            mainListRepeater.DataSource = companies;
            mainListRepeater.DataBind();
        }
    }
}