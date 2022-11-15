using UnityEngine;

namespace ScriptableVariables.Core
{
    public abstract class ScriptableVariable<VariableType> : ScriptableObject, IVariable<VariableType>
    {
        [Header("Debug")]
        [SerializeField] private VariableType _value;

        public VariableType Value
        {
            get { return GetValue(); }
            set { _value = value; }
        }

        protected virtual VariableType GetValue()
        {
            return _value;
        }
    }
}