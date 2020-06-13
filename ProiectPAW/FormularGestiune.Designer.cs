namespace ProiectPAW
{
    partial class FormularGestiune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularGestiune));
            this.btnListaCurse = new System.Windows.Forms.Button();
            this.btnAdaugaSofer = new System.Windows.Forms.Button();
            this.btnAdaugaTransport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.despreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListaCurse
            // 
            this.btnListaCurse.Location = new System.Drawing.Point(49, 170);
            this.btnListaCurse.Name = "btnListaCurse";
            this.btnListaCurse.Size = new System.Drawing.Size(93, 50);
            this.btnListaCurse.TabIndex = 11;
            this.btnListaCurse.Text = "Lista \r\ncurse";
            this.btnListaCurse.UseVisualStyleBackColor = true;
            this.btnListaCurse.Click += new System.EventHandler(this.btnListaCurse_Click);
            // 
            // btnAdaugaSofer
            // 
            this.btnAdaugaSofer.Location = new System.Drawing.Point(49, 74);
            this.btnAdaugaSofer.Name = "btnAdaugaSofer";
            this.btnAdaugaSofer.Size = new System.Drawing.Size(93, 50);
            this.btnAdaugaSofer.TabIndex = 12;
            this.btnAdaugaSofer.Text = "Adauga\r\nsofer";
            this.btnAdaugaSofer.UseVisualStyleBackColor = true;
            this.btnAdaugaSofer.Click += new System.EventHandler(this.btnAdaugaSofer_Click);
            // 
            // btnAdaugaTransport
            // 
            this.btnAdaugaTransport.Location = new System.Drawing.Point(199, 74);
            this.btnAdaugaTransport.Name = "btnAdaugaTransport";
            this.btnAdaugaTransport.Size = new System.Drawing.Size(93, 50);
            this.btnAdaugaTransport.TabIndex = 13;
            this.btnAdaugaTransport.Text = "Adauga\r\ntransport";
            this.btnAdaugaTransport.UseVisualStyleBackColor = true;
            this.btnAdaugaTransport.Click += new System.EventHandler(this.btnAdaugaTransport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Va rugam sa selectati operatia dorita:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 249);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(337, 26);
            this.statusStrip1.TabIndex = 15;
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
            this.despreToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.despreToolStripMenuItem.Text = "Despre";
            this.despreToolStripMenuItem.Click += new System.EventHandler(this.despreToolStripMenuItem_Click);
            // 
            // btnAdaugaMasina
            // 
            this.btnAdaugaMasina.Location = new System.Drawing.Point(199, 170);
            this.btnAdaugaMasina.Name = "btnAdaugaMasina";
            this.btnAdaugaMasina.Size = new System.Drawing.Size(93, 50);
            this.btnAdaugaMasina.TabIndex = 16;
            this.btnAdaugaMasina.Text = "Adauga\r\nmasina";
            this.btnAdaugaMasina.UseVisualStyleBackColor = true;
            this.btnAdaugaMasina.Click += new System.EventHandler(this.btnAdaugaMasina_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // FormularGestiune
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 275);
            this.Controls.Add(this.btnAdaugaMasina);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdaugaTransport);
            this.Controls.Add(this.btnAdaugaSofer);
            this.Controls.Add(this.btnListaCurse);
            this.Name = "FormularGestiune";
            this.Text = "Formular_gestiune";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formular_gestiune_FormClosed);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnListaCurse;
        private System.Windows.Forms.Button btnAdaugaSofer;
        private System.Windows.Forms.Button btnAdaugaTransport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem despreToolStripMenuItem;
        private System.Windows.Forms.Button btnAdaugaMasina;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
    }
}