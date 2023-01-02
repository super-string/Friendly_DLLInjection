using System.Reflection;

namespace InjectTarget
{
    public class InjectTarget
    {
        public static void ShowMyself()
        {
            MessageBox.Show($"{Path.GetFileName(Application.ExecutablePath)}");
        }
    }
}