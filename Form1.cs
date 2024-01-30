using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Proffsen_Utility_Tool
{


    public partial class checkBoxBotten : Form
    {

        int newPiece = 0;
        public checkBoxBotten()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            MyMath calculation = new MyMath();
            if (newPiece == 1)
            {
                try
                {
                    double text1 = Convert.ToDouble(textBox1.Text);
                    double text2 = Convert.ToDouble(textBox2.Text);
                    double text3 = Convert.ToDouble(textBox3.Text);
                    var pieceDetails = new List<string>();

                    bool box1;
                    if (checkBoxPG.Checked)
                    {
                        box1 = true;
                    }
                    else
                        box1 = false;
                    bool box2;
                    if (checkBoxPG2.Checked)
                    {
                        box2 = true;
                    }
                    else
                        box2 = false;
                    if (text1 > 0.0 && text2 > 0.0 && text3 > 0.0)
                    {
                        sqMeterTextBox.Text = Convert.ToString(calculation.rkSqMeters(text1, text2, text3, box1, box2));
                        textBox4.Text = Convert.ToString(calculation.rkPris(text1, text2, text3, box1, box2));
                        totalPriceText.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(QtyBox.Text));
                        totalsqmeters.Text = Convert.ToString(Convert.ToDouble(sqMeterTextBox.Text) * Convert.ToDouble(QtyBox.Text));
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Value(Check zero's");
                    }
                }
                catch (Exception) { MessageBox.Show("InvalidFormat: Look what you have inserted"); }
            }
            else if (newPiece == 2)
            {
                try
                {

                    double text1 = Convert.ToDouble(textBox1.Text);
                    double text2 = Convert.ToDouble(textBox2.Text);
                    double radius = Convert.ToDouble(radie.Text);
                    double secondRadius = Convert.ToDouble(radie2.Text);

                    bool box1;
                    if (checkBoxPG.Checked)
                    {
                        box1 = true;
                    }
                    else
                        box1 = false;
                    bool box2;
                    if (checkBoxPG2.Checked)
                    {
                        box2 = true;
                    }
                    else
                        box2 = false;

                    bool radieBox;
                    if (sameRadieBox.Checked)
                    {
                        radieBox = true;
                    }
                    else
                        radieBox = false;

                    if (text1 > 0.0 && text2 > 0.0 && radius > 0.0)
                    {
                        textBox4.Text = Convert.ToString(calculation.nittiBoj(text1, text2, radius, secondRadius, box1, box2, radieBox));
                        sqMeterTextBox.Text = Convert.ToString(calculation.sqmNittiBoj(text1, text2, radius, secondRadius, box1, box2, radieBox));
                        totalPriceText.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(QtyBox.Text));
                        totalsqmeters.Text = Convert.ToString(Convert.ToDouble(sqMeterTextBox.Text) * Convert.ToDouble(QtyBox.Text));
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Value(Check zero's");
                    }
                }
                catch (Exception) { MessageBox.Show("InvalidFormat: Look what you have inserted"); }
            }
            else if (newPiece == 3)
            {
                try
                {
                    double text1 = Convert.ToDouble(textBox1.Text);
                    double text2 = Convert.ToDouble(textBox2.Text);
                    double radius = Convert.ToDouble(radie.Text);
                    double secondRadius = Convert.ToDouble(radie2.Text);

                    bool box1;
                    if (checkBoxPG.Checked)
                    {
                        box1 = true;
                    }
                    else
                        box1 = false;
                    bool box2;
                    if (checkBoxPG2.Checked)
                    {
                        box2 = true;
                    }
                    else
                        box2 = false;

                    bool radieBox;
                    if (sameRadieBox.Checked)
                    {
                        radieBox = true;
                    }
                    else
                        radieBox = false;

                    if (text1 > 0.0 && text2 > 0.0 && radius > 0.0)
                    {
                        textBox4.Text = Convert.ToString(calculation.fortiFemBoj(text1, text2, radius, secondRadius, box1, box2, radieBox));
                        sqMeterTextBox.Text = Convert.ToString(calculation.sqmFortiFemBoj(text1, text2, radius, secondRadius, box1, box2, radieBox));
                        totalPriceText.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(QtyBox.Text));
                        totalsqmeters.Text = Convert.ToString(Convert.ToDouble(sqMeterTextBox.Text) * Convert.ToDouble(QtyBox.Text));
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Value(Check zero's");
                    }
                }
                catch (Exception) { MessageBox.Show("InvalidFormat: Look what you have inserted"); }
            }
            else if (newPiece == 4)
            {
                try
                {
                    double text1 = Convert.ToDouble(textBox1.Text);
                    double text2 = Convert.ToDouble(textBox2.Text);
                    double text3 = Convert.ToDouble(textBox3.Text);
                    var pieceDetails = new List<string>();

                    bool box1;
                    if (checkBoxPG.Checked)
                    {
                        box1 = true;
                    }
                    else
                        box1 = false;
                    bool box2;
                    if (checkBoxPG2.Checked)
                    {
                        box2 = true;
                    }
                    else
                        box2 = false;
                    if (text1 > 0.0 && text2 > 0.0 && text3 > 0.0)
                    {
                        sqMeterTextBox.Text = Convert.ToString(calculation.rkSqMeters(text1, text2, text3, box1, box2));
                        textBox4.Text = Convert.ToString((calculation.rkPris(text1, text2, text3, box1, box2) + 460.0));
                        totalPriceText.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(QtyBox.Text));
                        totalsqmeters.Text = Convert.ToString(Convert.ToDouble(sqMeterTextBox.Text) * Convert.ToDouble(QtyBox.Text));
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Value(Check zero's");
                    }
                }
                catch (Exception) { MessageBox.Show("InvalidFormat: Look what you have inserted"); }
            }
            else if (newPiece == 5)
            {
                try
                {
                    double text1 = Convert.ToDouble(textBox1.Text);
                    double text2 = Convert.ToDouble(textBox2.Text);
                    double text3 = Convert.ToDouble(textBox3.Text);
                    double dimX = Convert.ToDouble(DimX.Text);
                    double dimY = Convert.ToDouble(DimY.Text);
                    var pieceDetails = new List<string>();

                    bool box1;
                    if (checkBoxPG.Checked)
                    {
                        box1 = true;
                    }
                    else
                        box1 = false;
                    bool box2;
                    if (checkBoxPG2.Checked)
                    {
                        box2 = true;
                    }
                    else
                        box2 = false;
                    bool centered;
                    if(centeredOrGrad.Checked) { centered = true; }
                    else { centered = false; }


                    if (text1 > 0.0 && text2 > 0.0 && text3 > 0.0)
                    {
                        sqMeterTextBox.Text = Convert.ToString(calculation.sqmDim(text1, text2, text3, dimX, dimY, box1, box2));
                        textBox4.Text = Convert.ToString((calculation.dimPris(text1, text2, text3, dimX, dimY, box1, box2, centered)));
                        totalPriceText.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * Convert.ToDouble(QtyBox.Text));
                        totalsqmeters.Text = Convert.ToString(Convert.ToDouble(sqMeterTextBox.Text) * Convert.ToDouble(QtyBox.Text));
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Value(Check zero's");
                    }
                }
                catch (Exception) { MessageBox.Show("InvalidFormat: Look what you have inserted"); }
            }
            else MessageBox.Show("Välj en typ av produkt");
        }

        public void checkBoxPG_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void button10_Click(object sender, EventArgs e)
        {
            AdditionalLogic logic = new AdditionalLogic();

            string x = textBox1.Text;
            string y = textBox2.Text;
            string l = textBox3.Text;
            string r = radie.Text;
            string secondaryR = radie2.Text;
            string dimx = DimX.Text;
            string dimy = DimY.Text;
            bool firstEndLocked = checkBoxPG.Checked;
            bool secondEndLocked = checkBoxPG.Checked;
            bool cOG = centeredOrGrad.Checked;
            string qty = QtyBox.Text;
            string totalPrice = totalPriceText.Text;
            string pricePerPiece = textBox4.Text;
            string totalSquareMeters = totalsqmeters.Text;
            string squareMetersPerPiece = sqMeterTextBox.Text;

            
            Items piece1 = new Items(x, y,l,r,dimx,dimy,firstEndLocked,secondEndLocked,cOG,pricePerPiece,totalPrice,squareMetersPerPiece,totalSquareMeters,qty);

            string info = piece1.ToString();
            Console.WriteLine(info);


            //string details = logic.writingDownDetails(newPiece, x, y, l, r, secondaryR, dimx, dimy, firstEndLocked, secondEndLocked, qty);
            //MessageBox.Show(details);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            newPiece = 2;

            buttonrk.BackColor = Color.White;
            button90.BackColor = Color.Green;
            DimButton.BackColor = Color.White;
            button45.BackColor = Color.White;
            buttonav.BackColor = Color.White;

            radie.Text = "100";
            radie2.Text = "100";

            labTo.Visible = false;
            labRadie2.Visible = true;
            sameRadieBox.Visible = true;
            sameRadieBox.Checked = true;
            radie2.Visible = true;
            radie2.TabStop = true;
            textBox3.Visible = false;
            radie.Visible = true;
            radie.TabStop = true;
            labRadie.Visible = true;
            labDimX.Visible = false;
            labDimY.Visible = false;
            centeredOrGrad.Visible = false;
            centeredOrGrad.Checked = false;
            DimX.Visible = false;
            DimY.Visible = false;
            DimX.TabStop = false;
            DimY.TabStop = false;

        }

        private void buttonrk_Click(object sender, EventArgs e)
        {
            newPiece = 1;

            buttonrk.BackColor = Color.Green;
            button90.BackColor = Color.White;
            DimButton.BackColor = Color.White;
            button45.BackColor = Color.White;
            buttonav.BackColor = Color.White;

            textBox3.Text = "1250";

            labTo.Visible = false;
            labRadie2.Visible = false;
            sameRadieBox.Visible = false;
            sameRadieBox.Checked = false;
            radie2.Visible = false;
            radie2.TabStop = false;
            textBox3.Visible = true;
            radie.Visible = false;
            radie.TabStop = false;
            labDimX.Visible = false;
            labDimY.Visible = false;
            labRadie.Visible = false;
            centeredOrGrad.Visible = false;
            centeredOrGrad.Checked = false;
            DimX.Visible = false;
            DimY.Visible = false;
            DimX.TabStop = false;
            DimY.TabStop = false;





            //  CheckBox Mycheckbox = new CheckBox();
            //  Mycheckbox.Height = 50;
            //Mycheckbox.Width = 100;
            //Point point = new Point(632, 371);
            //Mycheckbox.Location = point;
            //Mycheckbox.Text = "Married";
            //Mycheckbox.Font = new Font("Bradley Hand ITC", 12);
            //this.Controls.Add(Mycheckbox);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {
            newPiece = 3;

            buttonrk.BackColor = Color.White;
            button90.BackColor = Color.White;
            DimButton.BackColor = Color.White;
            button45.BackColor = Color.Green;
            buttonav.BackColor = Color.White;

            radie.Text = "100";
            radie2.Text = "100";

            labTo.Visible = false;
            labRadie2.Visible = true;
            sameRadieBox.Visible = true;
            sameRadieBox.Checked = true;
            radie2.Visible = true;
            radie2.TabStop = true;
            textBox3.Visible = false;
            radie.Visible = true;
            radie.TabStop = true;
            labRadie.Visible = true;
            labDimX.Visible = false;
            labDimY.Visible = false;
            centeredOrGrad.Visible = false;
            centeredOrGrad.Checked = false;
            DimX.Visible = false;
            DimY.Visible = false;
            DimX.TabStop = false;
            DimY.TabStop = false;
        }

        private void buttonav_Click(object sender, EventArgs e)
        {
            newPiece = 4;

            buttonrk.BackColor = Color.White;
            button90.BackColor = Color.White;
            DimButton.BackColor = Color.White;
            button45.BackColor = Color.White;
            buttonav.BackColor = Color.Green;

            textBox3.Text = "100";

            labTo.Visible = false;
            labRadie2.Visible = false;
            sameRadieBox.Visible = false;
            sameRadieBox.Checked = false;
            radie2.Visible = false;
            radie2.TabStop = false;
            textBox3.Visible = true;
            radie.Visible = false;
            radie.TabStop = false;
            labDimX.Visible = false;
            labDimY.Visible = false;
            labRadie.Visible = false;
            centeredOrGrad.Visible = false;
            centeredOrGrad.Checked = false;
            DimX.Visible = false;
            DimY.Visible = false;
            DimX.TabStop = false;
            DimY.TabStop = false;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            newPiece = 5;

            buttonrk.BackColor = Color.White;
            button90.BackColor = Color.White;
            DimButton.BackColor = Color.Green;
            button45.BackColor = Color.White;
            buttonav.BackColor = Color.White;

            labTo.Visible = true;
            labRadie2.Visible = false;
            sameRadieBox.Visible = false;
            sameRadieBox.Checked = false;
            radie2.Visible = false;
            radie2.TabStop = false;
            textBox3.Visible = true;
            radie.Visible = false;
            radie.TabStop = false;
            labDimX.Visible = true;
            labDimY.Visible = true;
            labRadie.Visible = true;
            centeredOrGrad.Visible = true;
            centeredOrGrad.Checked = true;
            DimX.Visible = true;
            DimY.Visible = true;
            DimX.TabStop = true;
            DimY.TabStop = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            newPiece = 6;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            newPiece = 7;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            newPiece = 8;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void sameRadieBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sameRadieBox.Checked)
            {
                radie2.BackColor = Color.Gray;
                radie2.Enabled = false;
            }
            else if (sameRadieBox.Checked == false)
            {
                radie2.BackColor = Color.White;
                radie2.Enabled = true;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData ==Keys.Q) { buttonrk.PerformClick();}
            else if (keyData ==Keys.W) { button90.PerformClick(); }
            else if (keyData ==Keys.E) { button45.PerformClick(); }
            else if (keyData ==Keys.R) { buttonav.PerformClick(); }
            else if (keyData ==Keys.A) { DimButton.PerformClick(); }
            else if (keyData == Keys.Enter) { button1.PerformClick(); }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
            }

        private void radie_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DimX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void DimY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void radie2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void QtyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {

        }
    }
}

