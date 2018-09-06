using System;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Generator_Lokalizacji
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void btnZamknij_Click(object sender, EventArgs e)
        {


            // koniec pracy

            this.Close();

        }

        private void btnDrukuj_Click(object sender, EventArgs e)
        {


            int rodzaj = 0;
            int ilosc_kopii = 0;
            string ZPLString = "";
            string Drukarka = "";
       
            string plik = Path.Combine(Path.GetTempPath(), "etykiety.txt");


            Drukarka = cboDrukarki.Text;

            if (cboDrukarki.Text == "")

            {

                txtStatus.Text = "Nie wybrano drukarki!";
                MessageBox.Show("Nie wybrano drukarki!");
            }


            else

            {
                txtStatus.Text = "Drukarka: " + Drukarka;

//            MessageBox.Show(plik);

            

            // wybieranie rodzaju naklejek

            if (rdoRegaly.Checked)
            {
                rodzaj = 1;
                ilosc_kopii = 1;

            }


            if (rdoPodloga.Checked)
            {
                rodzaj = 2;
                ilosc_kopii = 1;

            }


            if (rdoKoszyki.Checked)
            {
                rodzaj = 3;
                ilosc_kopii = Convert.ToInt16(cboIleNaKoszyk.SelectedItem.ToString());

            }

            


            FileStream fs = new FileStream(plik, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);






            for (int i= 0; i< txtData.Lines.Length; i++ )

            {


                switch (rodzaj)

                {

                    case 1:

                        // naklejki na półki

                        ZPLString =
                        "^XA" +
                        "^FO10,10^BY3^A0N,90,70" +
                        "^BCN,90,Y,N,Y" +
                        "^FD" + txtData.Lines[i] + "^FS" +
                        "^XZ";

                        break;


                    case 2:

                        // naklejki na podłogę

                        ZPLString =
                        "^XA" +
                        "^FO5,25^BY4^A0N,120,70" +
                        "^BCN,250,Y,N,Y" +
                        "^FD" + txtData.Lines[i] + "^FS" +
                        "^XZ";

                        break;


                    case 3:

                        // naklejki na koszyk

                        ZPLString =
                        "^XA" +
                        "^FO5,25^BY4^A0N,120,70" +
                        "^BCN,250,Y,N,Y" +
                        "^FD" + txtData.Lines[i] + "^FS" +
                        "^XZ";

                        break;

                }



                try
                {
                    

 
                    for (int j = 1; j <= ilosc_kopii; j++)
                    {


                        sw.WriteLine(ZPLString);
                        

                    }

                                     
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            sw.Close();
            fs.Close();



            System.IO.File.Move(plik, Drukarka);

            MessageBox.Show("Drukowanie zakończone.");
            }


        }



        private void cboIleNaKoszyk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


          
            string Drukarka = cboDrukarki.Text;

            if (cboDrukarki.Text == "")

            {

                txtStatus.Text = "Nie wybrano drukarki!";

            }

            else

            {
                txtStatus.Text = "Drukarka: " + cboDrukarki.Text;
            }



        }

        private void btnNew_Click(object sender, EventArgs e)
        {

            txtData.Text = "";

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {


            MessageBox.Show("Wersja: " + Application.ProductVersion);


        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

            openFileDialog.Filter = "Plik tekstowy|*.txt";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog.FileName);
                txtData.Text =  sr.ReadToEnd();
                sr.Close();
            }




        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            saveFileDialog.Filter = "Plik tekstowy|*.txt";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

    
                File.WriteAllText(saveFileDialog.FileName, txtData.Text);
                
    
            }


        }

        private void cboDrukarki_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtStatus.Text = "Drukarka: " + cboDrukarki.Text;

        }
    }
    


}
