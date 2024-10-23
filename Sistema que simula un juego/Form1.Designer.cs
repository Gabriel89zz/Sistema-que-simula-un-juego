namespace Sistema_que_simula_un_juego
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpGeografia = new TabPage();
            tpHistoria = new TabPage();
            tpMate = new TabPage();
            tpFutbol = new TabPage();
            tpAnime = new TabPage();
            lblGeografia = new Label();
            GeoOp1 = new RadioButton();
            GeoOp3 = new RadioButton();
            geoRespuesta = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            historiaRespuesta = new RadioButton();
            label1 = new Label();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            mateRespuesta = new RadioButton();
            label2 = new Label();
            radioButton7 = new RadioButton();
            fuchoRespuesta = new RadioButton();
            radioButton9 = new RadioButton();
            label3 = new Label();
            bankai = new RadioButton();
            radioButton11 = new RadioButton();
            radioButton12 = new RadioButton();
            label4 = new Label();
            btnEvaluar = new Button();
            tabControl1.SuspendLayout();
            tpGeografia.SuspendLayout();
            tpHistoria.SuspendLayout();
            tpMate.SuspendLayout();
            tpFutbol.SuspendLayout();
            tpAnime.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpGeografia);
            tabControl1.Controls.Add(tpHistoria);
            tabControl1.Controls.Add(tpMate);
            tabControl1.Controls.Add(tpFutbol);
            tabControl1.Controls.Add(tpAnime);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 0;
            // 
            // tpGeografia
            // 
            tpGeografia.Controls.Add(geoRespuesta);
            tpGeografia.Controls.Add(GeoOp3);
            tpGeografia.Controls.Add(GeoOp1);
            tpGeografia.Controls.Add(lblGeografia);
            tpGeografia.Location = new Point(4, 24);
            tpGeografia.Name = "tpGeografia";
            tpGeografia.Padding = new Padding(3);
            tpGeografia.Size = new Size(768, 398);
            tpGeografia.TabIndex = 0;
            tpGeografia.Text = "Geografia";
            tpGeografia.UseVisualStyleBackColor = true;
            // 
            // tpHistoria
            // 
            tpHistoria.Controls.Add(radioButton1);
            tpHistoria.Controls.Add(radioButton2);
            tpHistoria.Controls.Add(historiaRespuesta);
            tpHistoria.Controls.Add(label1);
            tpHistoria.Location = new Point(4, 24);
            tpHistoria.Name = "tpHistoria";
            tpHistoria.Padding = new Padding(3);
            tpHistoria.Size = new Size(768, 398);
            tpHistoria.TabIndex = 1;
            tpHistoria.Text = "Historia";
            tpHistoria.UseVisualStyleBackColor = true;
            // 
            // tpMate
            // 
            tpMate.Controls.Add(radioButton4);
            tpMate.Controls.Add(radioButton5);
            tpMate.Controls.Add(mateRespuesta);
            tpMate.Controls.Add(label2);
            tpMate.Location = new Point(4, 24);
            tpMate.Name = "tpMate";
            tpMate.Padding = new Padding(3);
            tpMate.Size = new Size(768, 398);
            tpMate.TabIndex = 2;
            tpMate.Text = "Matematicas";
            tpMate.UseVisualStyleBackColor = true;
            // 
            // tpFutbol
            // 
            tpFutbol.Controls.Add(radioButton7);
            tpFutbol.Controls.Add(fuchoRespuesta);
            tpFutbol.Controls.Add(radioButton9);
            tpFutbol.Controls.Add(label3);
            tpFutbol.Location = new Point(4, 24);
            tpFutbol.Name = "tpFutbol";
            tpFutbol.Size = new Size(768, 398);
            tpFutbol.TabIndex = 0;
            tpFutbol.Text = "Futbol";
            tpFutbol.UseVisualStyleBackColor = true;
            // 
            // tpAnime
            // 
            tpAnime.Controls.Add(btnEvaluar);
            tpAnime.Controls.Add(bankai);
            tpAnime.Controls.Add(radioButton11);
            tpAnime.Controls.Add(radioButton12);
            tpAnime.Controls.Add(label4);
            tpAnime.Location = new Point(4, 24);
            tpAnime.Name = "tpAnime";
            tpAnime.Size = new Size(768, 398);
            tpAnime.TabIndex = 0;
            tpAnime.Text = "Anime";
            tpAnime.UseVisualStyleBackColor = true;
            // 
            // lblGeografia
            // 
            lblGeografia.AutoSize = true;
            lblGeografia.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            lblGeografia.Location = new Point(226, 32);
            lblGeografia.Name = "lblGeografia";
            lblGeografia.Size = new Size(313, 26);
            lblGeografia.TabIndex = 0;
            lblGeografia.Text = "¿Cual es la capital de Turquía?";
            // 
            // GeoOp1
            // 
            GeoOp1.AutoSize = true;
            GeoOp1.Font = new Font("Yu Gothic", 12F);
            GeoOp1.Location = new Point(312, 93);
            GeoOp1.Name = "GeoOp1";
            GeoOp1.Size = new Size(97, 25);
            GeoOp1.TabIndex = 1;
            GeoOp1.TabStop = true;
            GeoOp1.Text = "Estambul";
            GeoOp1.UseVisualStyleBackColor = true;
            // 
            // GeoOp3
            // 
            GeoOp3.AutoSize = true;
            GeoOp3.Font = new Font("Yu Gothic", 12F);
            GeoOp3.Location = new Point(312, 201);
            GeoOp3.Name = "GeoOp3";
            GeoOp3.Size = new Size(88, 25);
            GeoOp3.TabIndex = 2;
            GeoOp3.TabStop = true;
            GeoOp3.Text = "Esmirna";
            GeoOp3.UseVisualStyleBackColor = true;
            // 
            // geoRespuesta
            // 
            geoRespuesta.AutoSize = true;
            geoRespuesta.Font = new Font("Yu Gothic", 12F);
            geoRespuesta.Location = new Point(312, 147);
            geoRespuesta.Name = "geoRespuesta";
            geoRespuesta.Size = new Size(79, 25);
            geoRespuesta.TabIndex = 3;
            geoRespuesta.TabStop = true;
            geoRespuesta.Text = "Ankara";
            geoRespuesta.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Yu Gothic", 12F);
            radioButton1.Location = new Point(288, 152);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(150, 25);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Imperio Romano";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Yu Gothic", 12F);
            radioButton2.Location = new Point(288, 206);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(138, 25);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Imperio Azteca";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // historiaRespuesta
            // 
            historiaRespuesta.AutoSize = true;
            historiaRespuesta.Font = new Font("Yu Gothic", 12F);
            historiaRespuesta.Location = new Point(288, 98);
            historiaRespuesta.Name = "historiaRespuesta";
            historiaRespuesta.Size = new Size(148, 25);
            historiaRespuesta.TabIndex = 5;
            historiaRespuesta.TabStop = true;
            historiaRespuesta.Text = "Imperio Japones";
            historiaRespuesta.TextAlign = ContentAlignment.BottomRight;
            historiaRespuesta.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label1.Location = new Point(71, 46);
            label1.Name = "label1";
            label1.Size = new Size(619, 26);
            label1.TabIndex = 4;
            label1.Text = "¿Qué imperio fue conocido como \"el imperio del sol naciente?";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Yu Gothic", 12F);
            radioButton4.Location = new Point(292, 213);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(181, 25);
            radioButton4.TabIndex = 11;
            radioButton4.TabStop = true;
            radioButton4.Text = "Teorema de Euclides";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Yu Gothic", 12F);
            radioButton5.Location = new Point(292, 267);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(165, 25);
            radioButton5.TabIndex = 10;
            radioButton5.TabStop = true;
            radioButton5.Text = "Teorema de Reyes";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // mateRespuesta
            // 
            mateRespuesta.AutoSize = true;
            mateRespuesta.Font = new Font("Yu Gothic", 12F);
            mateRespuesta.Location = new Point(292, 159);
            mateRespuesta.Name = "mateRespuesta";
            mateRespuesta.Size = new Size(191, 25);
            mateRespuesta.TabIndex = 9;
            mateRespuesta.TabStop = true;
            mateRespuesta.Text = "Teorema de Pitágoras";
            mateRespuesta.TextAlign = ContentAlignment.BottomRight;
            mateRespuesta.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label2.Location = new Point(144, 43);
            label2.Name = "label2";
            label2.Size = new Size(470, 92);
            label2.TabIndex = 8;
            label2.Text = "¿Que teorema describe que en todo triangulo rectangulo la suma de los cuadrados de sus catetos es igual a la hipotenusa al cuadrado?";
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Font = new Font("Yu Gothic", 12F);
            radioButton7.Location = new Point(305, 154);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(109, 25);
            radioButton7.TabIndex = 11;
            radioButton7.TabStop = true;
            radioButton7.Text = "Argenzuela";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // fuchoRespuesta
            // 
            fuchoRespuesta.AutoSize = true;
            fuchoRespuesta.Font = new Font("Yu Gothic", 12F);
            fuchoRespuesta.Location = new Point(305, 208);
            fuchoRespuesta.Name = "fuchoRespuesta";
            fuchoRespuesta.Size = new Size(96, 25);
            fuchoRespuesta.TabIndex = 10;
            fuchoRespuesta.TabStop = true;
            fuchoRespuesta.Text = "Alemania";
            fuchoRespuesta.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Font = new Font("Yu Gothic", 12F);
            radioButton9.Location = new Point(305, 100);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(81, 25);
            radioButton9.TabIndex = 9;
            radioButton9.TabStop = true;
            radioButton9.Text = "México";
            radioButton9.TextAlign = ContentAlignment.BottomRight;
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label3.Location = new Point(114, 42);
            label3.Name = "label3";
            label3.Size = new Size(529, 26);
            label3.TabIndex = 8;
            label3.Text = "¿Ultima seleccion campeona del mundo legalmente?";
            // 
            // bankai
            // 
            bankai.AutoSize = true;
            bankai.Font = new Font("Yu Gothic", 12F);
            bankai.Location = new Point(293, 173);
            bankai.Name = "bankai";
            bankai.Size = new Size(78, 25);
            bankai.TabIndex = 15;
            bankai.TabStop = true;
            bankai.Text = "Bankai";
            bankai.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Font = new Font("Yu Gothic", 12F);
            radioButton11.Location = new Point(293, 227);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(192, 25);
            radioButton11.TabIndex = 14;
            radioButton11.TabStop = true;
            radioButton11.Text = "Expansion de Dominio";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Font = new Font("Yu Gothic", 12F);
            radioButton12.Location = new Point(293, 119);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(146, 25);
            radioButton12.TabIndex = 13;
            radioButton12.TabStop = true;
            radioButton12.Text = "Kame Hame Ha";
            radioButton12.TextAlign = ContentAlignment.BottomRight;
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Font = new Font("Yu Gothic", 15F, FontStyle.Bold);
            label4.Location = new Point(115, 16);
            label4.Name = "label4";
            label4.Size = new Size(513, 100);
            label4.TabIndex = 12;
            label4.Text = "En el padre del shonen Bleach, ¿como se llama a la tecnica final que usan sus personajes al liberar su zanpakuto?";
            // 
            // btnEvaluar
            // 
            btnEvaluar.Location = new Point(315, 288);
            btnEvaluar.Name = "btnEvaluar";
            btnEvaluar.Size = new Size(142, 26);
            btnEvaluar.TabIndex = 16;
            btnEvaluar.Text = "EVALUAR";
            btnEvaluar.UseVisualStyleBackColor = true;
            btnEvaluar.Click += btnEvaluar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tpGeografia.ResumeLayout(false);
            tpGeografia.PerformLayout();
            tpHistoria.ResumeLayout(false);
            tpHistoria.PerformLayout();
            tpMate.ResumeLayout(false);
            tpMate.PerformLayout();
            tpFutbol.ResumeLayout(false);
            tpFutbol.PerformLayout();
            tpAnime.ResumeLayout(false);
            tpAnime.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpGeografia;
        private TabPage tpHistoria;
        private TabPage tpMate;
        private TabPage tpFutbol;
        private TabPage tpAnime;
        private Label lblGeografia;
        private RadioButton geoRespuesta;
        private RadioButton GeoOp3;
        private RadioButton GeoOp1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton historiaRespuesta;
        private Label label1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton mateRespuesta;
        private Label label2;
        private RadioButton radioButton7;
        private RadioButton fuchoRespuesta;
        private RadioButton radioButton9;
        private Label label3;
        private RadioButton bankai;
        private RadioButton radioButton11;
        private RadioButton radioButton12;
        private Label label4;
        private Button btnEvaluar;
    }
}
