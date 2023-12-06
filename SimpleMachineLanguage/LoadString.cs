﻿namespace SVM.SimpleMachineLanguage;

/// <summary>
/// Implements the SML LoadString instruction
/// Loads the supplied string on to
/// the stack
/// </summary>
public class LoadString: BaseInstructionWithOperand
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
    #endregion

    #region System.Object overrides
    /// <summary>
    /// Determines whether the specified <see cref="System.Object">Object</see> is equal to the current <see cref="System.Object">Object</see>.
    /// </summary>
    /// <param name="obj">The <see cref="System.Object">Object</see> to compare with the current <see cref="System.Object">Object</see>.</param>
    /// <returns><b>true</b> if the specified <see cref="System.Object">Object</see> is equal to the current <see cref="System.Object">Object</see>; otherwise, <b>false</b>.</returns>
    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    /// <summary>
    /// Serves as a hash function for this type.
    /// </summary>
    /// <returns>A hash code for the current <see cref="System.Object">Object</see>.</returns>
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    /// <summary>
    /// Returns a <see cref="System.String">String</see> that represents the current <see cref="System.Object">Object</see>.
    /// </summary>
    /// <returns>A <see cref="System.String">String</see> that represents the current <see cref="System.Object">Object</see>.</returns>
    public override string ToString()
    {
        return base.ToString();
    }
    #endregion

    #region IInstruction Members

    public override void Run()
    {
        if (VirtualMachine == null)
        {
            throw new SvmRuntimeException("VirtualMachine is not initialized.");
        }

        if (Operands[0].GetType() != typeof(string))
        {
            throw new SvmRuntimeException(String.Format(BaseInstruction.OperandOfWrongTypeMessage, 
                                            this.ToString(), VirtualMachine.ProgramCounter));
        }

        VirtualMachine.Stack.Push(Operands[0]);
    }
    #endregion
}
