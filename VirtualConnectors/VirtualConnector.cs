using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace VirtualConnectors
{
    public abstract class VirtualConnector
    {
        public abstract System.Windows.Forms.Panel getSettingsPanel();

        public abstract String getTitle();

        public abstract int execCommand();

    }
}
