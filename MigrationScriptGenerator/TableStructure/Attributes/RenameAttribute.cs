using System;

namespace MigrationScriptGenerator.TableStructure.Attributes
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Property)]
    public class RenameAttribute : Attribute
    {
        public string NewName;

        public RenameAttribute(string newName)
        {
            this.NewName = newName;
        }
    }
}