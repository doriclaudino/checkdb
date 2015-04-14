using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Collections.Specialized;
using Oracle.DataAccess.Client;
using System.Text.RegularExpressions;


namespace checkdb
{
    public partial class FormAnalise : Form
    {
        public static String connectionString;
        public Boolean testando_conexao = false;
        public Boolean conectando = false;
        private AnaliseOracle ao;
        private NameValueCollection retornos;


        public FormAnalise()
        {          
            InitializeComponent();
        }

        private void comboBoxBancoDeDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxBancoDeDados.SelectedIndex == 0){
                this.labelConexao.Text = "Fonte de dados (somente sqlserver):";
                toolTipConexao.SetToolTip(this.textBoxConexao, "Verifique nas fontes de dados do Sistema (ODBC).");
            }
            else{
                this.labelConexao.Text = "Nome do serviço (somente oracle):";
                toolTipConexao.SetToolTip(this.textBoxConexao, "Verifique no arquivo tnsnames.ora");
            }
        }

        private void buttonExecutar_Click(object sender, EventArgs e)
        {
            if (comboBoxBancoDeDados.SelectedIndex == 1)
            {
                try
                {
                    AnaliseOracle ao;
                    if (conectando && !testando_conexao)
                    {
                        //executa as querys
                        bwAnalise.RunWorkerAsync();
                    }
                    //ExecuteConsultas();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
        }


        private void ExecuteConsultas()
        {
            
            Thread backgroundThread = new Thread(
            new ThreadStart(() =>
            {
                String formulario_oracle = "1aIOnJGjfbM7exWfGCNrj6rQ7m_YeksidBPyEjGQIjZ4";
                String url_inicial = "https://docs.google.com/forms/d/" + formulario_oracle + "/formResponse?ifq&";

                AnaliseOracle ao = null;
                NameValueCollection resultados = null;         

                ao = new AnaliseOracle(true);
               
                resultados = new NameValueCollection();

                int percent = 0;
                int total = ao.getConsultas().Count;

                
                for (int i = 0; i < total; i++)
                {
                    percent += (i + 1 * 100) / total;

                    ao.consultas[i].retorno = ao.getError(ao.consultas[i].query);

                    //cria os parametros pra enviar os valores para web
                    resultados.Add(ao.consultas[i].campo, ao.consultas[i].retorno.ToString());

                    /*
                    if (i % 2 == 1)
                        Thread.Sleep(650);
                    else
                        Thread.Sleep(150);
                        * */

                    //incrementa a barra de progresso
                    progressBar1.BeginInvoke(
                        new Action(() =>
                        {
                            progressBar1.Value = percent;
                        }
                    ));
                }
                
                String result = "";
                //envia os resultados para planilha
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        byte[] response =
                        client.UploadValues(url_inicial, resultados);
                        result = System.Text.Encoding.UTF8.GetString(response);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (result.Length < 1)
                    MessageBox.Show("Oopss! não conseguimos enviar!");
                else
                {
                    Thread.Sleep(100);
                    MessageBox.Show("Recebemos suas informações!");
                }
                
                
                progressBar1.BeginInvoke(
                    new Action(() =>
                    {
                        progressBar1.Value = 0;
                    }
                ));
            }
            ));

            if (!testando_conexao)
            {
                backgroundThread.Start();
            }                          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxBancoDeDados.SelectedIndex = 1;            
        }

        private void conexaoOracle_StateChange(object sender, StateChangeEventArgs e)
        {
            testando_conexao = false;
            if (e.CurrentState == ConnectionState.Open){
                MessageBox.Show("Conexão ok");
                //this.panel2.BackgroundImage = global::checkdb.Properties.Resources.button_ok;               
            }else{
                //this.panel2.BackgroundImage = global::checkdb.Properties.Resources.button_no;
                //buttonExecutar.Enabled = false;
            }
                          
        }

        private void montaConnectionString()
        {
            //oracle connection
            if (comboBoxBancoDeDados.SelectedIndex == 1){
                //EZConnect [hostname]:[port]/[service_name]
                String credencial = "User Id=" + textBoxUsuario.Text + "; Password=" + textBoxSenha.Text + ";";
                String datasource = "Data Source=" + textBoxEndereco.Text + ":" + textBoxPorta.Text + "/" + textBoxConexao.Text + ";";
                String option = "Pooling = false;";

                connectionString =  credencial + datasource + option;
	        }
            
        }


        private void buttonTestarConexao_Click(object sender, EventArgs e)
        {
            //monta conexao do oracle ou sqlserver
            montaConnectionString();
            if (!testando_conexao)
            {
                buttonExecutar.Enabled = false;
                conectando = false;
                testando_conexao = true;
                bw.RunWorkerAsync();                
            }               
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            testando_conexao = false;

            if(conectando){
                buttonExecutar.Enabled = true;
            }else
	        {
                buttonExecutar.Enabled = false;
	        }
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            testando_conexao = true;
            AnaliseOracle ao;
            try
            {
                ao = new AnaliseOracle(true);
                conectando = true;
                MessageBox.Show("Conexão efetuada com sucesso!");
            }
            catch (InvalidProgramException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                testando_conexao = false;                
            }            
        }

         public static void ShowError(String erro)
         {
             MessageBox.Show(erro);
         }

         private void txtEmail_Validated(object sender, EventArgs e)
         {
             var mask = sender as MaskedTextBox;

             Regex reg = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
             if (!reg.IsMatch(mask.Text))
             {
                 errorProvider1.SetError(mask, "e-mail inválido.");
             }
             else
             {
                 errorProvider1.Dispose();
             }
             if (mask.Text.Length < 1)
             {
                 mask.Text = "fulano@minhaempresa.com.br";
                 mask.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
             }
         }

         private void txtNome_Validated(object sender, EventArgs e)
         {
             var nome = sender as TextBox;

             if (nome.Text.Length < 1)
             {
                 errorProvider1.SetError(nome, "Informe um nome!");
             }
             else
             {
                 errorProvider1.Dispose();
             }
             if (nome.Text.Length < 1)
             {
                 nome.Text = "Fulano da Silva";
                 nome.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
             }
         }

         private void txtEmpresa_Validated(object sender, EventArgs e)
         {
             var empresa = sender as TextBox;

             if (empresa.Text.Length < 1)
             {
                 errorProvider1.SetError(empresa, "Informe um nome!");
             }
             else
             {
                 errorProvider1.Dispose();
             }
             if (empresa.Text.Length < 1)
             {
                 empresa.Text = "Empresa do Fulano";
                 empresa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
             }
         }

         private void txtEmail_Enter(object sender, EventArgs e)
         {
             var mask = sender as MaskedTextBox;
             if(mask.Text == "fulano@minhaempresa.com.br")
                mask.Text = "";

             mask.ForeColor = System.Drawing.SystemColors.WindowText;
         }

         private void txtNome_Enter(object sender, EventArgs e)
         {
             var textbox = sender as TextBox;
             if (textbox.Text == "Fulano da Silva")
                 textbox.Text = "";

             textbox.ForeColor = System.Drawing.SystemColors.WindowText;
         }

         private void txtEmpresa_Enter(object sender, EventArgs e)
         {
             var textbox = sender as TextBox;
             if (textbox.Text == "Empresa do Fulano")
                 textbox.Text = "";

             textbox.ForeColor = System.Drawing.SystemColors.WindowText;
         }

         private void EnableButton(Button btn, bool enable)
         {
             if(!btn.InvokeRequired)
                 btn.Visible = enable; 
             else
                 btn.Invoke(new EnableButtonHandler(EnableButton), btn, enable);
         }
         delegate void EnableButtonHandler(Button btn, bool enable);

         private void bwAnalise_DoWork(object sender, DoWorkEventArgs e)
         {
             MessageBox.Show("dowork bwAnalise");

             ao = new AnaliseOracle(true);

             retornos = new NameValueCollection();

             int percent = 0;
             int total = ao.getConsultas().Count;

             for (int i = 0; i < total; i++)
             {
                 percent += (i + 1 * 100) / total;

                 ao.consultas[i].retorno = ao.getError(ao.consultas[i].query);

                 //cria os parametros pra enviar os valores para web
                 retornos.Add(ao.consultas[i].campo, ao.consultas[i].retorno.ToString());

                 //incrementa a barra de progresso
                 progressBar1.BeginInvoke(
                     new Action(() =>
                     {
                         progressBar1.Value = percent;
                     }
                 ));
             }
         }

         private void bwAnalise_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
         {
             MessageBox.Show("Complete bwAnalise");
             bwUpload.RunWorkerAsync();
         }

         private void bwUpload_DoWork(object sender, DoWorkEventArgs e)
         {
             if (retornos != null)
             {
                 String formulario_oracle = "1aIOnJGjfbM7exWfGCNrj6rQ7m_YeksidBPyEjGQIjZ4";
                 String url_inicial = "https://docs.google.com/forms/d/" + formulario_oracle + "/formResponse?ifq&";

                 String result = "";
                 //envia os resultados para planilha
                 try
                 {
                     using (WebClient client = new WebClient())
                     {
                         byte[] response =
                         client.UploadValues(url_inicial, retornos);
                         result = System.Text.Encoding.UTF8.GetString(response);
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 if (result.Length < 1)
                     MessageBox.Show("Oopss! não conseguimos enviar!");
                 else
                 {
                     Thread.Sleep(100);
                     MessageBox.Show("Recebemos suas informações!");
                 }
             }
         }

         private void bwUpload_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
         {
             MessageBox.Show("bwUpload Workercomplete");
         }
    }
}
