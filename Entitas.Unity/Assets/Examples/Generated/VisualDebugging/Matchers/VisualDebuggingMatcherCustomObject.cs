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

    static IMatcher<VisualDebuggingEntity> _matcherCustomObject;

    public static IMatcher<VisualDebuggingEntity> CustomObject {
        get {
            if(_matcherCustomObject == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.CustomObject);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherCustomObject = matcher;
            }

            return _matcherCustomObject;
        }
    }
}
