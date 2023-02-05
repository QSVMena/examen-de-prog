namespace Examen_de_Programacion
{
    public partial class Tabla : Form
    {
        public Tabla()
        {
            InitializeComponent();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int n = Tablas.Rows.Add();
            Tablas.Rows[n].Cells[0].Value = textCuentas.Text;
            Tablas.Rows[n].Cells[1].Value = textColumna1.Text;
            Tablas.Rows[n].Cells[2].Value = textColumna2.Text;
            Tablas.Rows[n].Cells[3].Value = textColumna3.Text;
            
            textCuentas.Text = " ";
            textColumna1.Text = " ";
            textColumna2.Text = " ";
            textColumna3.Text = " ";
        }

        private void Tabla_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSumaTotal_Click(object sender, EventArgs e)
        {
            int suma1 = 0;
            int a = Tablas.Rows.Add ();
            Tablas.Rows[a].Cells[0].Value = textCuentas.Text;

            foreach (DataGridViewRow row in Tablas.Rows)
            {
                suma1 += Convert.ToInt32((row.Cells["Column1"].Value));
                Tablas.Rows[a].Cells[2].Value = suma1;
            }
            textSuma1.Text = Convert.ToString(suma1);
            
        }

        private void btnSuma2_Click(object sender, EventArgs e)
        {
            int suma2 = 0;
            int b = Tablas.Rows.Add();
            Tablas.Rows[b].Cells[0].Value = textCuentas.Text;

            foreach (DataGridViewRow row in Tablas.Rows)
            {
                suma2 += Convert.ToInt32((row.Cells["Column2"].Value));
                Tablas.Rows[b].Cells[3].Value = suma2;
            }
            textSuma1.Text = Convert.ToString(suma2);


        }

        private void btnsuma3_Click(object sender, EventArgs e)
        {
            int suma3 = 0;
            int c = Tablas.Rows.Add();
            Tablas.Rows[c].Cells[0].Value = textCuentas.Text;

            foreach (DataGridViewRow row in Tablas.Rows)
            {
                suma3 += Convert.ToInt32((row.Cells["Column3"].Value));
                Tablas.Rows[c].Cells[4].Value = suma3;
            }
            textSuma1.Text = Convert.ToString(suma3);

        }

        private void btnResta1_Click(object sender, EventArgs e)
        {
            int resta1 = 0;
            int d = Tablas.Rows.Add();
            Tablas.Rows[d].Cells[0].Value = textCuentas.Text;

            foreach (DataGridViewRow row in Tablas.Rows)
            {
                resta1 -= Convert.ToInt32((row.Cells["Column1"].Value));
                Tablas.Rows[d].Cells[2].Value = resta1;
            }
            textSuma1.Text = Convert.ToString(resta1);
        }

        private void btnResta2_Click(object sender, EventArgs e)
        {
            int resta2 = 0;
            int i = Tablas.Rows.Add();
            Tablas.Rows[i].Cells[0].Value = textCuentas.Text;

            foreach (DataGridViewRow row in Tablas.Rows)
            {
                resta2 -= Convert.ToInt32((row.Cells["Column2"].Value));
                Tablas.Rows[i].Cells[3].Value = resta2;
            }
            textSuma1.Text = Convert.ToString(resta2);
        }

        private void btnResta3_Click(object sender, EventArgs e)
        {
            int resta3 = 0;
            int f = Tablas.Rows.Add();
            Tablas.Rows[f].Cells[0].Value = textCuentas.Text;

            foreach (DataGridViewRow row in Tablas.Rows)
            {
                resta3 -= Convert.ToInt32((row.Cells["Column3"].Value));
                Tablas.Rows[f].Cells[4].Value = resta3;
            }
            textSuma1.Text = Convert.ToString(resta3);
        }
    }
}

