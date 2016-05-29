/*
 * Создано в SharpDevelop.
 * Пользователь: Аяз
 * Дата: 27.05.2016
 * Время: 18:14
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace TestBizApps
{
	class Program
	{
		public static OtdelKadrov myKadry;
		public static void Main(string[] args)
		{
			myKadry = new OtdelKadrov();
			LoadOtdelKadrov();
			/*myKadry.sotrudniki.Add(new Sotrudnik("ayaz","Zali","Aidar","developer","otdel1","89518954606","0","0"));
			myKadry.dolzhnosti.Add("developer");
			myKadry.dolzhnosti.Add("qa");
			myKadry.dolzhnosti.Add("project manager");
			myKadry.dolzhnosti.Add("business analyst");
			myKadry.dolzhnosti.Add("product owner");
           
          myKadry.otdely.Add("отдел1");
          myKadry.otdely.Add("отдел2");
          myKadry.otdely.Add("отдел3");
          myKadry.otdely.Add("отдел4");
          */
			//Console.Write("Press any key to continue . . .   И база сохраниться");
			SaveOtdelKadrov();
			//Console.ReadKey(true);
		}
		public static void LoadOtdelKadrov()//ref OtdelKadrov myKadry
		{
            FileStream filestream = new FileStream("file.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
            myKadry = (OtdelKadrov)xmls.Deserialize(filestream);
            filestream.Close();
        }
		public static void SaveOtdelKadrov()
		{
			FileStream filestream = new FileStream("file.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
            xmls.Serialize(filestream, myKadry);
            filestream.Close();
		}
	}
}