using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbpaste {
class Program {
  [STAThread]
  static void
  Main(string[] args) {
    var pasteboard = Clipboard.GetText();
    if (args.Length > 0 && "--lf".Equals(args[0])) {
      pasteboard = pasteboard.Replace("\r\n", "\n");
    }
    Console.Write(pasteboard);
  }
}
}
