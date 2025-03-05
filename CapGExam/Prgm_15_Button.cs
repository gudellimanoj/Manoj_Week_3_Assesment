using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    class Prgm_15_Button
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;
        public void Click()
        {
            Console.WriteLine("Button clicked");
            OnClick?.Invoke();

        }
    }
}
