using System;
using System.Windows.Forms;
using Core;
using DataModel.Entity;
using Utility;

namespace CalculadoraDePrestaciones1._1
{
    public partial class Form1 : Form
    {
        Mantenimiento mantenimiento;
        decimal[] salarios;
        Calculadora calculadora;

        public Form1()
        {
            InitializeComponent();
            mantenimiento = Mantenimiento.Instance;
            calculadora = new Calculadora();

        }
        // Validaciones de campos
        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarLetras(e);
        }

        private void textLugarDeTrabajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarLetras(e);
        }

        private void Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void txtSalario1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void txtSalario2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void txtSalario3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void txtSalario4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void txtSalario5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void txtSalario8_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }
        // validar campo
        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }


        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validador.ValidarNumeros(e);
        }

        // validar fecha
        private void dateTimeFechaSalida_Leave(object sender, EventArgs e)
        {
            if (dateFechaIngreso.Value.Date > dateFechaSalida.Value.Date)
            {
                MessageBox.Show("La fecha de Ingreso no puede ser mayor que la de salida",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                labelTiempoLaborado.Text = dateFechaSalida.Value.Date.IntervaloEntreFechas(dateFechaIngreso.Value.Date);
                labelYear.Text = dateFechaSalida.Value.Date.YearDifference(dateFechaIngreso.Value.Date).ToString();
                labelMeses.Text = dateFechaSalida.Value.Date.MonthDifference(dateFechaIngreso.Value.Date).ToString();
                labelDias.Text = dateFechaSalida.Value.Date.DaysDifference(dateFechaIngreso.Value.Date).ToString();

            }
        }

        //Autocompletar los campos
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validador.ValidarTextBoxVacio(txtSalario1))
            {
                MessageBox.Show("Error debe entrar un salario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(labelYear.Text) > 0)
            {
                txtSalario2.Text = txtSalario1.Text;
                txtSalario3.Text = txtSalario1.Text;
                txtSalario4.Text = txtSalario1.Text;
                txtSalario5.Text = txtSalario1.Text;
                txtSalario6.Text = txtSalario1.Text;
                txtSalario7.Text = txtSalario1.Text;
                txtSalario8.Text = txtSalario1.Text;
                txtSalario9.Text = txtSalario1.Text;
                txtSalario10.Text = txtSalario1.Text;
                txtSalario11.Text = txtSalario1.Text;
                txtSalario12.Text = txtSalario1.Text;
            }
            else
            {
                switch (Convert.ToInt32(labelMeses.Text))
                {
                    case 1:
                        
                        break;

                    case 2:
                        txtSalario2.Text = txtSalario1.Text;
                        break;

                    case 3:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        break;

                    case 4:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        break;

                    case 5:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        break;

                    case 6:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        txtSalario6.Text = txtSalario1.Text;
                        break;

                    case 7:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        txtSalario6.Text = txtSalario1.Text;
                        txtSalario7.Text = txtSalario1.Text;
                        break;

                    case 8:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        txtSalario6.Text = txtSalario1.Text;
                        txtSalario7.Text = txtSalario1.Text;
                        txtSalario8.Text = txtSalario1.Text;
                        break;

                    case 9:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        txtSalario6.Text = txtSalario1.Text;
                        txtSalario7.Text = txtSalario1.Text;
                        txtSalario8.Text = txtSalario1.Text;
                        txtSalario9.Text = txtSalario1.Text;
                        break;

                    case 10:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        txtSalario6.Text = txtSalario1.Text;
                        txtSalario7.Text = txtSalario1.Text;
                        txtSalario8.Text = txtSalario1.Text;
                        txtSalario9.Text = txtSalario1.Text;
                        txtSalario10.Text = txtSalario1.Text;
                        break;

                    case 11:
                        txtSalario2.Text = txtSalario1.Text;
                        txtSalario3.Text = txtSalario1.Text;
                        txtSalario4.Text = txtSalario1.Text;
                        txtSalario5.Text = txtSalario1.Text;
                        txtSalario6.Text = txtSalario1.Text;
                        txtSalario7.Text = txtSalario1.Text;
                        txtSalario8.Text = txtSalario1.Text;
                        txtSalario9.Text = txtSalario1.Text;
                        txtSalario10.Text = txtSalario1.Text;
                        txtSalario11.Text = txtSalario1.Text;
                        break;
                }
            }
        }

        // Boton Calcular
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!Validador.ValidarTextBoxVacio(txtNombre) || !Validador.ValidarTextBoxVacio(txtSalario1) 
                || labelMeses.Text == "0")
            {
                int ind;
                 if (Convert.ToInt32(labelYear.Text) > 0)
                {
                    this.salarios = new decimal[12];
                }
                else 
                {
                    this.salarios = new decimal[Convert.ToInt32(labelMeses.Text)];
                }


                if (Convert.ToInt32(labelYear.Text) > 0)
                {
                    this.salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                    this.salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                    this.salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                    this.salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                    this.salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                    salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                    salarios[6] = Convert.ToDecimal(txtSalario7.Text);
                    salarios[7] = Convert.ToDecimal(txtSalario8.Text);
                    salarios[8] = Convert.ToDecimal(txtSalario9.Text);
                    salarios[9] = Convert.ToDecimal(txtSalario10.Text);
                    salarios[10] = Convert.ToDecimal(txtSalario11.Text);
                    salarios[11] = Convert.ToDecimal(txtSalario12.Text);
                }
                else
                {
                    switch (Convert.ToInt32(labelMeses.Text))
                    {
                        case 1:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            break;

                        case 2:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            break;

                        case 3:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            break;

                        case 4:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            break;

                        case 5:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            break;

                        case 6:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                            break;

                        case 7:
                            this.salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            this.salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            this.salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            this.salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            this.salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            this.salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                            this.salarios[6] = Convert.ToDecimal(txtSalario7.Text);
                            break;

                        case 8:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                            salarios[6] = Convert.ToDecimal(txtSalario7.Text);
                            salarios[7] = Convert.ToDecimal(txtSalario8.Text);
                            break;

                        case 9:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                            salarios[6] = Convert.ToDecimal(txtSalario7.Text);
                            salarios[7] = Convert.ToDecimal(txtSalario8.Text);
                            salarios[8] = Convert.ToDecimal(txtSalario9.Text);
                            break;

                        case 10:
                            salarios[0] = Convert.ToDecimal(txtSalario1.Text);
                            salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                            salarios[6] = Convert.ToDecimal(txtSalario7.Text);
                            salarios[7] = Convert.ToDecimal(txtSalario8.Text);
                            salarios[8] = Convert.ToDecimal(txtSalario9.Text);
                            salarios[9] = Convert.ToDecimal(txtSalario10.Text);
                            break;

                        case 11:
                            this.salarios[1] = Convert.ToDecimal(txtSalario2.Text);
                            this.salarios[2] = Convert.ToDecimal(txtSalario3.Text);
                            this.salarios[3] = Convert.ToDecimal(txtSalario4.Text);
                            this.salarios[4] = Convert.ToDecimal(txtSalario5.Text);
                            this.salarios[5] = Convert.ToDecimal(txtSalario6.Text);
                            this.salarios[6] = Convert.ToDecimal(txtSalario7.Text);
                            this.salarios[7] = Convert.ToDecimal(txtSalario8.Text);
                            this.salarios[8] = Convert.ToDecimal(txtSalario9.Text);
                            this.salarios[9] = Convert.ToDecimal(txtSalario10.Text);
                            this.salarios[10] = Convert.ToDecimal(txtSalario11.Text);
                            break;
                    }
                }

                // creamos un nuevo licitante
                bool preaviso = checkPreaviso.Checked;
                bool cesantia = checkCesantia.Checked;
                bool vacion = checkVacion.Checked;
                bool navidad = checkSalarioNavidad.Checked;
                Solicitante solicitante = new Solicitante(txtCedula.Text, txtNombre.Text,
                    txtLugarDeTrabajo.Text,dateFechaIngreso.Value.Date, dateFechaSalida.Value.Date,
                    this.salarios, preaviso, navidad, vacion, cesantia);
                calculadora.CalcularDatos(solicitante);

                // agreagamos a la lista
                mantenimiento.AgregarSolicitante(solicitante);

                // mostramos los datos en sus respetivos label
                labelSumatoria.Text = solicitante.SumatoriaDeSalarios.ToString();
                labelSPM.Text = String.Format("{0:0.##}", solicitante.SalarioPromedioMensual);
                labelSPD.Text = String.Format("{0:0.##}", solicitante.SalarioPromedioDiario);
                labelPreaviso.Text = String.Format("{0:0.##}", solicitante.MyPrestacion.Preaviso);
                labelCesantia.Text = String.Format("{0:0.##}", solicitante.MyPrestacion.Cesantia);
                labelVacaciones.Text = String.Format("{0:0.##}", solicitante.MyPrestacion.Vacaciones);
                labelSalarioNavidad.Text = String.Format("{0:0.##}", solicitante.MyPrestacion.SalarioNavidad);
                labelTotal.Text = String.Format("{0:0.##}", solicitante.MyPrestacion.Total);
                
            }
        }

        private void LimpiarCampos()
        {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtLugarDeTrabajo.Text = "";
            txtSalario1.Text = "";
            txtSalario2.Text = "";
            txtSalario3.Text = "";
            txtSalario4.Text = "";
            txtSalario5.Text = "";
            txtSalario6.Text = "";
            txtSalario7.Text = "";
            txtSalario8.Text = "";
            txtSalario9.Text = "";
            txtSalario10.Text = "";
            txtSalario11.Text = "";
            txtSalario12.Text = "";
            labelTiempoLaborado.Text = "";
            labelSalarioNavidad.Text = "";
            labelSumatoria.Text = "";
            labelSPM.Text = "";
            labelSPD.Text = "";
            labelPreaviso.Text = "";
            labelCesantia.Text = "";
            labelVacaciones.Text = "";
            
           
        }

        private void buttonNuevoSolicitante_Click(object sender, EventArgs e)
        {
            LimpiarCampos();


            dataGridView1.DataSource = null;
            dataGridView1.DataSource = mantenimiento.ObternerRegistro();
            
        }
    }
}
