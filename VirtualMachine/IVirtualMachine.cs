namespace SVM.VirtualMachine;

/// <summary>
/// Defines the interface contract for all Simple 
/// Virtual Machine 
/// </summary>
public interface IVirtualMachine
{
    Stack Stack { get; } 
    void PushStack(object item); 
    object PopStack();
    int StackSize { get; }
    void ClearStack();

    // Program counter management
    int ProgramCounter { get; set; }
    void IncrementProgramCounter();
    void DecrementProgramCounter();

    // Instruction execution
    void ExecuteInstruction();

    // Error handling and reporting
    void HandleError(Exception exception);
    void ReportError(string errorMessage);
}

