using System;

namespace Basic.Templates
{
#if (Internal)
    internal class Basic
#endif
#if (InternalAbstract)
    internal abstract class Basic
#endif
#if (InternalSealed)
    internal sealed class Basic
#endif
#if (Public)
    public class Basic
#endif
#if (PublicAbstract)
    public abstract class Basic
#endif
#if (PublicSealed)
    public sealed class Basic
#endif
#if (Protected)
    protected class Basic
#endif
#if (ProtectedAbstract)
    protected abstract class Basic
#endif
#if (ProtectedInternal)
    protected internal class Basic
#endif
#if (ProtectedInternalAbstract)
    protected internal abstract class Basic
#endif
#if (PrivateProtected)
    private protected class Basic
#endif
#if (PrivateProtectedAbstract)
    private protected abstract class Basic
#endif
    {
    }
}
