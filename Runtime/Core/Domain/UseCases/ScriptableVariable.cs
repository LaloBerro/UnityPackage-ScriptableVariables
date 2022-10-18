using UnityEngine;

namespace ScriptableVariables.Core
{
    public class ScriptableVariable<VariableType> : ScriptableObject, IVariable<VariableType>
    {
        [Header("Debug")]
        [SerializeField] private VariableType _value;

        public VariableType Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}