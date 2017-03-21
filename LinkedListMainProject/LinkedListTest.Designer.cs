namespace LinkedListMainProject
{
    partial class LinkedListTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLinkedListItems = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNthElementFromtheLinkedList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNthElementFromEnd = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblNthElementFromEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLinkedListItems
            // 
            this.lblLinkedListItems.AutoSize = true;
            this.lblLinkedListItems.Location = new System.Drawing.Point(13, 39);
            this.lblLinkedListItems.Name = "lblLinkedListItems";
            this.lblLinkedListItems.Size = new System.Drawing.Size(0, 13);
            this.lblLinkedListItems.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linked List Items";
            // 
            // txtNthElementFromtheLinkedList
            // 
            this.txtNthElementFromtheLinkedList.Location = new System.Drawing.Point(16, 84);
            this.txtNthElementFromtheLinkedList.Name = "txtNthElementFromtheLinkedList";
            this.txtNthElementFromtheLinkedList.Size = new System.Drawing.Size(100, 20);
            this.txtNthElementFromtheLinkedList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nth Element From End of List";
            // 
            // btnNthElementFromEnd
            // 
            this.btnNthElementFromEnd.Location = new System.Drawing.Point(16, 111);
            this.btnNthElementFromEnd.Name = "btnNthElementFromEnd";
            this.btnNthElementFromEnd.Size = new System.Drawing.Size(100, 23);
            this.btnNthElementFromEnd.TabIndex = 4;
            this.btnNthElementFromEnd.Text = "Get Element";
            this.btnNthElementFromEnd.UseVisualStyleBackColor = true;
            this.btnNthElementFromEnd.Click += new System.EventHandler(this.btnNthElementFromEnd_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(19, 141);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.lblErrorMessage.TabIndex = 5;
            // 
            // lblNthElementFromEnd
            // 
            this.lblNthElementFromEnd.AutoSize = true;
            this.lblNthElementFromEnd.Location = new System.Drawing.Point(19, 158);
            this.lblNthElementFromEnd.Name = "lblNthElementFromEnd";
            this.lblNthElementFromEnd.Size = new System.Drawing.Size(0, 13);
            this.lblNthElementFromEnd.TabIndex = 6;
            // 
            // LinkedListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblNthElementFromEnd);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnNthElementFromEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNthElementFromtheLinkedList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLinkedListItems);
            this.Name = "LinkedListTest";
            this.Text = "LinkedList Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLinkedListItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNthElementFromtheLinkedList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNthElementFromEnd;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblNthElementFromEnd;
    }
}

