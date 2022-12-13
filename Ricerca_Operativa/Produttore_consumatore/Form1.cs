using System.Runtime.CompilerServices;

namespace Produttore_consumatore
{
    public partial class Form1 : Form
    {
        bool tabella = false;
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
            if (int.Parse(produttori.Text) < 1 && int.Parse(consumatori.Text) < 1)
            {
                MessageBox.Show("Campi vuoiti! Inserire i dati neccessari!");
                tabella = false;
            }
            else
            {
                matrice.Columns.Clear();
                matrice.Rows.Clear();
                tabella = true;
                if (int.Parse(produttori.Text) > 1 && int.Parse(consumatori.Text) > 1)
                {
                    matrice.RowHeadersVisible = false;
                    matrice.Columns.Add("", "");
                    for (int i = 1; i < int.Parse(consumatori.Text) + 1; i++)
                    {
                        matrice.Columns.Add("Col_D" + i, "D" + i);
                    }

                    for (int i = 1; i < int.Parse(produttori.Text) + 1; i++)
                    {
                        matrice.Rows.Add("P" + i);
                    }

                    matrice.Columns[0].ReadOnly = true;
                    matrice.Columns.Add("Col_tot", "Totali");
                    matrice.Rows.Add("Totali");
                    foreach (DataGridViewColumn dgvc in matrice.Columns)
                    {
                        dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
                else
                {
                    MessageBox.Show("I campi devono essere magggiore di uno per avere senso");
                    tabella = false;
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

        public bool controllo_vuoto()
        {
            int count = 0;
            for(int i = 1; i < matrice.ColumnCount; i++)
            {
                for (int j = 0; j < matrice.RowCount; j++)
                {
                    if (matrice[i,j].Value == null)
                    {
                        count++;
                    }
                }
            }
            if(count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private void riempi_Click(object sender, EventArgs e)
        {
            if (tabella == true)
            {
                if (controllo_vuoto() == false)
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
                else
                {
                    MessageBox.Show("Genera tabella");
                }
            }
            else
            {
                MessageBox.Show("Tabella non creata");
            }  
        }

        private bool controllo()
        {
            int y = matrice.RowCount - 1;
            int x = matrice.ColumnCount - 1;
            int somma_row = 0;
            for (int i = 0; i < y; i++)
            {
                somma_row += int.Parse(matrice[x, i].Value.ToString());
            }
            int somma_col = 0;
            for(int i = 1; i < x; i++)
            {
                somma_col += int.Parse(matrice[i, y].Value.ToString());
            }
            if(somma_col == somma_row)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void nord_ovest_Click(object sender, EventArgs e)
        {
 
            int costi = 0;
            int prodotto;
            if (tabella == true)
            {
                if (controllo_vuoto() == true)
                {
                    if (controllo() == true)
                    {

                        istruzioni.Visible = true;
                        operazioni.Items.Add("NORD-OVEST\n");
                        int tot = int.Parse(matrice[matrice.ColumnCount - 1, matrice.RowCount - 1].Value.ToString());
                        while (matrice.Rows.Count > 1 && matrice.RowCount > 1)
                        {
                            int col = int.Parse(matrice[matrice.ColumnCount - 1, 0].Value.ToString());
                            int row = int.Parse(matrice[1, matrice.RowCount - 1].Value.ToString());
                            int n = int.Parse(matrice[1, 0].Value.ToString());
                            if (col > row)
                            {
                                col -= row;
                                tot -= row;
                                matrice[matrice.ColumnCount - 1, 0].Value = col;
                                matrice[matrice.ColumnCount - 1, matrice.RowCount - 1].Value = tot;
                                costi += n * row;
                                prodotto = n * row;
                                operazioni.Items.Add(n.ToString() + " x " + row.ToString() + " = " + prodotto.ToString() + "\n");
                                matrice.Columns.Remove(matrice.Columns[1]);
                            }
                            else
                            {
                                row -= col;
                                tot -= col;
                                matrice[1, matrice.RowCount - 1].Value = row;
                                matrice[matrice.ColumnCount - 1, matrice.RowCount - 1].Value = tot;
                                costi += n * col;
                                prodotto = n * col;
                                operazioni.Items.Add(n.ToString() + " x " + col.ToString() + " = " + prodotto.ToString() + "\n");
                                matrice.Rows.Remove(matrice.Rows[0]);
                            }
                            var pause = Task.Delay(1000);
                            pause.Wait();
                        }

                        operazioni.Items.Add("Costo totale: " + costi.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Le somma non coincidono");
                }
            }
        }

        private void nuovo_Click(object sender, EventArgs e)
        {
            istruzioni.Visible = false;
            operazioni.Items.Clear(); 
        }
    }
}