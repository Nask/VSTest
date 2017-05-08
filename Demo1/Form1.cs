using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;

namespace Demo1
{
    public partial class Form1 : Form
    {
        IWebDriver browser;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      //1. Пример с Google
        {
            
            browser.Navigate().GoToUrl("https://www.google.ru/");

            IWebElement SearchInput = browser.FindElement(By.Id("lst-ib"));
            SearchInput.SendKeys("найди мне нужный сайт" + OpenQA.Selenium.Keys.Enter);
        }

        private void button2_Click(object sender, EventArgs e)      //Закрыть браузер
        {
            browser.Quit();
        }

        private void button4_Click(object sender, EventArgs e)      //Открыть браузер
        {
            browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            browser.Manage().Window.Maximize();
        }

        private void button3_Click(object sender, EventArgs e)      //2. Поиск элементов и клики
        {
            browser.Navigate().GoToUrl("https://www.yandex.ru/");
            IWebElement element;        //Обявляем переменную "element"
            //element = browser.FindElement(By.Id("text"));       //находит элемент с id="text"
            //element.SendKeys("текст");      // и вводит туда - "текст"

            
            element = browser.FindElement( By.ClassName("promo_9may2017__entry") );
            element.Click();
        }
    }
}
