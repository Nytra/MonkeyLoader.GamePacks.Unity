// Adapted from the NeosModLoader project.

using System;

namespace MonkeyLoader.Configuration
{
    /// <summary>
    /// Marks a field of type <see cref="ConfigKey{T}"/> on a class
    /// deriving from <see cref="ResoniteMod"/> to be automatically included in that mod's configuration.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public sealed class IgnoreConfigKeyAttribute : MonkeyLoaderAttribute
    { }
}