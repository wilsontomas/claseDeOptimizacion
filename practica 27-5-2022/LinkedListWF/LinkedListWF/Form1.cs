namespace LinkedListWF
{
    public partial class Form1 : Form
    {
        public LinkedList<string> studentList { get; set; }
        public Form1()
        {
            InitializeComponent();
            studentList = new LinkedList<string>();
        }

        private void AddFirstBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Addtxt.Text))
                studentList.AddFirst(Addtxt.Text);
            else MessageBox.Show("Debe llenar el campo");

            listBox1.DataSource = studentList.ToList();
            Addtxt.Text = "";
        }

        private void AddLastBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Addtxt.Text))
                studentList.AddLast(Addtxt.Text);
            else MessageBox.Show("Debe llenar el campo");

            listBox1.DataSource = studentList.ToList();
            Addtxt.Text = "";
        }

        private void AverifyBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(VerifyTxt.Text))
            {
                if (studentList.Any(x => x.Equals(VerifyTxt.Text)))
                    MessageBox.Show("El valor se encuentra en la lista");
                else MessageBox.Show("Valor no encontrado");
               
            } else 
            { MessageBox.Show("Debe llenar el campo de busqueda"); }
            VerifyTxt.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(MoveLastTxt.Text))
            {
                var node = studentList.FirstOrDefault(x => x.Equals(MoveLastTxt.Text));
                if (node !=null)
                {
                    studentList.Remove(node);
                    studentList.AddLast(node);
                    listBox1.DataSource = studentList.ToList();

                }
                else MessageBox.Show("Valor no encontrado");

            }
            else
            { MessageBox.Show("Debe llenar el campo para mover"); }
            MoveLastTxt.Text = "";
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RemoveTxt.Text))
            {
                var node = studentList.FirstOrDefault(x => x.Equals(RemoveTxt.Text));
                if (node != null)
                {
                    studentList.Remove(node);
                    listBox1.DataSource = studentList.ToList();

                }
                else MessageBox.Show("Valor no encontrado");

            }
            else MessageBox.Show("Debe llenar el campo de busqueda");
            RemoveTxt.Text = "";
        }
    }
}