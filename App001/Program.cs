using App001.Logic;
using System;
using System.Windows.Forms;

namespace App001
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Run run = new Run();
            run.INITIAL_RUN_METHOD();
        }
    }
}
