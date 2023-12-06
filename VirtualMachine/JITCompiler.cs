namespace SVM.VirtualMachine;

using SVM.SimpleMachineLanguage;

#region Using directives
using System.Reflection;
#endregion

/// <summary>
/// Utility class which generates compiles a textual representation
/// of an SML instruction into an executable instruction instance
/// </summary>
internal static class JITCompiler
{
    #region Constants
    #endregion

    #region Fields
    #endregion

    #region Constructors
    #endregion

    #region Properties
    #endregion

    #region Public methods
    #endregion

    #region Non-public methods
    internal static IInstruction CompileInstruction(string opcode, bool isBreakpoint)
    {
        IInstruction instruction = null;

        switch (opcode.ToLower())
        {
            
            case "writestring":
                instruction = new WriteString();
                break;
            case "add":
                instruction = new Add();
                break;
            case "decr":
                instruction = new Decr();
                break;
            case "incr":
                instruction = new Incr();
                break;
            case "subtract":
                instruction = new Subtract();
                break;
            // Handle other instructions similarly
            default:
                throw new SvmCompilationException($"Unknown opcode: {opcode}");
        }
        instruction.IsBreakpoint = isBreakpoint;
        return instruction;
    }

    internal static IInstruction CompileInstruction(string opcode, bool isBreakpoint, params string[] operands)
    {
        IInstructionWithOperand instruction = null;

        switch (opcode.ToLower())
        {
            case "loadstring":
                if (operands.Length != 1)
                {
                    throw new SvmCompilationException("LoadString instruction requires one string operand");
                }
                instruction = new LoadString();
                instruction.Operands = operands;
                break;
            case "loadint":
                if (operands.Length != 1)
                {
                    throw new SvmCompilationException("LoadInt instruction requires one integer operand");
                }
                instruction = new LoadInt();
                instruction.Operands = operands;
                break;
            default:
                throw new SvmCompilationException($"Unknown opcode: {opcode}");
        }

        // Set the breakpoint flag 
        instruction.IsBreakpoint = isBreakpoint;
        return instruction;
    }
    #endregion
}
