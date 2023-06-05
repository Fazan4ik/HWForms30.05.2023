using System;
using System.Windows.Forms;

namespace HWForms30._05._2023
{
    public partial class Form1 : Form
    {
        private TextBox parentTextBox;
        private TextBox childTextBox;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            parentTextBox = new TextBox();
            childTextBox = new TextBox();

            parentTextBox.Location = new System.Drawing.Point(50, 50);
            parentTextBox.Size = new System.Drawing.Size(200, 25);

            childTextBox.Location = new System.Drawing.Point(50, 100);
            childTextBox.Size = new System.Drawing.Size(200, 25);

            parentTextBox.TextChanged += ParentTextBox_TextChanged;
            childTextBox.TextChanged += ChildTextBox_TextChanged;

            Controls.Add(parentTextBox);
            Controls.Add(childTextBox);
        }

        private void ParentTextBox_TextChanged(object sender, EventArgs e)
        {
            childTextBox.Text = parentTextBox.Text;
        }

        private void ChildTextBox_TextChanged(object sender, EventArgs e)
        {
            parentTextBox.Text = childTextBox.Text;
        }
    }
}