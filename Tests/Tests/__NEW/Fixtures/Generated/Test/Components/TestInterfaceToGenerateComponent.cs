//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public InterfaceToGenerateComponent interfaceToGenerate { get { return (InterfaceToGenerateComponent)GetComponent(TestComponentsLookup.InterfaceToGenerate); } }
    public bool hasInterfaceToGenerate { get { return HasComponent(TestComponentsLookup.InterfaceToGenerate); } }

    public void AddInterfaceToGenerate(My.Namespace.InterfaceToGenerate newValue) {
        var component = CreateComponent<InterfaceToGenerateComponent>(TestComponentsLookup.InterfaceToGenerate);
        component.value = newValue;
        AddComponent(TestComponentsLookup.InterfaceToGenerate, component);
    }

    public void ReplaceInterfaceToGenerate(My.Namespace.InterfaceToGenerate newValue) {
        var component = CreateComponent<InterfaceToGenerateComponent>(TestComponentsLookup.InterfaceToGenerate);
        component.value = newValue;
        ReplaceComponent(TestComponentsLookup.InterfaceToGenerate, component);
    }

    public void RemoveInterfaceToGenerate() {
        RemoveComponent(TestComponentsLookup.InterfaceToGenerate);
    }
}
