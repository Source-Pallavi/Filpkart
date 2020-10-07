﻿using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Filpcart
{
    public class Class1
    {

        public IWebDriver driver;
        public Class1(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='container']/div/div[3]/div/div[2]/div/form/div[1]/input")]
        public IWebElement phoneNum;

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        public IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']//span[contains(text(),'Login')]")]
        public IWebElement loginButton;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for products, brands and more']")]
        public IWebElement search;
        [FindsBy(How = How.XPath, Using = "//button[@class='vh79eN']//*[local-name()='svg']")]
        public IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]")]
        public IWebElement selectProduct;
        public void FlipkartLogin()
        {
            phoneNum.SendKeys("7869605345");
            Thread.Sleep(2000);
            password.SendKeys("12respect34");
            Thread.Sleep(2000);
            loginButton.Click();
            Thread.Sleep(3000);
        }
        public void SearchProduct()
        {
            search.Click();
            Thread.Sleep(2000);
            search.SendKeys("iphone");
            Thread.Sleep(2000);
            searchButton.Click();
            Thread.Sleep(5000);
            selectProduct.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }

    }
}
