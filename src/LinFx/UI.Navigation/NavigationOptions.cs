﻿using System.Collections.Generic;

namespace LinFx.UI.Navigation
{
    public class NavigationOptions
    {
        [NotNull]
        public List<IMenuContributor> MenuContributors { get; }

        public NavigationOptions()
        {
            MenuContributors = new List<IMenuContributor>();
        }
    }
}