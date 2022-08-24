namespace MiPrimeraApp.Formularios
{
    partial class SegundoFormulario
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnCicloFor = new System.Windows.Forms.Button();
            this.btnCicloWhile = new System.Windows.Forms.Button();
            this.btnCicloDoWhile = new System.Windows.Forms.Button();
            this.btnCicloForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.SegundoFormulario_Load);
            // 
            // btnCicloFor
            // 
            this.btnCicloFor.Location = new System.Drawing.Point(83, 49);
            this.btnCicloFor.Name = "btnCicloFor";
            this.btnCicloFor.Size = new System.Drawing.Size(75, 23);
            this.btnCicloFor.TabIndex = 0;
            this.btnCicloFor.Text = "Ciclo For";
            this.btnCicloFor.UseVisualStyleBackColor = true;
            this.btnCicloFor.Click += new System.EventHandler(this.btnCicloFor_Click);
            // 
            // btnCicloWhile
            // 
            this.btnCicloWhile.Location = new System.Drawing.Point(182, 49);
            this.btnCicloWhile.Name = "btnCicloWhile";
            this.btnCicloWhile.Size = new System.Drawing.Size(75, 23);
            this.btnCicloWhile.TabIndex = 1;
            this.btnCicloWhile.Text = "Ciclo While";
            this.btnCicloWhile.UseVisualStyleBackColor = true;
            this.btnCicloWhile.Click += new System.EventHandler(this.btnCicloWhile_Click);
            // 
            // btnCicloDoWhile
            // 
            this.btnCicloDoWhile.Location = new System.Drawing.Point(285, 49);
            this.btnCicloDoWhile.Name = "btnCicloDoWhile";
            this.btnCicloDoWhile.Size = new System.Drawing.Size(91, 23);
            this.btnCicloDoWhile.TabIndex = 2;
            this.btnCicloDoWhile.Text = "Ciclo Do While";
            this.btnCicloDoWhile.UseVisualStyleBackColor = true;
            this.btnCicloDoWhile.Click += new System.EventHandler(this.btnCicloDoWhile_Click);
            // 
            // btnCicloForEach
            // 
            this.btnCicloForEach.Location = new System.Drawing.Point(404, 49);
            this.btnCicloForEach.Name = "btnCicloForEach";
            this.btnCicloForEach.Size = new System.Drawing.Size(87, 23);
            this.btnCicloForEach.TabIndex = 3;
            this.btnCicloForEach.Text = "Ciclo Foreach";
            this.btnCicloForEach.UseVisualStyleBackColor = true;
            this.btnCicloForEach.Click += new System.EventHandler(this.btnCicloForEach_Click);
            // 
            // SegundoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 418);
            this.Controls.Add(this.btnCicloForEach);
            this.Controls.Add(this.btnCicloDoWhile);
            this.Controls.Add(this.btnCicloWhile);
            this.Controls.Add(this.btnCicloFor);
            this.Name = "SegundoFormulario";
            this.Text = "SegundoFormulario";
            this.Load += new System.EventHandler(this.SegundoFormulario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnCicloFor;
        private System.Windows.Forms.Button btnCicloWhile;
        private System.Windows.Forms.Button btnCicloDoWhile;
        private System.Windows.Forms.Button btnCicloForEach;
    }
}