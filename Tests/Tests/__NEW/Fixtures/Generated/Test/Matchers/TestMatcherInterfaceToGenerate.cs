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

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherInterfaceToGenerate;

    public static IMatcher<TestEntity> InterfaceToGenerate {
        get {
            if(_matcherInterfaceToGenerate == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.InterfaceToGenerate);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherInterfaceToGenerate = matcher;
            }

            return _matcherInterfaceToGenerate;
        }
    }
}
