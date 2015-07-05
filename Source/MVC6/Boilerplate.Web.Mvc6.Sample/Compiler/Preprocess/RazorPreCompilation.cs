﻿namespace MvcBoilerplate.Compiler.Preprocess
{
    using System;
    using Microsoft.AspNet.Mvc;

    /// <summary>
    /// Enable pre-compilation of Razor views, so that errors in your .cshtml files are caught and displayed 
    /// in the Visual Studio errors window at compile time, rather than your sites users receiving a runtime 500 
    /// internal server error. Pre-compilation may reduce the time it takes to build and launch your project but will 
    /// cause the build time to increase.
    /// </summary>
    public class RazorPreCompilation : RazorPreCompileModule
    {
        public RazorPreCompilation(IServiceProvider provider) : base(provider)
        {
            this.GenerateSymbols = true;
        }
    }
}