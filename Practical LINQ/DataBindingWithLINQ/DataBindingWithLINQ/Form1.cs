using DataBindingWithLINQ.Biz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindingWithLINQ
{
    public partial class Form1 : Form
    {
        private List<Person> People;
        public Form1()
        {
            InitializeComponent();
            People = new List<Person>()
            {
                new Person()
                {
                    age = 5,
                    FirstName = "Aaron",
                    Surname = "Clarke"
                },
                new Person()
                {
                age = 10,
                FirstName = "Jason",
                Surname = "Walsh"
                },
                new Person()
                {
                    age = 15,
                    FirstName = "Lee",
                    Surname = "Walsh"
                },
                new Person()
                {
                    age = 25,
                    FirstName = "Ricky",
                    Surname = "ingle"
                },
                new Person()
                {
                    age = 35,
                    FirstName = "Jeff",
                    Surname = "ingle"
                },
                new Person()
                {
                    age = 45,
                    FirstName = "Julie",
                    Surname = "Fodden"
                },
                new Person()
                {
                    age = 55,
                    FirstName = "Marcia",
                    Surname = "Ingle"
                },
                new Person()
                {
                    age = 65,
                    FirstName = "Claudia",
                    Surname = "Ingle"
                }
            };
        }

        private void Btn_GetData_Click( object sender, EventArgs e )
        {
            DGV_Data.DataSource = People;
        }

        private void Form1_Load( object sender, EventArgs e )
        {
            CBx_Test.DisplayMember = "FirstName";
            CBx_Test.ValueMember = "age";
            CBx_Test.DataSource = People;
        }

        private void CBx_Test_SelectedIndexChanged( object sender, EventArgs e )
        {
            MessageBox.Show( CBx_Test.SelectedValue.ToString() );
        }
    }
}
