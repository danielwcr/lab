﻿using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Lab.Infra.CrossCutting.IoC
{
    public class IoCDependencyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            return IoC.Get(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return IoC.GetAll(serviceType);
        }
    }
}
