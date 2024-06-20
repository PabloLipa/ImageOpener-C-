namespace CAD___Imageopener;

partial class Form2
{
    private System.ComponentModel.IContainer components2 = null;
    public PictureBox localimagem;
    public Button backchoose;
    
    private void InitializeComponent()
    {

        this.components2 = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(5,5);
        this.FormBorderStyle = FormBorderStyle.None;
        this.AutoSize = true;
        this.TopMost = true;// sempre a frente
        exibir();

    }


    public void exibir(){
        // exibir as imagens
        localimagem = new PictureBox();
        localimagem.Location = new Point(1, 1); // Defina a posição desejada
        localimagem.SizeMode = PictureBoxSizeMode.AutoSize; // Ajuste o modo de exibição conforme necessário
        localimagem.BorderStyle = BorderStyle.None; // Adicione uma borda para visualização
        localimagem.MouseDown += Form2MouseDown;
        localimagem.MouseMove += Form2MouseMove;

        this.Controls.Add(localimagem); // Adicione o PictureBox ao formulário


    }


    


}
