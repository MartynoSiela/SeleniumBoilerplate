using OpenQA.Selenium;

namespace Framework
{
    internal static class Common
    {
        private static IWebElement GetElement(string xpath)
        {
            return Driver.Instance.FindElement(By.XPath(xpath));
        }

        private static IList<IWebElement> GetElements(string xpath)
        {
            return Driver.Instance.FindElements(By.XPath(xpath));
        }

        internal static void OpenPage(string url)
        {
            Driver.Instance.Url = url;
        }

        internal static void ClickElement(string xpath)
        {
            GetElement(xpath).Click();
        }

        internal static void SendKeysToElement(string xpath, string keys)
        {
            GetElement(xpath).SendKeys(keys);
        }

        internal static string GetElementText(string xpath)
        {
            return GetElement(xpath).Text;
        }
    }
}
