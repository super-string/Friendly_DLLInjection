using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using System.Diagnostics;
using System.Reflection;

namespace InjectorApp
{
    public partial class InjectorForm : Form
    {
        public InjectorForm()
        {
            InitializeComponent();
        }

        private void _buttonInject_Click(object sender, EventArgs e)
        {
            //�C���W�F�N�V�����Ώۂ̃A�v�����N��
            var p = Process.Start(@"C:\Users\ABC\source\repos\Friendly_DLLInjection\Friendly_DLLInjection\bin\Debug\net6.0-windows\Friendly_DLLInjection.exe");

            //�N�������A�v����Friendly�ŃA�^�b�`
            var app = new WindowsAppFriend(p);

            //�C���W�F�N�V����������DLL�����[�h
            var asm = Assembly.LoadFrom(@"C:\Users\ABC\source\repos\Friendly_DLLInjection\InjectTarget\bin\Debug\net6.0-windows\InjectTarget.dll");

            //�C���W�F�N�V�����ΏۃA�v����DLL�𒍓�
            WindowsAppExpander.LoadAssembly(app, asm);

            //�ΏۃA�v�����ŁA���[�h������DLL�̃��\�b�h���Ăяo��
            app.Type("InjectTarget.InjectTarget").ShowMyself();
        }
    }
}