using System.Collections.Generic;
using MigrationScriptGenerator.TableStructure.Actions;

namespace MigrationScriptGenerator.TableStructure
{
    public class Table
    {
        public string Name { get; private set; }
        public List<Column> Columns { get; private set; }
        public TableAction Action { get; set; }

        public void AddColumn(Column column)
        {
            Columns.Add(column);
        }

        public Table(string name, TableAction action = TableAction.None)
        {
            Name = name;
            Columns = new List<Column>();
            Action = action;
        }

        public void AddColumn(IEnumerable<Column> columns)
        {
            Columns.AddRange(columns);
        }
    }
}