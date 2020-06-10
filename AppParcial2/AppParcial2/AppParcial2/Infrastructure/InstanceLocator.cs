using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.Infrastructure
{
    using AppParcial2.ViewModels;
    public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
