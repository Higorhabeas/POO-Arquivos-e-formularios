namespace Arquivos_e_formularios
{
    using System.IO;
    partial class Form1
    {

        private string strPathFile = @"C:\temp\ArquivoExemplo.txt";

        private void Criar()
        {
            try
            {
                //Usarei a cláusula using como boas práticas de programação em todos os métodos
                //Instancio a classe FileStream, uso a classe File e o método Create para criar o
                //arquivo passando como parâmetro a variável strPathFile, que contém o arquivo
                using (FileStream fs = File.Create(strPathFile))
                {
                    //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
                    //que recebe como parâmetro a variável fs, referente ao FileStream criado anteriormente
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        //Uso o método Write para escrever algo em nosso arquivo texto
                        sw.Write("Texto adicionado ao exemplo!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //Se tudo ocorrer bem, exibo a mensagem ao usuário.
            MessageBox.Show("Arquivo criado com sucesso!!!");

        }

        private void Abrir()
        {
            try
            {
                //Verifico se o arquivo que desejo abrir existe e passo como parâmetro a respectiva variável
                if (File.Exists(strPathFile))
                {
                    //se existe "starto" um processo do sistema para abrir a arquvo e, sem precisar
                    //passar ao processo o aplicativo a ser aberto, ele abre automaticamente o Notepad
                    System.Diagnostics.Process.Start("notepad.exe", strPathFile);
                }
                else
                {
                    //Se não existir exibo a mensagem
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Concatenar()
        {
            try
            {
                //Verificose o arquivo que desejo abrir existe e passo como parâmetro
                //a respectiva veriável
                if (File.Exists(strPathFile))
                {
                    //Crio um using, dentro dele instacio StreamWriter,uso a classe
                    //File e o método AppendText para concatenar o texto, passando
                    //como parâmetro a variável strPathFile
                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        //Uso  o método Write para escrever o arquivo
                        sw.Write("\r\n Texto adicionado ao final do arquivo texto");
                    }
                    //Exibo a mensagem que o arquivo foi atualizado
                    MessageBox.Show("Arquivo atualizado!");
                }
                else
                {
                    //se não existir
                    MessageBox.Show("Arquivo não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnCriar = new Button();
            btnAbrir = new Button();
            BtnConcatenar = new Button();
            BtnAlterar = new Button();
            BtnExcluir = new Button();
            SuspendLayout();
            // 
            // BtnCriar
            // 
            BtnCriar.Location = new Point(210, 57);
            BtnCriar.Name = "BtnCriar";
            BtnCriar.Size = new Size(130, 23);
            BtnCriar.TabIndex = 0;
            BtnCriar.Text = "Criar Arquivo";
            BtnCriar.UseVisualStyleBackColor = true;
            BtnCriar.Click += BtnCriar_Click;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(210, 98);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(130, 23);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir Arquivo";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += BtnAbrir_Click;
            // 
            // BtnConcatenar
            // 
            BtnConcatenar.Location = new Point(210, 139);
            BtnConcatenar.Name = "BtnConcatenar";
            BtnConcatenar.Size = new Size(130, 23);
            BtnConcatenar.TabIndex = 2;
            BtnConcatenar.Text = "Concatenar Arquivo";
            BtnConcatenar.UseVisualStyleBackColor = true;
            BtnConcatenar.Click += BtnConcatenar_Click;
            // 
            // BtnAlterar
            // 
            BtnAlterar.Location = new Point(210, 180);
            BtnAlterar.Name = "BtnAlterar";
            BtnAlterar.Size = new Size(130, 23);
            BtnAlterar.TabIndex = 3;
            BtnAlterar.Text = "Alterar Arquivo";
            BtnAlterar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(210, 221);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(130, 23);
            BtnExcluir.TabIndex = 4;
            BtnExcluir.Text = "Excluir Arquivo";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 315);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnConcatenar);
            Controls.Add(btnAbrir);
            Controls.Add(BtnCriar);
            Name = "Form1";
            Text = "Manipulando Arquivo Texto em C#";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCriar;
        private Button btnAbrir;
        private Button BtnConcatenar;
        private Button BtnAlterar;
        private Button BtnExcluir;
    }
}