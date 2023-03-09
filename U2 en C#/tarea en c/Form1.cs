using Microsoft.VisualBasic;

namespace tarea_en_c
{
    public partial class Form1 : Form
    {
        Persona[] p;

        Contacto[] c;
            
        public Form1()
        {
            InitializeComponent();

        }
        int index = 0;
        int lengtch = 10;
        
        private void btmGuardar_Click(object sender, EventArgs e)
        {
            if (index==lengtch) { return; }
            c= new Contacto[lengtch];
            c[index] = new Contacto();
            c[index].Nombre = txtNombre.Text;
            c[index].FechaNacimiento = dtpFechaDeNacimiento.Value;
            dtpFechaDeNacimiento.Value=DateTime.Now;
            c[index].Telefono = txtTelefono.Text;
            string espacio = c.ToString() + Environment.NewLine;
          label5.Text = label5.Text + espacio; 
             index++;
        }
    }
}