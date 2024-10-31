using NewSCodeFirst.DAI;

namespace NewSCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewsContext db = new NewsContext();
            // dgv_students.DataSource = db.students.Include(n=>n.department).ToList();
            AllNews.DataSource = db.News.ToList();

        }
    }
}
