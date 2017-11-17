using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public delegate void TryEventHandler(object sender, TryEventArgs e);
    public class TryEvent
    {
        public event TryEventHandler tryEvent;

        public void TryOne()
        {
            tryEvent(new Employee() {ID = 1,Name = "Tufan" }, new TryEventArgs() { Time = 8 });
        }

        public void TryTwo()
        {
            tryEvent(new Employee() { ID = 2, Name = "Batuhan" }, new TryEventArgs() { Time = 18 });
        }
    }
}
