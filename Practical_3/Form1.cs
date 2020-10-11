using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Practical_3
{
    public partial class frmPuzzle : Form
    {
        int iBlank, iMoves = 0;
        List<Bitmap> lstPartsOfOriginal = new List<Bitmap>();
        public frmPuzzle()
        {
            InitializeComponent();
            lstPartsOfOriginal.AddRange(new Bitmap[] { Properties.Resources._1, 
                Properties.Resources._2, Properties.Resources._3, 
                Properties.Resources._4, Properties.Resources._5, Properties.Resources._6, 
                Properties.Resources._7, Properties.Resources._8, Properties.Resources._9, 
                Properties.Resources._null });
            lblMoves.Text += iMoves;
        }

        //method to shuffle the parts randomly
        void ShuffleThePictures()
        {
            do
            {
                int j;
                //remove number 8 in the list, due to it being the piece left out
                List<int> Nodes = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 9 });
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Nodes.Remove((j = Nodes[r.Next(0, Nodes.Count)]));
                    ((PictureBox)gbPuzzle.Controls[i]).Image = lstPartsOfOriginal[j];
                    if (j == 9)
                        iBlank = i;
                }
            } while (Check_if_Won());
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            iMoves = 0;
            lblMoves.Text = "0";
            ShuffleThePictures();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShuffleThePictures();
        }
        //check if the person won and returns true or false, by comparing the part sequence to the original list
        bool Check_if_Won()
        {
            int i;
            for (i = 0; i < 8; i++)
            {
                if ((gbPuzzle.Controls[i] as PictureBox).Image != lstPartsOfOriginal[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

        //loads a csv file with a range to place the parts in a specific order
        private void btnLoad_Click(object sender, EventArgs e)
        {
            iMoves = 0;
            lblMoves.Text = "0";
            string filename;
            string[] arrVal = new string[9];
            try
            {
                openFileDialog1.Filter = "CSV files(*.csv)| *.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    
                    using (var reader = new StreamReader(@filename))
                    {
                        while (!reader.EndOfStream)
                        {
                            var line = reader.ReadLine();
                            var value = line.Split(',');
                            for (int i = 0; i < 9; i++)
                            {
                                arrVal[i] = value[i];
                            }
                        }
                    }

                    int j;
                    for (int i = 0; i < 9; i++)
                    {
                        j = Convert.ToInt32(arrVal[i]);
                        ((PictureBox)gbPuzzle.Controls[i]).Image = lstPartsOfOriginal[j];
                        if (j == 9)
                            iBlank = i;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong" + ex);
            }


        }
       //method to move the piece of the picture that is clicked on into the blank space,if it is a piece next to said space 
        private void SwitchPictureBox(object sender, EventArgs e)
        {
            int iCurrentPosition = gbPuzzle.Controls.IndexOf(sender as Control);
            if (iBlank != iCurrentPosition)
            {
                List<int> PossibleMoves = new List<int>(new int[] { ((iCurrentPosition % 3 == 0) ? -1 : iCurrentPosition - 1), 
                    iCurrentPosition - 3,
                    (iCurrentPosition % 3 == 2) ? -1 : iCurrentPosition + 1,
                    iCurrentPosition + 3 });

                if (PossibleMoves.Contains(iBlank))
                {
                    //This only works is you dont move the pictureboxes in the groupbox, otherwise you need to change the control in the design view
                    ((PictureBox)gbPuzzle.Controls[iBlank]).Image = ((PictureBox)gbPuzzle.Controls[iCurrentPosition]).Image;
                    ((PictureBox)gbPuzzle.Controls[iCurrentPosition]).Image = lstPartsOfOriginal[9];
                    iBlank = iCurrentPosition;
                    lblMoves.Text = " " + (++iMoves);
                    if (Check_if_Won())
                    {
                        (gbPuzzle.Controls[8] as PictureBox).Image = lstPartsOfOriginal[8];
                        MessageBox.Show("Congratulations!!\nYou made an Elephant " + 
                            "\nTotal Moves Made : " + iMoves, "Elephant Completed");
                        iMoves = 0;
                        lblMoves.Text = "0";
                        ShuffleThePictures();
                    }
                }
            }
        }

    }
}
