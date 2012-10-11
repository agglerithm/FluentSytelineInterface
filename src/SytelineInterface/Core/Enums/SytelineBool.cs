namespace SytelineInterface.Core.Enums
{
    using Common;

    public class SytelineBool : EnumerationOfString<SytelineBool>
    {
        private SytelineBool(string value, string displayName) : base(value, displayName) { }
        public SytelineBool(){}

        public static readonly SytelineBool True = new SytelineBool("1","True");
        public static readonly SytelineBool False = new SytelineBool("0","False");
    }
}