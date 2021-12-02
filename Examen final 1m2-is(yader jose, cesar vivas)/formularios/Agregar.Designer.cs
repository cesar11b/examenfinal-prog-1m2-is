
namespace Examen_final_1m2_is_yader_jose__cesar_vivas_.formularios
{
    partial class Agregar
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIngId = new System.Windows.Forms.TextBox();
            this.txtIngNom = new System.Windows.Forms.TextBox();
            this.txtIngApe = new System.Windows.Forms.TextBox();
            this.txtIngCar = new System.Windows.Forms.TextBox();
            this.cmbIngMun = new System.Windows.Forms.ComboBox();
            this.cmbIngDepto = new System.Windows.Forms.ComboBox();
            this.btnAgrNotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Carnet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Municipio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento";
            // 
            // txtIngId
            // 
            this.txtIngId.Location = new System.Drawing.Point(144, 36);
            this.txtIngId.Name = "txtIngId";
            this.txtIngId.Size = new System.Drawing.Size(100, 20);
            this.txtIngId.TabIndex = 6;
            // 
            // txtIngNom
            // 
            this.txtIngNom.Location = new System.Drawing.Point(144, 79);
            this.txtIngNom.Name = "txtIngNom";
            this.txtIngNom.Size = new System.Drawing.Size(100, 20);
            this.txtIngNom.TabIndex = 7;
            // 
            // txtIngApe
            // 
            this.txtIngApe.Location = new System.Drawing.Point(144, 128);
            this.txtIngApe.Name = "txtIngApe";
            this.txtIngApe.Size = new System.Drawing.Size(100, 20);
            this.txtIngApe.TabIndex = 8;
            // 
            // txtIngCar
            // 
            this.txtIngCar.Location = new System.Drawing.Point(144, 174);
            this.txtIngCar.Name = "txtIngCar";
            this.txtIngCar.Size = new System.Drawing.Size(100, 20);
            this.txtIngCar.TabIndex = 9;
            // 
            // cmbIngMun
            // 
            this.cmbIngMun.FormattingEnabled = true;
            this.cmbIngMun.Items.AddRange(new object[] {
            "Managua",
            "Ciudada_Sandino",
            "El_Crucero",
            "Mateare",
            "San_Framcisco_Libre",
            "San_Rafael_del_sur",
            "Ticuantepe",
            "Tipitapa"});
            this.cmbIngMun.Location = new System.Drawing.Point(144, 231);
            this.cmbIngMun.Name = "cmbIngMun";
            this.cmbIngMun.Size = new System.Drawing.Size(121, 21);
            this.cmbIngMun.TabIndex = 10;
            // 
            // cmbIngDepto
            // 
            this.cmbIngDepto.FormattingEnabled = true;
            this.cmbIngDepto.Items.AddRange(new object[] {
            "Chinandega",
            "Esteli",
            "Granada",
            "Jinotega",
            "Managua",
            "Masaya",
            "Matagalpa",
            "Carazo",
            "Boaco"});
            this.cmbIngDepto.Location = new System.Drawing.Point(144, 279);
            this.cmbIngDepto.Name = "cmbIngDepto";
            this.cmbIngDepto.Size = new System.Drawing.Size(121, 21);
            this.cmbIngDepto.TabIndex = 11;
            // 
            // btnAgrNotas
            // 
            this.btnAgrNotas.Location = new System.Drawing.Point(351, 363);
            this.btnAgrNotas.Name = "btnAgrNotas";
            this.btnAgrNotas.Size = new System.Drawing.Size(75, 23);
            this.btnAgrNotas.TabIndex = 12;
            this.btnAgrNotas.Text = "Agregar notas";
            this.btnAgrNotas.UseVisualStyleBackColor = true;
            this.btnAgrNotas.Click += new System.EventHandler(this.btnAgrNotas_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.btnAgrNotas);
            this.Controls.Add(this.cmbIngDepto);
            this.Controls.Add(this.cmbIngMun);
            this.Controls.Add(this.txtIngCar);
            this.Controls.Add(this.txtIngApe);
            this.Controls.Add(this.txtIngNom);
            this.Controls.Add(this.txtIngId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIngId;
        private System.Windows.Forms.TextBox txtIngNom;
        private System.Windows.Forms.TextBox txtIngApe;
        private System.Windows.Forms.TextBox txtIngCar;
        private System.Windows.Forms.ComboBox cmbIngMun;
        private System.Windows.Forms.ComboBox cmbIngDepto;
        private System.Windows.Forms.Button btnAgrNotas;
    }
}