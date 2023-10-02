using System.Windows.Forms;

namespace CardHolder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            listBox1 = new ListBox();
            addButton = new Button();
            delButton = new Button();
            mixButton = new Button();
            CardsLabel = new Label();
            CardsBox = new RichTextBox();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(210, 349);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(228, 14);
            addButton.Name = "addButton";
            addButton.Size = new Size(85, 37);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // delButton
            // 
            delButton.Location = new Point(228, 57);
            delButton.Name = "delButton";
            delButton.Size = new Size(83, 37);
            delButton.TabIndex = 3;
            delButton.Text = "Delete";
            delButton.UseVisualStyleBackColor = true;
            delButton.Click += delButton_Click;
            // 
            // mixButton
            // 
            mixButton.Location = new Point(230, 324);
            mixButton.Name = "mixButton";
            mixButton.Size = new Size(83, 37);
            mixButton.TabIndex = 4;
            mixButton.Text = "Mix";
            mixButton.UseVisualStyleBackColor = true;
            mixButton.Click += mixButton_Click;
            // 
            // CardsLabel
            // 
            CardsLabel.AutoSize = true;
            CardsLabel.Location = new Point(319, 14);
            CardsLabel.Name = "CardsLabel";
            CardsLabel.Size = new Size(37, 15);
            CardsLabel.TabIndex = 5;
            CardsLabel.Text = "Cards";
            // 
            // CardsBox
            // 
            CardsBox.Location = new Point(319, 32);
            CardsBox.Name = "CardsBox";
            CardsBox.Size = new Size(147, 175);
            CardsBox.TabIndex = 6;
            CardsBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 367);
            Controls.Add(CardsBox);
            Controls.Add(CardsLabel);
            Controls.Add(mixButton);
            Controls.Add(delButton);
            Controls.Add(addButton);
            Controls.Add(listBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Card Storage";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ListBox listBox1;
        private Button addButton;
        private Button delButton;
        private Button mixButton;
        private Label CardsLabel;
        private RichTextBox CardsBox;
    }


}