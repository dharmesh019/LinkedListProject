using LinkedListMainProject.LinkedListNodeClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedListMainProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //creating LinkedList of integer values initalization
            LinkedList lnklist = new LinkedList();
            lnklist.AddObjectAtEnd(1);
            lnklist.AddObjectAtEnd(2);
            lnklist.AddObjectAtEnd(4);
            lnklist.AddObjectAtEnd(3);
            lnklist.AddObjectAtEnd(6);
            lnklist.AddObjectAtEnd(8);
            lnklist.AddObjectAtEnd(10);
            lnklist.AddObjectAtEnd(22);
            lnklist.AddObjectAtEnd(13);
            lnklist.AddObjectAtEnd(15);
            lnklist.AddObjectAtEnd(7);

            lblLinkedListItems.Text = lnklist.DisplayAddedLinkedListItems();

            var TotalItems = lnklist.Counter;

          var resultedNode=  lnklist.GetNthElementFromEnd(5);
           // resultedNode.data;

        }
    }
}
