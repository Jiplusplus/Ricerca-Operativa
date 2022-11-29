namespace Produttore_consumatore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.matrice = new System.Windows.Forms.DataGridView();
            this.genera = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.produttori = new System.Windows.Forms.NumericUpDown();
            this.consumatori = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.riempi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumatori)).BeginInit();
            this.SuspendLayout();
            // 
            // matrice
            // 
            this.matrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.matrice.BackgroundColor = System.Drawing.Color.White;
            this.matrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrice.Location = new System.Drawing.Point(23, 166);
            this.matrice.Name = "matrice";
            this.matrice.RowTemplate.Height = 25;
            this.matrice.Size = new System.Drawing.Size(1008, 423);
            this.matrice.TabIndex = 0;
            this.matrice.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrice_EditingControlShowing);
            // 
            // genera
            // 
            this.genera.Location = new System.Drawing.Point(683, 121);
            this.genera.Name = "genera";
            this.genera.Size = new System.Drawing.Size(75, 28);
            this.genera.TabIndex = 3;
            this.genera.Text = "GENERA";
            this.genera.UseVisualStyleBackColor = true;
            this.genera.Click += new System.EventHandler(this.genera_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label.Location = new System.Drawing.Point(121, 128);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 15);
            this.label.TabIndex = 4;
            this.label.Text = "NUMERO PRODUTTORI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(396, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "NUMERO CONSUMATORI";
            // 
            // produttori
            // 
            this.produttori.Location = new System.Drawing.Point(256, 124);
            this.produttori.Name = "produttori";
            this.produttori.Size = new System.Drawing.Size(120, 23);
            this.produttori.TabIndex = 7;
            this.produttori.Click += new System.EventHandler(this.produttori_Click);
            // 
            // consumatori
            // 
            this.consumatori.Location = new System.Drawing.Point(544, 126);
            this.consumatori.Name = "consumatori";
            this.consumatori.Size = new System.Drawing.Size(120, 23);
            this.consumatori.TabIndex = 8;
            this.consumatori.Click += new System.EventHandler(this.consumatori_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(186, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 86);
            this.label1.TabIndex = 9;
            this.label1.Text = "RICERCA OPERATIVA";
            // 
            // riempi
            // 
            this.riempi.Location = new System.Drawing.Point(776, 121);
            this.riempi.Name = "riempi";
            this.riempi.Size = new System.Drawing.Size(75, 28);
            this.riempi.TabIndex = 10;
            this.riempi.Text = "RIEMPI";
            this.riempi.UseVisualStyleBackColor = true;
            this.riempi.Click += new System.EventHandler(this.riempi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::Produttore_consumatore.Properties.Resources.sfondo_applicazioni;
            this.ClientSize = new System.Drawing.Size(1056, 601);
            this.Controls.Add(this.riempi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consumatori);
            this.Controls.Add(this.produttori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.genera);
            this.Controls.Add(this.matrice);
            this.MinimumSize = new System.Drawing.Size(1072, 640);
            this.Name = "Form1";
            this.Text = "Ricerca Operativa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produttori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView matrice;
        private Button genera;
        private Label label;
        private Label label2;
        private NumericUpDown produttori;
        private NumericUpDown consumatori;
        private Label label1;
        private Button riempi;
    }
}