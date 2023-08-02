using PROIECT_PAW.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace PROIECT_PAW
{
    public partial class Bet : Form
    {
        private Utilizator utilizator; 

        public Bet()
        {
            InitializeComponent();
            utilizator = new Utilizator(); 
            this.Load += Bet_Load;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bet_KeyDown);
            toolStripStatusLabel1.Click += new EventHandler(toolStripStatusLabel1_Click);

            ButonReutilizabil butonReutilizabil = new ButonReutilizabil();
            butonReutilizabil.Location = new Point(10, 10);
            Controls.Add(butonReutilizabil);

        }

        private float soldIntrodus = 0;

        private void lblSoldUtilizator_Click(object sender, EventArgs e)
        {
            float sumaSolduri = 0;

            sumaSolduri += utilizator.GetSold();

            sumaSolduri += soldIntrodus;

            lblSoldUtilizator.Text = "Sold: " + sumaSolduri.ToString("0.00"); 
        }

        private List<Meci> GetMeciuriDisponibile()
        {
            List<Meci> listaMeciuri = new List<Meci>();

            listaMeciuri.Add(new Meci { Nume = "Rapid Bucuresti - Universitatea Craiova", Data = new DateTime(2023, 6, 14) });
            listaMeciuri.Add(new Meci { Nume = "Farul Constanta - Universitatea Craiova", Data = new DateTime(2023, 6, 15) });
            listaMeciuri.Add(new Meci { Nume = "Rapid Bucuresti - Farul Constanta", Data = new DateTime(2023, 6, 16) });
            listaMeciuri.Add(new Meci { Nume = "FCSB - Rapid Bucuresti", Data = new DateTime(2023, 6, 17) });

            return listaMeciuri;
        }


        private void Bet_Load(object sender, EventArgs e)
        {
            List<Meci> listaMeciuriDisponibile = GetMeciuriDisponibile();

            foreach (Meci meci in listaMeciuriDisponibile)
            {
                comboBoxMeciuri.Items.Add(meci); 
            }

            string[] optiuniSumaBani = { "10", "50", "100", "200","500" };

            comboBoxSumaBani.Items.AddRange(optiuniSumaBani);

            comboBoxSumaBani.SelectedIndexChanged += comboBoxSumaBani_SelectedIndexChanged;



            txtNume.KeyPress += new KeyPressEventHandler(txtNume_KeyPress);
            txtNume.Validating += new CancelEventHandler(txtNume_Validating);
            txtNume.Validated += new EventHandler(txtNume_Validated);

        }
        

        private void comboBoxSumaBani_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sumaSelectata = comboBoxSumaBani.SelectedItem.ToString();
        }
       

        private void comboBoxMeciuri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMeciuri.SelectedItem != null)
            {
                Meci meciSelectat = comboBoxMeciuri.SelectedItem as Meci;
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un meci.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInregistrarePariu_Click(object sender, EventArgs e)
        {
            if (comboBoxMeciuri.SelectedItem != null)
            {
                Meci meciSelectat = comboBoxMeciuri.SelectedItem as Meci;

                if (comboBoxSumaBani.SelectedItem != null)
                {
                    string sumaSelectata = comboBoxSumaBani.SelectedItem.ToString();

                    if (float.TryParse(sumaSelectata, out float sumaBani))
                    {
                        if (sumaBani <= utilizator.GetSold())
                        {
                            utilizator.ScadeSold(sumaBani);

                            lblSoldUtilizator.Text = "Sold: " + utilizator.GetSold().ToString("0.00");

                            MessageBox.Show("Pariul a fost înregistrat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Suma de bani pariata depaseste soldul disponibil.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vă rugăm să selectați o sumă de bani validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vă rugăm să selectați o sumă de bani.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vă rugăm să selectați un meci.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButtonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        

        private void Bet_Load_1(object sender, EventArgs e)
        {

        }

        //CTRL+P PENTRU ADAUGAREA UNUI PARIU
        private void Bet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.P) 
            {
                
                e.Handled = true; 
                if (comboBoxMeciuri.SelectedItem != null)
                {
                    Meci meciSelectat = comboBoxMeciuri.SelectedItem as Meci;

                    if (comboBoxSumaBani.SelectedItem != null)
                    {
                        string sumaSelectata = comboBoxSumaBani.SelectedItem.ToString();

                        if (float.TryParse(sumaSelectata, out float sumaBani))
                        {
                            if (sumaBani <= utilizator.GetSold())
                            {
                                utilizator.ScadeSold(sumaBani);

                                lblSoldUtilizator.Text = "Sold: " + utilizator.GetSold().ToString("0.00");

                                MessageBox.Show("Pariul a fost înregistrat cu succes.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Suma de bani pariata depaseste soldul disponibil.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vă rugăm să selectați o sumă de bani validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vă rugăm să selectați o sumă de bani.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vă rugăm să selectați un meci.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


   

        private void txtNume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Se pot introduce doar litere și spații. Caracterele non-litere și non-spații nu sunt permise.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //VALIDATING
        private void txtNume_Validating(object sender, CancelEventArgs e)
        {
            string textIntrodus = txtNume.Text.Trim();

            // Verificarea conditiilor de validare (de exemplu, numar minim de caractere)
            if (string.IsNullOrEmpty(textIntrodus) || textIntrodus.Length < 3)
            {
                e.Cancel = true; 
                errorProvider.SetError(txtNume, "Numele trebuie să conțină cel puțin 3 caractere!"); 
            }
            else
            {
                errorProvider.SetError(txtNume, ""); 
            }
        }


        private void txtNume_Validated(object sender, EventArgs e)
        {
        }


        //ERROR PROVIDER

        private void txtSold_TextChanged(object sender, EventArgs e)
        {
            string textIntrodus = txtSold.Text;

            string textDoarNumere = new string(textIntrodus.Where(c => char.IsDigit(c) || c == '.').ToArray());

            if (textIntrodus != textDoarNumere)
            {
                MessageBox.Show("Se pot introduce doar numere (daca sunt numere cu zecimale, acestea vor fi separate prin punct). Caracterele nepermise vor fi eliminate.", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtSold.Text = textDoarNumere;

            if (string.IsNullOrEmpty(textDoarNumere))
            {
                errorProviderSold.SetError(txtSold, "Introduceți un sold!"); 
            }
            else
            {
                errorProviderSold.SetError(txtSold, "");

                if (float.TryParse(textDoarNumere, out float sold) && sold <= 0)
                {
                    errorProviderSold.SetError(txtSold, "Soldul trebuie să fie mai mare decât 0!"); 
                }
                else
                {
                    errorProviderSold.SetError(txtSold, "");

                    if (float.TryParse(textDoarNumere, out sold))
                    {
                        utilizator.Sold = sold;
                    }
                }
            }
        }


        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            string textIntrodus = txtId.Text;

            string textDoarNumere = new string(textIntrodus.Where(char.IsDigit).ToArray());

            if (textIntrodus != textDoarNumere)
            {
                MessageBox.Show("Se pot introduce doar numere naturale!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtId.Text = textDoarNumere;
        }



        private void AdaugaSoldLaSoldExistent(float soldAdaugat)
        {
            float soldCurent = utilizator.GetSold();

            float soldActualizat = soldCurent + soldAdaugat;

            utilizator.Sold = soldActualizat;

            float sumaSolduri = soldActualizat;
            lblSoldUtilizator.Text = "Sold: " + sumaSolduri.ToString("0.00");
        }

        private void btnIntroducereSold_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nume = txtNume.Text;
            float sold = float.Parse(txtSold.Text);

            string userInfo = "ID: " + id + Environment.NewLine;
            userInfo += "Nume: " + nume + Environment.NewLine;
            userInfo += "Sold: " + sold.ToString("0.00") + Environment.NewLine;
            if (string.IsNullOrEmpty(txtSold.Text))
            {
                MessageBox.Show("Introduceți un sold!", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float soldIntrodus;
            if (!float.TryParse(txtSold.Text, out soldIntrodus))
            {
                MessageBox.Show("Introduceți o valoare numerică validă pentru sold!", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            AdaugaSoldLaSoldExistent(soldIntrodus);

            MessageBox.Show("Soldul a fost adăugat cu succes la soldul existent.", "Adăugare sold", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string folderPath = "PROIECT PAW";
            string fileName = "fisier_user.txt";
            string filePath = Path.Combine(folderPath, fileName);

            try
            {
                string absoluteFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, folderPath);

                if (!Directory.Exists(absoluteFolderPath))
                {
                    Directory.CreateDirectory(absoluteFolderPath);
                }

                string absoluteFilePath = Path.Combine(absoluteFolderPath, fileName);

                using (StreamWriter file = new StreamWriter(absoluteFilePath))
                {
                    file.WriteLine(userInfo);
                }

                MessageBox.Show("Informațiile utilizatorului au fost salvate în " + absoluteFilePath + ".", "Salvare reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la salvarea fișierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            TreeNode newNode = new TreeNode();
            newNode.Text = "ID: " + id;

            TreeNode numeNode = new TreeNode("Nume: " + nume);
            TreeNode soldNode = new TreeNode("Sold: " + sold.ToString("0.00"));

            newNode.Nodes.Add(numeNode);
            newNode.Nodes.Add(soldNode);

            treeView1.Nodes.Add(newNode);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Items.Clear();

            ToolStripMenuItem menuItemText = new ToolStripMenuItem("Afișează text");

            menuItemText.Click += menuItemText_Click;

            contextMenuStrip1.Items.Add(menuItemText);
        }
        private void menuItemText_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mult noroc, poate poate!!!", "Mesaj de incurajare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

     

        private void toolStripBttnDelete_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.SelectedNode.Remove();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            float soldUtilizator = utilizator.GetSold();

            toolStripStatusLabel1.Text = "Sold: " + soldUtilizator.ToString("0.00");

        }



    }
}
