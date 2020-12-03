using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PresentationLayerWEBFORM
{
    public partial class _Default : Page
    {
        private  StudentBuisness studentBusiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.studentBusiness = new StudentBuisness();
            RefreshData();
        
        }
        public void RefreshData()
        {
            List<Student> students = studentBusiness.GetAllStudents();
            Listbox1.Items.Clear();
            foreach(Student s in students)
            {
                Listbox1.Items.Add("Ime: " + s.Name + "\tBroj indeksa: " + s.IndexNumber + "\tProsecna ocena: " + s.AverageMark);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = "Lazar";
            s.IndexNumber = "33/2018";
            s.AverageMark = 3;

            this.studentBusiness.InsertStudent(s);
                RefreshData();
        }
    }
        
}