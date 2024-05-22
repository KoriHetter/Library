namespace Library
{
    partial class MainWindow
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
            ToBook = new Button();
            ToLibrarians = new Button();
            ToUsers = new Button();
            SuspendLayout();
            // 
            // ToBook
            // 
            ToBook.Cursor = Cursors.Hand;
            ToBook.Location = new Point(51, 136);
            ToBook.Name = "ToBook";
            ToBook.Size = new Size(199, 144);
            ToBook.TabIndex = 0;
            ToBook.Text = "Книги";
            ToBook.UseVisualStyleBackColor = true;
            ToBook.Click += ToBooks_Click;
            // 
            // ToLibrarians
            // 
            ToLibrarians.Cursor = Cursors.Hand;
            ToLibrarians.Location = new Point(282, 136);
            ToLibrarians.Name = "ToLibrarians";
            ToLibrarians.Size = new Size(216, 144);
            ToLibrarians.TabIndex = 1;
            ToLibrarians.Text = "Библиотекари";
            ToLibrarians.UseVisualStyleBackColor = true;
            ToLibrarians.Click += ToLibrarians_Click;
            // 
            // ToUsers
            // 
            ToUsers.Cursor = Cursors.Hand;
            ToUsers.Location = new Point(536, 136);
            ToUsers.Name = "ToUsers";
            ToUsers.Size = new Size(204, 144);
            ToUsers.TabIndex = 2;
            ToUsers.Text = "Пользователи";
            ToUsers.UseVisualStyleBackColor = true;
            ToUsers.Click += ToUsers_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToUsers);
            Controls.Add(ToLibrarians);
            Controls.Add(ToBook);
            Name = "MainWindow";
            Text = "Управляющая вкладка";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ToBook;
        private Button ToLibrarians;
        private Button ToUsers;
    }
}
