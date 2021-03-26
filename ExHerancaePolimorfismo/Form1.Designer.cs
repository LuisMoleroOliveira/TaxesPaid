
namespace ExHerancaePolimorfismo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_n_payers = new System.Windows.Forms.TextBox();
            this.Gb_payer_data = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_anualincome = new System.Windows.Forms.TextBox();
            this.Radio_Company = new System.Windows.Forms.RadioButton();
            this.Radio_Individual = new System.Windows.Forms.RadioButton();
            this.Btn_Confirm2 = new System.Windows.Forms.Button();
            this.Lbl_health_employee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_health_employee = new System.Windows.Forms.TextBox();
            this.Txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_search = new System.Windows.Forms.Button();
            this.Btn_Confirm1 = new System.Windows.Forms.Button();
            this.Gb_search = new System.Windows.Forms.GroupBox();
            this.Btn_clear = new System.Windows.Forms.Button();
            this.Datagrid_date = new System.Windows.Forms.DataGridView();
            this.Gb_number_payers = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnualIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxPaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gb_payer_data.SuspendLayout();
            this.Gb_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_date)).BeginInit();
            this.Gb_number_payers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of tax payers: ";
            // 
            // Txt_n_payers
            // 
            this.Txt_n_payers.Location = new System.Drawing.Point(163, 13);
            this.Txt_n_payers.Name = "Txt_n_payers";
            this.Txt_n_payers.Size = new System.Drawing.Size(100, 20);
            this.Txt_n_payers.TabIndex = 1;
            // 
            // Gb_payer_data
            // 
            this.Gb_payer_data.Controls.Add(this.label4);
            this.Gb_payer_data.Controls.Add(this.Txt_anualincome);
            this.Gb_payer_data.Controls.Add(this.Radio_Company);
            this.Gb_payer_data.Controls.Add(this.Radio_Individual);
            this.Gb_payer_data.Controls.Add(this.Btn_Confirm2);
            this.Gb_payer_data.Controls.Add(this.Lbl_health_employee);
            this.Gb_payer_data.Controls.Add(this.label3);
            this.Gb_payer_data.Controls.Add(this.Txt_health_employee);
            this.Gb_payer_data.Controls.Add(this.Txt_name);
            this.Gb_payer_data.Controls.Add(this.label2);
            this.Gb_payer_data.Enabled = false;
            this.Gb_payer_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gb_payer_data.Location = new System.Drawing.Point(12, 61);
            this.Gb_payer_data.Name = "Gb_payer_data";
            this.Gb_payer_data.Size = new System.Drawing.Size(463, 169);
            this.Gb_payer_data.TabIndex = 0;
            this.Gb_payer_data.TabStop = false;
            this.Gb_payer_data.Text = "Tax Payer #1 data:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Anual Income";
            // 
            // Txt_anualincome
            // 
            this.Txt_anualincome.Location = new System.Drawing.Point(163, 69);
            this.Txt_anualincome.Name = "Txt_anualincome";
            this.Txt_anualincome.Size = new System.Drawing.Size(100, 20);
            this.Txt_anualincome.TabIndex = 6;
            // 
            // Radio_Company
            // 
            this.Radio_Company.AutoSize = true;
            this.Radio_Company.Location = new System.Drawing.Point(231, 20);
            this.Radio_Company.Name = "Radio_Company";
            this.Radio_Company.Size = new System.Drawing.Size(32, 17);
            this.Radio_Company.TabIndex = 4;
            this.Radio_Company.Text = "C";
            this.Radio_Company.UseVisualStyleBackColor = true;
            this.Radio_Company.Click += new System.EventHandler(this.Radio_Company_Click);
            // 
            // Radio_Individual
            // 
            this.Radio_Individual.AutoSize = true;
            this.Radio_Individual.Checked = true;
            this.Radio_Individual.Location = new System.Drawing.Point(163, 20);
            this.Radio_Individual.Name = "Radio_Individual";
            this.Radio_Individual.Size = new System.Drawing.Size(28, 17);
            this.Radio_Individual.TabIndex = 3;
            this.Radio_Individual.TabStop = true;
            this.Radio_Individual.Text = "I";
            this.Radio_Individual.UseVisualStyleBackColor = true;
            this.Radio_Individual.Click += new System.EventHandler(this.Radio_Individual__Click);
            // 
            // Btn_Confirm2
            // 
            this.Btn_Confirm2.Location = new System.Drawing.Point(163, 140);
            this.Btn_Confirm2.Name = "Btn_Confirm2";
            this.Btn_Confirm2.Size = new System.Drawing.Size(100, 23);
            this.Btn_Confirm2.TabIndex = 8;
            this.Btn_Confirm2.Text = "Confirm";
            this.Btn_Confirm2.UseVisualStyleBackColor = true;
            this.Btn_Confirm2.Click += new System.EventHandler(this.Btn_Confirm2_Click);
            // 
            // Lbl_health_employee
            // 
            this.Lbl_health_employee.AutoSize = true;
            this.Lbl_health_employee.Location = new System.Drawing.Point(7, 98);
            this.Lbl_health_employee.Name = "Lbl_health_employee";
            this.Lbl_health_employee.Size = new System.Drawing.Size(104, 13);
            this.Lbl_health_employee.TabIndex = 0;
            this.Lbl_health_employee.Text = "Health expenditures:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name: ";
            // 
            // Txt_health_employee
            // 
            this.Txt_health_employee.Location = new System.Drawing.Point(163, 95);
            this.Txt_health_employee.Name = "Txt_health_employee";
            this.Txt_health_employee.Size = new System.Drawing.Size(100, 20);
            this.Txt_health_employee.TabIndex = 7;
            // 
            // Txt_name
            // 
            this.Txt_name.Location = new System.Drawing.Point(163, 43);
            this.Txt_name.Name = "Txt_name";
            this.Txt_name.Size = new System.Drawing.Size(100, 20);
            this.Txt_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Individual or company (I/ C)?";
            // 
            // Btn_search
            // 
            this.Btn_search.Location = new System.Drawing.Point(10, 19);
            this.Btn_search.Name = "Btn_search";
            this.Btn_search.Size = new System.Drawing.Size(100, 23);
            this.Btn_search.TabIndex = 9;
            this.Btn_search.Text = "Search";
            this.Btn_search.UseVisualStyleBackColor = true;
            this.Btn_search.Click += new System.EventHandler(this.Btn_search_Click);
            // 
            // Btn_Confirm1
            // 
            this.Btn_Confirm1.Location = new System.Drawing.Point(269, 11);
            this.Btn_Confirm1.Name = "Btn_Confirm1";
            this.Btn_Confirm1.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm1.TabIndex = 2;
            this.Btn_Confirm1.Text = "Confirm";
            this.Btn_Confirm1.UseVisualStyleBackColor = true;
            this.Btn_Confirm1.Click += new System.EventHandler(this.Btn_Confirm1_Click);
            // 
            // Gb_search
            // 
            this.Gb_search.Controls.Add(this.Btn_clear);
            this.Gb_search.Controls.Add(this.Btn_search);
            this.Gb_search.Controls.Add(this.Datagrid_date);
            this.Gb_search.Location = new System.Drawing.Point(12, 236);
            this.Gb_search.Name = "Gb_search";
            this.Gb_search.Size = new System.Drawing.Size(463, 202);
            this.Gb_search.TabIndex = 0;
            this.Gb_search.TabStop = false;
            // 
            // Btn_clear
            // 
            this.Btn_clear.Location = new System.Drawing.Point(353, 19);
            this.Btn_clear.Name = "Btn_clear";
            this.Btn_clear.Size = new System.Drawing.Size(100, 23);
            this.Btn_clear.TabIndex = 11;
            this.Btn_clear.Text = "Clear";
            this.Btn_clear.UseVisualStyleBackColor = true;
            this.Btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // Datagrid_date
            // 
            this.Datagrid_date.AllowUserToOrderColumns = true;
            this.Datagrid_date.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Datagrid_date.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagrid_date.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.AnualIncome,
            this.TaxPaid});
            this.Datagrid_date.Location = new System.Drawing.Point(9, 55);
            this.Datagrid_date.Name = "Datagrid_date";
            this.Datagrid_date.Size = new System.Drawing.Size(444, 114);
            this.Datagrid_date.TabIndex = 10;
            // 
            // Gb_number_payers
            // 
            this.Gb_number_payers.Controls.Add(this.label1);
            this.Gb_number_payers.Controls.Add(this.Txt_n_payers);
            this.Gb_number_payers.Controls.Add(this.Btn_Confirm1);
            this.Gb_number_payers.Location = new System.Drawing.Point(12, 12);
            this.Gb_number_payers.Name = "Gb_number_payers";
            this.Gb_number_payers.Size = new System.Drawing.Size(463, 43);
            this.Gb_number_payers.TabIndex = 3;
            this.Gb_number_payers.TabStop = false;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // AnualIncome
            // 
            this.AnualIncome.HeaderText = "Anual Income";
            this.AnualIncome.Name = "AnualIncome";
            // 
            // TaxPaid
            // 
            this.TaxPaid.HeaderText = "Tax Paid";
            this.TaxPaid.Name = "TaxPaid";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.Gb_number_payers);
            this.Controls.Add(this.Gb_search);
            this.Controls.Add(this.Gb_payer_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Gb_payer_data.ResumeLayout(false);
            this.Gb_payer_data.PerformLayout();
            this.Gb_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_date)).EndInit();
            this.Gb_number_payers.ResumeLayout(false);
            this.Gb_number_payers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_n_payers;
        private System.Windows.Forms.GroupBox Gb_payer_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_health_employee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_health_employee;
        private System.Windows.Forms.TextBox Txt_name;
        private System.Windows.Forms.Button Btn_Confirm1;
        private System.Windows.Forms.Button Btn_Confirm2;
        private System.Windows.Forms.RadioButton Radio_Company;
        private System.Windows.Forms.RadioButton Radio_Individual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_anualincome;
        private System.Windows.Forms.Button Btn_search;
        private System.Windows.Forms.GroupBox Gb_search;
        private System.Windows.Forms.DataGridView Datagrid_date;
        private System.Windows.Forms.GroupBox Gb_number_payers;
        private System.Windows.Forms.Button Btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnualIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxPaid;
    }
}

