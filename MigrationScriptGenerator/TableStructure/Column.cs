using MigrationScriptGenerator.TableStructure.Actions;

namespace MigrationScriptGenerator.TableStructure
{
    public class Column
    {
        public string Name { get; private set; }
        public string Type { get; private set; }
        public ColumnAction ColumnAction { get; set; }

        public Column(string name, string type, ColumnAction columnAction = ColumnAction.None)
        {
            Name = name;
            Type = type;
            ColumnAction = columnAction;
        }
    }
}