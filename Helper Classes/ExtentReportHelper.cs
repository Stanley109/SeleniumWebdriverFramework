using System;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace SeleniumWebdriver{

    class ExtentReportsHelper{
        private static ExtentHtmlReporter? _htmlreport;
        private static AventStack.ExtentReports.ExtentReports? _extent ;
        public static void CreateNewReport(){
            _htmlreport =  new ExtentHtmlReporter(Base.basePath+"\\Test Reports\\");
            _extent = new AventStack.ExtentReports.ExtentReports();
            
        }
        public static void LogReport(string specflowContext){
           if (_extent is not null) 
           {_extent.AttachReporter(_htmlreport);
            
            var feature = _extent.CreateTest(specflowContext);
           }
        }
        public static void EndReport(){
            if (_extent is not null) _extent.Flush();
        }
        
    }
}