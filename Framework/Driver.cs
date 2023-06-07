using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
{
    public static class Driver
    {
        internal static IWebDriver Instance { get; private set; }

        public static void Initialize()
        {
            Instance = new ChromeDriver();
        }

        public static void Quit()
        {
            Instance.Quit();
        }
    }
}
