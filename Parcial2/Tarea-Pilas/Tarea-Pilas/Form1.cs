namespace Tarea_Pilas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static bool EsBalanceado(string texto)
        {

            Pila mipila = new Pila(texto.Length); //vector pila tipo char que tiene el tama�o del texto
           

            foreach (char c in texto) //mientras que la variable de tipo char este en "texto"
            {
                // si es un simbolo de apertura se guarda en la pila
                if (c == '(' || c == '{' || c == '[')
                {
                    mipila.Apilar(c); // apilamos
                }
                // si es un simbolo de cierre se verifica con el tope de la pila
                else if (c == ')' || c == '}' || c == ']') //else if (si no se cumple la condicion anterior y se cumple esta)
                {
                    if (mipila.EstaVacia())
                        return false; // hay un cierre sin apertura

                  char apertura = mipila.Desapilar(); // desapilamos

                    if (!Coinciden(apertura, c))
                        return false; // apertura y cierre no coinciden y si si coinciden retorna true 
                }
            }

            // si queda algo en la pila, no est� balanceado
            return mipila.EstaVacia();
        }
        private static bool Coinciden(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') || //Devuelve el resultado de la comparaci�n que es true o false
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }
        private void btnVerificar_Click(object sender, EventArgs e)
        {
           MessageBox.Show(EsBalanceado(txtTexto.Text) ? "La expresi�n est� balanceada." : "La expresi�n no est� balanceada.");
            txtTexto.Clear();
        }
    }
}
