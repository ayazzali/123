# 123
12
  myKadry = new OtdelKadrov();
  потом загрузить из файла file.xml данные отдела кадров:
			FileStream filestream = new FileStream("file.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
      XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
      myKadry = (OtdelKadrov)xmls.Deserialize(filestream);
      filestream.Close(); OtdelKadrov
  все сотрудники хранятся в myKadry.sotrudniki 
  у сотрудников свойства публичные - их можно изменять
  должности myKadry.dolzhnosti
  отделы myKadry.otdely
  
  в конце нужно сохранить данные

Сотрудников можно переводить в другой отдел, повышать и понижать в должности, а также менять контактную информацию. 
Отделы так же можно редактировать. 
Необходима возможность просмотра иерархии взаимоотношений.
