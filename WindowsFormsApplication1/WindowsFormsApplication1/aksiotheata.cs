using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class aksiotheata : Form
    {
        public static int aks = 0;
        string connectionstring = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = Database1.mdb";
        OleDbConnection conn;
        public aksiotheata()
        {
            InitializeComponent();
            this.Text = "Αξιοθέατα";

            conn = new OleDbConnection(connectionstring);

            if (music.medplay == true)
            {
                button4.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button4.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.paliapoli_pli == true)
            {
                button5.BackColor = Color.LightGreen;
            }
            if(history.paliapoli_sxo == true)
            {
                button9.BackColor = Color.LightGreen;
            }
            if(history.enidrio_pli == true)
            {
                button6.BackColor = Color.LightGreen;
            }
            if (history.enidrio_sxo == true)
            {
                button10.BackColor = Color.LightGreen;
            }
            if(history.akropoli_pli  == true)
            {
                button7.BackColor = Color.LightGreen;
            }
            if(history.akropoli_sxo == true)
            {
                button11.BackColor = Color.LightGreen;
            }
            if(history.petaloudes_pli == true)
            {
                button8.BackColor = Color.LightGreen;
            }
            if(history.petaloudes_sxo == true)
            {
                button12.BackColor = Color.LightGreen;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void σχετικαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Τουριστικός Οδηγός Ρόδου\nΈκδοση: 1.0\nΑνάπτυξη:\nΚιτσούλης Ευάγγελος\nΠοσνακίδης Ηρακλής");
        }

        private void έξοδοςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void σχόλιαToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        //music control
        private void button4_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button4.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button4.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private int imageNumber = 1;

        private void loadNextImage1()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            loadNextImage.ImageLocation = string.Format(@"../../rodos_images/palia_poli/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void loadNextImage2()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"../../rodos_images/enidrio/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void loadNextImage3()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"../../rodos_images/akropoli/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void loadNextImage4()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox3.ImageLocation = string.Format(@"../../rodos_images/petaloudes/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage1();
            loadNextImage2();
            loadNextImage3();
            loadNextImage4();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history.paliapoli_pli = true;
            this.Hide();
            paliapoli pal = new paliapoli();
            pal.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            history.enidrio_pli = true;
            this.Hide();
            enidrio en = new enidrio();
            en.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            history.petaloudes_pli = true;
            this.Hide();
            petaloudes pet = new petaloudes();
            pet.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            history.akropoli_pli = true;
            this.Hide();
            akropoli akr = new akropoli();
            akr.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void εμφάνισηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Form1.user == true)
            {
                this.Hide();
                emfanisi emf = new emfanisi();
                emf.ShowDialog();
            }
            else
            {
                MessageBox.Show("Για αυτή τη λειτουργία, θα πρέπει να εισέλθετε ως χρήστης.");
            }
            
        }

        //history clearing
        private void button13_Click(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            history.aksiotheata = false;
            button9.BackColor = SystemColors.Control;
            button9.UseVisualStyleBackColor = true;
            history.paralies = false;
            button6.BackColor = SystemColors.Control;
            button6.UseVisualStyleBackColor = true;
            history.estiatoria = false;
            button10.BackColor = SystemColors.Control;
            button10.UseVisualStyleBackColor = true;
            history.ekdiloseis = false;
            button7.BackColor = SystemColors.Control;
            button7.UseVisualStyleBackColor = true;
            history.aksiotheata = false;
            button11.BackColor = SystemColors.Control;
            button11.UseVisualStyleBackColor = true;
            history.paralies = false;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            history.estiatoria = false;
            button12.BackColor = SystemColors.Control;
            button12.UseVisualStyleBackColor = true;
            history.ekdiloseis = false;
        }
    }
}
