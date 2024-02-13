namespace Arquivos_e_formularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            Criar();
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void BtnConcatenar_Click(object sender, EventArgs e)
        {
            Concatenar();
        }
    }
}