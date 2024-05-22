namespace Library
{
    partial class Librarians
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
            textBox3 = new TextBox();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            BookNumber = new TextBox();
            label1 = new Label();
            FindLibrarian = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(134, 248);
            textBox3.MinimumSize = new Size(140, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 58);
            textBox3.TabIndex = 15;
            // 
            // label4
            // 
            label4.Location = new Point(12, 248);
            label4.Name = "label4";
            label4.Size = new Size(106, 58);
            label4.TabIndex = 14;
            label4.Text = "Отчество";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(134, 174);
            textBox2.MinimumSize = new Size(140, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 58);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.Location = new Point(12, 174);
            label3.Name = "label3";
            label3.Size = new Size(106, 58);
            label3.TabIndex = 12;
            label3.Text = "Имя";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(134, 91);
            textBox1.MinimumSize = new Size(140, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 58);
            textBox1.TabIndex = 11;
            // 
            // label2
            // 
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(106, 58);
            label2.TabIndex = 10;
            label2.Text = "Фамилия";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookNumber
            // 
            BookNumber.Cursor = Cursors.IBeam;
            BookNumber.Location = new Point(134, 9);
            BookNumber.MinimumSize = new Size(140, 58);
            BookNumber.Name = "BookNumber";
            BookNumber.Size = new Size(140, 58);
            BookNumber.TabIndex = 9;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 58);
            label1.TabIndex = 8;
            label1.Text = "№Библиотекаря";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FindLibrarian
            // 
            FindLibrarian.Cursor = Cursors.Hand;
            FindLibrarian.Location = new Point(362, 91);
            FindLibrarian.Name = "FindLibrarian";
            FindLibrarian.Size = new Size(191, 141);
            FindLibrarian.TabIndex = 16;
            FindLibrarian.Text = "Найти библиотекаря";
            FindLibrarian.UseVisualStyleBackColor = true;
            // 
            // Librarians
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 320);
            Controls.Add(FindLibrarian);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(BookNumber);
            Controls.Add(label1);
            Name = "Librarians";
            Text = "Librarians";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox3;
        private Label label4;
        public TextBox textBox2;
        private Label label3;
        public TextBox textBox1;
        private Label label2;
        public TextBox BookNumber;
        private Label label1;
        private Button FindLibrarian;
    }
}