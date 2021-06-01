﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using NewDataAccess;
using NewModel;

namespace NewService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    
    public class NewService : IEmployeeInfoService
    {
        public DataSet GetEmployeesUsingDBWithConfig()
        {
            return DataAccessEmployee.GetEmployeesUsingDBWithConfig();
        }

        //public DataSet GetEmployeesUsingDBWithOutConfig()
        //{
        //    return DataAccessEmployee.GetEmployeesUsingDBWithOutConfig();
        //}
    }
}
