namespace HeianFilms
{
    partial class Programa
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
            this.btFechar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imgAvengers = new System.Windows.Forms.PictureBox();
            this.imgJurassic = new System.Windows.Forms.PictureBox();
            this.imgVenow = new System.Windows.Forms.PictureBox();
            this.txtTitulo = new System.Windows.Forms.Label();
            this.txtDescrisao = new System.Windows.Forms.Label();
            this.boxNota = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.estrelinhas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvengers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJurassic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVenow)).BeginInit();
            this.SuspendLayout();
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFechar.Location = new System.Drawing.Point(694, 397);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(149, 41);
            this.btFechar.TabIndex = 0;
            this.btFechar.Text = "Fechar";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catálogo de filmes";
            // 
            // imgAvengers
            // 
            this.imgAvengers.Image = global::HeianFilms.Properties.Resources.vingadores;
            this.imgAvengers.Location = new System.Drawing.Point(383, 87);
            this.imgAvengers.Name = "imgAvengers";
            this.imgAvengers.Size = new System.Drawing.Size(159, 252);
            this.imgAvengers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAvengers.TabIndex = 4;
            this.imgAvengers.TabStop = false;
            this.imgAvengers.Click += new System.EventHandler(this.imgAvengers_Click);
            // 
            // imgJurassic
            // 
            this.imgJurassic.Image = global::HeianFilms.Properties.Resources.jurassic;
            this.imgJurassic.Location = new System.Drawing.Point(200, 87);
            this.imgJurassic.Name = "imgJurassic";
            this.imgJurassic.Size = new System.Drawing.Size(159, 252);
            this.imgJurassic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgJurassic.TabIndex = 3;
            this.imgJurassic.TabStop = false;
            this.imgJurassic.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // imgVenow
            // 
            this.imgVenow.Image = global::HeianFilms.Properties.Resources.posterVenow;
            this.imgVenow.Location = new System.Drawing.Point(19, 87);
            this.imgVenow.Name = "imgVenow";
            this.imgVenow.Size = new System.Drawing.Size(159, 252);
            this.imgVenow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgVenow.TabIndex = 2;
            this.imgVenow.TabStop = false;
            this.imgVenow.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.AutoSize = true;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(572, 45);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(265, 31);
            this.txtTitulo.TabIndex = 5;
            this.txtTitulo.Text = "Selecione um filme...";
            // 
            // txtDescrisao
            // 
            this.txtDescrisao.AutoSize = true;
            this.txtDescrisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrisao.Location = new System.Drawing.Point(573, 87);
            this.txtDescrisao.Name = "txtDescrisao";
            this.txtDescrisao.Size = new System.Drawing.Size(17, 16);
            this.txtDescrisao.TabIndex = 6;
            this.txtDescrisao.Text = "...";
            // 
            // boxNota
            // 
            this.boxNota.BackColor = System.Drawing.SystemColors.MenuText;
            this.boxNota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.boxNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNota.ForeColor = System.Drawing.SystemColors.Menu;
            this.boxNota.Location = new System.Drawing.Point(578, 308);
            this.boxNota.Name = "boxNota";
            this.boxNota.Size = new System.Drawing.Size(30, 29);
            this.boxNota.TabIndex = 7;
            this.boxNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(607, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "/5";
            // 
            // estrelinhas
            // 
            this.estrelinhas.AutoSize = true;
            this.estrelinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estrelinhas.ForeColor = System.Drawing.Color.Yellow;
            this.estrelinhas.Location = new System.Drawing.Point(638, 303);
            this.estrelinhas.Name = "estrelinhas";
            this.estrelinhas.Size = new System.Drawing.Size(110, 33);
            this.estrelinhas.TabIndex = 9;
            this.estrelinhas.Text = "☆☆☆☆☆";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Confirmar Nota";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.estrelinhas);
            this.Controls.Add(this.boxNota);
            this.Controls.Add(this.txtDescrisao);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.imgAvengers);
            this.Controls.Add(this.imgJurassic);
            this.Controls.Add(this.imgVenow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFechar);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Programa";
            this.Text = "Aplicativo";
            ((System.ComponentModel.ISupportInitialize)(this.imgAvengers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgJurassic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgVenow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgVenow;
        private System.Windows.Forms.PictureBox imgJurassic;
        private System.Windows.Forms.PictureBox imgAvengers;
        private System.Windows.Forms.Label txtTitulo;
        private System.Windows.Forms.Label txtDescrisao;
        private System.Windows.Forms.TextBox boxNota;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label estrelinhas;
        private System.Windows.Forms.Button button1;
    }
}