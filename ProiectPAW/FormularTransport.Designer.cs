namespace ProiectPAW
{
    partial class FormularTransport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularTransport));
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdaugaTransport = new System.Windows.Forms.Button();
            this.lvSofer = new System.Windows.Forms.ListView();
            this.lvMasina = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epDenumireIncarcatura = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbOras = new System.Windows.Forms.ComboBox();
            this.btnFormularGestiune = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumireIncarcatura)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(9, 206);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(2);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(128, 20);
            this.tbDenumire.TabIndex = 21;
            this.tbDenumire.Validating += new System.ComponentModel.CancelEventHandler(this.tbDenumire_Validating);
            this.tbDenumire.Validated += new System.EventHandler(this.tbDenumire_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Denumire incarcatura:";
            // 
            // btnAdaugaTransport
            // 
            this.btnAdaugaTransport.Location = new System.Drawing.Point(664, 48);
            this.btnAdaugaTransport.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugaTransport.Name = "btnAdaugaTransport";
            this.btnAdaugaTransport.Size = new System.Drawing.Size(70, 41);
            this.btnAdaugaTransport.TabIndex = 19;
            this.btnAdaugaTransport.Text = "Adauga\r\ncursa";
            this.btnAdaugaTransport.UseVisualStyleBackColor = true;
            this.btnAdaugaTransport.Click += new System.EventHandler(this.btnAdaugaTransport_Click);
            // 
            // lvSofer
            // 
            this.lvSofer.HideSelection = false;
            this.lvSofer.Location = new System.Drawing.Point(9, 115);
            this.lvSofer.Margin = new System.Windows.Forms.Padding(2);
            this.lvSofer.Name = "lvSofer";
            this.lvSofer.Size = new System.Drawing.Size(542, 62);
            this.lvSofer.TabIndex = 18;
            this.lvSofer.UseCompatibleStateImageBehavior = false;
            // 
            // lvMasina
            // 
            this.lvMasina.HideSelection = false;
            this.lvMasina.Location = new System.Drawing.Point(9, 24);
            this.lvMasina.Margin = new System.Windows.Forms.Padding(2);
            this.lvMasina.Name = "lvMasina";
            this.lvMasina.Size = new System.Drawing.Size(542, 65);
            this.lvMasina.TabIndex = 17;
            this.lvMasina.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selectati un sofer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selectati o masina:";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip.Location = new System.Drawing.Point(0, 299);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(794, 26);
            this.statusStrip.TabIndex = 24;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despreToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // despreToolStripMenuItem
            // 
            this.despreToolStripMenuItem.Name = "despreToolStripMenuItem";
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // epDenumireIncarcatura
            // 
            this.epDenumireIncarcatura.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 238);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Oras destinatie:";
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
            this.cbOras.Location = new System.Drawing.Point(11, 254);
            this.cbOras.Margin = new System.Windows.Forms.Padding(2);
            this.cbOras.Name = "cbOras";
            this.cbOras.Size = new System.Drawing.Size(128, 21);
            this.cbOras.TabIndex = 26;
            // 
            // btnFormularGestiune
            // 
            this.btnFormularGestiune.Location = new System.Drawing.Point(664, 175);
            this.btnFormularGestiune.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormularGestiune.Name = "btnFormularGestiune";
            this.btnFormularGestiune.Size = new System.Drawing.Size(70, 41);
            this.btnFormularGestiune.TabIndex = 27;
            this.btnFormularGestiune.Text = "Anulare";
            this.btnFormularGestiune.UseVisualStyleBackColor = true;
            this.btnFormularGestiune.Click += new System.EventHandler(this.btnFormularGestiune_Click);
            // 
            // FormularTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 325);
            this.Controls.Add(this.btnFormularGestiune);
            this.Controls.Add(this.cbOras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdaugaTransport);
            this.Controls.Add(this.lvSofer);
            this.Controls.Add(this.lvMasina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularTransport";
            this.Text = "Formular adaugare transport";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularTransport_FormClosed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epDenumireIncarcatura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdaugaTransport;
        private System.Windows.Forms.ListView lvSofer;
        private System.Windows.Forms.ListView lvMasina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epDenumireIncarcatura;
        private System.Windows.Forms.ComboBox cbOras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFormularGestiune;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}