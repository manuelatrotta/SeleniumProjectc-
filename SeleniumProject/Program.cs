using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
//  {
//  static void Main()
//   {
//oggetto ChromeDriver
//   IWebDriver driver = new ChromeDriver();
//richiamo metodo navigate. Open a url in a chrome browser
//   driver.Navigate().GoToUrl("https://www.zalando.it/donna-home/");
//metodo sleep pausa di 2 secondi
//   Thread.Sleep(2000);
// search an element with find element by name or by class name in HTML 
//  IWebElement element = driver.FindElement(By.ClassName("z-navicat-header_svgLogo"));

//  if (element.Displayed)
//   {
//      MagentaMessage("element is present on this page");
// }
//   else
//  {
//       DarkRedMessage("element isn't present on this page");
//   }
// chiusura del driver
//     driver.Quit();

// }

// private methods MagentaMessage and DarkRedMessage for write colored message in console log
// private static void MagentaMessage(string message)
// {
//      Console.ForegroundColor = ConsoleColor.DarkMagenta;
//       Console.WriteLine(message);
//      Console.ForegroundColor = ConsoleColor.DarkCyan;
//  }

//    private static void DarkRedMessage(string message)
//  {
//       Console.ForegroundColor = ConsoleColor.DarkRed;
//       Console.WriteLine(message);
//        Console.ForegroundColor = ConsoleColor.DarkYellow;
//    }
//}

//class LoginLayout
{





    static void Main()
    {
        string url = "http://demo.guru99.com/test/login.html";
        string email = "pmondo@yopmail.com";
        string psw = "12345";


        //oggetto ChromeDriver
        IWebDriver driver = new ChromeDriver();
        //richiamo metodo navigate. Open a url in a chrome browser
        driver.Navigate().GoToUrl(url);

        Thread.Sleep(2000);

        //identicatation of elements 
        IWebElement title = driver.FindElement(By.ClassName("page-subheading"));
        IWebElement labelemail = driver.FindElement(By.Id("email"));
        IWebElement labelpass = driver.FindElement(By.Id("passwd"));
        IWebElement forgotpassword = driver.FindElement(By.ClassName("lost_password"));
        IWebElement login = driver.FindElement(By.Name("SubmitLogin"));


        try
        {
            if (title.Displayed && labelemail.Displayed && labelpass.Displayed && forgotpassword.Displayed && login.Displayed)
            {
                MagentaMessage("Elements are present");
            }

        }
        catch (NoSuchElementException)
        {
            DarkRedMessage("Elements aren't present");
        }


        //insert value in email and password and submit with button login

        labelemail.SendKeys(email);
        labelpass.SendKeys(psw);
        login.Submit();
        driver.Quit();
    }

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


