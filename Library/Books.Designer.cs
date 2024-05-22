namespace Library
{
    partial class Books
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
            BookNumber = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            FindBooks = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 58);
            label1.TabIndex = 0;
            label1.Text = "№Книги";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookNumber
            // 
            BookNumber.Cursor = Cursors.IBeam;
            BookNumber.Location = new Point(144, 19);
            BookNumber.MinimumSize = new Size(140, 58);
            BookNumber.Name = "BookNumber";
            BookNumber.Size = new Size(140, 58);
            BookNumber.TabIndex = 1;
            BookNumber.TextChanged += textBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(144, 101);
            textBox1.MinimumSize = new Size(140, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 58);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(22, 101);
            label2.Name = "label2";
            label2.Size = new Size(106, 58);
            label2.TabIndex = 2;
            label2.Text = "Международный стандартный книжный номер";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click_1;
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(144, 184);
            textBox2.MinimumSize = new Size(140, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 58);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.Location = new Point(22, 184);
            label3.Name = "label3";
            label3.Size = new Size(106, 58);
            label3.TabIndex = 4;
            label3.Text = "Жанры";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(144, 258);
            textBox3.MinimumSize = new Size(140, 58);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 58);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Location = new Point(22, 258);
            label4.Name = "label4";
            label4.Size = new Size(106, 58);
            label4.TabIndex = 6;
            label4.Text = "Том";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Cursor = Cursors.IBeam;
            textBox4.Location = new Point(144, 335);
            textBox4.MinimumSize = new Size(140, 58);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(140, 58);
            textBox4.TabIndex = 9;
            // 
            // label5
            // 
            label5.Location = new Point(22, 335);
            label5.Name = "label5";
            label5.Size = new Size(106, 58);
            label5.TabIndex = 8;
            label5.Text = "Год выпуска";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.Cursor = Cursors.IBeam;
            textBox5.Location = new Point(144, 728);
            textBox5.MinimumSize = new Size(140, 58);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 58);
            textBox5.TabIndex = 19;
            // 
            // label6
            // 
            label6.Location = new Point(22, 728);
            label6.Name = "label6";
            label6.Size = new Size(106, 58);
            label6.TabIndex = 18;
            label6.Text = "Пометки";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Cursor = Cursors.IBeam;
            textBox6.Location = new Point(144, 651);
            textBox6.MinimumSize = new Size(140, 58);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 58);
            textBox6.TabIndex = 17;
            // 
            // label7
            // 
            label7.Location = new Point(22, 651);
            label7.Name = "label7";
            label7.Size = new Size(106, 58);
            label7.TabIndex = 16;
            label7.Text = "Цена";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            textBox7.Cursor = Cursors.IBeam;
            textBox7.Location = new Point(144, 577);
            textBox7.MinimumSize = new Size(140, 58);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(140, 58);
            textBox7.TabIndex = 15;
            // 
            // label8
            // 
            label8.Location = new Point(22, 577);
            label8.Name = "label8";
            label8.Size = new Size(106, 58);
            label8.TabIndex = 14;
            label8.Text = "Издательство";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox8
            // 
            textBox8.Cursor = Cursors.IBeam;
            textBox8.Location = new Point(144, 494);
            textBox8.MinimumSize = new Size(140, 58);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(140, 58);
            textBox8.TabIndex = 13;
            // 
            // label9
            // 
            label9.Location = new Point(22, 494);
            label9.Name = "label9";
            label9.Size = new Size(106, 58);
            label9.TabIndex = 12;
            label9.Text = "Автор";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox9
            // 
            textBox9.Cursor = Cursors.IBeam;
            textBox9.Location = new Point(144, 412);
            textBox9.MinimumSize = new Size(140, 58);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(140, 58);
            textBox9.TabIndex = 11;
            // 
            // label10
            // 
            label10.Location = new Point(22, 412);
            label10.Name = "label10";
            label10.Size = new Size(106, 58);
            label10.TabIndex = 10;
            label10.Text = "Название";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FindBooks
            // 
            FindBooks.Cursor = Cursors.Hand;
            FindBooks.Location = new Point(315, 258);
            FindBooks.Name = "FindBooks";
            FindBooks.Size = new Size(212, 294);
            FindBooks.TabIndex = 20;
            FindBooks.Text = "Найти книгу или книги";
            FindBooks.UseVisualStyleBackColor = true;
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 803);
            Controls.Add(FindBooks);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label9);
            Controls.Add(textBox9);
            Controls.Add(label10);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(BookNumber);
            Controls.Add(label1);
            Name = "Books";
            Text = "Books";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox BookNumber;
        public TextBox textBox1;
        private Label label2;
        public TextBox textBox2;
        private Label label3;
        public TextBox textBox3;
        private Label label4;
        public TextBox textBox4;
        private Label label5;
        public TextBox textBox5;
        private Label label6;
        public TextBox textBox6;
        private Label label7;
        public TextBox textBox7;
        private Label label8;
        public TextBox textBox8;
        private Label label9;
        public TextBox textBox9;
        private Label label10;
        private Button FindBooks;
    }
}