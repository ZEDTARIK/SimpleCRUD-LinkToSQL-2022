using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : DataContext
    {
        public static void addDepartment(Department department)
        {
            try
            {
                db.Departments.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
