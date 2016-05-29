/*
 * Создано в SharpDevelop.
 * Пользователь: Аяз
 * Дата: 27.05.2016
 * Время: 18:14
 * 23
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
		public List<Sotrudnik> sotrudniki = new List<Sotrudnik>();//B asp.
//        int lastBusyID = 0;//для нового сотрудника
//        public string FreeID {
//            get
//            {
//            	//var t=GetHashCode("");
//            	
////            	for(int i =0;i<sotrudniki.Count;i++){
////            		if (sotrudniki[i].sotrudnikID!="")
////                	if (int.Parse(sotrudniki[i].sotrudnikID) > lastBusyID)
////                		lastBusyID = int.Parse(sotrudniki[i].sotrudnikID);
////            	}
//            	
//                foreach (var Node in sotrudniki) {
//            		
//        			if (Node.sotrudnikID=="")
//                	if (int.Parse(Node.sotrudnikID) > lastBusyID)
//                		lastBusyID = int.Parse(Node.sotrudnikID);
//            		
//        		}
//            	return (lastBusyID+1).ToString();
//            }
//        }
        public OtdelKadrov()
        { 

        }
			
    }
	
	public class Sotrudnik
	{
		public string name,lastname, middlename, dolzhnost, otdel,phone,rukovoditelID ;
		public string sotrudnikID {get;set;}
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
