using SVM;
using System.Collections.Generic;
using System.Windows.Forms;

public class Debugger : IDebugger
{
    #region TASK 5 - TO BE IMPLEMENTED BY THE STUDENT
    private DebuggerForm debuggerForm;

    public SvmVirtualMachine VirtualMachine { get; set; }

    public Debugger()
    {
        debuggerForm = new DebuggerForm(); // Initialize debuggerForm
        debuggerForm.ContinueClicked += OnContinueClicked;
    }
    private void OnContinueClicked()
    {
        // This method will be called when the Continue button is clicked
        // Close the debugger form to resume execution
        debuggerForm.Close();
    }
    public void Break(IDebugFrame debugFrame, int programCounter)
    {
        //// Retrieve the current instruction
        //IInstruction currentInstruction = debugFrame.CurrentInstruction;

        //// Retrieve and display the code frame
        //List<IInstruction> codeFrame = debugFrame.CodeFrame;

        // Retrieve and display the stack contents
        Stack stack = VirtualMachine.Stack;
        DisplayStack(stack);

        //// Show the debugger form
        //ShowDebugger(codeFrame, programCounter );

        debuggerForm.LoadDebuggerContent(debugFrame.CodeFrame);
        debuggerForm.HighlightBreakpointLine(programCounter);  // You need to figure out the index of the current instruction
        debuggerForm.ShowDialog();
    }

     private void DisplayStack(Stack stack)
     {
        debuggerForm.ClearStack(); 

        foreach (var item in stack)
        {
            debuggerForm.AddToStack(item.ToString()); // Add each item to the stack display
        }
     }

    //public void ShowDebugger(List<IInstruction> codeLines, int breakpointLine)
    //{
    //    // Show the debugger form
    //    debuggerForm.LoadDebuggerContent(codeLines); // Load all code lines into the Code ListBox
    //    debuggerForm.HighlightBreakpointLine(breakpointLine); // Highlight the breakpoint line
    //    debuggerForm.ContinueClicked += DebuggerForm_ContinueClicked(List < IInstruction > codeLines, int breakpointLine);
    //    debuggerForm.ShowDialog();
    //}

    //private void DebuggerForm_ContinueClicked(List<IInstruction> codeLines, int breakpointLine)
    //{
    //    // Get the last line number
    //    int lastLine = codeLines.Count - 1;

    //    // Resume execution from the next line after the breakpoint
    //    while (breakpointLine <= lastLine)
    //    {
    //        IInstruction currentInstruction = codeLines[breakpointLine];

    //        if (currentInstruction.IsBreakpoint)
    //        {
    //            // Skip the breakpoint and go to the next line
    //            breakpointLine++;
    //            continue;
    //        }

    //        // Execute the current line (you may have a different way to execute the lines)
    //        ExecuteLine(currentInstruction);

    //        // Move to the next line
    //        breakpointLine++;
    //    }
    //}
    #endregion
}

