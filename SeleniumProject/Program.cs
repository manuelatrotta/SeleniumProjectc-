using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
    {
        static void Main()
        {
        //oggetto ChromeDriver
        IWebDriver driver = new ChromeDriver();
        //richiamo metodo navigate. Open a url in a chrome browser
        driver.Navigate().GoToUrl("https://www.zalando.it/donna-home/");
        //metodo sleep pausa di 2 secondi
        Thread.Sleep(2000);
        // search an element with find element by name or by class name in HTML 
        IWebElement element = driver.FindElement(By.ClassName("z-navicat-header_svgLogo"));

        if (element.Displayed)
        {
            MagentaMessage("element is present on this page");
        }
        else
        {
            DarkRedMessage("element isn't present on this page");
        }
        // chiusura del driver
         driver.Quit();

    }

    // private methods MagentaMessage and DarkRedMessage for write colored message in console log
    private static void MagentaMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.DarkCyan;
    }

    private static void DarkRedMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }
}

