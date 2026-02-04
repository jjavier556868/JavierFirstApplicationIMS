using IMS.Infrastracture.Data;

namespace IMS.Application
{
    public partial class Form1 : Form
    {

        private AppDbContext _context = new AppDbContext();
        public Form1() { 
            InitializeComponent();
            LoadPrograms();
        }

        //CRUD - Read Operation (Listing Programs)
        private void LoadPrograms()
        {
            using (var _context = new AppDbContext())
            {
                dataGridView1.DataSource = _context.Programs.ToList();
            }
        }
    }
}
