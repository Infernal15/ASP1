using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text;

namespace ASP_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            load();
        }

        private async void load()
        {
            string[] tmp;
            string text = "";
            if (!File.Exists("D:\\users.txt"))
                File.Create("D:\\users.txt");
            using (StreamReader read = new StreamReader("D:\\users.txt"))
            {
                while (!read.EndOfStream)
                {
                    tmp = read.ReadLine().Split(',');
                    text += "<div class='element'>" +
                        "<div>" +
                        $"<p>Name: {tmp[0]}</p>" +
                        $"<p>Date: {tmp[1]}</p>" +
                        "</div>" +
                        $"<p>Address: {tmp[2]}</p>" +
                        "<div>" +
                        $"<p>Sex: {tmp[3]}</p>" +
                        $"<p>Profession: {tmp[4]}</p>" +
                        "</div>" +
                        "</div>";
                }
            }

            content.InnerHtml = text;
        }

        protected async void Save(object sender, EventArgs e)
        {
            if (!File.Exists("D:\\users.txt"))
                File.Create("D:\\users.txt");
            using (StreamWriter writer = new StreamWriter("D:\\users.txt", true, Encoding.UTF8))
            {
                writer.WriteLine($"{Name.Value},{date.Value},{address.Value},{RadioButtonList1.SelectedValue},{profession.Value}");
                Name.Value = "";
                date.Value = "";
                address.Value = "";
                RadioButtonList1.SelectedValue = "";
                profession.Value = "";
            }
            load();
        }
    }
}