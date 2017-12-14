using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JNTUUniModelBinding.Models;
using System.Web.ModelBinding;
using System.Data.Entity;

namespace JNTUUniModelBinding
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //public IQueryable<Enrollment> coursesGrid_GetData([QueryString] int? studentID)
        //{
        //    SchoolContext db = new SchoolContext();
        //    var query = db.Enrollments.Include(e => e.Course)
        //        .Where(e => e.StudentID == studentID);
        //    return query;
        //}

        protected void btnGoBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Students");
        }
        protected void coursesGrid_CallingDataMethods(object sender, CallingDataMethodsEventArgs e)
        {
            e.DataMethodsObject = new JNTUUniModelBinding.BLL.SchoolBL();
        }
       
    }
}