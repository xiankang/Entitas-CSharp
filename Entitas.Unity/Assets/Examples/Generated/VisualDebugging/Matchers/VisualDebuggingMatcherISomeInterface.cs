//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;
using Entitas.Api;

public sealed partial class VisualDebuggingMatcher {

    static IMatcher<VisualDebuggingEntity> _matcherISomeInterface;

    public static IMatcher<VisualDebuggingEntity> ISomeInterface {
        get {
            if(_matcherISomeInterface == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.ISomeInterface);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherISomeInterface = matcher;
            }

            return _matcherISomeInterface;
        }
    }
}
