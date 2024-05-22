namespace Library
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToLibrarians_Click(object sender, EventArgs e)
        {
            Librarians librarians = new Librarians();
            librarians.Show();
        }

        private void ToBooks_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
        }

        private void ToUsers_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
        }
    }
}
