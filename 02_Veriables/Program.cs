﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double
            //Console.WriteLine("****** Fiyat Listesi ********");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine(" ---- Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine(" ---- Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine(" ---- Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine(" ---- Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine(" ---- Domates Birim Fiyatı: " + tomatoPrice + "TL");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.65;
            //strawberryGram = 0.75;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("****** Toplam Tutar *******");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün - Elma " + "Birim Fiyat: " + applePrice + " -Gramaj: " + appleGram + "- Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün - Portakal " + "Birim Fiyat: " + orangePrice + " -Gramaj: " + orangeGram + "- Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün - Çilek " + "Birim Fiyat: " + strawberryPrice + " -Gramaj: " + strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün - Patates " + "Birim Fiyat: " + potatoPrice + " -Gramaj: " + potatoGram + "- Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün - Domates " + "Birim Fiyat: " + tomatoPrice + " -Gramaj: " + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice);


            //Console.WriteLine();
            //Console.WriteLine();

            //double shopingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar: " + shopingTotalPrice + "TL");


            #endregion
            #region char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu  Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu TC Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("----------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " +passengerIdentityNumber+ " - Yolcu Ad Soyad " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge + " ");


            #endregion
            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice + "TL");



            #endregion
            #region Klavyeden Ondalıklı sayı işlemeleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Lütfen Sınav Not Ortalamsını Giriniz: " + result);


            #endregion
            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);



            #endregion

            Console.Read();

        }
    }
}