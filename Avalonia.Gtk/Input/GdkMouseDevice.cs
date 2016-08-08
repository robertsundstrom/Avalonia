using Avalonia.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalonia.Gtk.Input
{
    public class GdkMouseDevice : MouseDevice
    {
        public override IInputElement Target
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override Point GetClientPosition()
        {
            throw new NotImplementedException();
        }

        protected override Point GetScreenPosition()
        {
            throw new NotImplementedException();
        }
    }
}
