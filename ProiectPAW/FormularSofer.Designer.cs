namespace ProiectPAW
{
    partial class FormularSofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularSofer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataAngajarii = new System.Windows.Forms.DateTimePicker();
            this.tbNumeSofer = new System.Windows.Forms.TextBox();
            this.btnAdaugaSofer = new System.Windows.Forms.Button();
            this.btnFormularGestiune = new System.Windows.Forms.Button();
            this.epNumeSofer = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDataAngajarii = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeSofer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDataAngajarii)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 126);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(490, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume sofer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data angajarii:";
            // 
            // dtpDataAngajarii
            // 
            this.dtpDataAngajarii.Location = new System.Drawing.Point(12, 84);
            this.dtpDataAngajarii.Name = "dtpDataAngajarii";
            this.dtpDataAngajarii.Size = new System.Drawing.Size(208, 22);
            this.dtpDataAngajarii.TabIndex = 4;
            this.dtpDataAngajarii.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDataAngajarii_Validating);
            this.dtpDataAngajarii.Validated += new System.EventHandler(this.dtpDataAngajarii_Validated);
            // 
            // tbNumeSofer
            // 
            this.tbNumeSofer.Location = new System.Drawing.Point(12, 29);
            this.tbNumeSofer.Name = "tbNumeSofer";
            this.tbNumeSofer.Size = new System.Drawing.Size(208, 22);
            this.tbNumeSofer.TabIndex = 3;
            this.tbNumeSofer.Validating += new System.ComponentModel.CancelEventHandler(this.tbNumeSofer_Validating);
            this.tbNumeSofer.Validated += new System.EventHandler(this.tbNumeSofer_Validated);
            // 
            // btnAdaugaSofer
            // 
            this.btnAdaugaSofer.Location = new System.Drawing.Point(248, 47);
            this.btnAdaugaSofer.Name = "btnAdaugaSofer";
            this.btnAdaugaSofer.Size = new System.Drawing.Size(93, 50);
            this.btnAdaugaSofer.TabIndex = 10;
            this.btnAdaugaSofer.Text = "Adauga\r\nsofer";
            this.btnAdaugaSofer.UseVisualStyleBackColor = true;
            this.btnAdaugaSofer.Click += new System.EventHandler(this.btnAdaugaSofer_Click);
            // 
            // btnFormularGestiune
            // 
            this.btnFormularGestiune.Location = new System.Drawing.Point(372, 47);
            this.btnFormularGestiune.Name = "btnFormularGestiune";
            this.btnFormularGestiune.Size = new System.Drawing.Size(93, 50);
            this.btnFormularGestiune.TabIndex = 11;
            this.btnFormularGestiune.Text = "Anulare";
            this.btnFormularGestiune.UseVisualStyleBackColor = true;
            this.btnFormularGestiune.Click += new System.EventHandler(this.btnFormularGestiune_Click);
            // 
            // epNumeSofer
            // 
            this.epNumeSofer.ContainerControl = this;
            // 
            // epDataAngajarii
            // 
            this.epDataAngajarii.ContainerControl = this;
            // 
            // FormularSofer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 152);
            this.Controls.Add(this.btnFormularGestiune);
            this.Controls.Add(this.btnAdaugaSofer);
            this.Controls.Add(this.tbNumeSofer);
            this.Controls.Add(this.dtpDataAngajarii);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormularSofer";
            this.Text = "Formular adaugare sofer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularSofer_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNumeSofer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDataAngajarii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataAngajarii;
        private System.Windows.Forms.TextBox tbNumeSofer;
        private System.Windows.Forms.Button btnAdaugaSofer;
        private System.Windows.Forms.Button btnFormularGestiune;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epNumeSofer;
        private System.Windows.Forms.ErrorProvider epDataAngajarii;
    }
}