namespace WindowsFormsApp1
{
    partial class CoheteApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoheteApp));
            this.Comenzar = new System.Windows.Forms.Button();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.TiempoIntroducido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Parar = new System.Windows.Forms.Button();
            this.Cohete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Cohete)).BeginInit();
            this.SuspendLayout();
            // 
            // Comenzar
            // 
            this.Comenzar.Location = new System.Drawing.Point(40, 78);
            this.Comenzar.Name = "Comenzar";
            this.Comenzar.Size = new System.Drawing.Size(75, 23);
            this.Comenzar.TabIndex = 0;
            this.Comenzar.Text = "Comenzar";
            this.Comenzar.UseVisualStyleBackColor = true;
            this.Comenzar.Click += new System.EventHandler(this.Comenzar_Click);
            // 
            // Reiniciar
            // 
            this.Reiniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reiniciar.Location = new System.Drawing.Point(118, 78);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(75, 23);
            this.Reiniciar.TabIndex = 1;
            this.Reiniciar.Text = "Reiniciar";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // TiempoIntroducido
            // 
            this.TiempoIntroducido.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TiempoIntroducido.Location = new System.Drawing.Point(108, 50);
            this.TiempoIntroducido.Name = "TiempoIntroducido";
            this.TiempoIntroducido.Size = new System.Drawing.Size(100, 20);
            this.TiempoIntroducido.TabIndex = 3;
            this.TiempoIntroducido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TiempoIntroducido.TextChanged += new System.EventHandler(this.Temporizador_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduce un número para comenzar la cuenta regresiva";
            // 
            // Temporizador
            // 
            this.Temporizador.AutoSize = true;
            this.Temporizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temporizador.Location = new System.Drawing.Point(22, 110);
            this.Temporizador.Name = "Temporizador";
            this.Temporizador.Size = new System.Drawing.Size(0, 108);
            this.Temporizador.TabIndex = 5;
            this.Temporizador.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Parar
            // 
            this.Parar.Location = new System.Drawing.Point(197, 78);
            this.Parar.Name = "Parar";
            this.Parar.Size = new System.Drawing.Size(75, 23);
            this.Parar.TabIndex = 6;
            this.Parar.Text = "Parar";
            this.Parar.UseVisualStyleBackColor = true;
            this.Parar.Click += new System.EventHandler(this.Parar_Click_1);
            // 
            // Cohete
            // 
            this.Cohete.Image = ((System.Drawing.Image)(resources.GetObject("Cohete.Image")));
            this.Cohete.Location = new System.Drawing.Point(-104, 107);
            this.Cohete.Name = "Cohete";
            this.Cohete.Size = new System.Drawing.Size(512, 229);
            this.Cohete.TabIndex = 7;
            this.Cohete.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 287);
            this.Controls.Add(this.Cohete);
            this.Controls.Add(this.Parar);
            this.Controls.Add(this.Temporizador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TiempoIntroducido);
            this.Controls.Add(this.Reiniciar);
            this.Controls.Add(this.Comenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Cohete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Comenzar;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.TextBox TiempoIntroducido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Temporizador;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Parar;
        private System.Windows.Forms.PictureBox Cohete;
    }
}

