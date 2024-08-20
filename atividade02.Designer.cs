namespace LOPAL_pedro_paulo
{
    partial class atividade02
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.rbmercurio = new System.Windows.Forms.RadioButton();
            this.rbmarte = new System.Windows.Forms.RadioButton();
            this.rbjupter = new System.Windows.Forms.RadioButton();
            this.rbvenus = new System.Windows.Forms.RadioButton();
            this.rbsaturno = new System.Windows.Forms.RadioButton();
            this.rburano = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso na Terra (kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o Planeta:";
            // 
            // txtvalor1
            // 
            this.txtvalor1.Location = new System.Drawing.Point(39, 73);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(139, 20);
            this.txtvalor1.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(210, 73);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(102, 24);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular Peso ";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // rbmercurio
            // 
            this.rbmercurio.AutoSize = true;
            this.rbmercurio.Location = new System.Drawing.Point(39, 171);
            this.rbmercurio.Name = "rbmercurio";
            this.rbmercurio.Size = new System.Drawing.Size(66, 17);
            this.rbmercurio.TabIndex = 7;
            this.rbmercurio.TabStop = true;
            this.rbmercurio.Text = "Mercúrio";
            this.rbmercurio.UseVisualStyleBackColor = true;
            // 
            // rbmarte
            // 
            this.rbmarte.AutoSize = true;
            this.rbmarte.Location = new System.Drawing.Point(150, 171);
            this.rbmarte.Name = "rbmarte";
            this.rbmarte.Size = new System.Drawing.Size(52, 17);
            this.rbmarte.TabIndex = 7;
            this.rbmarte.TabStop = true;
            this.rbmarte.Text = "Marte";
            this.rbmarte.UseVisualStyleBackColor = true;
            // 
            // rbjupter
            // 
            this.rbjupter.AutoSize = true;
            this.rbjupter.Location = new System.Drawing.Point(150, 194);
            this.rbjupter.Name = "rbjupter";
            this.rbjupter.Size = new System.Drawing.Size(56, 17);
            this.rbjupter.TabIndex = 7;
            this.rbjupter.TabStop = true;
            this.rbjupter.Text = "Júpiter";
            this.rbjupter.UseVisualStyleBackColor = true;
            // 
            // rbvenus
            // 
            this.rbvenus.AutoSize = true;
            this.rbvenus.Location = new System.Drawing.Point(39, 194);
            this.rbvenus.Name = "rbvenus";
            this.rbvenus.Size = new System.Drawing.Size(55, 17);
            this.rbvenus.TabIndex = 7;
            this.rbvenus.TabStop = true;
            this.rbvenus.Text = "Vênus";
            this.rbvenus.UseVisualStyleBackColor = true;
            // 
            // rbsaturno
            // 
            this.rbsaturno.AutoSize = true;
            this.rbsaturno.Location = new System.Drawing.Point(254, 171);
            this.rbsaturno.Name = "rbsaturno";
            this.rbsaturno.Size = new System.Drawing.Size(62, 17);
            this.rbsaturno.TabIndex = 7;
            this.rbsaturno.TabStop = true;
            this.rbsaturno.Text = "Saturno";
            this.rbsaturno.UseVisualStyleBackColor = true;
            // 
            // rburano
            // 
            this.rburano.AutoSize = true;
            this.rburano.Location = new System.Drawing.Point(254, 194);
            this.rburano.Name = "rburano";
            this.rburano.Size = new System.Drawing.Size(54, 17);
            this.rburano.TabIndex = 7;
            this.rburano.TabStop = true;
            this.rburano.Text = "Urano";
            this.rburano.UseVisualStyleBackColor = true;
            // 
            // atividade02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 275);
            this.Controls.Add(this.rbjupter);
            this.Controls.Add(this.rbmarte);
            this.Controls.Add(this.rbsaturno);
            this.Controls.Add(this.rbvenus);
            this.Controls.Add(this.rburano);
            this.Controls.Add(this.rbmercurio);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtvalor1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "atividade02";
            this.Text = "atividade02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.RadioButton rbmercurio;
        private System.Windows.Forms.RadioButton rbmarte;
        private System.Windows.Forms.RadioButton rbjupter;
        private System.Windows.Forms.RadioButton rbvenus;
        private System.Windows.Forms.RadioButton rbsaturno;
        private System.Windows.Forms.RadioButton rburano;
    }
}