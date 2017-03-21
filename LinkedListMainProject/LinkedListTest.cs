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
    public partial class LinkedListTest : Form
    {
        LinkedList lnklist;
        public LinkedListTest()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //creating LinkedList of integer values initalization
            lnklist = new LinkedList();
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


        }

        private void btnNthElementFromEnd_Click(object sender, EventArgs e)
        {
            //here validation of entered position is not the main focus of the project so directly adding validtion  in the main project level as below

            try
            {
                lblErrorMessage.Text = "";
                lblNthElementFromEnd.Text = "";
                int NthElementNumber = Convert.ToInt16(txtNthElementFromtheLinkedList.Text);
                //here validation of entered position is not the main focus of the project so directly adding validtion  in the main project level as below
                if (NthElementNumber > lnklist.Counter || NthElementNumber < 1) // number must be with in predefined linked list int items position
                { 
                lblErrorMessage.Text = "Please enter Nth Element within predefined linked list items added!";
                txtNthElementFromtheLinkedList.Text = "";
                }
                else
                {
                    //getting Nth element from the end of linked list using best possible traverse method
                   var resultedNode = lnklist.GetNthElementFromEnd(NthElementNumber);
                    lblNthElementFromEnd.Text = resultedNode.data.ToString();
                }
            }
            catch
            {
                lblErrorMessage.Text = "Please enter valid interget number position!";
                txtNthElementFromtheLinkedList.Text = "";
            }
            // resultedNode.data;
        }
    }
}
