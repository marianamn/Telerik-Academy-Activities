namespace _04.VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Struct |
                    AttributeTargets.Class |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum | 
                    AttributeTargets.Method, 
                    AllowMultiple = false)]
    public class Version : Attribute
    {
        private string vers;

        public Version(string version)
        {
            this.Vers = version;
        }

        public string Vers
        {
            get { return this.vers; }
            private set { this.vers = value; }
        }
    }
}
