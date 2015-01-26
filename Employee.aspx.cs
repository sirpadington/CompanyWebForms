using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyWebForms
{
    public partial class Employee : System.Web.UI.Page
    {
        private CompanyService.CompanyServiceClient companyService = new CompanyService.CompanyServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            int employeeId;
            Int32.TryParse(Request.QueryString["Id"], out employeeId);

            var employee = companyService.GetEmployee(employeeId);
            firstName.Text = employee.FirstName;
            lastName.Text = employee.LastName;
            birthDate.Text = employee.Birthday.ToString();
        }
    }
}