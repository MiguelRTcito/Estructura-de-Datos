namespace Tarea_Pilas_Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EsPalindromo(txtPalabra.Text)  ? ("Es un pal�ndromo") : ("No es un pal�ndromo"));
            txtPalabra.Clear();
            txtPalabra.Focus();
        }
        static bool EsPalindromo(string palabra)
        {
           
            palabra = palabra.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", ""); // Normalizar la palabra

            Pila miPila = new Pila(palabra.Length);

            // Apilar caracteres
            foreach (char c in palabra)
            {
               miPila.Apilar(c);
            }
            // Desapilar y comparar
            foreach (char c in palabra)
            {
                if (miPila.Desapilar() != c)
                {
                    return false; // No es un pal�ndromo
                }
            }
            return true; // Es un pal�ndromo
        }
    }
}
