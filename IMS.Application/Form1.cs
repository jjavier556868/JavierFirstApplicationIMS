using IMS.Domain.Models;
using IMS.Infrastracture.Data;

namespace IMS.Application
{
    public partial class Form1 : Form
    {

        private AppDbContext _context = new AppDbContext();
        public Form1()
        {
            InitializeComponent();
            LoadPrograms();
        }

        //CRUD - Read Operation (Listing Programs)
        private void LoadPrograms(string? searchTerm = null)
        {
            using (var _context = new AppDbContext())
            {
                if (string.IsNullOrEmpty(searchTerm))
                {
                    dataGridView1.DataSource = _context.Programs.ToList();
                }
                else
                {
                    dataGridView1.DataSource = _context.Programs
                        .Where(p => p.MyProperty.ToString().Contains(searchTerm) ||
                        p.Name.ToLower().Contains(searchTerm) ||
                        p.Description.ToLower().Contains(searchTerm)).ToList();
                }
            }
        }

        //CRUD reading operation
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            LoadPrograms(txtBoxSearch.Text.ToLower());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var _context = new AppDbContext())
                {

                    var program = new Programs
                    {
                        Name = txtBoxName.Text.Trim(),
                        Description = txtBoxDescription.Text.Trim()
                    };

                    _context.Programs.Add(program);
                    _context.SaveChanges();

                    MessageBox.Show("Program saved/updated successfully!");
                    LoadPrograms();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //CRUD Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var _context = new AppDbContext())
            {
                if (string.IsNullOrEmpty(txtBoxID.Text.Trim()))
                {
                    MessageBox.Show("Please enter a valid Program ID to delete");
                    return;
                }
                var programId = int.Parse(txtBoxID.Text.Trim());
                var entity = _context.Programs.Find(programId);
                if (entity != null)
                {
                    _context.Programs.Remove(entity);
                    _context.SaveChanges();
                    MessageBox.Show("Program deleted successfully!");
                    LoadPrograms();
                }
                else
                {
                    MessageBox.Show("Program not found!");
                }

            }
        }

        private void txtBoxName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBoxDescription.Focus();
            }
        }

        private void txtBoxDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
    }
}
