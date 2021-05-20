using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MyBtn

    {
        public Button button { get; set; }
        public int i { get; set; }
        // Свойста 
        public int j { get; set; }

        // Метод 
        public MyBtn(Button button, int i, int j)
        {
            this.i = i;
            this.j = j;
            this.button = button;
        }
    }
}
