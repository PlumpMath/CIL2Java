using System.Runtime.InteropServices;
using System;

namespace System.Reflection.Emit
{
    /// <summary>Describes how values are pushed onto a stack or popped off a stack.</summary>
    [Serializable]
    [ComVisibleAttribute(true)]
    public enum StackBehaviour : int
    {
        /// <summary>No values are popped off the stack.</summary>
        Pop0 = 0,
        /// <summary>Pops one value off the stack.</summary>
        Pop1 = 1,
        /// <summary>Pops 1 value off the stack for the first operand, and 1 value of the stack for the second operand.</summary>
        Pop1_pop1 = 2,
        /// <summary>Pops a 32-bit integer off the stack.</summary>
        Popi = 3,
        /// <summary>Pops a 32-bit integer off the stack for the first operand, and a value off the stack for the second operand.</summary>
        Popi_pop1 = 4,
        /// <summary>Pops a 32-bit integer off the stack for the first operand, and a 32-bit integer off the stack for the second operand.</summary>
        Popi_popi = 5,
        /// <summary>Pops a 32-bit integer off the stack for the first operand, and a 64-bit integer off the stack for the second operand.</summary>
        Popi_popi8 = 6,
        /// <summary>Pops a 32-bit integer off the stack for the first operand, a 32-bit integer off the stack for the second operand, and a 32-bit integer off the stack for the third operand.</summary>
        Popi_popi_popi = 7,
        /// <summary>Pops a 32-bit integer off the stack for the first operand, and a 32-bit floating point number off the stack for the second operand.</summary>
        Popi_popr4 = 8,
        /// <summary>Pops a 32-bit integer off the stack for the first operand, and a 64-bit floating point number off the stack for the second operand.</summary>
        Popi_popr8 = 9,
        /// <summary>Pops a reference off the stack.</summary>
        Popref = 10,
        /// <summary>Pops a reference off the stack for the first operand, and a value off the stack for the second operand.</summary>
        Popref_pop1 = 11,
        /// <summary>Pops a reference off the stack for the first operand, and a 32-bit integer off the stack for the second operand.</summary>
        Popref_popi = 12,
        /// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a value off the stack for the third operand.</summary>
        Popref_popi_popi = 13,
        /// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 64-bit integer off the stack for the third operand.</summary>
        Popref_popi_popi8 = 14,
        /// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 32-bit integer off the stack for the third operand.</summary>
        Popref_popi_popr4 = 15,
        /// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 64-bit floating point number off the stack for the third operand.</summary>
        Popref_popi_popr8 = 16,
        /// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a reference off the stack for the third operand.</summary>
        Popref_popi_popref = 17,
        /// <summary>No values are pushed onto the stack.</summary>
        Push0 = 18,
        /// <summary>Pushes one value onto the stack.</summary>
        Push1 = 19,
        /// <summary>Pushes 1 value onto the stack for the first operand, and 1 value onto the stack for the second operand.</summary>
        Push1_push1 = 20,
        /// <summary>Pushes a 32-bit integer onto the stack.</summary>
        Pushi = 21,
        /// <summary>Pushes a 64-bit integer onto the stack.</summary>
        Pushi8 = 22,
        /// <summary>Pushes a 32-bit floating point number onto the stack.</summary>
        Pushr4 = 23,
        /// <summary>Pushes a 64-bit floating point number onto the stack.</summary>
        Pushr8 = 24,
        /// <summary>Pushes a reference onto the stack.</summary>
        Pushref = 25,
        /// <summary>Pops a variable off the stack.</summary>
        Varpop = 26,
        /// <summary>Pushes a variable onto the stack.</summary>
        Varpush = 27,
        /// <summary>Pops a reference off the stack for the first operand, a value off the stack for the second operand, and a 32-bit integer off the stack for the third operand.</summary>
        Popref_popi_pop1 = 28
    }
}
