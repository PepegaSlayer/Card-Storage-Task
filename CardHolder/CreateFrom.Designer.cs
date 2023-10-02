namespace CardHolder
{
    public partial class CreateFrom
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
            label1 = new Label();
            NewDeckName = new TextBox();
            rb36 = new RadioButton();
            rb52 = new RadioButton();
            createButton = new Button();
            cencelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Deck name";
            // 
            // NewDeckName
            // 
            NewDeckName.Location = new Point(12, 27);
            NewDeckName.Name = "NewDeckName";
            NewDeckName.Size = new Size(165, 23);
            NewDeckName.TabIndex = 1;
            // 
            // rb36
            // 
            rb36.AutoSize = true;
            rb36.Location = new Point(12, 56);
            rb36.Name = "rb36";
            rb36.Size = new Size(37, 19);
            rb36.TabIndex = 2;
            rb36.TabStop = true;
            rb36.Text = "36";
            rb36.UseVisualStyleBackColor = true;
            rb36.CheckedChanged += rb36_CheckedChanged;
            // 
            // rb52
            // 
            rb52.AutoSize = true;
            rb52.Location = new Point(111, 56);
            rb52.Name = "rb52";
            rb52.Size = new Size(37, 19);
            rb52.TabIndex = 3;
            rb52.TabStop = true;
            rb52.Text = "52";
            rb52.UseVisualStyleBackColor = true;
            rb52.CheckedChanged += rb52_CheckedChanged;
            // 
            // createButton
            // 
            createButton.Enabled = false;
            createButton.Location = new Point(12, 81);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 32);
            createButton.TabIndex = 4;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButtton_Click;
            // 
            // cencelButton
            // 
            cencelButton.Location = new Point(102, 81);
            cencelButton.Name = "cencelButton";
            cencelButton.Size = new Size(75, 32);
            cencelButton.TabIndex = 5;
            cencelButton.Text = "Cencel";
            cencelButton.UseVisualStyleBackColor = true;
            cencelButton.Click += cencelButton_Click;
            // 
            // CreateFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 125);
            Controls.Add(cencelButton);
            Controls.Add(createButton);
            Controls.Add(rb52);
            Controls.Add(rb36);
            Controls.Add(NewDeckName);
            Controls.Add(label1);
            Name = "CreateFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NewDeckName;
        private RadioButton rb36;
        private RadioButton rb52;
        private Button createButton;
        private Button cencelButton;
    }
}