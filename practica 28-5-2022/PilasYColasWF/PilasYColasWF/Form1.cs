namespace PilasYColasWF
{
    public partial class Form1 : Form
    {
        public Queue<string> fila { get; set; }
        public Stack<string> pila { get; set; }
        public Form1()
        {
            InitializeComponent();
            fila = new Queue<string>();
            pila = new Stack<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valor = filaTxt.Text;
            fila.Enqueue(valor);
            filaTxt.Text = "";
            loadFila();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string valor = pilaTxt.Text;
            pila.Push(valor);
            pilaTxt.Text = "";
            loadPila();
        }

        private void loadFila()
        {
            filaList.DataSource = fila.ToList();
        }
        private void loadPila()
        {
            pilaList.DataSource = pila.ToList();
        }

        private void deleteFila()
        {
           
            DialogResult result = MessageBox.
                Show("Eliminar Elemento", "Desea eliminar el elemento de la fila?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                fila.Dequeue();
                loadFila();
            }
            
        }
        private void deletePila() 
        {
            DialogResult result = MessageBox.
                  Show("Eliminar elemento", "Desea Eliminar el elemento de la pila?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                pila.Pop();
                loadPila();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteFila();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            deletePila();
        }
    }
}