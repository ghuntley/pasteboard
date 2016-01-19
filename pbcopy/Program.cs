using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbcopy
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            StringBuilder pasteboard = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                pasteboard.AppendLine(line);
            }

            Clipboard.SetText(pasteboard.ToString());
        }
    }
}
