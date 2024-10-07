Imports System

Module Program
    Sub Main()
        ' Example of passing by value (ByVal)
        Dim num1 As Integer = 10
        Console.WriteLine("Before calling ModifyByVal: " & num1)
        ModifyByVal(num1)
        Console.WriteLine("After calling ModifyByVal: " & num1)

        ' Example of passing by reference (ByRef)
        Dim num2 As Integer = 10
        Console.WriteLine("Before calling ModifyByRef: " & num2)
        ModifyByRef(num2)
        Console.WriteLine("After calling ModifyByRef: " & num2)

        Console.ReadLine()
    End Sub

    ' This function takes a parameter by value (ByVal)
    Sub ModifyByVal(ByVal value As Integer)
        value += 5 ' This modifies only the local copy, not the original variable
        Console.WriteLine("Inside ModifyByVal: " & value)
    End Sub

    ' This function takes a parameter by reference (ByRef)
    Sub ModifyByRef(ByRef value As Integer)
        value += 5 ' This modifies the original variable directly
        Console.WriteLine("Inside ModifyByRef: " & value)
    End Sub
End Module

