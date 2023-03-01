using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Simple_Fake_Identity_Generator
{
    public partial class Form1 : Form
    {
        Persona persona = new();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Aleatorio";
            comboBox2.SelectedItem = "Aleatorio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameGenerator();
            DNICalculator();
            
            NumberPhoneGenerator();
            LabelRespEdad.Text = (DateTime.Now.Year - persona.FechaNacimiento.Year).ToString();
            LabelRespNombre.Text = persona.NombreCompleto;
            LabelRespGen.Text = persona.Genero;
            LabelRespDNI.Text = persona.DNI;
            LabelRespNum.Text = persona.Numero;
            label3.Text = persona.FechaNacimiento.ToString();
            //RandomImage();
        }

        private static string SelectRandomLine(string path)
        {
            Random random = new();
            string[] read = File.ReadAllLines(path);
            return read[random.Next(read.Length)];
        }

        private void NameGenerator()
        {
            switch (comboBox1.Text)
            {
                case "Hombre":
                    persona.NombreCompleto = ManNameGenerator();
                    persona.Genero = "Hombre";
                    comboBox1.Text = "Aleatorio";
                    break;
                case "Mujer":
                    persona.NombreCompleto = WomanNameGenerator();
                    persona.Genero = "Mujer";
                    comboBox1.Text = "Aleatorio";
                    break;
                case "Aleatorio":
                    Random rand = new();
                    string[] gender = { "Hombre", "Mujer" };
                    string random = gender[rand.Next(gender.Length)];
                    comboBox1.Text = random;
                    NameGenerator();
                    break;
            }
        }

        private static string ManNameGenerator()
        {
            string firstname = SelectRandomLine("data/frecuentnames_chilean_male.txt");
            string secondname = SelectRandomLine("data/frecuentnames_chilean_male.txt");
            string lastname1 = SelectRandomLine("data/frecuentlastnames_chilean.txt");
            string lastname2 = SelectRandomLine("data/frecuentlastnames_chilean.txt");
            string final = string.Join(" ", firstname, secondname, lastname1, lastname2);
            return final;
        }

        private static string WomanNameGenerator()
        {
            string firstname = SelectRandomLine("data/frecuentnames_chilean_female.txt");
            string secondname = SelectRandomLine("data/frecuentnames_chilean_female.txt");
            string lastname1 = SelectRandomLine("data/frecuentlastnames_chilean.txt");
            string lastname2 = SelectRandomLine("data/frecuentlastnames_chilean.txt");
            string final = string.Join(" ", firstname, secondname, lastname1, lastname2);
            return final;
        }

        public void DNICalculator()
        {
            persona.FechaNacimiento = GenerarFecha();
            persona.DNI = GenerarDNI();
        }


        public string GenerarDNI()
        {
            string a, b, c;
            int d;
            int dia = persona.FechaNacimiento.Day;
            int mes = persona.FechaNacimiento.Month;
            int anio = persona.FechaNacimiento.Year % 100; // Tomar solo los últimos 2 dígitos del año
            string dni = string.Format("{0:00}{1:00}{2:0000}", dia, mes, anio);
            d = Convert.ToInt32(dni);

            switch (comboBox2.Text)
            {
                case "Argentina":
                    a = DigitoDNIAR(d);
                    b = string.Join("-", dni, a);
                    c = b.Insert(2, ".").Insert(6, ".");
                    return c;
                case "Chile":
                    a = DigitoDNICL(d);
                    b = string.Join("-", dni, a);
                    c = b.Insert(2, ".").Insert(6, ".");
                    return c;
                case "Perú":
                    a = DigitoDNIPE(d);
                    b = string.Join("-", dni, a);
                    return b;
                default:
                    return "Desconocido";
            }
        }

        public static string DigitoDNICL(int dni)
        {
            var digits = dni.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            int suma = 0;
            int multiplicador = 2;

            for (int i = digits.Length - 1; i >= 0; i--)
            {
                suma += int.Parse(digits[i].ToString()) * multiplicador;
                multiplicador++;

                if (multiplicador > 7)
                {
                    multiplicador = 2;
                }
            }

            int resto = suma % 11;
            int verificador = 11 - resto;

            if (verificador == 11)
            {
                return "0";
            }

            else if (verificador == 10)
            {
                return "K";
            }

            return verificador.ToString();
        }

        public static string DigitoDNIAR(int dni)
        {
            var digits = dni.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K' }; // Tabla de letras correspondientes a los números
            int suma = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                suma += digits[i] * (i + 2);
            }

            int resto = suma % 11;
            char letra = letras[resto];
            return letra.ToString();
        }

        private static string DigitoDNIPE(int dni)
        {
            var digits = dni.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            int suma = 0;
        
            for (int i = 0; i< digits.Length; i++) {
            suma += digits[i] * (i + 2);
            }

            int resto = suma % 11;
            int verificador = resto == 10 ? 0 : resto;
            return verificador.ToString();
        }

        private void NumberPhoneGenerator()
        {
            LabelRespNum.Text = NumberPhoneCalculator();
        }

        private static string NumberPhoneCalculator()
        {
            Random random = new();
            string a = "+56 ", b = "9", e, f;
            int c, d;
            c = random.Next(999, 10000);
            d = random.Next(999, 10000);
            e = string.Concat(a, b);
            f = string.Join(" ", e, c, d);
            return f;
        }

        private DateTime GenerarFecha()
        {
            int a, b, c;
            Random rnd = new();
            a = rnd.Next(1, 28);
            b = rnd.Next(1, 12);
            c = rnd.Next(DateTime.Now.Year-40, DateTime.Now.Year-18);
            return new DateTime(c, b, a);
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (sender == BtnCopy1)
            {
                Clipboard.SetText(LabelRespNombre.Text);
            }
            else if (sender == BtnCopy2)
            {
                Clipboard.SetText(LabelRespDNI.Text);
            }
            else if (sender == BtnCopy3)
            {
                Clipboard.SetText(LabelRespNum.Text);
            }
            else if (sender == BtnCopy4)
            {
                Clipboard.SetText(LabelRespGen.Text);
            }
            else if (sender == BtnCopy5)
            {
                Clipboard.SetText(LabelRespEdad.Text);
            }
            else if (sender == BtnCopy6)
            {
                Clipboard.SetText(LabelRespPais.Text);
            }
        }
    }
}