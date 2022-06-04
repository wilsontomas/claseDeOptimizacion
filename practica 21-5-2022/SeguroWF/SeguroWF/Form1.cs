namespace SeguroWF
{
    public partial class Form1 : Form
    {
        public List<Persona> personas { get; set; }
        public int generador { get; set; }
        public double afp { get; set; }
        public double sfs { get; set; }
        public Form1()
        {
            InitializeComponent();
            personas = new List<Persona>();
            afp = 2.87;
            sfs = 3.04;
            generador = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var per = new Persona();
            per.id = generador;
            per.nombre = nombre.Text ?? "N/A";
            per.cargo = cargo.Text ?? "N/A";
            double valor = 0;
            var salarioStr = salario.Text;
            if (!double.TryParse(salarioStr, out valor))
                valor = 0;

            per.sueldo = valor;
            per.afp = (per.sueldo / 100) * afp;
            per.sfs = (per.sueldo / 100) * sfs;
            per.total = per.sueldo - per.afp - per.sfs;
            personas.Add(per);
            fillList(personas);
            generador++;
            contador.Text = personas.Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var termino = buscarTxt.Text;
            if (personas.Any(x => x.nombre == termino))
                MessageBox.Show("Se encontro la persona");
            else MessageBox.Show("No se encontro la persona");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var termino = eliminarTxt.Text;
            var persona = personas.FirstOrDefault(x => x.nombre == termino);
            if (persona != null)
            {
                personas.Remove(persona);
               
                fillList(personas);
                MessageBox.Show("Se elimino la persona");
            }
            else
              MessageBox.Show("La persona no existe");

            contador.Text = personas.Count().ToString();
        }

        private void fillList(List<Persona> persona)
        {
            listBox1.MultiColumn = true;

            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Items.Clear();
            foreach (var item in persona) 
            {
              var valor = string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
            item.id,
            item.nombre,
            item.cargo,
            item.sueldo,
            item.afp,
            item.sfs,
            item.total
            
            );


                listBox1.Items.Add(valor);
                
            }
        }
    }
}