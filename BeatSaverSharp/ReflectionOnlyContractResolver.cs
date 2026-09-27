using System.Reflection;
using Newtonsoft.Json.Serialization;

namespace BeatSaverSharp
{
    // Unity's bundled Mono scripting runtime has a correctness bug in Newtonsoft.Json's
    // DynamicValueProvider (its Reflection.Emit-based fast property accessor generator) when
    // accessing members of non-public types across assemblies -- confirmed via an actual crash
    // log from a real gameplay session: deserializing SerializableSearch (an internal type)
    // threw InvalidCastException inside a dynamically-generated `GetDocs(object)` wrapper
    // method, even though the property itself ("get; internal set;") is completely ordinary.
    // ReflectionValueProvider (plain, non-code-generated reflection) doesn't hit this bug.
    internal sealed class ReflectionOnlyContractResolver : DefaultContractResolver
    {
        public static readonly ReflectionOnlyContractResolver Instance = new ReflectionOnlyContractResolver();

        protected override IValueProvider CreateMemberValueProvider(MemberInfo member)
        {
            return new ReflectionValueProvider(member);
        }
    }
}
