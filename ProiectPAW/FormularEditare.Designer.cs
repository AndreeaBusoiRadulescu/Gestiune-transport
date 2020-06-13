namespace ProiectPAW
{
    partial class FormularEditare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFormularGestiune = new System.Windows.Forms.Button();
            this.cbOras = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalveza = new System.Windows.Forms.Button();
            this.lvSofer = new System.Windows.Forms.ListView();
            this.lvMasina = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFormularGestiune
            // 
            this.btnFormularGestiune.Location = new System.Drawing.Point(426, 226);
            this.btnFormularGestiune.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormularGestiune.Name = "btnFormularGestiune";
            this.btnFormularGestiune.Size = new System.Drawing.Size(70, 41);
            this.btnFormularGestiune.TabIndex = 37;
            this.btnFormularGestiune.Text = "Anulare";
            this.btnFormularGestiune.UseVisualStyleBackColor = true;
            this.btnFormularGestiune.Click += new System.EventHandler(this.btnFormularGestiune_Click);
            // 
            // cbOras
            // 
            this.cbOras.FormattingEnabled = true;
            this.cbOras.Items.AddRange(new object[] {
            "BUCURESTI",
            "PITESTI",
            "TARGOVISTE",
            "PLOIESTI",
            "VALCEA",
            "CONSTANTA"});
            this.cbOras.Location = new System.Drawing.Point(13, 256);
            this.cbOras.Margin = new System.Windows.Forms.Padding(2);
            this.cbOras.Name = "cbOras";
            this.cbOras.Size = new System.Drawing.Size(162, 21);
            this.cbOras.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Oras destinatie:";
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(11, 208);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(2);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(164, 20);
            this.tbDenumire.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Denumire incarcatura:";
            // 
            // btnSalveza
            // 
            this.btnSalveza.Location = new System.Drawing.Point(257, 226);
            this.btnSalveza.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalveza.Name = "btnSalveza";
            this.btnSalveza.Size = new System.Drawing.Size(70, 41);
            this.btnSalveza.TabIndex = 32;
            this.btnSalveza.Text = "Salveza";
            this.btnSalveza.UseVisualStyleBackColor = true;
            this.btnSalveza.Click += new System.EventHandler(this.btnSalveza_Click);
            // 
            // lvSofer
            // 
            this.lvSofer.HideSelection = false;
            this.lvSofer.Location = new System.Drawing.Point(11, 117);
            this.lvSofer.Margin = new System.Windows.Forms.Padding(2);
            this.lvSofer.Name = "lvSofer";
            this.lvSofer.Size = new System.Drawing.Size(542, 62);
            this.lvSofer.TabIndex = 31;
            this.lvSofer.UseCompatibleStateImageBehavior = false;
            // 
            // lvMasina
            // 
            this.lvMasina.HideSelection = false;
            this.lvMasina.Location = new System.Drawing.Point(11, 26);
            this.lvMasina.Margin = new System.Windows.Forms.Padding(2);
            this.lvMasina.Name = "lvMasina";
            this.lvMasina.Size = new System.Drawing.Size(542, 65);
            this.lvMasina.TabIndex = 30;
            this.lvMasina.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Selectati un sofer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selectati o masina:";
            // 
            // FormularEditare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 329);
            this.Controls.Add(this.btnFormularGestiune);
            this.Controls.Add(this.cbOras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalveza);
            this.Controls.Add(this.lvSofer);
            this.Controls.Add(this.lvMasina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularEditare";
            this.Text = "Editare";
            this.Load += new System.EventHandler(this.FormularEditare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFormularGestiune;
        private System.Windows.Forms.ComboBox cbOras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalveza;
        private System.Windows.Forms.ListView lvSofer;
        private System.Windows.Forms.ListView lvMasina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}