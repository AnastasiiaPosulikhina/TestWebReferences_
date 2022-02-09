using System;
using System.Web.Services;

namespace AspNetService
{
    /// <summary>
    /// Simple ASMX Calculator Web Service.	
    /// </summary>
    [WebService(Namespace="http://tempuri.org/")]
    public class CalculatorService : System.Web.Services.WebService
    {        
        [WebMethod]
        public double Add(double n1, double n2)
        {
            return n1 + n2;
        }
        [WebMethod]
        public double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }
        [WebMethod]
        public double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }
        [WebMethod]
        public double Divide(double n1, double n2)
        {
            return n1 / n2;
        }
        [WebMethod]
        public double Sqrt(double n1)
        {
            return Math.Sqrt(n1);
        }
    }
}