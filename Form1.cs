namespace CAD___Imageopener;

public partial class Form1 : Form
{
    Form2 mostraimagem = new Form2();
    public Form1()
    {
        InitializeComponent();
        
    }


    private void Clickbotaobuscaimagem(object sender, EventArgs e)
    {
       
        Button clicado = (Button)sender;
        OpenFileDialog arquivario = new OpenFileDialog();
        arquivario.Filter = "Imagem Jpeg|*.jpeg|Imagem PNG|*.png|tiff|*.tiff" +
             "|Bitmap|*.bmp;" + "|Icon|*.ico;"+
             "|All Files|*.*";

        if (arquivario.ShowDialog() == System.Windows.Forms.DialogResult.OK){
           caixa.Text = arquivario.FileName;

            // Passa o caminho da imagem para o Form2
            mostraimagem.localimagem.ImageLocation = arquivario.FileName;
            mostraimagem.localimagem.SizeMode = PictureBoxSizeMode.AutoSize;

            // Exibe o Form2 com a imagem
            mostraimagem.Show();

        }
        
        
    }


}
