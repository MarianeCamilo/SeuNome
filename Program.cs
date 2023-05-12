using System;
using System.Diagnostics;
using System.Windows.Forms;

public class Program
{

    public static void Main()
    {
        TextBox textBox = new TextBox();
        
        Button button = new Button();
        button.Text = "Olá";
        

        Form janela = new Form();
        janela.Text = "Telinha daora";
        janela.Width = 400;
        janela.Height = 350;
        janela.StartPosition = FormStartPosition.CenterScreen;
        janela.FormBorderStyle = FormBorderStyle.FixedDialog;
        janela.MaximizeBox = false;
        janela.MinimizeBox = false;
        janela.ShowIcon = false;
        janela.ShowInTaskbar = false;
        janela.TopMost = true;
        janela.FormClosed += (sender, e) => { janela.Dispose(); };

        Label lblNome = new Label();
        lblNome.Text = "Digite seu nome";
        lblNome.Location = new System.Drawing.Point(70, 30);

        TextBox txtNome = new TextBox();
        txtNome.Location = new System.Drawing.Point(70, 60);
        txtNome.Width = 250;

        Button olaButton = new Button();
            olaButton.BackColor = System.Drawing.Color.Gray;
            olaButton.Text = "Olá";
            olaButton.Top = 110;
            olaButton.Left = 110;
            olaButton.Width = 150;
            olaButton.Click += (sender, e) =>
        {
            string texto = txtNome.Text;
         MessageBox.Show("Olá, " + texto);
        };

        
        Button sairButton = new Button();
            sairButton.BackColor = System.Drawing.Color.Gray;
            sairButton.Text = "Fechar";
            sairButton.Top = 150;
            sairButton.Left = 110;
            sairButton.Width = 150;
            sairButton.Click += (sender, e) => { janela.Close(); };

        janela.Controls.Add(lblNome);
        janela.Controls.Add(txtNome);
        janela.Controls.Add(olaButton);
        janela.Controls.Add(sairButton);
        janela.ShowDialog();
    }

}