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
            double total = 0;
            int a = Tablas.Rows.Add();
            Tablas.Rows[a].Cells[0].Value = textCuentas.Text;
            foreach (DataGridViewRow row in Tablas.Rows)
            {
                total += Convert.ToDouble(row.Cells["Column2"].Value);
                Tablas.Rows[a].Cells[3].Value = total;
            }
            textSuma1.Text = Convert.ToString(total);
        }

        private void btnSuma2_Click(object sender, EventArgs e)
        {
            double suma = 0;
            int b = Tablas.Rows.Add();
            Tablas.Rows[b].Cells[0].Value = textCuentas.Text;
            foreach (DataGridViewRow row in Tablas.Rows)
            {
                suma += Convert.ToDouble(row.Cells["Column3"].Value);
                Tablas.Rows[b].Cells[3].Value = suma;
            }
            textSuma2.Text = Convert.ToString(suma);


        }

        private void btnsuma3_Click(object sender, EventArgs e)
        {
            double suma3 = 0;
            int c = Tablas.Rows.Add();
            Tablas.Rows[c].Cells[0].Value = textCuentas.Text;
            foreach (DataGridViewRow row in Tablas.Rows)
            {
                suma3 += Convert.ToDouble(row.Cells["Column4"].Value);
                Tablas.Rows[c].Cells[4].Value = suma3;
            }
            textSuma3.Text = Convert.ToString(suma3);
        }
        
        private void btnResta1_Click(object sender, EventArgs e)
        {
            double resta = 0;
            int a = Tablas.Rows.Add();
            Tablas.Rows[a].Cells[0].Value = textCuentas.Text;
            foreach (DataGridViewRow row in Tablas.Rows)
            {
                resta -= Convert.ToDouble(row.Cells["Column2"].Value);
                Tablas.Rows[a].Cells[3].Value = resta;
            }
            textResta1.Text = Convert.ToString(resta);
        }

        private void btnResta2_Click(object sender, EventArgs e)
        {
       
        }

        private void btnResta3_Click(object sender, EventArgs e)
        {

        }

        private void textCuentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSuma1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

