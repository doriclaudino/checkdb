namespace checkdb
{
    partial class FormAnalise
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
            this.components = new System.ComponentModel.Container();
            this.comboBoxBancoDeDados = new System.Windows.Forms.ComboBox();
            this.labelBancoDeDados = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxConexao = new System.Windows.Forms.TextBox();
            this.labelConexao = new System.Windows.Forms.Label();
            this.toolTipConexao = new System.Windows.Forms.ToolTip(this.components);
            this.buttonExecutar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonTestarConexao = new System.Windows.Forms.Button();
            this.groupBoxDadosAcesso = new System.Windows.Forms.GroupBox();
            this.textBoxEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxMeuContato = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.MaskedTextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LbTelefone = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.bw = new System.ComponentModel.BackgroundWorker();
            this.bwAnalise = new System.ComponentModel.BackgroundWorker();
            this.bwUpload = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBoxDadosAcesso.SuspendLayout();
            this.gboxMeuContato.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBancoDeDados
            // 
            this.comboBoxBancoDeDados.FormattingEnabled = true;
            this.comboBoxBancoDeDados.Items.AddRange(new object[] {
            "SQL Server",
            "Oracle"});
            this.comboBoxBancoDeDados.Location = new System.Drawing.Point(11, 52);
            this.comboBoxBancoDeDados.Name = "comboBoxBancoDeDados";
            this.comboBoxBancoDeDados.Size = new System.Drawing.Size(126, 21);
            this.comboBoxBancoDeDados.TabIndex = 5;
            this.comboBoxBancoDeDados.SelectedIndexChanged += new System.EventHandler(this.comboBoxBancoDeDados_SelectedIndexChanged);
            // 
            // labelBancoDeDados
            // 
            this.labelBancoDeDados.AutoSize = true;
            this.labelBancoDeDados.Location = new System.Drawing.Point(8, 36);
            this.labelBancoDeDados.Name = "labelBancoDeDados";
            this.labelBancoDeDados.Size = new System.Drawing.Size(85, 13);
            this.labelBancoDeDados.TabIndex = 2;
            this.labelBancoDeDados.Text = "Banco de dados";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(8, 88);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 3;
            this.labelUsuario.Text = "Usuário";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(11, 104);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(82, 20);
            this.textBoxUsuario.TabIndex = 6;
            this.textBoxUsuario.Text = "system";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(99, 104);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(82, 20);
            this.textBoxSenha.TabIndex = 6;
            this.textBoxSenha.Text = "oracle";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(107, 88);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(38, 13);
            this.labelSenha.TabIndex = 5;
            this.labelSenha.Text = "Senha";
            // 
            // textBoxConexao
            // 
            this.textBoxConexao.Location = new System.Drawing.Point(181, 153);
            this.textBoxConexao.Name = "textBoxConexao";
            this.textBoxConexao.Size = new System.Drawing.Size(126, 20);
            this.textBoxConexao.TabIndex = 7;
            this.textBoxConexao.Text = "orcl";
            // 
            // labelConexao
            // 
            this.labelConexao.AutoSize = true;
            this.labelConexao.Location = new System.Drawing.Point(178, 137);
            this.labelConexao.Name = "labelConexao";
            this.labelConexao.Size = new System.Drawing.Size(165, 13);
            this.labelConexao.TabIndex = 7;
            this.labelConexao.Text = "Nome do Serviço (apenas oracle)";
            // 
            // toolTipConexao
            // 
            this.toolTipConexao.AutoPopDelay = 5000;
            this.toolTipConexao.InitialDelay = 100;
            this.toolTipConexao.IsBalloon = true;
            this.toolTipConexao.ReshowDelay = 100;
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.Enabled = false;
            this.buttonExecutar.Location = new System.Drawing.Point(23, 529);
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(75, 23);
            this.buttonExecutar.TabIndex = 10;
            this.buttonExecutar.Text = "Executar";
            this.buttonExecutar.UseVisualStyleBackColor = true;
            this.buttonExecutar.Click += new System.EventHandler(this.buttonExecutar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 63);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "NVL";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 558);
            this.progressBar1.MarqueeAnimationSpeed = 15;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(370, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // buttonTestarConexao
            // 
            this.buttonTestarConexao.Location = new System.Drawing.Point(231, 36);
            this.buttonTestarConexao.Name = "buttonTestarConexao";
            this.buttonTestarConexao.Size = new System.Drawing.Size(113, 23);
            this.buttonTestarConexao.TabIndex = 9;
            this.buttonTestarConexao.Text = "Testar Conexão";
            this.buttonTestarConexao.UseVisualStyleBackColor = true;
            this.buttonTestarConexao.Click += new System.EventHandler(this.buttonTestarConexao_Click);
            // 
            // groupBoxDadosAcesso
            // 
            this.groupBoxDadosAcesso.Controls.Add(this.textBoxEndereco);
            this.groupBoxDadosAcesso.Controls.Add(this.label3);
            this.groupBoxDadosAcesso.Controls.Add(this.textBoxPorta);
            this.groupBoxDadosAcesso.Controls.Add(this.label1);
            this.groupBoxDadosAcesso.Controls.Add(this.comboBoxBancoDeDados);
            this.groupBoxDadosAcesso.Controls.Add(this.buttonTestarConexao);
            this.groupBoxDadosAcesso.Controls.Add(this.labelBancoDeDados);
            this.groupBoxDadosAcesso.Controls.Add(this.textBoxUsuario);
            this.groupBoxDadosAcesso.Controls.Add(this.labelUsuario);
            this.groupBoxDadosAcesso.Controls.Add(this.textBoxSenha);
            this.groupBoxDadosAcesso.Controls.Add(this.textBoxConexao);
            this.groupBoxDadosAcesso.Controls.Add(this.labelConexao);
            this.groupBoxDadosAcesso.Controls.Add(this.labelSenha);
            this.groupBoxDadosAcesso.Location = new System.Drawing.Point(23, 295);
            this.groupBoxDadosAcesso.Name = "groupBoxDadosAcesso";
            this.groupBoxDadosAcesso.Size = new System.Drawing.Size(370, 193);
            this.groupBoxDadosAcesso.TabIndex = 16;
            this.groupBoxDadosAcesso.TabStop = false;
            this.groupBoxDadosAcesso.Text = "Informações de Acesso";
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.Location = new System.Drawing.Point(11, 153);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(98, 20);
            this.textBoxEndereco.TabIndex = 17;
            this.textBoxEndereco.Text = "192.168.0.100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Endereço (ip)";
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Location = new System.Drawing.Point(116, 153);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(57, 20);
            this.textBoxPorta.TabIndex = 8;
            this.textBoxPorta.Text = "1521";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Porta";
            // 
            // gboxMeuContato
            // 
            this.gboxMeuContato.Controls.Add(this.txtEmail);
            this.gboxMeuContato.Controls.Add(this.lbEmail);
            this.gboxMeuContato.Controls.Add(this.txtEmpresa);
            this.gboxMeuContato.Controls.Add(this.lbEmpresa);
            this.gboxMeuContato.Controls.Add(this.txtTelefone);
            this.gboxMeuContato.Controls.Add(this.LbTelefone);
            this.gboxMeuContato.Controls.Add(this.txtNome);
            this.gboxMeuContato.Controls.Add(this.lbNome);
            this.gboxMeuContato.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gboxMeuContato.Location = new System.Drawing.Point(23, 88);
            this.gboxMeuContato.Name = "gboxMeuContato";
            this.gboxMeuContato.Size = new System.Drawing.Size(370, 182);
            this.gboxMeuContato.TabIndex = 17;
            this.gboxMeuContato.TabStop = false;
            this.gboxMeuContato.Text = "Meu Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmail.Location = new System.Drawing.Point(11, 138);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "fulano@minhaempresa.com.br";
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Validated += new System.EventHandler(this.txtEmail_Validated);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(8, 122);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 13;
            this.lbEmail.Text = "Email";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtEmpresa.Location = new System.Drawing.Point(11, 38);
            this.txtEmpresa.MaxLength = 300;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(333, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.Text = "Empresa do Fulano";
            this.txtEmpresa.Enter += new System.EventHandler(this.txtEmpresa_Enter);
            this.txtEmpresa.Validated += new System.EventHandler(this.txtEmpresa_Validated);
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Location = new System.Drawing.Point(8, 22);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(48, 13);
            this.lbEmpresa.TabIndex = 11;
            this.lbEmpresa.Text = "Empresa";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(181, 90);
            this.txtTelefone.Mask = "(099) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(90, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // LbTelefone
            // 
            this.LbTelefone.AutoSize = true;
            this.LbTelefone.Location = new System.Drawing.Point(178, 74);
            this.LbTelefone.Name = "LbTelefone";
            this.LbTelefone.Size = new System.Drawing.Size(49, 13);
            this.LbTelefone.TabIndex = 9;
            this.LbTelefone.Text = "Telefone";
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNome.Location = new System.Drawing.Point(11, 90);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(146, 20);
            this.txtNome.TabIndex = 2;
            this.txtNome.Text = "Fulano da Silva";
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Validated += new System.EventHandler(this.txtNome_Validated);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(8, 74);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 7;
            this.lbNome.Text = "Nome";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bw
            // 
            this.bw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_DoWork);
            this.bw.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_RunWorkerCompleted);
            // 
            // bwAnalise
            // 
            this.bwAnalise.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwAnalise_DoWork);
            this.bwAnalise.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwAnalise_RunWorkerCompleted);
            // 
            // bwUpload
            // 
            this.bwUpload.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwUpload_DoWork);
            this.bwUpload.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwUpload_RunWorkerCompleted);
            // 
            // FormAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 602);
            this.Controls.Add(this.buttonExecutar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.gboxMeuContato);
            this.Controls.Add(this.groupBoxDadosAcesso);
            this.Controls.Add(this.panel1);
            this.Name = "FormAnalise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "checkdb";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxDadosAcesso.ResumeLayout(false);
            this.groupBoxDadosAcesso.PerformLayout();
            this.gboxMeuContato.ResumeLayout(false);
            this.gboxMeuContato.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }        

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBancoDeDados;
        private System.Windows.Forms.Label labelBancoDeDados;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxConexao;
        private System.Windows.Forms.Label labelConexao;
        private System.Windows.Forms.ToolTip toolTipConexao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExecutar;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonTestarConexao;
        private System.Windows.Forms.GroupBox groupBoxDadosAcesso;
        private System.Windows.Forms.GroupBox gboxMeuContato;
        private System.Windows.Forms.MaskedTextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label LbTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker bw;
        private System.Windows.Forms.TextBox textBoxEndereco;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bwAnalise;
        private System.ComponentModel.BackgroundWorker bwUpload;

    }
}

