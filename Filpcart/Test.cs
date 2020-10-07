using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filpcart
{
    public class Test:Base
    {
     

        [Test, Order(1)]
        public void LoginTest()
        {
            Class1  objectFC = new Class1(driver);
            objectFC.FlipkartLogin();
        }
        [Test, Order(2)]
        public void Home()
        {
            Class1 objectFC = new Class1(driver);
            objectFC.SearchProduct();
        }
    }
}
