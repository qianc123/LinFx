﻿using System.Threading.Tasks;

namespace LinFx.Security.Authorization.Permissions
{
    public abstract class PermissionValueProvider : IPermissionValueProvider
    {
        public abstract string Name { get; }

        protected IPermissionStore PermissionStore { get; }

        protected PermissionValueProvider(IPermissionStore permissionStore)
        {
            PermissionStore = permissionStore;
        }

        public abstract Task<PermissionValueProviderGrantInfo> CheckAsync(PermissionValueCheckContext context);
    }
}