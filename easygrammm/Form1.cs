using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
    
namespace easygrammm
{
    public partial class Dilavergram : Form 
    {
        private static int maxDeger;
        static List<Hesap> hesapList = new List<Hesap>();

        public static ChromeDriver driver;
        private static ChromeOptions ayarlar = new ChromeOptions();
        public Dilavergram()
        {
            InitializeComponent();
            ayarlar.AddArgument("--disable-popup-blocking");
            ayarlar.EnableMobileEmulation("iPhone X");
            ayarlar.AddArgument("log-level=3");

            driver = new ChromeDriver(options: ayarlar);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5f);
        }

        private void HesapYarat(string id,string ad,string sifre,string mail)
        {
            Hesap yeniHesap = new Hesap();

            yeniHesap.SetMail(mail);
            yeniHesap.SetKullanciAdi(id);
            yeniHesap.SetadSoyad(ad);
            yeniHesap.SetSifre(sifre);

            try
            {
                driver.Url = "https://www.instagram.com/accounts/signup/phone";

                var adim =
                    driver.FindElementByXPath("//*[@id=\"react-root\"]/section/main/div[2]/div/div[1]/span[2]");

                adim.Click();

                var eposta = driver.FindElementByName("email");
                    
                eposta.SendKeys(mail+"@gmail.com");

                adim = driver.FindElementByXPath("//*[@id=\"react-root\"]/section/main/div[2]/div/div[3]/button");

                adim.Click();

                var adSoyad = driver.FindElementByName("fullName");
                
                adSoyad.SendKeys(ad);

                var sifreWeb = driver.FindElementByName("password");

                sifreWeb.SendKeys(sifre);

                adim = driver.FindElementByXPath("//*[@id=\"react-root\"]/section/main/div[2]/div/div[2]/button");

                adim.Click();

                var dogumYili = driver.FindElementByXPath(
                    "//*[@id=\"react-root\"]/section/main/div[2]/div/div[1]/div[4]/div/div/span/span[3]/select");

                SelectElement sec = new SelectElement(dogumYili);

                Random rastgele = new Random();
                int rastgeleYil = rastgele.Next(1965, 2002);
                sec.SelectByValue(rastgeleYil.ToString());


                adim = driver.FindElementByXPath(
                    "//*[@id=\"react-root\"]/section/main/div[2]/div/div[2]/button");

                adim.Click();

                var randomID =
                    driver.FindElementByXPath("//*[@id=\"react-root\"]/section/main/div[2]/div/div[1]/div/h1").Text;


                yeniHesap.SetKullanciAdi(randomID);

                adim = driver.FindElementByXPath(
                    "//*[@id=\"react-root\"]/section/main/div[2]/div/div[2]/button");

                adim.Click();

                Thread.Sleep(4000);

                driver.SwitchTo().Alert().Accept();

                hesapList.Add(yeniHesap);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            
            var result = hesapList.Select(s => new
            {
                KullaniciAdi = s.GetKullaninciAdi(),
                Sifre = s.GetSifre(),
                Mail = s.GetMail(),
                Ad = s.GetAdSoyad()
            }).ToList();
            listeGoster.DataSource = result;
        }


        private void basla_Click(object sender, EventArgs e)
        {
            var tmMi = Int32.TryParse(rastgeleMax.Text, out maxDeger);

            var randomID = Extra.TekrarDuzenle(idBox.Text, maxDeger, randomYazi.AutoCheck, randomSayi.AutoCheck);
            var randomSifre = Extra.TekrarDuzenle(sifreBox.Text, maxDeger, randomYazi.AutoCheck, randomSayi.AutoCheck);
            var randomMail = Extra.TekrarDuzenle(mailBox.Text, maxDeger, randomYazi.AutoCheck, randomSayi.AutoCheck);
            var randomAd = Extra.TekrarDuzenle(adBox.Text, maxDeger, randomYazi.AutoCheck, randomSayi.AutoCheck);

            HesapYarat(randomAd,randomAd,randomSifre,randomMail);

        }


    }
}
