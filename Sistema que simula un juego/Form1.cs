namespace Sistema_que_simula_un_juego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (geoRespuesta.Checked) score += 1;

            if (historiaRespuesta.Checked) score += 1; 

            if (mateRespuesta.Checked) score += 1;

            if (fuchoRespuesta.Checked) score += 1;

            if (bankai.Checked) score += 1; 

            MessageBox.Show($"Has obtenido {score} de 5 puntos.", "Resultados");
        }
    }
}
