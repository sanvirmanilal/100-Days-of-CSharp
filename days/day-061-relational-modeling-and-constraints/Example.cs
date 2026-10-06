namespace Days.Day061;

// Learning example: Relational modeling and constraints. Predict the output before running.
public static class Example
{
    public static void Run()
    {
        var row = new System.Data.DataTable("Products"); row.Columns.Add("Id", typeof(int)); row.Columns.Add("Sku", typeof(string)); Console.WriteLine(row.Columns.Count);
    }


}
