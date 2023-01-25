using System;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace SeleniumWebdriver{

    class ExtentReportsHelper{
        public static ExtentHtmlReporter? htmlreport;
        public static AventStack.ExtentReports.ExtentReports? extent ;
        public static void createNewReport(){
            htmlreport =  new ExtentHtmlReporter(CommonHooks.basePath+"\\Test Reports\\");
            extent = new AventStack.ExtentReports.ExtentReports();
            
        }
        public static void logReport(string specflowContext){
           if (extent is not null) 
           {extent.AttachReporter(htmlreport);
            
            var feature = extent.CreateTest(specflowContext);
           }
        }
        public static void endReport(){
            if (extent is not null) extent.Flush();
        }
        
    }
}