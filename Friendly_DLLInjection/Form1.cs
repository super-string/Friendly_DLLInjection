using System.Reflection;

namespace Friendly_DLLInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
        }

        private void CurrentDomain_AssemblyLoad(object? sender, AssemblyLoadEventArgs args)
        {
            textBox1.Text += args.LoadedAssembly.FullName + Environment.NewLine;
        }
    }
}