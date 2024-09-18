namespace WS
{
    partial class FrmPrincipal
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
            this.btnCadastrarMedico = new System.Windows.Forms.Button();
            this.btnCadastrarPaciente = new System.Windows.Forms.Button();
            this.btnListarAgendamento = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarMedico
            // 
            this.btnCadastrarMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrarMedico.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarMedico.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarMedico.Location = new System.Drawing.Point(90, 28);
            this.btnCadastrarMedico.Name = "btnCadastrarMedico";
            this.btnCadastrarMedico.Size = new System.Drawing.Size(159, 54);
            this.btnCadastrarMedico.TabIndex = 0;
            this.btnCadastrarMedico.Text = "Cadastrar Médico";
            this.btnCadastrarMedico.UseVisualStyleBackColor = false;
            this.btnCadastrarMedico.Click += new System.EventHandler(this.btnCadastrarMedico_Click);
            // 
            // btnCadastrarPaciente
            // 
            this.btnCadastrarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastrarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarPaciente.Location = new System.Drawing.Point(90, 88);
            this.btnCadastrarPaciente.Name = "btnCadastrarPaciente";
            this.btnCadastrarPaciente.Size = new System.Drawing.Size(159, 54);
            this.btnCadastrarPaciente.TabIndex = 1;
            this.btnCadastrarPaciente.Text = "Cadastrar Paciente";
            this.btnCadastrarPaciente.UseVisualStyleBackColor = false;
            this.btnCadastrarPaciente.Click += new System.EventHandler(this.btnCadastrarPaciente_Click);
            // 
            // btnListarAgendamento
            // 
            this.btnListarAgendamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnListarAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarAgendamento.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAgendamento.Location = new System.Drawing.Point(90, 148);
            this.btnListarAgendamento.Name = "btnListarAgendamento";
            this.btnListarAgendamento.Size = new System.Drawing.Size(159, 54);
            this.btnListarAgendamento.TabIndex = 2;
            this.btnListarAgendamento.Text = "Listar Agendamento";
            this.btnListarAgendamento.UseVisualStyleBackColor = false;
            this.btnListarAgendamento.Click += new System.EventHandler(this.btnListarAgendamento_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(90, 359);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(159, 54);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnListarAgendamento);
            this.Controls.Add(this.btnCadastrarPaciente);
            this.Controls.Add(this.btnCadastrarMedico);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarMedico;
        private System.Windows.Forms.Button btnCadastrarPaciente;
        private System.Windows.Forms.Button btnListarAgendamento;
        private System.Windows.Forms.Button btnSair;
    }
}

