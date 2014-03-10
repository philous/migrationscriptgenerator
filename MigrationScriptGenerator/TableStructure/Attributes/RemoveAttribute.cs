using System;

namespace MigrationScriptGenerator.TableStructure.Attributes
{
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Property)]
    public class RemoveAttribute : Attribute
    {
    }
}