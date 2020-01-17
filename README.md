This program removes any certificate with a FriendlyName containing "ID - ".
Removing that certificate will help prevent the constant "Select Certificate" popup when using IMA NALCOMIS.

To compile the program.
1. Download or create a new txt file and copy/paste the code from CertRemover.cs into it.  

2. Open a command prompt. Navigate to the directory you saved the CertRemover.cs file in.

3. Find your csc.exe file in "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\". You may have a different version so the path may not match exactly.

4. Run the following in your command prompt window (Change path if needed).

    C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe CertRemover.cs
    
5. You should now have the CertRemover.exe file on your Desktop.


Example Command Prompt.

C:\>cd C:\Users\Darren.Tuggey\Desktop

C:\Users\Darren.Tuggey\Desktop>C:\Windows\Microsoft.NET\Framework64\v4.0.30319\csc.exe CertRemover.cs
Microsoft (R) Visual C# Compiler version 4.7.3056.0
for C# 5
Copyright (C) Microsoft Corporation. All rights reserved.

This compiler is provided as part of the Microsoft (R) .NET Framework, but only supports language versions up to C# 5, which is no longer the latest version. For compilers that support newer versions of the C# programming language, see http://go.microsoft.com/fwlink/?LinkID=533240


C:\Users\Darren.Tuggey\Desktop>CertRemover.exe

Removed certificate: ID - TUGGEY.DARREN
