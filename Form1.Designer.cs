using System.Security.Cryptography.X509Certificates;

namespace CAD___Imageopener;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    //======ELEMENTOS=============================================================================//
    public Button botaobuscaimagem;
    public TextBox caixa;
    public string caminhoarquivo = "";
    public FileDialog caminhodaimagem;


    //===========================================================================================//

    #region Inicialização dos componentes.
    private void InitializeComponent()
    {
        caracteristicas();
        
    }

    #endregion


    public void caracteristicas(){
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 70);
        this.FormBorderStyle = FormBorderStyle.FixedSingle;
        this.Text = "CAD - Exibir imagem";
        this.MaximizeBox = false;
        this.MinimizeBox = true;
        carregarelementos();
        
    }






    public void carregarelementos(){
        //botão
        botaobuscaimagem = new Button();
        botaobuscaimagem.Text = "Procurar Imagem";
        botaobuscaimagem.Location = new Point(370,20);
        botaobuscaimagem.Size = new Size (110,30);
        botaobuscaimagem.Click += Clickbotaobuscaimagem;
        this.Controls.Add(botaobuscaimagem); // adiciona na janela
        




        //caixadetexto
        caixa = new TextBox();
        caixa.Text = string.Empty;
        caixa.Location = new Point(15,20);
        caixa.Size = new Size(350,90);
        this.Controls.Add(caixa); // adiciona na janela
    }


}
