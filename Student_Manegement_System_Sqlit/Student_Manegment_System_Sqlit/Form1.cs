using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Student_Manegment_System_Sqlit
{
    public partial class Students : Form
    {
        private SQLiteConnection sqlconn;
        private SQLiteCommand sqlCmd;
        private DataTable sqlDT = new DataTable();
        private DataSet DS = new DataSet();
        private SQLiteDataAdapter DB;

        public Students()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void SetConnection()
        {
            sqlconn = new SQLiteConnection("Data Source = E:\\Software_Project\\C#\\Student_Manegement_System_Sqlit\\Student_Manegment_System_Sqlit\\bin\\Debug\\Student_Manegment_System.db");
        }



        private void ExecuteQuery(String StudentIDq)
        {
            SetConnection();
            sqlconn.Open();
            sqlCmd = sqlconn.CreateCommand();
            sqlCmd.CommandText = StudentIDq;
            sqlCmd.ExecuteNonQuery();
            sqlCmd.Dispose();
            sqlconn.Close();


        }

        private void LoadData()
        {
            SetConnection();
            sqlconn.Open();
            sqlCmd = sqlconn.CreateCommand();
            String CommandText = "SELECT * FROM students ";
            DB = new SQLiteDataAdapter(CommandText, sqlconn);
            DS.Reset();
            DB.Fill(DS);
            sqlDT=DS.Tables[0];
            DataGridView1.DataSource = sqlDT;
            sqlconn.Close();


        }

    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String StudentIDq = "DELET FROM students WHERE ID = id"+ SIdtext +  CCodecomboBox + FNamtext  + SNametext +  GendercomboBox +  Agetext +  PostCodetext +  Addresstext + Mobailtext + AddMathstext   + Mathstext + Businesstext  + Biologytext  + Chemistrytext + Computingtext +  Englishtext +Physicstext + TScoretext  + Averagetext + Rankingtext ;
            ExecuteQuery(StudentIDq);
            LoadData();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Exit Button Action
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit","Student Database",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Reset Button Action
        void ClearAllText(Control con)
        {
            foreach(Control c in con.Controls)
            {
                if (c is TextBox)

                {
                    ((TextBox)c).Clear();
                }
                else
                {
                    ClearAllText(c);
                }
            }

        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            CCodecomboBox.Text= "";
            GendercomboBox.Text = "";
            TranscriptTextBox.Text = "";

        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            int asciiCode = Convert.ToInt32(e.KeyChar);
            if ((asciiCode != 8))
            {
                if (asciiCode >=48 && asciiCode <= 75)
                {
                    e.Handled = false;

                }
                else
                {
                    MessageBox.Show("Number Only Please !", "Error:Number Only", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    e.Handled = true;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SIdtext.Text = DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CCodecomboBox.Text = DataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            AddMathstext .Text = DataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Mathstext.Text = DataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            Biologytext.Text = DataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            Businesstext.Text = DataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            Chemistrytext.Text = DataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            Computingtext.Text = DataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            Englishtext.Text = DataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            Physicstext.Text = DataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            TScoretext.Text = DataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            Averagetext.Text = DataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            Rankingtext.Text = DataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            
        }

        private void Transcriptbutton_Click(object sender, EventArgs e)
        {
            TranscriptTextBox.AppendText("Students ID :\t\t\t\t" + SIdtext.Text+"\n");
            TranscriptTextBox.AppendText("Name :\t\t\t\t" + FNamtext.Text +SNametext.Text + "\n");
            TranscriptTextBox.AppendText("Course Code :\t\t\t\t" + CCodecomboBox.Text + "\n");
            TranscriptTextBox.AppendText("Gender :\t\t\t\t" + GendercomboBox.Text + "\n");
            TranscriptTextBox.AppendText("Age :\t\t\t\t" + Agetext.Text + "\n");
            TranscriptTextBox.AppendText("Address :\t\t\t\t" + Addresstext.Text + "\n");
            TranscriptTextBox.AppendText("Add Maths:\t\t\t\t" + AddMathstext.Text + "\n");
            TranscriptTextBox.AppendText("Maths :\t\t\t\t" + Mathstext.Text + "\n");
            TranscriptTextBox.AppendText("Business :\t\t\t\t" + Businesstext.Text + "\n");
            TranscriptTextBox.AppendText("Biology :\t\t\t\t" + Biologytext.Text + "\n");
            TranscriptTextBox.AppendText("Chemistry:\t\t\t\t" + Chemistrytext.Text + "\n");
            TranscriptTextBox.AppendText("Computing :\t\t\t\t" +Computingtext.Text + "\n");
            TranscriptTextBox.AppendText("English :\t\t\t\t" + Englishtext.Text + "\n");
            TranscriptTextBox.AppendText("Physics :\t\t\t\t" + Physicstext.Text + "\n");
            TranscriptTextBox.AppendText("Total Score :\t\t\t\t" + TScoretext.Text + "\n");
            TranscriptTextBox.AppendText("Average:\t\t\t\t" + Averagetext.Text + "\n");
            TranscriptTextBox.AppendText("Ranking:\t\t\t\t" + Rankingtext.Text + "\n");
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
           
           String StudentIDq = "INSERT INTO students( Student_Id,Course - Code,FNam,SName,Gender,Age,PostCode,Address,Mobail,AddMaths,Maths,Business,"+
                "Biology,Chemistry,Computing,English,Physics,TotalScore,Average,"+
                "Ranking) VALUES('"+ SIdtext + "','" + CCodecomboBox + "','" + FNamtext + "','"+SNametext+"','"+ GendercomboBox + "','"
                +Agetext+"','"+PostCodetext+"','"+Addresstext+"','"+Mobailtext+"','"+AddMathstext+"','"
                +Mathstext+"','" + Businesstext + "','"+ Biologytext+ "','"+ Chemistrytext+ "','"+ Computingtext+ "','"+ Englishtext+ "','"
                + Physicstext+ "','"+TScoretext+"','"+Averagetext+"','"+Rankingtext+"')  ";

            ExecuteQuery(StudentIDq);
            LoadData();


        }

        Bitmap bitmap;
        private void Printbutton_Click(object sender, EventArgs e)
        {

            int height = DataGridView1.Height;
            DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(DataGridView1.Width, DataGridView1.Height);
            DataGridView1.DrawToBitmap(bitmap,new Rectangle(0,0, DataGridView1.Width, DataGridView1.Height) );
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            DataGridView1.Height = height;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DialogResult iPrint;
            iPrint = MessageBox.Show("Confirm if you want to print transcript Or print DataGridView ", "Student Result", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (iPrint == DialogResult.Yes)
            {
                e.Graphics.DrawString(TranscriptTextBox.Text, new Font("Harlow Solid", 14, FontStyle.Regular), Brushes.Black, new Point(0,0));
            }
            else
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }

        }

        private void SResultbutton_Click(object sender, EventArgs e)
        {
            if (AddMathstext.Text == "")
            {
                AddMathstext.Text = "0";
            }
            if (Mathstext.Text == "")
            {
                Mathstext.Text = "0";
            }
            if (Businesstext.Text == "")
            {
                Businesstext.Text = "0";
            }
            if (Biologytext.Text == "")
            {
                Biologytext.Text = "0";
            }
            if (Chemistrytext.Text == "")
            {
                Chemistrytext.Text = "0";
            }
            if (Computingtext.Text == "")
            {
                Computingtext.Text = "";
            }
            if (Englishtext.Text == "")
            {
                Englishtext.Text = "0";
            }
            if (Physicstext.Text == "") ;
            {
                Physicstext.Text = "0";
            }

            int[] R = new int[15];
            R[0] = Convert.ToInt32(AddMathstext.Text);
            R[1] = Convert.ToInt32(Mathstext.Text);
            R[2] = Convert.ToInt32(Businesstext.Text);
            R[3] = Convert.ToInt32(Biologytext.Text);
            R[4] = Convert.ToInt32(Chemistrytext.Text);
            R[5] = Convert.ToInt32(Computingtext.Text);
            R[6] = Convert.ToInt32(Englishtext.Text);
            R[7] = Convert.ToInt32(Physicstext.Text);

            R[8] = (R[0]+ R[1]+ R[2]+ R[3]+ R[4]+ R[5]+ R[6]+ R[7])/8;
            R[9] = (R[0]+ R[1]+ R[2]+ R[3]+ R[4]+ R[5]+ R[6]+ R[7]);
            Averagetext.Text = Convert.ToString(R[8]);
            TScoretext.Text = Convert.ToString(R[9]);
            if (R[9] >= 700)
            {
                Rankingtext.Text = ("1st");
            }
            else if (R[9] >= 600)
            {
                Rankingtext.Text = ("2i");
            }
            else if (R[9] >= 500)
            {
                Rankingtext.Text = ("2ii");
            }
            else if (R[9] >= 400)
            {
                Rankingtext.Text = ("3rd");
            }
            else if (R[9] >= 300)
            {
                Rankingtext.Text = ("Cohe");
            }
            else if (R[9] < 200)
            {
                Rankingtext.Text = ("Fail");
            }
        }
    }
}
