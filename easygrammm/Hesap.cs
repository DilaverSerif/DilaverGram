using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easygrammm
{
    class Hesap
    {
        private string adSoyad, mail, kullaniciAdi, sifre;

        public void SetadSoyad(string padSoyad)
        {
            adSoyad = padSoyad;
        }

        public void SetMail(string pMail)
        {
            mail = pMail;
        }

        public void SetKullanciAdi(string pkullaniciAdi)
        {
            kullaniciAdi = pkullaniciAdi;
        }

        public void SetSifre(string pSetSifre)
        {
            sifre = pSetSifre;
        }

        public string GetSifre()
        {
            return sifre;
        }

        public string GetKullaninciAdi()
        {
            return kullaniciAdi;
        }

        public string GetMail()
        {
            return mail;
        }

        public string GetAdSoyad()
        {
            return adSoyad;
        }

    }

}
