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

    static IMatcher<VisualDebuggingEntity> _matcherListArray;

    public static IMatcher<VisualDebuggingEntity> ListArray {
        get {
            if(_matcherListArray == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.ListArray);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherListArray = matcher;
            }

            return _matcherListArray;
        }
    }
}
