﻿using System;

namespace LinFx.UI.Navigation
{
    public class MenuConfigurationContext
    {
        public ApplicationMenu Menu { get; }

        public IServiceProvider ServiceProvider { get; }

        public MenuConfigurationContext(ApplicationMenu menu, IServiceProvider serviceProvider)
        {
            Menu = menu;
            ServiceProvider = serviceProvider;
        }
    }
}