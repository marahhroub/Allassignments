using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Controlform : Form
    {
        public Controlform()
        {
            InitializeComponent();
        }

        // This method is called when the user clicks the "Create Controls" button.
        // It creates controls based on the user input and adds them to the panel.
        private void button1_Click(object sender, EventArgs e)
        {
            // Clear the panel before adding new controls.
            panel.Controls.Clear();

            // Get the type of control that the user wants to create.
            string controlType = controltype.Text;

            // Create controls based on the user input.
            if (controlType == "button")
            {
                // Get the number of controls that the user wants to create.
                int numberOfControls = int.Parse(txtnumofcontrols.Text);

                // Create and add new buttons to the panel.
                for (int i = 0; i < numberOfControls; i++)
                {
                    Button newButton = new Button();
                    newButton.Name = "Button " + (i + 1);
                    newButton.Text = "Button " + (i + 1);
                    newButton.Size = new Size(120, 40);
                    newButton.Location = new Point(0, (i * 50));

                    panel.Controls.Add(newButton);
                }

            }
            else if (controlType == "textbox")
            {
                // Get the number of controls that the user wants to create.
                int numberOfControls = int.Parse(txtnumofcontrols.Text);

                // Create and add new textboxes to the panel.
                for (int i = 0; i < numberOfControls; i++)
                {
                    TextBox newTextBox = new TextBox();
                    newTextBox.Name = "TextBox " + (i + 1);
                    newTextBox.Text = "TextBox " + (i + 1);
                    newTextBox.Size = new Size(120, 40);
                    newTextBox.Location = new Point(0, (i * 50));

                    panel.Controls.Add(newTextBox);
                }
            }
            else if (controlType == "lable")
            {
                // Get the number of controls that the user wants to create.
                int numberOfControls = int.Parse(txtnumofcontrols.Text);

                // Create and add new labels to the panel.
                for (int i = 0; i < numberOfControls; i++)
                {
                    Label newLabel = new Label();
                    newLabel.Name = "Label " + (i + 1);
                    newLabel.Text = "Label " + (i + 1);
                    newLabel.Size = new Size(120, 40);
                    newLabel.Location = new Point(0, (i * 50));

                    panel.Controls.Add(newLabel);
                }
            }
        }
    }


}

