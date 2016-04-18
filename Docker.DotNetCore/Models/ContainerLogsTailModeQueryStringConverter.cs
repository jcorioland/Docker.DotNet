using System;
using System.Linq;
using System.Reflection;

namespace Docker.DotNet.Models
{
    internal class ContainerLogsTailModeQueryStringConverter : IQueryStringConverter
    {
        public ContainerLogsTailModeQueryStringConverter()
        {
        }

        public bool CanConvert(Type t)
        {
#if NET451
            return t.GetInterfaces().Contains(typeof (IContainerLogsTailMode));
#else
            return t.GetTypeInfo().ImplementedInterfaces.Contains(typeof(IContainerLogsTailMode));
#endif
        }

        public string Convert(object o)
        {
            IContainerLogsTailMode t = o as IContainerLogsTailMode;
            if (t == null)
            {
                throw new InvalidOperationException("Casting returned null");
            }
            return t.Value;
        }

        public bool ChangesKey()
        {
            return false;
        }

        public string GetKey(object o)
        {
            throw new NotImplementedException();
        }
    }
}