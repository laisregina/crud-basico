namespace Consulta
{
    partial class Form1
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtPena = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtGrau = new System.Windows.Forms.TextBox();
            this.txtCrime = new System.Windows.Forms.TextBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RG:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(158, 60);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(158, 109);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(158, 135);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(130, 20);
            this.txtRg.TabIndex = 5;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(294, 269);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 43);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "ADICIONAR";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(375, 51);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(100, 36);
            this.btEditar.TabIndex = 7;
            this.btEditar.Text = "EDITAR";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.BtEditar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(264, 51);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(94, 36);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(548, 574);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(100, 42);
            this.btnExibir.TabIndex = 9;
            this.btnExibir.Text = "EXIBIR REGISTROS";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.BtnExibir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(493, 51);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 36);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(41, 343);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(607, 225);
            this.dgvDados.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tempo de pena:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Data de entrada:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Grau de periculosidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(114, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Crime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Situação atual:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(158, 162);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(317, 20);
            this.txtEndereco.TabIndex = 18;
            // 
            // txtPena
            // 
            this.txtPena.Location = new System.Drawing.Point(158, 188);
            this.txtPena.Name = "txtPena";
            this.txtPena.Size = new System.Drawing.Size(130, 20);
            this.txtPena.TabIndex = 19;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(158, 214);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(130, 20);
            this.txtData.TabIndex = 20;
            // 
            // txtGrau
            // 
            this.txtGrau.Location = new System.Drawing.Point(158, 240);
            this.txtGrau.Name = "txtGrau";
            this.txtGrau.Size = new System.Drawing.Size(130, 20);
            this.txtGrau.TabIndex = 21;
            // 
            // txtCrime
            // 
            this.txtCrime.Location = new System.Drawing.Point(158, 266);
            this.txtCrime.Name = "txtCrime";
            this.txtCrime.Size = new System.Drawing.Size(130, 20);
            this.txtCrime.TabIndex = 22;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Location = new System.Drawing.Point(158, 292);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(130, 20);
            this.txtSituacao.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(153, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(372, 26);
            this.label10.TabIndex = 24;
            this.label10.Text = "INFORMAÇÕES DO PRESIDIÁRIO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(683, 636);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSituacao);
            this.Controls.Add(this.txtCrime);
            this.Controls.Add(this.txtGrau);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtPena);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtPena;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtGrau;
        private System.Windows.Forms.TextBox txtCrime;
        private System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label10;
    }
}

