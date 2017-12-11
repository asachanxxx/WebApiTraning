using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP1
{
    public partial class Form1 : Form
    {
        BookManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new BookManager(1000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Books book = new Books();
            book.id = 1;
            book.Name = "Story Of me";
            book.price = 200;
            book.HashCode = book.GetHashCode();
            manager.AddBok(book);

            List<Books> _books = new List<Books>();
            _books = manager.GetBook();
            //Books book2= new Books();
            MessageBox.Show(manager.writeGrades());
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Inheritance
            Example obj = new Example();
            MessageBox.Show(obj.ReturnMain());
            MessageBox.Show(obj.ReturnValues());

            B bclass = new OOP1.B();
            MessageBox.Show(bclass.Dowork());

            A aclass = new OOP1.A();

            MessageBox.Show(aclass.ToString());
            MessageBox.Show(aclass.GetHashCode().ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToolWindow toolw = new OOP1.ToolWindow();
            MessageWindow msgw = new OOP1.MessageWindow();


            ContraintTypes emp = new OOP1.ContraintTypes();
            MessageBox.Show(emp.Find().Name);            


        }




        
    }



}

