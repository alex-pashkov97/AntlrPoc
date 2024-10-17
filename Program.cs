public class Program
{
    public static void Main(string[] args)
    {
        // Create a sample Task object
        double val = 0.3;
        var task = new Task(1, "Example task for processing", val);

        // User-defined script as a string
        var script = @"
        if (1) {
            PushToOrder(task);
        } else {
            CallExternal(task);
        }";

        var script2 = @"
        if (task.ValueToCompare < 0.2) {
            PushToOrder(task);
        } else {
            CallExternal(task);
        }";

        var interpreter = new PocInterpreter(task);
        interpreter.Interpret(script2);
    }
}
