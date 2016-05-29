using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TestBizApps;
using System.IO;
using System.Xml.Serialization;
using System.Security.Cryptography;
using System.Text;

namespace AspNet
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static OtdelKadrov myKadry;
        public static Sotrudnik mySotrud;
        public static string ID;
        protected void Page_Load(object sender, EventArgs e)
        {
            myKadry = new OtdelKadrov();
            LoadOtdelKadrov();
            foreach (var node in myKadry.sotrudniki)//руководители
            {
                ListItem temp2 = new ListItem(node.lastname + ' ' + node.name + ' ' + node.middlename, node.sotrudnikID);
                ListBox1.Items.Add(temp2);
            }
            foreach (var node in myKadry.dolzhnosti)//должности
            {
                ListItem temp2 = new ListItem(node, node);
                ListBox2.Items.Add(temp2);

            }
            foreach (var node in myKadry.otdely)//отделы
            {
                ListItem temp2 = new ListItem(node, node);
                ListBox3.Items.Add(temp2);
            }

            ID = Request.QueryString["id"];
            if (ID!=null) {
                Label9.Text = "Изменить информацтю о сотруднике";
                
                foreach (var Node in myKadry.sotrudniki)
                   if (Node.sotrudnikID == ID)
                        mySotrud = Node;                
                /*TextBox1.Text = mySotrud.name;
                TextBox2.Text = mySotrud.lastname;
                TextBox3.Text = mySotrud.middlename;
                TextBox6.Text = mySotrud.phone;*/
                ListBox1.Visible = false;//руководит
                TextBox9.Visible = true;//руководит
                //TextBox9.Text = mySotrud.rukovoditelID;
                Button4.Visible = true;//кнопка изменения
                Button1.Visible = false;//кнпк создания
                

            }
            else
            {
                    foreach (var node in myKadry.dolzhnosti)//должности
                {
                    ListItem temp2 = new ListItem(node, node);
                    ListBox2.Items.Add(temp2);
                }
                foreach (var node in myKadry.otdely)//отделы
                {
                    ListItem temp2 = new ListItem(node, node);
                    ListBox3.Items.Add(temp2);
                }
                //показать всё иерархию

                Temp(ref Label8, "0");//начинаем с директора- ""
                //ListBox1.DataSource = myKadry.sotrudniki.;
                //ListBox1.DataBind();
                // ListBox1.
                /*IEnumerable<OtdelKadrov> myFiltrKadry =
                    from student in app.students
                    join ci in app.contactList on student.ID equals ci.ID
                    select ci;
                */
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
                //SaveOtdelKadrov();
            }
        }
        public static void LoadOtdelKadrov()//ref OtdelKadrov myKadry
        {
            try
            {
                FileStream filestream = new FileStream("file.xml", FileMode.Open, FileAccess.Read, FileShare.Read);//|DataDirectory|/
                XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
                myKadry = (OtdelKadrov)xmls.Deserialize(filestream);
                filestream.Close();
            }
            catch { }

        }
        public static void SaveOtdelKadrov()
        {
            FileStream filestream = new FileStream("file.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
            xmls.Serialize(filestream, myKadry);
            filestream.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        	using (MD5 md5Hash = MD5.Create())
            	{
        			string source = TextBox1.Text+ TextBox2.Text+ TextBox3.Text;
        			string hash = GetMd5Hash(md5Hash, source);
        			myKadry.sotrudniki.Add(new Sotrudnik(TextBox1.Text, TextBox2.Text, TextBox3.Text, ListBox2.SelectedValue, ListBox3.SelectedValue, TextBox6.Text, ListBox1.SelectedValue, hash));//myKadry.FreeID
           		}
    		SaveOtdelKadrov();
    		
        }
        static string GetMd5Hash(MD5 md5Hash, string input)//взял с MSDN
        {
            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        public static void Temp(ref Label div, string soID )
        {
            foreach (var node in myKadry.sotrudniki)
                {
                    if (soID == node.sotrudnikID)
                    {
                        div.Text += @"</BR>
<li> <a href=" + '"' + "default.aspx?id=" + node.sotrudnikID + '"' + ">" + node.lastname + ' ' + node.name + ' ' + node.middlename + ' ' + node.otdel + ' ' + node.dolzhnost + ' ' + node.phone + "</a></li>";
                    }
                }
            //ищем подчинённых
            foreach (var node in myKadry.sotrudniki)
            {
               if (soID == node.rukovoditelID)
                {
                    div.Text += "<ul>";
                   Temp(ref div,  node.sotrudnikID );
                }
            }
            div.Text+="</ul>";//закрываем всех подчинённых
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            myKadry.dolzhnosti.Add(TextBox7.Text);
            SaveOtdelKadrov();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            myKadry.otdely.Add(TextBox8.Text);
            SaveOtdelKadrov();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            if(TextBox6.Text!="")
                mySotrud.phone=TextBox6.Text;
            if(ListBox2.SelectedValue!="")
            mySotrud.dolzhnost = ListBox2.SelectedValue;
            if (ListBox3.SelectedValue != "") 
            mySotrud.otdel = ListBox3.SelectedValue;
            
            for (int i = 0; i < myKadry.sotrudniki.Count; i++)
            {
                if (myKadry.sotrudniki[i].sotrudnikID == ID)
                    myKadry.sotrudniki[i] = mySotrud;
            } 
            
    		SaveOtdelKadrov();
        }

        protected void ListBox2_TextChanged(object sender, EventArgs e)
        {
            Label9.Text += ListBox2.SelectedValue;
        }
    }
}