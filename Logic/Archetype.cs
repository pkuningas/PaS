using System;

namespace Logic
{
    public class Archetype
    {
        public event EventHandler OnChanged;

        public void SetValue<T>(ref T field, T value)
        {
            if (field == null) return;
            if (field.Equals(value)) return;
            field = value;
            DoOnChanged();
        }

        public void DoOnChanged()
        {
            OnChanged?.Invoke(this, null);
        }

    }
}
