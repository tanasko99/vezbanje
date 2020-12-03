using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        private readonly StudentBuisness studentBuisness;
        public Form1()
        {
            this.studentBuisness = new StudentBuisness();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();

        }
        public void RefreshData()
        {
            List<Student> students = this.studentBuisness.GetAllStudents();
            listBox1.Items.Clear();
            foreach(Student s in students)
            {
                listBox1.Items.Add("Ime: "+ s.Name + "\tBroj indeksa: " + s.IndexNumber + "\tProsecna ocena: " + s.AverageMark);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBox1.Text;
            s.IndexNumber = textBox2.Text;
            s.AverageMark = Convert.ToDecimal(textBox3.Text);

            if (this.studentBuisness.InsertStudent(s))
                RefreshData();
            MessageBox.Show("Greska!");
        }
    }
}
