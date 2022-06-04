namespace EstructuraWF
{
    public partial class Form1 : Form
    {
        public List<Libro> libros { get; set; }
        public Form1()
        {
            InitializeComponent();
            libros = new List<Libro>();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            
            var lib = new Libro();
            lib.titulo = tituloTxt.Text;
            lib.editorial = editorialTxt.Text;
            lib.categoria = categoriaTxt.Text;
            lib.autor = autorTxt.Text;
            lib.anio = anioTxt.Text;

            libros.Add(lib);
            dataGridView1.DataSource = libros;
        }
    }
}