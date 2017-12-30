using System;
using System.Windows.Forms;
namespace CalculadoraDePrestaciones1._1
{
    public static class Validador
    {
        public static void ValidarLetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {


            }
        }

        public static void ValidarNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {

                
            }
        }

        public static bool ValidarTextBoxVacio(TextBox tex)
        {
            if(tex.Text == "")
            {
                MessageBox.Show("Debe llenar el campo" + tex.Name);
                return true;
            }
            return false;

        }
    }
}
