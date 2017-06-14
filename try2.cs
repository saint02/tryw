using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
        [TestFixture]
    public class Try2
    {

        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://www.salford.ac.uk/";
            verificationErrors = new StringBuilder();
        }
        
        //[TearDown]
       // public void TeardownTest()
        {
            try
            {
                //driver.Quit();
            }
            //catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheTry2Test()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.FindElement(By.LinkText("Applying for Postgraduate study")).Click();
            driver.FindElement(By.LinkText("Applying for a taught course")).Click();
            driver.FindElement(By.LinkText("Apply online here")).Click();
            driver.FindElement(By.LinkText("Create Account")).Click();
            driver.FindElement(By.Id("rdCboTitle_Input")).Clear();
            driver.FindElement(By.Id("rdCboTitle_Input")).SendKeys("--select--");
            driver.FindElement(By.Id("rdCboGender_Input")).Clear();
            driver.FindElement(By.Id("rdCboGender_Input")).SendKeys("--select--");
            driver.FindElement(By.Id("rdCboPrimaryCitizen_Input")).Clear();
            driver.FindElement(By.Id("rdCboPrimaryCitizen_Input")).SendKeys("--select--");
            driver.FindElement(By.Id("rdCboBirthCountry_Input")).Clear();
            driver.FindElement(By.Id("rdCboBirthCountry_Input")).SendKeys("--select--");
            driver.FindElement(By.Id("rdTxtMobileCode")).Clear();
            driver.FindElement(By.Id("rdTxtMobileCode")).SendKeys("");
            driver.FindElement(By.Id("rdCboApplyingCountry_Input")).Clear();
            driver.FindElement(By.Id("rdCboApplyingCountry_Input")).SendKeys("--select--");
            driver.FindElement(By.Id("rdCboTitle_Arrow")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered")).Click();
            driver.FindElement(By.Id("rdCboTitle_Input")).Clear();
            driver.FindElement(By.Id("rdCboTitle_Input")).SendKeys("Mr");
            driver.FindElement(By.Id("rdTxtFirstName")).Clear();
            driver.FindElement(By.Id("rdTxtFirstName")).SendKeys("ade");
            driver.FindElement(By.Id("rdTxtFirstName")).Clear();
            driver.FindElement(By.Id("rdTxtFirstName")).SendKeys("ade");
            driver.FindElement(By.Id("rdTxtLastName")).Clear();
            driver.FindElement(By.Id("rdTxtLastName")).SendKeys("tope");
            driver.FindElement(By.Id("rdTxtLastName")).Clear();
            driver.FindElement(By.Id("rdTxtLastName")).SendKeys("tope");
            driver.FindElement(By.Id("rdCboGender_Input")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered")).Click();
            driver.FindElement(By.Id("rdCboGender_Input")).Clear();
            driver.FindElement(By.Id("rdCboGender_Input")).SendKeys("Male");
            driver.FindElement(By.Id("rdCboPrimaryCitizen_Input")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered")).Click();
            driver.FindElement(By.Id("rdCboPrimaryCitizen_Input")).Clear();
            driver.FindElement(By.Id("rdCboPrimaryCitizen_Input")).SendKeys("Afghanistan");
            driver.FindElement(By.Id("rdCboBirthCountry_Input")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered")).Click();
            driver.FindElement(By.Id("rdCboBirthCountry_Input")).Clear();
            driver.FindElement(By.Id("rdCboBirthCountry_Input")).SendKeys("Afghanistan");
            driver.FindElement(By.Id("rdDateOfBirth_popupButton")).Click();
            driver.FindElement(By.Id("rdDateOfBirth_calendar_Title")).Click();
            driver.FindElement(By.LinkText("1997")).Click();
            driver.FindElement(By.LinkText("Jun")).Click();
            driver.FindElement(By.Id("rcMView_OK")).Click();
            driver.FindElement(By.LinkText("13")).Click();
            driver.FindElement(By.Id("rdDateOfBirth_dateInput")).Clear();
            driver.FindElement(By.Id("rdDateOfBirth_dateInput")).SendKeys("dd-mm-yyyy");
            driver.FindElement(By.Id("rdDateOfBirth")).Clear();
            driver.FindElement(By.Id("rdDateOfBirth")).SendKeys("1997-06-13");
            driver.FindElement(By.Id("rdCboApplyingCountry_Input")).Click();
            driver.FindElement(By.Id("rdTxtMobileCode")).Clear();
            driver.FindElement(By.Id("rdTxtMobileCode")).SendKeys("");
            driver.FindElement(By.CssSelector("li.rcbHovered")).Click();
            driver.FindElement(By.Id("rdCboApplyingCountry_Input")).Clear();
            driver.FindElement(By.Id("rdCboApplyingCountry_Input")).SendKeys("Afghanistan");
            driver.FindElement(By.Id("rdTxtmobno")).Clear();
            driver.FindElement(By.Id("rdTxtmobno")).SendKeys("2422524");
            driver.FindElement(By.Id("rdTxtmobno")).Clear();
            driver.FindElement(By.Id("rdTxtmobno")).SendKeys("2422524");
            driver.FindElement(By.Id("rdTxtEmail")).Clear();
            driver.FindElement(By.Id("rdTxtEmail")).SendKeys("now@gmail.com");
            driver.FindElement(By.Id("rdTxtEmail")).Clear();
            driver.FindElement(By.Id("rdTxtConfirmEmail")).SendKeys("now@gmail.com");
            driver.FindElement(By.Id("rdTxtConfirmEmail")).Clear();
            driver.FindElement(By.Id("rdTxtConfirmEmail")).SendKeys("now@gmail.com");
            driver.FindElement(By.Id("rdTxtsecretanswer")).Clear();
            driver.FindElement(By.Id("rdTxtsecretanswer")).SendKeys("binanno");
            driver.FindElement(By.Id("rdTxtsecretanswer")).Clear();
            driver.FindElement(By.Id("rdTxtsecretanswer")).SendKeys("binanno");
            driver.FindElement(By.Id("rdTxtPwd")).Clear();
            driver.FindElement(By.Id("rdTxtPwd")).SendKeys("laptop123");
            driver.FindElement(By.Id("rdTxtPwd")).Clear();
            driver.FindElement(By.Id("rdTxtPwd")).SendKeys("laptop123");
            driver.FindElement(By.Id("rdTxtCPwd")).Clear();
            driver.FindElement(By.Id("rdTxtCPwd")).SendKeys("laptop123");
            driver.FindElement(By.Id("rdTxtCPwd")).Clear();
            driver.FindElement(By.Id("rdTxtCPwd")).SendKeys("laptop123");
            driver.FindElement(By.Id("recaptcha_reload")).Click();
            driver.FindElement(By.Id("recaptcha_response_field")).Clear();
            driver.FindElement(By.Id("recaptcha_response_field")).SendKeys("CASABLANCA CREEKSIDE");
            driver.FindElement(By.XPath("//span[@id='rdBtnchkAccept']/span")).Click();
            driver.FindElement(By.CssSelector("a.mybutton")).Click();
            driver.FindElement(By.CssSelector("span.rwInnerSpan")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[2]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[2]/a/span/span[2]")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_radBtnNewApp_input")).Click();
            driver.FindElement(By.Id("chkListLevelOfStudyQ_1")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_radtxtCourseName")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_radtxtCourseName")).SendKeys("ISM");
            driver.FindElement(By.Id("ui-id-6")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_radtxtCourseName")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_radtxtCourseName")).SendKeys("Master of Arts in International Journalism for Digital Media");
            driver.FindElement(By.Id("btnQuickSearch_input")).Click();
            driver.FindElement(By.CssSelector("#ctl00_MainContent_grdSearchResult_ctl00__0 > td")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_grdSearchResult_ctl00_ctl04_radBtnShort_input")).Click();
            driver.FindElement(By.XPath("//div[@id='ctl00_MainContent_rToolBar']/div/div/div/ul/li[2]/a/span/span/span/span")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_rdGrdShortListCourse_ctl00_ctl04_rCboIntakeDate_Input")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered.")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_rdGrdShortListCourse_ctl00_ctl04_rCboIntakeDate_Input")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdGrdShortListCourse_ctl00_ctl04_rCboIntakeDate_Input")).SendKeys("24/09/2018");
            driver.FindElement(By.Id("ctl00_MainContent_rdGrdShortListCourse_ctl00_ctl04_ClientSelectColumnSelectCheckBox")).Click();
            driver.FindElement(By.Id("btnApplyCourse_input")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_dlstDetail_ctl00_btnPassport_input")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_dlstDetail_ctl00_btnEducation_input")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_dlstDetail_ctl00_btnEmployment_input")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_dlstDetail_ctl00_btnEnglish_input")).Click();
            driver.FindElement(By.XPath("//div[@id='ctl00_MainContent_rToolBar']/div/div/div/ul/li[2]/a/span/span/span/span")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_rdCmbCountry_Input")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered.")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_rdCmbCountry_Input")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdCmbCountry_Input")).SendKeys("Afghanistan");
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).SendKeys("minimum 3 letters");
            driver.FindElement(By.Id("ctl00_MainContent_rdCboCounty_Input")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdCboCounty_Input")).SendKeys("--select--");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtFaxCountryCode")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtFaxCountryCode")).SendKeys("cc");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhoneCountryCode")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhoneCountryCode")).SendKeys("cc");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtMobileCode")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtMobileCode")).SendKeys("");
            driver.FindElement(By.Id("ctl00_MainContent_rdCmbState_Input")).Click();
            driver.FindElement(By.CssSelector("li.rcbHovered")).Click();
            driver.FindElement(By.Id("ctl00_MainContent_rdCmbState_Input")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdCmbState_Input")).SendKeys("Badakhshan");
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).SendKeys("minimum 3 letters");
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).SendKeys("EDAN");
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_radTxtCity")).SendKeys("EDAN");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtStreet1")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtStreet1")).SendKeys("12 Nowway oglan suti");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtStreet1")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtStreet1")).SendKeys("12 Nowway oglan suti");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhoneCode")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhoneCode")).SendKeys("1");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhoneCode")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhoneCode")).SendKeys("1");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhone")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhone")).SendKeys("322423");
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhone")).Clear();
            driver.FindElement(By.Id("ctl00_MainContent_rdTxtPhone")).SendKeys("322423");
            driver.FindElement(By.XPath("//div[@id='ctl00_MainContent_rToolBar']/div/div/div/ul/li[3]/a/span/span/span/span")).Click();
            driver.FindElement(By.XPath("//div[@id='confirm1497429138949_content']/div/div[2]/a[2]/span/span")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[3]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[3]/div/ul/li[2]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[4]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[5]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[6]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[7]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[4]/a/span/span[2]")).Click();
            driver.FindElement(By.XPath("//div[@id='rPnlBarMainNav']/ul/li[5]/a/span/span[2]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
