using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enginesoft.AmazonAwsS3Sample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadTestCredential();
        }
        
        private void LoadTestCredential()
        {
            string path = @"C:\Temp\AmazonAwsS3Sample.xml";

            if (!System.IO.Directory.Exists(@"c:\Temp"))
                System.IO.Directory.CreateDirectory(@"c:\Temp");

            Models.AwsCredential credential;
            var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(Models.AwsCredential));

            if (!System.IO.File.Exists(path))
            {
                //Create a new config xml
                credential = new Models.AwsCredential(string.Empty, string.Empty, string.Empty);
                
                using (var streamWriter = new System.IO.StreamWriter(path))
                {
                    xmlSerializer.Serialize(streamWriter, credential);
                }
            }
            
            //Load config xml
            using (var streamReader = new System.IO.StreamReader(path))
            {
                credential = (Models.AwsCredential)xmlSerializer.Deserialize(streamReader);
            }

            txtAccessKeyId.Text = credential.AcesssKey;
            txtSecretAccessKey.Text = credential.SecretKey;
            txtRegion.Text = credential.Region;
        }

        private void ValidateCredentials()
        {
            //TODO: Verificar se as credenciais estão preenchidas
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ValidateCredentials();

            try
            {
                lstItems.Items.Clear();

                var credential = new Models.AwsCredential(txtAccessKeyId.Text, txtSecretAccessKey.Text, txtRegion.Text);

                var client = new AwsS3Client(credential);
                client.LogReported += Client_LogReported;

                var list = client.ListItems(txtBucketName.Text, txtServerFolder.Text, (int)nupMaxItems.Value);
                foreach (var item in list)
                    lstItems.Items.Add(item);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(this, string.Format("Error listing -- {0}", ex.Message), "AmazonAwsS3Sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Client_LogReported(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
