namespace GeneratoreParoleApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start_singolo = new System.Windows.Forms.Button();
            this.btn_start_tre = new System.Windows.Forms.Button();
            this.btn_gara = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pgb_singolo = new System.Windows.Forms.ProgressBar();
            this.pgb_tre = new System.Windows.Forms.ProgressBar();
            this.tb_singolo = new System.Windows.Forms.TextBox();
            this.tb_tre = new System.Windows.Forms.TextBox();
            this.bgw_singolo = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btn_start_singolo
            // 
            this.btn_start_singolo.Location = new System.Drawing.Point(23, 40);
            this.btn_start_singolo.Name = "btn_start_singolo";
            this.btn_start_singolo.Size = new System.Drawing.Size(75, 23);
            this.btn_start_singolo.TabIndex = 0;
            this.btn_start_singolo.Text = "Start";
            this.btn_start_singolo.UseVisualStyleBackColor = true;
            this.btn_start_singolo.Click += new System.EventHandler(this.btn_start_singolo_Click);
            // 
            // btn_start_tre
            // 
            this.btn_start_tre.Location = new System.Drawing.Point(23, 100);
            this.btn_start_tre.Name = "btn_start_tre";
            this.btn_start_tre.Size = new System.Drawing.Size(75, 23);
            this.btn_start_tre.TabIndex = 1;
            this.btn_start_tre.Text = "Start";
            this.btn_start_tre.UseVisualStyleBackColor = true;
            // 
            // btn_gara
            // 
            this.btn_gara.Location = new System.Drawing.Point(23, 138);
            this.btn_gara.Name = "btn_gara";
            this.btn_gara.Size = new System.Drawing.Size(297, 23);
            this.btn_gara.TabIndex = 2;
            this.btn_gara.Text = "Gara";
            this.btn_gara.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Singolo Thread";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tre Thread";
            // 
            // pgb_singolo
            // 
            this.pgb_singolo.Location = new System.Drawing.Point(113, 24);
            this.pgb_singolo.Name = "pgb_singolo";
            this.pgb_singolo.Size = new System.Drawing.Size(207, 13);
            this.pgb_singolo.TabIndex = 5;
            // 
            // pgb_tre
            // 
            this.pgb_tre.Location = new System.Drawing.Point(113, 84);
            this.pgb_tre.Name = "pgb_tre";
            this.pgb_tre.Size = new System.Drawing.Size(207, 13);
            this.pgb_tre.TabIndex = 6;
            // 
            // tb_singolo
            // 
            this.tb_singolo.Location = new System.Drawing.Point(113, 43);
            this.tb_singolo.Name = "tb_singolo";
            this.tb_singolo.Size = new System.Drawing.Size(207, 20);
            this.tb_singolo.TabIndex = 7;
            // 
            // tb_tre
            // 
            this.tb_tre.Location = new System.Drawing.Point(113, 103);
            this.tb_tre.Name = "tb_tre";
            this.tb_tre.Size = new System.Drawing.Size(207, 20);
            this.tb_tre.TabIndex = 8;
            // 
            // bgw_singolo
            // 
            this.bgw_singolo.WorkerReportsProgress = true;
            this.bgw_singolo.WorkerSupportsCancellation = true;
            this.bgw_singolo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_singolo_DoWork);
            this.bgw_singolo.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_singolo_ProgressChanged);
            this.bgw_singolo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_singolo_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 173);
            this.Controls.Add(this.tb_tre);
            this.Controls.Add(this.tb_singolo);
            this.Controls.Add(this.pgb_tre);
            this.Controls.Add(this.pgb_singolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_gara);
            this.Controls.Add(this.btn_start_tre);
            this.Controls.Add(this.btn_start_singolo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start_singolo;
        private System.Windows.Forms.Button btn_start_tre;
        private System.Windows.Forms.Button btn_gara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgb_singolo;
        private System.Windows.Forms.ProgressBar pgb_tre;
        private System.Windows.Forms.TextBox tb_singolo;
        private System.Windows.Forms.TextBox tb_tre;
        private System.ComponentModel.BackgroundWorker bgw_singolo;
    }
}

