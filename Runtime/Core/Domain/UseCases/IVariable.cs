namespace ScriptableVariables.Core
{
    public interface IVariable<VariableType>
    {
        VariableType Value { get; set; }
    }
}