using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brandon_Cassidy_CS559_Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Person dt = new Person("Donald", "Trump", DateTime.Parse("06/14/1946"));
            Person tc = new Person("Ted", "Cruz", DateTime.Parse("12/22/1970"));
            Person hc = new Person("Hillary", "Clinton", DateTime.Parse("10/26/1946"));

            YourQueue MyPeople = new YourQueue();

            MyPeople.PersonDequeued += MyPeople_PersonDequeued;
            MyPeople.NonPersonDequeued += MyPeople_NonPersonDequeued;

            MyPeople.Enqueue(dt);
            MyPeople.Enqueue(tc);
            MyPeople.Enqueue(hc);
            MyPeople.Enqueue("Mickey Mouse");

            while(MyPeople.Count > 0)
            {
                MyPeople.Dequeue();
            }
        }

        void MyPeople_PersonDequeued(Person p)
        {
            string message = $"You successfully dequeued {p.FirstName} {p.LastName}. \n Their birthday is in {p.DaysUntilBDay} days!";
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void MyPeople_NonPersonDequeued(Object o)
        {
            string message = $"You successfully dequeued {o.ToString()} who is not a person!";
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
