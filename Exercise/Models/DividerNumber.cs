using System;

namespace Exercise
{
    public class DividerNumber
    {
        public string number { get; set; }

        public bool isMutiple { get; set; }

        public override bool Equals(object obj)
        {
            DividerNumber other = obj as DividerNumber;
            if (obj == null)
                return false;
            return (this.number == other.number &&
                   this.isMutiple == other.isMutiple);
        }

        public override int GetHashCode()
        {
            return 33 * number.GetHashCode() + isMutiple.GetHashCode();
        }
    }
}
