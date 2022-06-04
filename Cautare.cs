using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C___Individual
{
    public partial class Cautare : Form
    {



        public Cautare()
        {
            InitializeComponent();



            cautari.arr = new int[5, 5];
            cautari.arr[0, 0] = 0;
            cautari.arr[0, 1] = 2;
            cautari.arr[0, 2] = 4;
            cautari.arr[0, 3] = 5;
            cautari.arr[0, 4] = 6;
            cautari.arr[1, 0] = 7;
            cautari.arr[1, 1] = 11;
            cautari.arr[1, 2] = 14;
            cautari.arr[1, 3] = 17;
            cautari.arr[1, 4] = 18;
            cautari.arr[2, 0] = 21;
            cautari.arr[2, 1] = 22;
            cautari.arr[2, 2] = 24;
            cautari.arr[2, 3] = 27;
            cautari.arr[2, 4] = 30;
            cautari.arr[3, 0] = 33;
            cautari.arr[3, 1] = 37;
            cautari.arr[3, 2] = 41;
            cautari.arr[3, 3] = 46;
            cautari.arr[3, 4] = 50;
            cautari.arr[4, 0] = 51;
            cautari.arr[4, 1] = 57;
            cautari.arr[4, 2] = 63;
            cautari.arr[4, 3] = 64;
            cautari.arr[4, 4] = 78;
            cautari.toarray();
            cautari.Prime(cautari.arr2);
            label4.Text = cautari.initial();



        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int max = cautari.FindMax(cautari.arr2);
            int min = cautari.FindMin(cautari.arr2);
            int minprim = cautari.FindMinP(cautari.prime);
            int maxprim = cautari.FindMax(cautari.prime);
            int maxdiv = cautari.FindDivisors(cautari.arr2);
            



            rezultat2 rez = new rezultat2();
            rezultat3 rez3 = new rezultat3();
            rezultat4 rez4 = new rezultat4();
            if (comboBox1.SelectedIndex == 0)
            {

                if (radioButton1.Checked)
                {
                    rez.label8.Text = "Linear Search";
                    rez.label2.Text = min.ToString();
                    rez.label6.Text = max.ToString();
                    rez.label4.Text = "Acesta se afla pe pozitia [" + cautari.LinearSearch(ref cautari.arr2, min) / cautari.arr.GetLength(0) + "][" + cautari.LinearSearch(ref cautari.arr2, min) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.label7.Text = "Acesta se afla pe pozitia [" + cautari.LinearSearch(ref cautari.arr2, max) / cautari.arr.GetLength(0) + "][" + (cautari.arr.GetLength(0) - 1) + "]".ToString();

                    rez.Show();
                }
                else if (radioButton2.Checked)
                {

                    rez3.label8.Text = "Linear Search";
                    rez3.label6.Text = maxprim.ToString();
                    rez3.label2.Text = minprim.ToString();
                    rez3.label4.Text = "Acesta se afla pe pozitia [" + (cautari.LinearSearch(ref cautari.arr2, minprim) / cautari.arr.GetLength(0)) + "][" + cautari.LinearSearch(ref cautari.arr2, minprim) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.label7.Text = "Acesta se afla pe pozitia [" + cautari.LinearSearch(ref cautari.arr2, maxprim) / cautari.arr.GetLength(0) + "][" + (cautari.LinearSearch(ref cautari.arr2, maxprim) % cautari.arr.GetLength(0) + "]".ToString());
                    rez3.Show();

                }
                else if (radioButton3.Checked)
                {
                    rez4.label8.Text = "Linear Search";
                    rez4.label2.Text = maxdiv.ToString();
                    rez4.label4.Text = "Acesta se afla pe pozitia [" + (cautari.LinearSearch(ref cautari.arr2, maxdiv) / cautari.arr.GetLength(0)) + "][" + (cautari.LinearSearch(ref cautari.arr2, maxdiv) % cautari.arr.GetLength(0)) + "]".ToString();
                    rez4.Show();
                }


            }
            else if (comboBox1.SelectedIndex == 1)
            {

                if (radioButton1.Checked)
                {
                    rez.label8.Text = "Binary Search";
                    rez.label2.Text = min.ToString();
                    rez.label6.Text = max.ToString();
                    rez.label4.Text = "Acesta se afla pe pozitia [" + cautari.BinarySearch(ref cautari.arr2, min, 0, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.BinarySearch(ref cautari.arr2, min, 0, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.label7.Text = "Acesta se afla pe pozitia [" + cautari.BinarySearch(ref cautari.arr2, max, 0, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.BinarySearch(ref cautari.arr2, max, 0, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.Show();
                }
                else if (radioButton2.Checked)
                {
                    rez3.label8.Text = "Binary Search";
                    rez3.label6.Text = maxprim.ToString();
                    rez3.label2.Text = minprim.ToString();
                    rez3.label4.Text = "Acesta se afla pe pozitia [" + cautari.BinarySearch(ref cautari.arr2, minprim, 0, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.BinarySearch(ref cautari.arr2, minprim, 0, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.label7.Text = "Acesta se afla pe pozitia [" + cautari.BinarySearch(ref cautari.arr2, maxprim, 0, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.BinarySearch(ref cautari.arr2, maxprim, 0, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();

                    rez3.Show();
                }
                else if (radioButton3.Checked)
                {
                    rez4.label8.Text = "Binary Search";
                    rez4.label2.Text = maxdiv.ToString();
                    rez4.label4.Text = "Acesta se afla pe pozitia [" + cautari.BinarySearch(ref cautari.arr2, maxdiv, 0, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.BinarySearch(ref cautari.arr2, maxdiv, 0, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez4.Show();
                }

            }
            else if (comboBox1.SelectedIndex == 3)
            {
                if (radioButton1.Checked)
                {
                    rez.label8.Text = "Interpolation Search";
                    rez.label2.Text = min.ToString();
                    rez.label6.Text = max.ToString();
                    rez.label4.Text = "Acesta se afla pe pozitia [" + cautari.InterpolationSearch(ref cautari.arr2, min) / cautari.arr.GetLength(0) + "][" + cautari.InterpolationSearch(ref cautari.arr2, min) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.label7.Text = "Acesta se afla pe pozitia [" + cautari.InterpolationSearch(ref cautari.arr2, max) / cautari.arr.GetLength(0) + "][" + cautari.InterpolationSearch(ref cautari.arr2, max) % cautari.arr.GetLength(0) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.Show();
                }
                else if (radioButton2.Checked)
                {
                    rez3.label8.Text = "Interpolation Search";
                    rez3.label6.Text = maxprim.ToString();
                    rez3.label2.Text = minprim.ToString();
                    rez3.label4.Text = "Acesta se afla pe pozitia [" + cautari.InterpolationSearch(ref cautari.arr2, minprim) / cautari.arr.GetLength(0) + "][" + cautari.InterpolationSearch(ref cautari.arr2, minprim) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.label7.Text = "Acesta se afla pe pozitia [" + cautari.InterpolationSearch(ref cautari.arr2, maxprim) / cautari.arr.GetLength(0) + "][" + cautari.InterpolationSearch(ref cautari.arr2, maxprim) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.Show();
                }
                else if (radioButton3.Checked)
                {
                    rez4.label8.Text = "Interpolation Search";
                    rez4.label2.Text = maxdiv.ToString();
                    rez4.label4.Text = "Acesta se afla pe pozitia [" + cautari.InterpolationSearch(ref cautari.arr2, maxdiv) / cautari.arr.GetLength(0) + "][" + cautari.InterpolationSearch(ref cautari.arr2, maxdiv) % cautari.arr.GetLength(0) + "]".ToString();
                    rez4.Show();
                }


            }
            else if (comboBox1.SelectedIndex == 2)
            {

                if (radioButton1.Checked)
                {
                    rez.label8.Text = "Jump Search";
                    rez.label2.Text = min.ToString();
                    rez.label6.Text = max.ToString();
                    rez.label4.Text = "Acesta se afla pe pozitia [" + cautari.JumpSearch(ref cautari.arr2, min) / cautari.arr.GetLength(0) + "][" + cautari.JumpSearch(ref cautari.arr2, min) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.label7.Text = "Acesta se afla pe pozitia [" + cautari.JumpSearch(ref cautari.arr2, max) / cautari.arr.GetLength(0) + "][" + cautari.JumpSearch(ref cautari.arr2, max) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.Show();
                }
                else if (radioButton2.Checked)
                {
                    rez3.label8.Text = "Jump Search";
                    rez3.label6.Text = maxprim.ToString();
                    rez3.label2.Text = minprim.ToString();
                    rez3.label4.Text = "Acesta se afla pe pozitia [" + cautari.JumpSearch(ref cautari.arr2, minprim) / cautari.arr.GetLength(0) + "][" + cautari.JumpSearch(ref cautari.arr2, minprim) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.label7.Text = "Acesta se afla pe pozitia [" + cautari.JumpSearch(ref cautari.arr2, maxprim) / cautari.arr.GetLength(0) + "][" + cautari.JumpSearch(ref cautari.arr2, maxprim) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.Show();
                }
                else if (radioButton3.Checked)
                {
                    rez4.label8.Text = "Linear Search";
                    rez4.label2.Text = maxdiv.ToString();
                    rez4.label4.Text = "Acesta se afla pe pozitia [" + cautari.JumpSearch(ref cautari.arr2, maxdiv) / cautari.arr.GetLength(0) + "][" + cautari.JumpSearch(ref cautari.arr2, maxdiv) % cautari.arr.GetLength(0) + "]".ToString();
                    rez4.Show();
                }

            }
            else if (comboBox1.SelectedIndex == 4)
            {

                if (radioButton1.Checked)
                {
                    rez.label8.Text = "Exponential Search";
                    rez.label2.Text = min.ToString();
                    rez.label6.Text = max.ToString();
                    rez.label4.Text = "Acesta se afla pe pozitia [" + cautari.ExponentialSearch(ref cautari.arr2, min, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.ExponentialSearch(ref cautari.arr2, min, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.label7.Text = "Acesta se afla pe pozitia [" + cautari.ExponentialSearch(ref cautari.arr2, max, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.ExponentialSearch(ref cautari.arr2, max, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.Show();
                }
                else if (radioButton2.Checked)
                {
                    rez3.label8.Text = "Exponential Search";
                    rez3.label6.Text = maxprim.ToString();
                    rez3.label2.Text = minprim.ToString();
                    rez3.label4.Text = "Acesta se afla pe pozitia [" + cautari.ExponentialSearch(ref cautari.arr2, minprim, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.ExponentialSearch(ref cautari.arr2, minprim, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.label7.Text = "Acesta se afla pe pozitia [" + cautari.ExponentialSearch(ref cautari.arr2, maxprim, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.ExponentialSearch(ref cautari.arr2, maxprim, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.Show();

                }
                else if (radioButton3.Checked)
                {
                    rez4.label8.Text = "Exponential Search";
                    rez4.label2.Text = maxdiv.ToString();
                    rez4.label4.Text = "Acesta se afla pe pozitia [" + cautari.ExponentialSearch(ref cautari.arr2, maxdiv, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.ExponentialSearch(ref cautari.arr2, maxdiv, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez4.Show();
                }

            }
            else if (comboBox1.SelectedIndex == 5)
            {

                if (radioButton1.Checked)
                {
                    rez.label8.Text = "Fibonacci Search";
                    rez.label2.Text = min.ToString();
                    rez.label6.Text = max.ToString();
                    rez.label4.Text = "Acesta se afla pe pozitia [" + cautari.FibonacciSearch(ref cautari.arr2, min, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.FibonacciSearch(ref cautari.arr2, min, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.label7.Text = "Acesta se afla pe pozitia [" + cautari.FibonacciSearch(ref cautari.arr2, max, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.FibonacciSearch(ref cautari.arr2, max, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez.Show();
                }
                else if (radioButton2.Checked)
                {
                    rez3.label8.Text = "Fibonacci Search";
                    rez3.label6.Text = maxprim.ToString();
                    rez3.label2.Text = minprim.ToString();
                    rez3.label4.Text = "Acesta se afla pe pozitia [" + cautari.FibonacciSearch(ref cautari.arr2, minprim, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.FibonacciSearch(ref cautari.arr2, minprim, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.label7.Text = "Acesta se afla pe pozitia [" + cautari.FibonacciSearch(ref cautari.arr2, maxprim, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.FibonacciSearch(ref cautari.arr2, maxprim, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez3.Show();
                }
                else if (radioButton3.Checked)
                {
                    rez4.label8.Text = "Fibonacci Search";
                    rez4.label2.Text = maxdiv.ToString();
                    rez4.label4.Text = "Acesta se afla pe pozitia [" + cautari.FibonacciSearch(ref cautari.arr2, maxdiv, cautari.arr2.Length) / cautari.arr.GetLength(0) + "][" + cautari.FibonacciSearch(ref cautari.arr2, maxdiv, cautari.arr2.Length) % cautari.arr.GetLength(0) + "]".ToString();
                    rez4.Show();
                }

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        private void button2_Click(object sender, EventArgs e)
        {

            File.Delete("C:/Users/Cadi/Desktop/cautari.txt");
            string method = comboBox1.GetItemText(comboBox1.SelectedItem);

            static void tofisier(string method)
            {
            

                int max = cautari.FindMax(cautari.arr2);
                int min = cautari.FindMin(cautari.arr2);
                int minprim = cautari.FindMinP(cautari.prime);
                int maxprim = cautari.FindMax(cautari.prime);
                int maxdiv = cautari.FindDivisors(cautari.arr2);
                var methodL = cautari.LinearSearch;
               

                switch (method)
                {
                    case "LinearSearch":
                        methodL = cautari.LinearSearch;
                        break;
                    case "BinarySearch:":
                       // methodL = cautari.BinarySearch;
                        break;
                    case "InterpolationSearch":
                        methodL = cautari.InterpolationSearch;
                        break;
                    case "JumpSearch":
                        methodL = cautari.JumpSearch;
                        break;
                    case "ExponentialSearch":
                        //methodL = cautari.ExponentialSearch;
                        break;
                    case "FibonacciSearch":
                       // methodL = cautari.FibonacciSearch;
                        break;
                    default:
                        methodL = cautari.LinearSearch;
                        break;

                }
                using (StreamWriter sw = File.AppendText("C:/Users/Cadi/Desktop/cautari.txt"))
                {
                    sw.WriteLine("Array-ul sortat:");
                    sw.Write(cautari.initial());
                    sw.WriteLine();
                    sw.WriteLine("Algoritmul de cautare ales este: " + method); sw.WriteLine();
                    sw.WriteLine("Elementul maxim si minim: ");
                    sw.WriteLine("Minimul este  " + min + " si se afla pe pozitia [" + methodL(ref cautari.arr2, min) / cautari.arr.GetLength(0) + "][" + cautari.LinearSearch(ref cautari.arr2, min) % cautari.arr.GetLength(0) + "]");
                    sw.WriteLine("Maximul este  " + max + " si se afla pe pozitia [" + methodL(ref cautari.arr2, max) / cautari.arr.GetLength(0) + "][" + cautari.LinearSearch(ref cautari.arr2, max) % cautari.arr.GetLength(0) + "]");
                    sw.WriteLine();

                    sw.WriteLine("Elementul maxim si minim prim: ");
                    sw.WriteLine("Minimul este  " + minprim + " si se afla pe pozitia [" + methodL(ref cautari.arr2, minprim) / cautari.arr.GetLength(0) + "][" + cautari.LinearSearch(ref cautari.arr2, minprim) % cautari.arr.GetLength(0) + "]");
                    sw.WriteLine("Maximul este  " + maxprim + " si se afla pe pozitia [" + methodL(ref cautari.arr2, maxprim) / cautari.arr.GetLength(0) + "][" + cautari.LinearSearch(ref cautari.arr2, maxprim) % cautari.arr.GetLength(0) + "]");
                    sw.WriteLine();


                    sw.WriteLine("Elementul cu cei mai multi divizori: ");
                    sw.WriteLine("Acesta este  " + maxdiv + " si se afla pe pozitia [" + methodL(ref cautari.arr2, maxdiv) / cautari.arr.GetLength(0) + "][" + cautari.LinearSearch(ref cautari.arr2, maxdiv) % cautari.arr.GetLength(0) + "]");
                    sw.WriteLine();

                    sw.Close();
                }
                MessageBox.Show("Datele au fost trimise in fisierul cautari.txt");
            }
            tofisier(method);
        }
    }
}
