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
            //インジェクション対象のアプリを起動
            var p = Process.Start(@"C:\Users\ABC\source\repos\Friendly_DLLInjection\Friendly_DLLInjection\bin\Debug\net6.0-windows\Friendly_DLLInjection.exe");

            //起動したアプリをFriendlyでアタッチ
            var app = new WindowsAppFriend(p);

            //インジェクションしたいDLLをロード
            var asm = Assembly.LoadFrom(@"C:\Users\ABC\source\repos\Friendly_DLLInjection\InjectTarget\bin\Debug\net6.0-windows\InjectTarget.dll");

            //インジェクション対象アプリにDLLを注入
            WindowsAppExpander.LoadAssembly(app, asm);

            //対象アプリ内で、ロードさせたDLLのメソッドを呼び出す
            app.Type("InjectTarget.InjectTarget").ShowMyself();
        }
    }
}