namespace Produttore_consumatore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matrice.AllowUserToAddRows = false;
            matrice.AllowUserToDeleteRows = false;
            matrice.AllowDrop = false;
            matrice.AllowUserToOrderColumns = false;
            matrice.AllowUserToResizeColumns = false;
            matrice.AllowUserToResizeRows = false;
            
        }

        private void genera_Click(object sender, EventArgs e)
        {
            matrice.Columns.Clear();
            matrice.Rows.Clear();   
            if(produttori.Text == "" || consumatori.Text == "")
            {
                MessageBox.Show("Campi vuoiti! Inserire i dati neccessari!");
            }
            else
            {
                if(int.Parse(produttori.Text) > 1 && int.Parse(consumatori.Text) > 1)
                {
                    matrice.RowHeadersVisible = false;
                    matrice.Columns.Add("", "");
                    for(int i = 1; i<int.Parse(consumatori.Text)+1; i++)
                    {
                        matrice.Columns.Add("Col_D" + i, "D" + i);
                    }
                                     
                    for(int i = 1; i < int.Parse(produttori.Text)+1; i++)
                    {
                        matrice.Rows.Add("P" + i);
                    }

                    matrice.Columns[0].ReadOnly = true;
                    matrice.Columns.Add("Col_tot", "Totali");
                    matrice.Rows.Add("Totali");
                    foreach(DataGridViewColumn dgvc in matrice.Columns)
                    {
                        dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
                else
                {
                    MessageBox.Show("I campi devono essere magggiore di uno per avere senso");
                }

            }
        }

        private void Solonumeri(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void matrice_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= Solonumeri;
            e.Control.KeyPress += Solonumeri;
        }

        private void produttori_Click(object sender, EventArgs e)
        {
            produttori.Text = "";
        }

        private void consumatori_Click(object sender, EventArgs e)
        {
            consumatori.Text = "";
        }

        private void riempi_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int i = 0; i < matrice.Rows.Count - 1; i++)
            {
                for (int j = 1; j < matrice.Columns.Count - 1; j++) 
                {
                    matrice.Rows[i].Cells[j].Value = r.Next(0, 200);
                }
            }
            int tot = 0;
            int n;
            for (int i = 1; i < matrice.ColumnCount - 1; i++)
            {
                n = r.Next(0, 100);
                matrice[i, matrice.RowCount - 1].Value = n;
                tot += n;
            }
            matrice[matrice.ColumnCount - 1, matrice.RowCount - 1].Value = tot;

            for (int j = 0; j < matrice.RowCount - 2; j++)
            {
                n = r.Next(0, tot);
                matrice[matrice.ColumnCount - 1, j].Value = n;
                tot -= n;
            }
            int value = tot;
            matrice[matrice.ColumnCount - 1, matrice.RowCount - 2].Value = value;
            matrice.ReadOnly = true;
        }
    }
}