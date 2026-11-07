namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerProducto_Click(object sender, EventArgs e)
        {
            using (var context = new Data.AppDbContext())
            {
                var productos = context.Productos.ToList();
               
            }
        }
    }
}
