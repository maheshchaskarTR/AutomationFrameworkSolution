﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace source.MedicalRecordAutomation.Utilities
{
    public class DataSource
    {
        /// <summary>
        /// Testdata for ValidLoginTest
        /// </summary>
        /// <returns></returns>
        public static object[] ValidLoginData()
        {
            //testcase1
            //siza- no. of argument
            string[] dataset1 = new string[3];
            dataset1[0] = "admin";
            dataset1[1] = "pass";
            dataset1[2] = "OpenEMR";

            string[] dataset2 = new string[3];
            dataset2[0] = "accountant";
            dataset2[1] = "accountant";
            dataset2[3] = "OpenEMR";

            object[] finalData = new object[2];
            finalData[0] = dataset1;
            finalData[1] = dataset2;

            return finalData;
        }
    }
}
