namespace Nomina
{
    partial class claNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelArs = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.labelAfp = new System.Windows.Forms.Label();
            this.labelIsr = new System.Windows.Forms.Label();
            this.labelTotalDiscount = new System.Windows.Forms.Label();
            this.labelMonthlyNetSalary = new System.Windows.Forms.Label();
            this.labelBiweeklyNetSalary = new System.Windows.Forms.Label();
            this.groupBoxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(184, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora para Retenciones de Nómina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Mensual:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(714, 104);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 35);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(714, 187);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 35);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(714, 269);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.labelBiweeklyNetSalary);
            this.groupBoxDetail.Controls.Add(this.labelMonthlyNetSalary);
            this.groupBoxDetail.Controls.Add(this.labelTotalDiscount);
            this.groupBoxDetail.Controls.Add(this.labelIsr);
            this.groupBoxDetail.Controls.Add(this.labelAfp);
            this.groupBoxDetail.Controls.Add(this.labelArs);
            this.groupBoxDetail.Controls.Add(this.label8);
            this.groupBoxDetail.Controls.Add(this.label7);
            this.groupBoxDetail.Controls.Add(this.label6);
            this.groupBoxDetail.Controls.Add(this.label5);
            this.groupBoxDetail.Controls.Add(this.label4);
            this.groupBoxDetail.Controls.Add(this.label3);
            this.groupBoxDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetail.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxDetail.Location = new System.Drawing.Point(55, 163);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(572, 260);
            this.groupBoxDetail.TabIndex = 6;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "Detalle pago de nómina";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkGreen;
            this.label8.Location = new System.Drawing.Point(15, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Salario Neto Quincenal:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(15, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Salario Neto Mensual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(15, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Descuento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(15, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Impuesto Sobre la Renta (ISR):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(15, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Administradora de Fondo de Pensiones (AFP):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(15, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seguro Familiar de Salud (ARS):";
            // 
            // labelArs
            // 
            this.labelArs.AutoSize = true;
            this.labelArs.ForeColor = System.Drawing.Color.Black;
            this.labelArs.Location = new System.Drawing.Point(254, 41);
            this.labelArs.Name = "labelArs";
            this.labelArs.Size = new System.Drawing.Size(0, 18);
            this.labelArs.TabIndex = 8;
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalary.Location = new System.Drawing.Point(201, 104);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(185, 24);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.TextChanged += new System.EventHandler(this.txtSalary_TextChanged);
            // 
            // labelAfp
            // 
            this.labelAfp.AutoSize = true;
            this.labelAfp.ForeColor = System.Drawing.Color.Black;
            this.labelAfp.Location = new System.Drawing.Point(359, 79);
            this.labelAfp.Name = "labelAfp";
            this.labelAfp.Size = new System.Drawing.Size(0, 18);
            this.labelAfp.TabIndex = 9;
            // 
            // labelIsr
            // 
            this.labelIsr.AutoSize = true;
            this.labelIsr.ForeColor = System.Drawing.Color.Black;
            this.labelIsr.Location = new System.Drawing.Point(243, 116);
            this.labelIsr.Name = "labelIsr";
            this.labelIsr.Size = new System.Drawing.Size(0, 18);
            this.labelIsr.TabIndex = 10;
            // 
            // labelTotalDiscount
            // 
            this.labelTotalDiscount.AutoSize = true;
            this.labelTotalDiscount.ForeColor = System.Drawing.Color.Black;
            this.labelTotalDiscount.Location = new System.Drawing.Point(152, 159);
            this.labelTotalDiscount.Name = "labelTotalDiscount";
            this.labelTotalDiscount.Size = new System.Drawing.Size(0, 18);
            this.labelTotalDiscount.TabIndex = 11;
            // 
            // labelMonthlyNetSalary
            // 
            this.labelMonthlyNetSalary.AutoSize = true;
            this.labelMonthlyNetSalary.ForeColor = System.Drawing.Color.Black;
            this.labelMonthlyNetSalary.Location = new System.Drawing.Point(182, 195);
            this.labelMonthlyNetSalary.Name = "labelMonthlyNetSalary";
            this.labelMonthlyNetSalary.Size = new System.Drawing.Size(0, 18);
            this.labelMonthlyNetSalary.TabIndex = 12;
            // 
            // labelBiweeklyNetSalary
            // 
            this.labelBiweeklyNetSalary.AutoSize = true;
            this.labelBiweeklyNetSalary.ForeColor = System.Drawing.Color.Black;
            this.labelBiweeklyNetSalary.Location = new System.Drawing.Point(193, 231);
            this.labelBiweeklyNetSalary.Name = "labelBiweeklyNetSalary";
            this.labelBiweeklyNetSalary.Size = new System.Drawing.Size(0, 18);
            this.labelBiweeklyNetSalary.TabIndex = 13;
            // 
            // claNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 498);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "claNomina";
            this.Text = "Calculadora de Nomina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxDetail.ResumeLayout(false);
            this.groupBoxDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelArs;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label labelBiweeklyNetSalary;
        private System.Windows.Forms.Label labelMonthlyNetSalary;
        private System.Windows.Forms.Label labelTotalDiscount;
        private System.Windows.Forms.Label labelIsr;
        private System.Windows.Forms.Label labelAfp;
    }
}

