using NewDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using NewModel;

namespace NewBusiness
{
    public class NewBusinessClass
    {
        public static List<EmployeeInformation> EmployeeInformation()
        {
            
            var IndivDemoList = new List<EmployeeInformation>();


            //2rd Assignment
            //Get the Employee List from database but get the connection string details from web.Config file
            DataSet dsGetReport = new DataSet();
            dsGetReport = DataAccessEmployee.GetEmployeesUsingDBWithConfig();
            //Get the Employee List from database but get the connection string details without web.Config file
            //dsGetReport = DataAccessEmployee.GetEmployeesUsingDBWithOutConfig(); 

            //3rd Assignment
            //Calling web service - Get the Employee List from database but get the connection string details from web.Config file
            //var testService = new NewService.MyServiceClient();
            //dsGetReport = testService.GetEmployeesUsingDBWithConfig();

            //------------------------------------------------------------------------------------------
            //Get the Employee List from database but define the connection string in this method
            //dsGetReport = NewDataAccess.GetEmployeesUsingDBWithOutConfig();
            //dsGetReport = testService.GetEmployeesUsingDBWithOutConfig();

            //var testServ = new DemoInformationService.DemoInformationServiceClient();
            //Get the Employee List data by NOT USING the database
            //dsGetReport = NewDataAccess.GetEmployeesWithOutDB();
            //dsGetReport = testService.GetEmployeesWithOutDB();
            //------------------------------------------------------------------------------------------

            //Transfer Dataset details to List Object
            if (dsGetReport.Tables.Count > 0)
            {
                IndivDemoList = dsGetReport.Tables[0].AsEnumerable().Select(m =>
                {
                    EmployeeInformation employeeInformation = new EmployeeInformation
                    {
                        //Left side is Model Object - Right Side is Database columns
                        FirstName = Convert.ToString(m["first_name"]),
                        LastName = Convert.ToString(m["last_name"]),
                        Sex = Convert.ToString(m["gender"]),
                        //Address = Convert.ToString(m["Address"]),
                        Emp_no = Convert.ToInt32(m["emp_no"]),
                        Hire_date = Convert.ToString(m["hire_date"])
                    };
                    return employeeInformation;
                }).ToList();

            }

            //Build the Business Logic here based on the requirements from the client

            return IndivDemoList;

        }
    }
}
