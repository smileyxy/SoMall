﻿using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace TT.SoMall.Branding
{
    [Dependency(ReplaceServices = true)]
    public class SoMallBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "SoMall";
    }
}
