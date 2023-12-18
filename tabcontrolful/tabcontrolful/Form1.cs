using System.Windows.Forms;

namespace tabcontrolful
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //YONTEM 1
            //tabControl1.SelectTab(tabPage2);
            //tabControl1.SelectedTab = tabPage2;
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"]; //name özelliği ile 2. tabpage'e geçiş yaparız.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //YONTEM 2
            //tabControl1.SelectedIndex = 0;
            tabControl1.SelectedTab = tabControl1.TabPages[0]; //0. index 1. tabpage veya 1. index 2. tabpage
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Tabcontrol'un görünümünü değiştiriyoruz. Ust kısmı gizleriz.
            tabControl1.Appearance = TabAppearance.FlatButtons;     //Tabcontrol'un görünümünü değiştiriyoruz.
            tabControl1.ItemSize = new Size(0, 1);                  //Tabcontrol'un boyutunu ayarlıyoruz.
            tabControl1.SizeMode = TabSizeMode.Fixed;               //Tabcontrol'un boyutunu sabitliyoruz.
            tabControl1.Dock = DockStyle.Fill;                      //Tabcontrol'u formun tamamına yayıyoruz.
        }
    }
}