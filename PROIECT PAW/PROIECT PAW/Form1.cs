using PROIECT_PAW.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PROIECT_PAW
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exporttxtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private bool textAfisat = false; 

        private void btnVizualizeazaMeciuri_Click(object sender, EventArgs e)
        {
            if (textAfisat)
            {
                return; 
            }

            List<Meci> listaMeciuri = Meci.GetListaMeciuri(); 

            foreach (Meci meci in listaMeciuri)
            {
                string textMeci = $"{meci.Nume} - Data: {meci.Data.ToShortDateString()}";

                TreeNode nodMeci = new TreeNode(textMeci); 
                nodMeci.Tag = meci; 

                treeViewMeciuri.Nodes.Add(nodMeci);
            }

            textAfisat = true; 
        }

        private void btnPariaza_Click(object sender, EventArgs e)
        {
            Bet betForm = new Bet(); 
            betForm.Show();
        }

        private void treeViewMeciuri_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void serializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Meci> listaMeciuri = Meci.GetListaMeciuri(); 


            XmlSerializer serializer = new XmlSerializer(typeof(List<Meci>));

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere XML (*.xml)|*.xml";
            saveFileDialog.Title = "Salvare fișier XML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string numeFisier = saveFileDialog.FileName;

                using (FileStream fileStream = new FileStream(numeFisier, FileMode.Create))
                {
                    serializer.Serialize(fileStream, listaMeciuri);
                }

                MessageBox.Show("Serializare XML realizată cu succes!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deserializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere XML (*.xml)|*.xml";
            openFileDialog.Title = "Deschidere fișier XML";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string numeFisier = openFileDialog.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(List<Meci>));

                using (FileStream fileStream = new FileStream(numeFisier, FileMode.Open))
                {
                    List<Meci> listaMeciuri = (List<Meci>)serializer.Deserialize(fileStream);


                    MessageBox.Show("Deserializare XML realizată cu succes!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    treeViewMeciuri.Nodes.Clear(); 

                    foreach (Meci meci in listaMeciuri)
                    {
                        string textMeci = $"{meci.Nume} - Data: {meci.Data.ToShortDateString()}";

                        TreeNode nodMeci = new TreeNode(textMeci);
                        nodMeci.Tag = meci;

                        treeViewMeciuri.Nodes.Add(nodMeci);
                    }
                }
            }
        }

        private void salvaretxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere text (*.txt)|*.txt";
            saveFileDialog.Title = "Salvare fișier text";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string numeFisier = saveFileDialog.FileName;

                using (StreamWriter writer = new StreamWriter(numeFisier))
                {
                    foreach (TreeNode nodMeci in treeViewMeciuri.Nodes)
                    {
                        Meci meci = (Meci)nodMeci.Tag; 

                        string textMeci = $"{meci.Nume} - Data: {meci.Data.ToShortDateString()}";

                        writer.WriteLine(textMeci);
                    }
                }

                MessageBox.Show("Salvare în fișier text realizată cu succes!", "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            List<Meci> listaMeciuri = Meci.GetListaMeciuri();
            Font font = new Font("Arial", 12);

            int startX = 50;
            int startY = 50;
            int lineHeight = 20;

            foreach (Meci meci in listaMeciuri)
            {
                string detaliiMeci = $"{meci.Nume}, Data: {meci.Data.ToString("dd.MM.yyyy")}";
                graphics.DrawString(detaliiMeci, font, Brushes.Black, startX, startY);

                startY += lineHeight;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();

            document.PrintPage += Document_PrintPage;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = document;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }




        private void btnPreview_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();

            document.PrintPage += Document_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog();
            previewDialog.Document = document;

            previewDialog.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Graphics graphics = pictureBox.CreateGraphics();

            // Desenare linie oblica
            Point startPoint = new Point(10, pictureBox.Height - 10);
            Point endPoint = new Point(pictureBox.Width - 10, 10);
            graphics.DrawLine(Pens.Red, startPoint, endPoint);

            // Desenare sageata
            int arrowSize = 10;
            PointF[] arrowPoints = new PointF[]
            {
            new PointF(endPoint.X - arrowSize, endPoint.Y),
            new PointF(endPoint.X, endPoint.Y),
            new PointF(endPoint.X, endPoint.Y + arrowSize)
            };
            graphics.FillPolygon(Brushes.Red, arrowPoints);


            // Afisare text
            string text = "FCSB - Rapid Bucuresti";
            Font font = new Font("Arial", 8);
            SolidBrush brush = new SolidBrush(Color.Black);
            graphics.DrawString(text, font, brush, 10, 150);

            string text1 = "Rapid Bucuresti - Farul Constanta";
            Font font1 = new Font("Arial", 8);
            SolidBrush brush1 = new SolidBrush(Color.Black);
            graphics.DrawString(text1, font1, brush1, 30, 120);

            string text2 = "Argentina - Franta";
            Font font2 = new Font("Arial", 8);
            SolidBrush brush2 = new SolidBrush(Color.Black);
            graphics.DrawString(text2, font2, brush2, 120, 50);

            graphics.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGolesteTreeView_Click(object sender, EventArgs e)
        {
            treeViewMeciuri.Nodes.Clear();
        }
    }
}
