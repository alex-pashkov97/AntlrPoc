using System;
using Antlr;
using Antlr4.Runtime;
using System.Linq;
using System.Threading;
using System.Reflection.Metadata.Ecma335;

public class PocInterpreter
{
    private readonly Task _task;
    private readonly TaskProcessor _taskProcessor;

    public PocInterpreter(Task task)
    {
        _task = task;
        _taskProcessor = new TaskProcessor();
    }

    public void Interpret(string code)
    {
        var inputStream = new AntlrInputStream(code);
        var lexer = new PocLexer(inputStream);
        var tokenStream = new CommonTokenStream(lexer);
        var parser = new PocParser(tokenStream);
        var tree = parser.prog();

        var visitor = new PocVisitor(_task, _taskProcessor);
        visitor.Visit(tree);
    }
}

public class PocVisitor : PocBaseVisitor<object>
{
    private readonly Task _task;
    private readonly TaskProcessor _taskProcessor;

    public PocVisitor(Task task, TaskProcessor taskProcessor)
    {
        _task = task;
        _taskProcessor = taskProcessor;
    }

    public override object VisitIfStatement(PocParser.IfStatementContext context)
    {
        bool conditionResult = EvaluateExpression(context.expression());

        bool hasElse = context
            .GetText()
            .Contains("else");

        if (conditionResult)
        {
            Console.WriteLine("Condition is true. Executing 'if' block.");
            //hack, visit only one statement, possible to extend to visit all statements
            Visit(context.statement(0));
        }
        else if (hasElse)  // Only visit 'else' if it exists
        {
            Console.WriteLine("Condition is false. Executing 'else' block.");
            //Same
            Visit(context.statement(1));
        }

        return null;
    }

    public override object VisitMethodCall(PocParser.MethodCallContext context)
    {
        string methodName = context.GetChild(0).GetText();

        if (methodName == "PushToOrder")
        {
            _taskProcessor.PushToOrder(_task);
        }
        else if (methodName == "CallExternal")
        {

            _taskProcessor.CallExternal(_task);
        }

        return null;
    }

    public bool EvaluateExpression(PocParser.ExpressionContext context)
    {
        if (context.ChildCount == 1) // Base case: single identifier or constant
        {
            if (context.GetText() == "1") return true;
            if (context.GetText() == "0") return false;
            if (context.GetText() == "true") return true;
            if (context.GetText() == "false") return false;
        }

        // Handle comparisons (e.g., Score > 0.2)
        //dirty hack
        if (context.ChildCount == 5)
        {
            //obj.prop>number
            //{0}{1}{2}{3}{4}{5}
            var leftValue = double.Parse(_task.GetType().GetProperty(context.children[2].GetText()).GetValue(_task).ToString());
            var operatorToken = context.children[3].GetText();
            var rightValue = double.Parse(context.children.Last().GetText());
            // var operatorToken = context.GetChild(1).GetText(); // The operator (e.g., >, <)

            // double leftValue = EvaluateExpression(leftExpr); // Recursively evaluate left
            // double rightValue = EvaluateExpression(rightExpr); // Recursively evaluate right

            // // Perform the comparison based on the operator
            return operatorToken switch
            {
                "<" => leftValue < rightValue,
                ">" => leftValue > rightValue,
                "<=" => leftValue <= rightValue,
                ">=" => leftValue >= rightValue,
                "==" => leftValue == rightValue,
                "!=" => leftValue != rightValue,
                _ => throw new InvalidOperationException($"Unknown operator: {operatorToken}")
            };
        }

        //throw new InvalidOperationException("Invalid expression context.");
        return false;
    }


    // private bool EvaluateExpression(PocParser.ExpressionContext context)
    // {
    //     if (context.GetText() == "1") return true;
    //     if (context.GetText() == "0") return false;
    //     if (context.GetText() == "true") return true;
    //     if (context.GetText() == "false") return false;

    //     if (context.INT() != null)
    //     {
    //         int value = int.Parse(context.INT().GetText());
    //         return value != 0;
    //     }

    //     var propertyName = context.GetText();

    //     // Assume `currentTask` is your Task object you want to evaluate against
    //     if (_task == null)
    //     {
    //         throw new InvalidOperationException("Current task is not set.");
    //     }

    //     // Using reflection to get the value of the property
    //     var propertyInfo = typeof(Task).GetProperty(propertyName);
    //     //??

    //     return false;
    // }
}
