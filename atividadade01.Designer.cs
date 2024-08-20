namespace LOPAL_pedro_paulo
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
            this.GRP_result = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvalor2 = new System.Windows.Forms.TextBox();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.txtvalor3 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblmaior = new System.Windows.Forms.Label();
            this.lblmenor = new System.Windows.Forms.Label();
            this.GRP_result.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRP_result
            // 
            this.GRP_result.Controls.Add(this.lblmenor);
            this.GRP_result.Controls.Add(this.label2);
            this.GRP_result.Controls.Add(this.label1);
            this.GRP_result.Location = new System.Drawing.Point(54, 240);
            this.GRP_result.Name = "GRP_result";
            this.GRP_result.Size = new System.Drawing.Size(390, 123);
            this.GRP_result.TabIndex = 0;
            this.GRP_result.TabStop = false;
            this.GRP_result.Text = "Resultado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Menor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Maior:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Atividade - Maior ou Menor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Valor 01:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Valor 02:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Valor 03:";
            // 
            // txtvalor2
            // 
            this.txtvalor2.Location = new System.Drawing.Point(147, 151);
            this.txtvalor2.Name = "txtvalor2";
            this.txtvalor2.Size = new System.Drawing.Size(275, 20);
            this.txtvalor2.TabIndex = 2;
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(147, 103);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(275, 20);
            this.txtvalor1.TabIndex = 2;
            // 
            // txtvalor3
            // 
            this.txtvalor3.Location = new System.Drawing.Point(147, 198);
            this.txtvalor3.Name = "txtvalor3";
            this.txtvalor3.Size = new System.Drawing.Size(275, 20);
            this.txtvalor3.TabIndex = 2;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(222, 381);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(86, 38);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblmaior
            // 
            this.lblmaior.AutoSize = true;
            this.lblmaior.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmaior.Location = new System.Drawing.Point(168, 272);
            this.lblmaior.Name = "lblmaior";
            this.lblmaior.Size = new System.Drawing.Size(10, 16);
            this.lblmaior.TabIndex = 0;
            this.lblmaior.Text = " ";
            this.lblmaior.Click += new System.EventHandler(this.lblmaior_Click);
            // 
            // lblmenor
            // 
            this.lblmenor.AutoSize = true;
            this.lblmenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmenor.Location = new System.Drawing.Point(114, 82);
            this.lblmenor.Name = "lblmenor";
            this.lblmenor.Size = new System.Drawing.Size(0, 16);
            this.lblmenor.TabIndex = 0;
            this.lblmenor.Click += new System.EventHandler(this.lblmenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 431);
            this.Controls.Add(this.lblmaior);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.txtvalor3);
            this.Controls.Add(this.txtvalor2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GRP_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GRP_result.ResumeLayout(false);
            this.GRP_result.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GRP_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvalor2;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.TextBox txtvalor3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblmenor;
        private System.Windows.Forms.Label lblmaior;
    }
}

