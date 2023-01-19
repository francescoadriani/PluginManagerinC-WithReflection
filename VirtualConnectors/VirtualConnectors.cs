using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Xml;
using System.Windows.Forms;

namespace VirtualConnectors
{
    public class VirtualConnectors
    {
        public static List<Type> getTypeConnectors()
        {
            List<Type> _getTypeConnectors = new List<Type>();
            foreach (string a in Directory.GetFiles(System.IO.Path.GetDirectoryName(Application.ExecutablePath)))
            {
                FileInfo dInfo = new FileInfo(a);
                if (dInfo.Extension == ".dll")
                {
                    try
                    {
                        String sTemp = Path.GetTempFileName();
                        File.Delete(sTemp);
                        File.Copy(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\" + dInfo.Name, sTemp);
                        Assembly assembly = Assembly.LoadFrom(sTemp);
                        foreach (var type in assembly.GetTypes())
                        {
                            if (type.IsClass)
                            {
                                if (type.BaseType == typeof(VirtualConnector))
                                {
                                    _getTypeConnectors.Add(type);
                                }
                            }
                        }
                    }
                    catch { }
                }
            }
            return _getTypeConnectors;
            //Assembly assembly = Assembly.LoadFrom("MyNice.dll");

            //Type type = assembly.GetType("MyType");

            //object instanceOfMyType = Activator.CreateInstance(type);
        }
    }
}
