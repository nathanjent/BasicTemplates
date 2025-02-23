using System;

namespace Basic.Templates
{
#if (Internal)
    internal class Basic
#elif (InternalAbstract)
    internal abstract class Basic
#elif (InternalSealed)
    internal sealed class Basic
#elif (InternalStatic)
    internal static class Basic
#elif (Public)
    public class Basic
#elif (PublicAbstract)
    public abstract class Basic
#elif (PublicSealed)
    public sealed class Basic
#elif (PublicStatic)
    public static class Basic
#endif
    {
    }
}
