using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExHerancaePolimorfismo.Entities;
/*Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
bem como o total de imposto arrecadado.
Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as
seguintes:
Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
destes gastos são abatidos no imposto.
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
fica: (50000 * 25%) - (2000 * 50%) = 11500.00
Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
400000 * 14% = 56000.00

- A idéia foi fazer um sistema que realize a operações acima, sem deixar o usuário utilizar o sistema de maneira incorreta.*/

namespace ExHerancaePolimorfismo
{
    public partial class Form1 : Form
    {
        readonly List<TaxPayer> list = new List<TaxPayer>();
        int i = 1;


        public Form1()
        {

            InitializeComponent();

        }

        private void Btn_Confirm1_Click(object sender, EventArgs e)
        {
            View(1);

        }
        private void Radio_Individual__Click(object sender, EventArgs e)
        {
            Lbl_health_employee.Text = "Health expenditures:";
        }
        private void Radio_Company_Click(object sender, EventArgs e)
        {
            Lbl_health_employee.Text = "Number of employees:";
        }
        private void Btn_Confirm2_Click(object sender, EventArgs e)
        {
            try
            {
                if (i <= Convert.ToInt32(Txt_n_payers.Text))
                {
                    string name = Txt_name.Text;
                    double anualincome = Convert.ToDouble(Txt_anualincome.Text);
                    double health = Convert.ToDouble(Txt_health_employee.Text);
                    if (Radio_Individual.Checked)
                    {
                        list.Add(new Individual(name, anualincome, health));
                        Txt_name.Text = null;
                        Txt_anualincome.Text = null;
                        Txt_health_employee.Text = null;
                    }
                    else
                    {
                        list.Add(new Company(name, anualincome, Convert.ToInt32(health)));
                        Txt_name.Text = null;
                        Txt_anualincome.Text = null;
                        Txt_health_employee.Text = null;
                    }
                    if (i < Convert.ToInt32(Txt_n_payers.Text)) { i++; } // adicionar contagem no Payer
                    Gb_payer_data.Text = "Tax Payer #" + i + " data:";
                }
                else
                {
                    MessageBox.Show("Invalid value");
                }

            }
            catch
            {
                MessageBox.Show("Invalid value");
            }
        }
        private void Btn_search_Click(object sender, EventArgs e)
        {
           

            double sum = 0.0;

            //Datagrid_date.DataSource = null; 
            Datagrid_date.Rows.Clear();
            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Datagrid_date.Rows.Add(new object[] { tp.Name, "$ " + tp.AnualIncome.ToString("F2"), "$ " + tp.Tax().ToString("F2") });
                sum += tax;
            }

            Datagrid_date.Rows.Add("");
            Datagrid_date.Rows.Add("Total Taxes");
            int r = Datagrid_date.Rows.Count;
            Datagrid_date.Rows[r - 2].Cells[2].Value = "$ " + sum.ToString("F2");
        }
        private void Btn_clear_Click(object sender, EventArgs e)
        {
            list.Clear(); // limpar a lista
            Datagrid_date.DataSource = null; //Remover a datasource
                                             // Datagrid_date.Columns.Clear(); //Remover as colunas
            Datagrid_date.Rows.Clear();    //Remover as linhas
            Datagrid_date.Refresh();    //Para a grid se actualizar
            View(0); // retornar para view inicial
        }
        public void View(int x)
        {
            switch (x)
            {
                case 1:
                    Gb_payer_data.Enabled = true;
                    Gb_number_payers.Enabled = false;

                    break;

                default:
                    Gb_number_payers.Enabled = true;
                    Gb_payer_data.Enabled = false;
                    i = 1; // reiniciar variálvel para se utilizar novamente
                    Gb_payer_data.Text = "Tax Payer #" + i + " data:";
                    break;
            }
        }
    }
}


