namespace Mario
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
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCogumelo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonSuperStar = new System.Windows.Forms.Button();
            this.buttonFireFlower = new System.Windows.Forms.Button();
            this.buttonDano = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxAção = new System.Windows.Forms.TextBox();
            this.textBoxNovoStatus = new System.Windows.Forms.TextBox();
            this.buttonNovo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCogumelo
            // 
            this.buttonCogumelo.BackgroundImage = global::Mario.Properties.Resources.growup4;
            this.buttonCogumelo.Location = new System.Drawing.Point(293, 112);
            this.buttonCogumelo.Name = "buttonCogumelo";
            this.buttonCogumelo.Size = new System.Drawing.Size(51, 51);
            this.buttonCogumelo.TabIndex = 0;
            this.buttonCogumelo.UseVisualStyleBackColor = true;
            this.buttonCogumelo.Click += new System.EventHandler(this.buttonCogumelo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cogumelo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estrela";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Flor de Fogo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dano";
            // 
            // buttonSuperStar
            // 
            this.buttonSuperStar.BackgroundImage = global::Mario.Properties.Resources.star1;
            this.buttonSuperStar.Location = new System.Drawing.Point(293, 179);
            this.buttonSuperStar.Name = "buttonSuperStar";
            this.buttonSuperStar.Size = new System.Drawing.Size(51, 51);
            this.buttonSuperStar.TabIndex = 8;
            this.buttonSuperStar.UseVisualStyleBackColor = true;
            this.buttonSuperStar.Click += new System.EventHandler(this.buttonSuperStar_Click);
            // 
            // buttonFireFlower
            // 
            this.buttonFireFlower.BackgroundImage = global::Mario.Properties.Resources.flower1;
            this.buttonFireFlower.Location = new System.Drawing.Point(293, 249);
            this.buttonFireFlower.Name = "buttonFireFlower";
            this.buttonFireFlower.Size = new System.Drawing.Size(51, 51);
            this.buttonFireFlower.TabIndex = 9;
            this.buttonFireFlower.UseVisualStyleBackColor = true;
            this.buttonFireFlower.Click += new System.EventHandler(this.buttonFireFlower_Click);
            // 
            // buttonDano
            // 
            this.buttonDano.BackgroundImage = global::Mario.Properties.Resources.i1;
            this.buttonDano.Location = new System.Drawing.Point(293, 318);
            this.buttonDano.Name = "buttonDano";
            this.buttonDano.Size = new System.Drawing.Size(51, 51);
            this.buttonDano.TabIndex = 10;
            this.buttonDano.UseVisualStyleBackColor = true;
            this.buttonDano.Click += new System.EventHandler(this.buttonDano_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(479, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ação:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Novo Status:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.textBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStatus.Location = new System.Drawing.Point(550, 112);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(249, 29);
            this.textBoxStatus.TabIndex = 14;
            // 
            // textBoxAção
            // 
            this.textBoxAção.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.textBoxAção.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAção.Location = new System.Drawing.Point(550, 170);
            this.textBoxAção.Name = "textBoxAção";
            this.textBoxAção.ReadOnly = true;
            this.textBoxAção.Size = new System.Drawing.Size(249, 29);
            this.textBoxAção.TabIndex = 15;
            // 
            // textBoxNovoStatus
            // 
            this.textBoxNovoStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(248)))), ((int)(((byte)(216)))));
            this.textBoxNovoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNovoStatus.Location = new System.Drawing.Point(550, 227);
            this.textBoxNovoStatus.Name = "textBoxNovoStatus";
            this.textBoxNovoStatus.ReadOnly = true;
            this.textBoxNovoStatus.Size = new System.Drawing.Size(249, 29);
            this.textBoxNovoStatus.TabIndex = 16;
            // 
            // buttonNovo
            // 
            this.buttonNovo.BackgroundImage = global::Mario.Properties.Resources.nsmb_mushroom_1up;
            this.buttonNovo.Location = new System.Drawing.Point(293, 40);
            this.buttonNovo.Name = "buttonNovo";
            this.buttonNovo.Size = new System.Drawing.Size(51, 51);
            this.buttonNovo.TabIndex = 17;
            this.buttonNovo.UseVisualStyleBackColor = true;
            this.buttonNovo.Click += new System.EventHandler(this.buttonNovo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Novo Jogo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mario.Properties.Resources.SuperMarioWorld_DonutPlains_DonutPlains46;
            this.ClientSize = new System.Drawing.Size(887, 502);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonNovo);
            this.Controls.Add(this.textBoxNovoStatus);
            this.Controls.Add(this.textBoxAção);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonDano);
            this.Controls.Add(this.buttonFireFlower);
            this.Controls.Add(this.buttonSuperStar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCogumelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCogumelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonSuperStar;
        private System.Windows.Forms.Button buttonFireFlower;
        private System.Windows.Forms.Button buttonDano;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxAção;
        private System.Windows.Forms.TextBox textBoxNovoStatus;
        private System.Windows.Forms.Button buttonNovo;
        private System.Windows.Forms.Label label8;
    }
}

