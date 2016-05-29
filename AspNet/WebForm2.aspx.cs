using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using TestBizApps;
using System.IO;
using System.Xml.Serialization;
namespace AspNet
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public static OtdelKadrov myKadry;
        public static Sotrudnik mySotrud;
        protected void Page_Load(object sender, EventArgs e)
        {
            var ID = Request.QueryString["id"];
            var myKadry = new OtdelKadrov();
            //LoadOtdelKadrov(); 
    FileStream filestream = new FileStream("file.xml", FileMode.Open, FileAccess.Read, FileShare.Read);//|DataDirectory|/
    XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
    myKadry = (OtdelKadrov)xmls.Deserialize(filestream);
    filestream.Close();

            foreach (var Node in myKadry.sotrudniki) {
                if (Node.sotrudnikID == ID)
                    mySotrud = Node;
            }

            //12367
            TextBox1.Text = mySotrud.name;
            TextBox2.Text = mySotrud.lastname;
            TextBox3.Text = mySotrud.middlename;
            TextBox6.Text = mySotrud.phone;
            TextBox7.Text = mySotrud.rukovoditelID;
            foreach (var node in myKadry.dolzhnosti)
            {
                ListItem temp2 = new ListItem(node, node);
                ListBox2.Items.Add(temp2);
            }
            foreach (var node in myKadry.otdely)
            {
                ListItem temp2 = new ListItem(node, node);
                ListBox3.Items.Add(temp2);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<myKadry.sotrudniki.Count;i++)
            {
                if (myKadry.sotrudniki[i].sotrudnikID == ID)
                    myKadry.sotrudniki[i]= mySotrud;
            }
            FileStream filestream = new FileStream("file.xml", FileMode.Create, FileAccess.Write, FileShare.ReadWrite);
            XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
            xmls.Serialize(filestream, myKadry);
            filestream.Close();
        }
        public static void LoadOtdelKadrov()//ref OtdelKadrov myKadry
        {
            FileStream filestream = new FileStream("file.xml", FileMode.Open, FileAccess.Read, FileShare.Read);//|DataDirectory|/
            XmlSerializer xmls = new XmlSerializer(typeof(OtdelKadrov));
            myKadry = (OtdelKadrov)xmls.Deserialize(filestream);
            filestream.Close();
        }
    }
}