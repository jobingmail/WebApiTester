using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using WinFormsApiClient;
using System.Text.Json.Serialization;
using System.Net.Http;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string serialisedText;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HTTPMethod();

        }

        void HTTPMethod()
        {
            if (comboBox1.Text == HttpVerb.GET.ToString())
            {
                GetMethod rClient = new GetMethod();
                rClient.endPoint = txtURL.Text;

                string StrResponse = rClient.GetData();
                txtOutput.Text = StrResponse;
            }
            else if (comboBox1.Text == HttpVerb.POST.ToString())
            {

                Quote quote = new Quote()
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Description = txtDescription.Text
                };


                PostMethod rClient = new PostMethod();
                txtOutput.Text = rClient.PostData(txtURL.Text, quote);
            }
            else if (comboBox1.Text == HttpVerb.PUT.ToString())
            {

                Quote quote = new Quote()
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    Description = txtDescription.Text
                };


                PutMethod rClient = new PutMethod();
                txtOutput.Text = rClient.PutData(txtURL.Text, quote);
            }
            else if (comboBox1.Text == HttpVerb.DELETE.ToString())
            {

                DeleteMethod rClient = new DeleteMethod();
                txtOutput.Text = rClient.DeleteData(txtURL.Text);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnJDSerialize_Click(object sender, EventArgs e)
        {
            
           

            Quote objQuote = System.Text.Json.JsonSerializer.Deserialize<Quote>(serialisedText);

            txtOutput.Text = "Title = " + objQuote.Title;
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText("Author = "+ objQuote.Author);
            txtOutput.AppendText(Environment.NewLine);
            txtOutput.AppendText("Description = " + objQuote.Description);
            
        }

        private void btnSerialise_Click(object sender, EventArgs e)
        {
            Quote quote = new Quote()
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Description = txtDescription.Text
            };

            serialisedText = System.Text.Json.JsonSerializer.Serialize(quote);

            //serialisedText = JsonConvert.SerializeObject(quote);

            txtOutput.Text = serialisedText;
        }
    }
}
