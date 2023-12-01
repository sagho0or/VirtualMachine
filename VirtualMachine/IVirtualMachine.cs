namespace SVM.VirtualMachine;

/// <summary>
/// Defines the interface contract for all Simple 
/// Virtual Machine 
/// </summary>
public interface IVirtualMachine
{
    Stack Stack { get; } 
    //void PushStack(object item); 
    //object PopStack();
    //int StackSize { get; }
    void Run();

    // Program counter management
    int ProgramCounter { get;}
    //void IncrementProgramCounter();
    //void DecrementProgramCounter();

    
    void ParseInstruction(string instruction, int lineNumber);

    // Error handling and reporting
    //void HandleError(Exception exception);
    //void ReportError(string errorMessage);
}

