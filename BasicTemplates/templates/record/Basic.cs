using System;

namespace Basic.Templates
{
#if (Internal)
    internal record Basic
#elif (InternalAbstract)
    internal abstract record Basic
#elif (InternalSealed)
    internal sealed record Basic
#elif (InternalStatic)
    internal static record Basic
#elif (Public)
    public record Basic
#elif (PublicAbstract)
    public abstract record Basic
#elif (PublicSealed)
    public sealed record Basic
#elif (PublicStatic)
    public static record Basic
#endif
    {
    }
}
