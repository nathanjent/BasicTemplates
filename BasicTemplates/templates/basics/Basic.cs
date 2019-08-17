using System;

namespace Basic.Templates
{
#if (PublicAbstractClass)
    public abstract class Basic
#endif
#if (ProtectedAbstractClass)
    protected abstract class Basic
#endif
#if (InternalAbstractClass)
    internal abstract class Basic
#endif
#if (ProtectedInternalAbstractClass)
    protected internal abstract class Basic
#endif
#if (PrivateProtectedAbstractClass)
    private protected abstract class Basic
#endif

#if (PublicClass)
    public class Basic
#endif
#if (ProtectedClass)
    protected class Basic
#endif
#if (InternalClass)
    internal class Basic
#endif
#if (ProtectedInternalClass)
    protected internal class Basic
#endif
#if (PrivateProtectedClass)
    private protected class Basic
#endif

#if (PublicStruct)
    public struct Basic
#endif
#if (ProtectedStruct)
    protected struct Basic
#endif
#if (InternalStruct)
    internal struct Basic
#endif
#if (ProtectedInternalStruct)
    protected internal struct Basic
#endif
#if (PrivateProtectedStruct)
    private protected struct Basic
#endif

#if (PublicEnum)
    public enum Basic
#endif
#if (ProtectedEnum)
    protected enum Basic
#endif
#if (InternalEnum)
    internal enum Basic
#endif
#if (ProtectedInternalEnum)
    protected internal enum Basic
#endif
#if (PrivateProtectedEnum)
    private protected enum Basic
#endif

#if (PublicInterface)
    public interface Basic
#endif
#if (ProtectedInterface)
    protected interface Basic
#endif
#if (InternalInterface)
    internal interface Basic
#endif
#if (ProtectedInternalInterface)
    protected internal interface Basic
#endif
#if (PrivateProtectedInterface)
    private protected interface Basic
#endif
    {
    }
}
