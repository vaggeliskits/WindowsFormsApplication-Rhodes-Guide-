using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class paralies : Form
    {
        public static int par = 0;
        public paralies()
        {
            InitializeComponent();
            this.Text = "Παραλίες";

            if (music.medplay == true)
            {
                button2.BackgroundImage = Properties.Resources.music_on;
            }
            else if (music.medplay == false)
            {
                button2.BackgroundImage = Properties.Resources.music_off;
            }

            //history control
            if (history.kalithea_pli == true)
            {
                button5.BackColor = Color.LightGreen;
            }
            if(history.kalithea_sxo == true)
            {
                button6.BackColor = Color.LightGreen;
            }
            if(history.faliraki_pli == true)
            {
                button7.BackColor = Color.LightGreen;
            }
            if(history.faliraki_sxo == true)
            {
                button8.BackColor = Color.LightGreen;
            }
            if(history.antoni_pli == true)
            {
                button9.BackColor = Color.LightGreen;
            }
            if(history.antoni_sxo == true)
            {
                button10.BackColor = Color.LightGreen;
            }
            if(history.tsampika_pli == true)
            {
                button11.BackColor = Color.LightGreen;
            }
            if(history.tsampika_sxo == true)
            {
                button12.BackColor = Color.LightGreen;
            }
        }

        private void αρχικήΣελίδαToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void σχετικάToolStripMenuItem_Click(object sender, EventArgs e)
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

        private int imageNumber = 1;
        private void loadNextImage1()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"../../rodos_images/paralies/kalithea/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void loadNextImage2()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox2.ImageLocation = string.Format(@"../../rodos_images/paralies/faliraki/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void loadNextImage3()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox3.ImageLocation = string.Format(@"../../rodos_images/paralies/antoni/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void loadNextImage4()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            pictureBox4.ImageLocation = string.Format(@"../../rodos_images/paralies/tsampika/logo{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage1();
            loadNextImage2();
            loadNextImage3();
            loadNextImage4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        //music control
        private void button2_Click(object sender, EventArgs e)
        {
            if (music.medplay == true)
            {
                music.SoundPlayerInstance.Stop();
                music.medplay = false;
                button2.BackgroundImage = Properties.Resources.music_off;
            }
            else
            {
                music.SoundPlayerInstance.Play();
                music.medplay = true;
                button2.BackgroundImage = Properties.Resources.music_on;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Είστε σίγουροι πως θέλετε να κλείσετε την εφαρμογή;", "Έξοδος", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            history.tsampika_pli = true;
            this.Hide();
            tsampika ts = new tsampika();
            ts.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            history.kalithea_pli = true;
            this.Hide();
            kalithea kal = new kalithea();
            kal.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            history.faliraki_pli = true;
            this.Hide();
            faliraki fal = new faliraki();
            fal.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            history.antoni_pli = true;
            this.Hide();
            antoni ant = new antoni();
            ant.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void εμφάνισηToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Form1.user == true)
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

        //clearing history
        private void button13_Click(object sender, EventArgs e)
        {
            button5.BackColor = SystemColors.Control;
            button5.UseVisualStyleBackColor = true;
            history.kalithea_pli= false;
            button6.BackColor = SystemColors.Control;
            button6.UseVisualStyleBackColor = true;
            history.kalithea_sxo = false;
            button7.BackColor = SystemColors.Control;
            button7.UseVisualStyleBackColor = true;
            history.faliraki_pli = false;
            button8.BackColor = SystemColors.Control;
            button8.UseVisualStyleBackColor = true;
            history.faliraki_sxo = false;
            button9.BackColor = SystemColors.Control;
            button9.UseVisualStyleBackColor = true;
            history.antoni_pli = false;
            button10.BackColor = SystemColors.Control;
            button10.UseVisualStyleBackColor = true;
            history.antoni_sxo = false;
            button11.BackColor = SystemColors.Control;
            button11.UseVisualStyleBackColor = true;
            history.tsampika_pli = false;
            button12.BackColor = SystemColors.Control;
            button12.UseVisualStyleBackColor = true;
            history.tsampika_sxo = false;
        }
    }
}
