using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinTV.Droid.Effects;
using XamarinTV.Effects;

namespace XamarinTV.Android
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseSharedMauiApp()
                .ConfigureEffects(effects =>
                {
                    effects.Add<Effects.TouchEffect, Droid.Effects.TouchEffect>();
                });

            return builder.Build();

        }
    }
}
