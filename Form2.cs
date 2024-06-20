namespace CAD___Imageopener;
public partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
        this.FormBorderStyle = FormBorderStyle.None;
        
    }
    public Point mouseDownLocation;

    public void Form2MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            mouseDownLocation = e.Location;
        }
    }

    public void Form2MouseMove(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            int deltaX = e.X - mouseDownLocation.X;
            int deltaY = e.Y - mouseDownLocation.Y;
            Location = new Point(Location.X + deltaX, Location.Y + deltaY);
        }
    }

}