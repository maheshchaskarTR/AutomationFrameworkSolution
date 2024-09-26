using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;

namespace MedicalRecordAutomation
{
/// <summary>
/// Will be deleted
/// </summary>
    public class ZDemo1Test
    {

        public static object[] ValidData()
        {
            //testcase1 
            //size - number of arguments
            string[] dataSet1 = new string[2];
            dataSet1[0] = "saul";
            dataSet1[1] = "saul123";

            //testcase1
            string[] dataSet2 = new string[2];
            dataSet2[0] = "peter";
            dataSet2[1] = "peter123";

            //testcase1
            string[] dataSet3 = new string[2];
            dataSet3[0] = "kim";
            dataSet3[1] = "kim123";

            string[] dataSet4 = new string[2];
            dataSet4[0] = "bala";
            dataSet4[1] = "bala123";

            //size - number of test case
            object[] finalData=new object[4];
            finalData[0] = dataSet1;
            finalData[1] = dataSet2;
            finalData[2] = dataSet3;   
            finalData[3] = dataSet4;

            return finalData;
           
        }

        [Test]
        [TestCaseSource(nameof(ValidData))]
        public void ValidTest(string username,string password)
        {
            Console.WriteLine("hello"+username+password);
        }



        //[Test]

        //public void ReadExcelSheet()
        //{
        //    var book = new XLWorkbook(@"C:\Users\6124711\source\repos\AutomationFrameworkSolution\MedicalRecordAutomation\TestData\openemr_data.xlsx");
        //    var sheet= book.Worksheet("ValidLoginTest");
        //    var range = sheet.RangeUsed();

           
        //    for(int r=1;r<=3;r++)
        //    {
        //        for(int c=1;c<=3;c++)
        //        {
        //            string value = range.Cell(r, c).GetString();
        //            Console.WriteLine(value);
        //        }
        //    }

        //    string[] excel1=new string[3];
        //    excel1[0] = "Username";
        //    excel1[1] = "Password";
        //    excel1[2] = "ExpectedTitle";

        //    book.Dispose();
        //}
    }
}
