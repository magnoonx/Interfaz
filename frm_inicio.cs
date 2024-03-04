using System.Net;
using System.Security.Policy;
using System.Text;
using Interfaz.Models;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Interfaz
{
    public partial class frm_inicio : Form
    {
        private async void Apiconn() //Codigo que genera la solicitud al Backend con usuario y contraseña
        {
            try
            {
                string url = "http://192.168.2.13:5000/api/User/Login"; // Reemplazar con la URL del backend
                var client = new HttpClient();
                var loginModel = new LoginModel  //llama al modelo de login
                {
                    UserName = Usuario.Text,
                    Password = Clave.Text
                };
                string jsonData = JsonConvert.SerializeObject(loginModel);
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(url, content).ConfigureAwait(false);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    string res = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(res);



                }
                else
                {

                    MessageBox.Show("Datos Incorrectos, por favor revisa y reintenta");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo conectar con el servidor, intente más tarde", "Error de Conexión");
                Console.WriteLine(ex.Message);
            }

        }
        public frm_inicio()
        {
            InitializeComponent();
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("Hola Mundo");
            Apiconn();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
