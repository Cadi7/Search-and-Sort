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
    public partial class Sortare : Form
    {
        public int j = 0;
        public int i = 0;

        string text1 = "Selection Sort";
        string text2 = "Insertion Sort";
        string text3 = "Bubble Sort";
        string text4 = "Shell Sort";
        string text5 = "Merge Sort";
        string text6 = "Heap Sort";
        string text7 = "Quick Sort";
        string text8 = "Combo Sort";
        string text9 = "Radix Sort";
        string text10 = "Cocktail Sort";
        public Sortare()
        {
            InitializeComponent();

        }

        private void Sortare_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            static void afisare()
            {
                for (int i = 0; i < sortari.a.Length; i++)
                {
                    for (int j = 0; j < sortari.a[0].Length; j++)
                    {
                        MessageBox.Show(sortari.a[i][j] + " ");
                    }
                    Console.Write("\n");
                }
            }

            static void tofisier()
            {

                    using (FileStream fs = File.Create("C:/Users/Cadi/Desktop/rezultate.txt"))
                    {
                        StreamWriter sw = new StreamWriter(fs);
                        for (int i = 0; i < sortari.a.Length; i++)
                        {
                            for (int j = 0; j < sortari.a[0].Length; j++)
                            {
                                sw.Write(sortari.a[i][j] + " ");
                            }
                            sw.Write("\n");
                        }
                        sw.Close();
                        fs.Close();
                    }
           
            }

           

            static void ReverseMatrix<T>(T[][] matrix)
            {
                int width = sortari.n;
                int height = sortari.m;
                int startRow = 0;
                int startCol = 0;
                int endRow = height - 1;
                int endCol = width - 1;

                while (true)
                {
                    if (startRow > endRow) return;

                    // swap
                    var temp = matrix[startRow][startCol];
                    matrix[startRow][startCol] = matrix[endRow][endCol];
                    matrix[endRow][endCol] = temp;

                    startCol++;
                    endCol--;

                    if (startCol == width)
                    {
                        startRow++;
                        startCol = 0;
                    }
                    if (startCol == -1)
                    {
                        startRow++;
                        startCol = width - 1;
                    }
                    if (endCol == -1)
                    {
                        endRow--;
                        endCol = width - 1;
                    }
                    if (endCol == width)
                    {
                        endRow--;
                        endCol = 0;
                    }
                }
            }

           

            using (Sort sort = new Sort(sortari.a, (Sort.SortTypes)comboBox1.SelectedIndex))
            {
                sortari.a = sort.Get();

                if (comboBox2.SelectedIndex == 1)
                {
                    ReverseMatrix(sortari.a);
                    if (comboBox3.SelectedIndex == 1)
                    {
                        parcurgeri.serpuit();
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {
                        parcurgeri.spirala();
                    }
                    else if(comboBox3.SelectedIndex == 3)
                    {
                        parcurgeri.diagonala();
                    }
                    tofisier();
                }
                else
                 if (comboBox2.SelectedIndex == 0)
                {
                    if (comboBox3.SelectedIndex == 1)
                    {
                        parcurgeri.serpuit();
                    }
                    else if (comboBox3.SelectedIndex == 2)
                    {   
                        parcurgeri.spirala();
                    }
                    else if (comboBox3.SelectedIndex == 3)
                    {
                        parcurgeri.diagonala();
                    }
                    tofisier();
                }
                //afisare();
            }

           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            File.Delete("C:/Users/Cadi/Desktop/total.txt");
            static void tofisier2(string text)
            {

                using (StreamWriter sw = File.AppendText("C:/Users/Cadi/Desktop/total.txt"))
                {
                    sw.Write(text + ": "); sw.WriteLine();

                    sw.WriteLine();

                    parcurgeri.serpuit(); sw.Write("Parcurgere serpuita: "); sw.WriteLine();
                    for (int i = 0; i < sortari.a.Length; i++)
                    {
                        sw.Write(" ");
                        for (int j = 0; j < sortari.a[0].Length; j++)
                        {
                            sw.Write(sortari.a[i][j] + " ");
                        }
                        sw.WriteLine();
                    }

                    parcurgeri.spirala(); sw.Write("Parcurgere spirala: "); sw.WriteLine();
                    for (int i = 0; i < sortari.a.Length; i++)
                    {
                        sw.Write(" ");
                        for (int j = 0; j < sortari.a[0].Length; j++)
                        {
                            sw.Write(sortari.a[i][j] + " ");
                        }
                        sw.WriteLine();
                    }

                    parcurgeri.diagonala(); sw.Write("Parcurgere diagonala: "); sw.WriteLine();

                    for (int i = 0; i < sortari.a.Length; i++)
                    {
                        sw.Write(" ");
                        for (int j = 0; j < sortari.a[0].Length; j++)
                        {
                            sw.Write(sortari.a[i][j] + " ");
                        }
                        sw.WriteLine();

                    }
                    sw.WriteLine();
                    sw.Close();
                }
                
            }

            Sort sort1 = new Sort(sortari.a, (Sort.SortTypes)0);
                sortari.a = sort1.Get();
                tofisier2(text1);
                Sort sort2 = new Sort(sortari.a, (Sort.SortTypes)1);
            sortari.a = sort2.Get();
            tofisier2(text2);
            Sort sort3 = new Sort(sortari.a, (Sort.SortTypes)2);
            sortari.a = sort3.Get();
            tofisier2(text3);
            Sort sort4 = new Sort(sortari.a, (Sort.SortTypes)3);
            sortari.a = sort4.Get();
            tofisier2(text4);
            Sort sort5 = new Sort(sortari.a, (Sort.SortTypes)4);
            sortari.a = sort5.Get();
            tofisier2(text5);
            Sort sort6 = new Sort(sortari.a, (Sort.SortTypes)5);
            sortari.a = sort6.Get();
            tofisier2(text6);
            Sort sort7 = new Sort(sortari.a, (Sort.SortTypes)6);
            sortari.a = sort7.Get();
            tofisier2(text7);
            Sort sort8 = new Sort(sortari.a, (Sort.SortTypes)7);
            sortari.a = sort8.Get();
            tofisier2(text8);
            Sort sort9 = new Sort(sortari.a, (Sort.SortTypes)8);
            sortari.a = sort9.Get();
            tofisier2(text9);
            Sort sort10 = new Sort(sortari.a, (Sort.SortTypes)9);
            sortari.a = sort10.Get();
            tofisier2(text10);

            MessageBox.Show("Datele au fost trimise catre fisier!"); 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            rezultat rez = new rezultat();
            rez.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "array.txt";
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            var reader = new StreamReader(File.OpenRead(filename));
            var Lines = System.IO.File.ReadAllLines(filename);
            sortari.m = 0;
            sortari.a = new int[Lines.Length][];
            sortari.n = Lines.Length;
           // sortari.array = new int[20];
            // sortari.b = new int[sortari.n][];

            for (int i = 0; i < Lines.Length; i++)
            {
                var DataSplitted = Lines[i].Split(' ');
                sortari.a[i] = new int[DataSplitted.Length];
                sortari.m = DataSplitted.Length;
                for (int j = 0; j < DataSplitted.Length; j++)
                {
                    sortari.a[i][j] = int.Parse(DataSplitted[j]);
                }
            }
            sortari.b = sortari.a;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.asortare = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.tipsortare = comboBox2.GetItemText(comboBox2.SelectedItem);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            temp.tipparcurgere = comboBox3.GetItemText(comboBox3.SelectedItem);
        }
    }
}
