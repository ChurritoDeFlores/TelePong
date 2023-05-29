namespace PongFer
{
    partial class Form1
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
            this.timer_ = new System.Windows.Forms.Timer(this.components);
            this.lbl_Anotador1 = new System.Windows.Forms.Label();
            this.lbl_Anotador2 = new System.Windows.Forms.Label();
            this.pic_Pared_Sup = new System.Windows.Forms.PictureBox();
            this.pic_Pared_Inf = new System.Windows.Forms.PictureBox();
            this.pic_Pelota = new System.Windows.Forms.PictureBox();
            this.pic_Jugador2 = new System.Windows.Forms.PictureBox();
            this.pic_Jugador1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pared_Sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pared_Inf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pelota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Jugador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Jugador1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_
            // 
            this.timer_.Interval = 10;
            this.timer_.Tick += new System.EventHandler(this.timer__Tick);
            // 
            // lbl_Anotador1
            // 
            this.lbl_Anotador1.AutoSize = true;
            this.lbl_Anotador1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Anotador1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anotador1.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Anotador1.Location = new System.Drawing.Point(18, 7);
            this.lbl_Anotador1.Name = "lbl_Anotador1";
            this.lbl_Anotador1.Size = new System.Drawing.Size(25, 28);
            this.lbl_Anotador1.TabIndex = 5;
            this.lbl_Anotador1.Text = "0";
            // 
            // lbl_Anotador2
            // 
            this.lbl_Anotador2.AutoSize = true;
            this.lbl_Anotador2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Anotador2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Anotador2.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_Anotador2.Location = new System.Drawing.Point(499, 7);
            this.lbl_Anotador2.Name = "lbl_Anotador2";
            this.lbl_Anotador2.Size = new System.Drawing.Size(25, 28);
            this.lbl_Anotador2.TabIndex = 6;
            this.lbl_Anotador2.Text = "0";
            // 
            // pic_Pared_Sup
            // 
            this.pic_Pared_Sup.BackColor = System.Drawing.Color.White;
            this.pic_Pared_Sup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_Pared_Sup.Location = new System.Drawing.Point(0, 0);
            this.pic_Pared_Sup.Name = "pic_Pared_Sup";
            this.pic_Pared_Sup.Size = new System.Drawing.Size(545, 40);
            this.pic_Pared_Sup.TabIndex = 4;
            this.pic_Pared_Sup.TabStop = false;
            this.pic_Pared_Sup.Tag = "ParedSuperior";
            // 
            // pic_Pared_Inf
            // 
            this.pic_Pared_Inf.BackColor = System.Drawing.Color.White;
            this.pic_Pared_Inf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pic_Pared_Inf.Location = new System.Drawing.Point(0, 322);
            this.pic_Pared_Inf.Name = "pic_Pared_Inf";
            this.pic_Pared_Inf.Size = new System.Drawing.Size(545, 27);
            this.pic_Pared_Inf.TabIndex = 3;
            this.pic_Pared_Inf.TabStop = false;
            this.pic_Pared_Inf.Tag = "ParedInferior";
            // 
            // pic_Pelota
            // 
            this.pic_Pelota.BackColor = System.Drawing.Color.Transparent;
            this.pic_Pelota.Image = global::PongFer.Properties.Resources.Pelota;
            this.pic_Pelota.Location = new System.Drawing.Point(257, 163);
            this.pic_Pelota.Name = "pic_Pelota";
            this.pic_Pelota.Size = new System.Drawing.Size(22, 22);
            this.pic_Pelota.TabIndex = 2;
            this.pic_Pelota.TabStop = false;
            this.pic_Pelota.Tag = "Pelota";
            // 
            // pic_Jugador2
            // 
            this.pic_Jugador2.BackColor = System.Drawing.Color.Transparent;
            this.pic_Jugador2.Image = global::PongFer.Properties.Resources.PJ2;
            this.pic_Jugador2.Location = new System.Drawing.Point(503, 125);
            this.pic_Jugador2.Name = "pic_Jugador2";
            this.pic_Jugador2.Size = new System.Drawing.Size(21, 93);
            this.pic_Jugador2.TabIndex = 1;
            this.pic_Jugador2.TabStop = false;
            this.pic_Jugador2.Tag = "Jugador2";
            // 
            // pic_Jugador1
            // 
            this.pic_Jugador1.BackColor = System.Drawing.Color.Transparent;
            this.pic_Jugador1.BackgroundImage = global::PongFer.Properties.Resources.PJ1;
            this.pic_Jugador1.Location = new System.Drawing.Point(22, 125);
            this.pic_Jugador1.Name = "pic_Jugador1";
            this.pic_Jugador1.Size = new System.Drawing.Size(21, 93);
            this.pic_Jugador1.TabIndex = 0;
            this.pic_Jugador1.TabStop = false;
            this.pic_Jugador1.Tag = "Jugador1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(545, 349);
            this.Controls.Add(this.lbl_Anotador2);
            this.Controls.Add(this.lbl_Anotador1);
            this.Controls.Add(this.pic_Pared_Sup);
            this.Controls.Add(this.pic_Pared_Inf);
            this.Controls.Add(this.pic_Pelota);
            this.Controls.Add(this.pic_Jugador2);
            this.Controls.Add(this.pic_Jugador1);
            this.Name = "Form1";
            this.Text = "TelePong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TeclaApretada);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TeclaSoltada);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pared_Sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pared_Inf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Pelota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Jugador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Jugador1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Jugador1;
        private System.Windows.Forms.PictureBox pic_Jugador2;
        private System.Windows.Forms.PictureBox pic_Pelota;
        private System.Windows.Forms.PictureBox pic_Pared_Inf;
        private System.Windows.Forms.PictureBox pic_Pared_Sup;
        private System.Windows.Forms.Timer timer_;
        private System.Windows.Forms.Label lbl_Anotador1;
        private System.Windows.Forms.Label lbl_Anotador2;
    }
}

