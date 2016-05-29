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
	/// <summary>
	/// Description of Class1.
	/// </summary>
	[Serializable]
	public class OtdelKadrov
	{
		public List<string> dolzhnosti = new List<string>();
		public List<string> otdely = new List<string>();
		public List<Sotrudnik> sotrudniki = new List<Sotrudnik>();
		/*public List<Sotrudnik> sotrudniki{
			set{
				value =_sotrudniki;
				if (int.Parse((value as Sotrudnik).sotrudnikID)>lastBusyID)lastBusyID=int.Parse((value as Sotrudnik).sotrudnikID);}
			get{return _sotrudniki;}
		}*/
        int lastBusyID = 0;//для нового сотрудника
        public string FreeID {
            get
            {
                 foreach (var Node in sotrudniki) {
                	if (int.Parse(Node.sotrudnikID) > lastBusyID)
                		lastBusyID = int.Parse(Node.sotrudnikID);
            		}
                
                return lastBusyID.ToString();
            }
        }
		public OtdelKadrov()
		{
			
		}
		
		
	}
	
	public class Sotrudnik
	{
		public string name,lastname, middlename, dolzhnost, otdel,phone,rukovoditelID ;
		public string sotrudnikID ;//{get;set;}
		//public Int32 sotrudnikID{get{return sotrudnikID;}}
		public Sotrudnik(string _name,string _lastname,string _middlename,string _dolzhnost,string _otdel,string _phone,string _rukovoditelID,string _sotrudnikID)
		{
			this.name=_name;
			lastname  =_lastname ;
			middlename  =_middlename  ;
			dolzhnost  =_dolzhnost  ;
			otdel  =_otdel  ;
			phone  =_phone  ;
			sotrudnikID=_sotrudnikID;
			rukovoditelID=_rukovoditelID;
            sotrudnikID = _sotrudnikID;
		}
		public Sotrudnik(){}
		//public void setDolzhnost(string _Dolzhnost){}
		//public void setPhone(string _phone){}
	}
	
	
	
}
