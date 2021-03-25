
namespace MicroOndas
{
    partial class Tela
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
            this.LblPotencia = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn30seg = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // LblPotencia
            // 
            this.LblPotencia.BackColor = System.Drawing.Color.LemonChiffon;
            this.LblPotencia.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblPotencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblPotencia.Location = new System.Drawing.Point(299, 135);
            this.LblPotencia.Name = "LblPotencia";
            this.LblPotencia.Size = new System.Drawing.Size(131, 23);
            this.LblPotencia.TabIndex = 0;
            this.LblPotencia.Text = "Potência E Tempo";
            this.LblPotencia.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(312, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Esquentar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(169, 206);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(393, 23);
            this.Input.TabIndex = 2;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Benner Micro Ondas";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btn30seg
            // 
            this.btn30seg.BackColor = System.Drawing.Color.White;
            this.btn30seg.Location = new System.Drawing.Point(327, 308);
            this.btn30seg.Name = "btn30seg";
            this.btn30seg.Size = new System.Drawing.Size(75, 23);
            this.btn30seg.TabIndex = 4;
            this.btn30seg.Text = "30 Seg";
            this.btn30seg.UseVisualStyleBackColor = false;
            this.btn30seg.Click += new System.EventHandler(this.btn30seg_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(257, 83);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(208, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 359);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btn30seg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblPotencia);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Tela";
            this.Text = "MicroOndas";
            this.Load += new System.EventHandler(this.Tela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPotencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn30seg;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer timer;
    }
}