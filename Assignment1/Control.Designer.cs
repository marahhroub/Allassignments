namespace Assignment1
{
    partial class Controlform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.controltype = new System.Windows.Forms.ComboBox();
            this.txtnumofcontrols = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of controls";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(15, 279);
            this.panel.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(620, 282);
            this.panel.TabIndex = 2;
            // 
            // controltype
            // 
            this.controltype.FormattingEnabled = true;
            this.controltype.Items.AddRange(new object[] {
            "button",
            "textbox",
            "lable"});
            this.controltype.Location = new System.Drawing.Point(252, 53);
            this.controltype.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.controltype.Name = "controltype";
            this.controltype.Size = new System.Drawing.Size(383, 32);
            this.controltype.TabIndex = 3;
            // 
            // txtnumofcontrols
            // 
            this.txtnumofcontrols.Location = new System.Drawing.Point(252, 103);
            this.txtnumofcontrols.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtnumofcontrols.Name = "txtnumofcontrols";
            this.txtnumofcontrols.Size = new System.Drawing.Size(383, 32);
            this.txtnumofcontrols.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(282, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 86);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create controls";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Controlform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 587);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnumofcontrols);
            this.Controls.Add(this.controltype);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Controlform";
            this.Text = "Control Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox controltype;
        private System.Windows.Forms.TextBox txtnumofcontrols;
        private System.Windows.Forms.Button button1;
    }
}

