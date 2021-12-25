Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices


Public Class UC100
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' '''     /// <summary>
    '    /// Scans and lists all connected UC devices.
    '    /// </summary>
    '    /// <param name="DevicesCount">Returns the number of available devices.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     <DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)> _
    '      public static extern int ListDevices(ref int DevicesCount)

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Returns the device properties defined by the boardID parameter. If the BoardID is lower or equals 0 then it is demo mode.
    '    /// </summary>
    '    /// <param name="BoardID">The ID of the board (Listdevices list number).</param>
    '    /// <param name="Type">Device type (DeviceType enum)</param>
    '    /// <param name="SerialNumber">Returns the serial number of the controller as an integer value. (Convert to hexadecimal to get the serial number in the correct format.)</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int DeviceInfo(int BoardID, ref int Type, ref int SerialNumber);


    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function DeviceInfo(ByVal BoardID As Integer, ByRef Type As Integer, ByRef SerialNumber As Integer) As Integer
    End Function
    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function Open(ByVal BoardID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function Close() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetStepRate(ByVal Rate As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Reads the kernel frequency.
    '    /// </summary>
    '    /// <param name="Rate">0->100kHz, 1->50kHz, 2->25kHz, 3->200kHz, 4->400kHz</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetStepRate(ref int Rate);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Reads the input pins states.
    '    /// </summary>
    '    /// <param name="Inp">One bit per pin.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetInput(ref long Inp); 

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Reads the output pins states.
    '    /// </summary>
    '    /// <param name="Out">One bit per pin.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetOutput(ref long Out);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetOutput(ByVal Out As Long) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetMPGCount(ByVal MPGx As Integer, ByVal MPGCount As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the MPG parameters. (MPGx=0 -> MPG1, MPGx=1 -> MPG2)
    '    /// </summary>
    '    /// <param name="MPGx">The number of the MPG.</param>
    '    /// <param name="MPGCount">The MPG count per turn value.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetMPGCount(int MPGx,ref int MPGCount); 

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetChargePumpSetting(ByVal Pin1 As Integer, ByVal PinNeg1 As Boolean, ByVal Pin2 As Integer, ByVal PinNeg2 As Boolean,
    <MarshalAs(UnmanagedType.I1)> ByVal ChargeAlwaysOn As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the charge pump settings.
    '    /// </summary>
    '    /// <param name="Pin1">Output pin of charge pump1.</param>
    '    /// <param name="PinNeg1">Inverts charge pump1. output.</param>
    '    /// <param name="Pin2">Output pin of charge pump2.</param>
    '    /// <param name="PinNeg2">Inverts charge pump2. output.</param>
    '    /// <param name="ChargeAlwaysOn">Charge pump active also in reset.</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetChargePumpSetting(ref int Pin1, [MarshalAs(UnmanagedType.I1)] ref bool PinNeg1, ref int Pin2, [MarshalAs(UnmanagedType.I1)] ref bool PinNeg2, [MarshalAs(UnmanagedType.I1)] ref bool ChargeAlwaysOn);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetDebounce(ByVal Debounce As Integer, ByVal THCDebounce As Integer, ByVal HomeDebounce As Integer, ByVal Probe1Debounce As Integer, ByVal Probe2Debounce As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '     /// <summary>
    '     /// Gets the debounce (inputs digital low pass filter).
    '     /// </summary>
    '     /// <param name="Debounce">General inputs debounce filter time constant(value*1msec).</param>
    '     /// <param name="THCDebounce">THC inputs debounce filter time constant(value*1msec).</param>
    '     /// <param name="HomeDebounce">Home inputs debounce filter time constant(value*1msec).</param>
    '     /// <param name="Probe1Debounce">Probe1 inputs debounce filter time constant(value*1msec).</param>
    '     /// <param name="Probe2Debounce">Probe2 inputs debounce filter time constant(value*1msec).</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetDebounce(ref int Debounce, ref int THCDebounce, ref int HomeDebounce, ref int Probe1Debounce, ref int Probe2Debounce);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetEstopSetting(ByVal Pin As Integer,
    <MarshalAs(UnmanagedType.I1)> ByVal PinNeg As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '     /// <summary>
    '     /// Gets the e-stop input pin.
    '     /// </summary>
    '     /// <param name="Pin">Input pin of e-stop.</param>
    '     /// <param name="PinNeg">Inverts the e-stop input.</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '      [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '      unsafe public static extern int GetEstopSetting(ref int Pin, [MarshalAs(UnmanagedType.I1)] ref bool PinNeg);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function StopEndOfSegment() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function StopWithDeccel() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function [Stop]() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetEstopState() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetTrajParam(
    <MarshalAs(UnmanagedType.Struct)> ByRef _TrajParam As TrajParam) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the path trajectory (Constant velocity) parameters.
    '    /// </summary>
    '    /// <param name="_TrajParam">The trajectory planner parameters struct.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetTrajParam([MarshalAs(UnmanagedType.Struct)] ref TrajParam _TrajParam);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAxisSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _AxisSetting As AxisSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetAxisSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _AxisSetting As AxisSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAxisPosition(ByVal Xpos As Double, ByVal Ypos As Double, ByVal Zpos As Double, ByVal Apos As Double, ByVal Bpos As Double, ByVal Cpos As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the position (coordinate counter) of the axes in Units.
    '    /// </summary>
    '    /// <param name="Xpos">X axis position in Units.</param>
    '    /// <param name="Ypos">Y axis position in Units.</param>
    '    /// <param name="Zpos">Z axis position in Units.</param>
    '    /// <param name="Apos">A axis position in Units.</param>
    '    /// <param name="Bpos">B axis position in Units.</param>
    '    /// <param name="Cpos">C axis position in Units.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAxisPosition(ref double Xpos, ref double Ypos, ref double Zpos, ref double Apos, ref double Bpos, ref double Cpos);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the DTG (distance to go) of the axes in Units.
    '    /// </summary>
    '    /// <param name="Xpos">X axis distance to go in Units.</param>
    '    /// <param name="Ypos">Y axis distance to go in Units.</param>
    '    /// <param name="Zpos">Z axis distance to go in Units.</param>
    '    /// <param name="Apos">A axis distance to go in Units.</param>
    '    /// <param name="Bpos">B axis distance to go in Units.</param>
    '    /// <param name="Cpos">C axis distance to go in Units.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAxisDTG(ref double Xpos, ref double Ypos, ref double Zpos, ref double Apos, ref double Bpos, ref double Cpos);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAxisIndex(ByVal Xpos As Integer, ByVal Ypos As Integer, ByVal Zpos As Integer, ByVal Apos As Integer, ByVal Bpos As Integer, ByVal Cpos As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the axis position in Steps.
    '    /// </summary>
    '    /// <param name="Xpos">X axis position in Steps.</param>
    '    /// <param name="Ypos">Y axis position in Steps.</param>
    '    /// <param name="Zpos">Z axis position in Steps.</param>
    '    /// <param name="Apos">A axis position in Steps.</param>
    '    /// <param name="Bpos">B axis position in Steps.</param>
    '    /// <param name="Cpos">C axis position in Steps.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAxisIndex(ref int Xpos,ref int Ypos, ref int Zpos, ref int Apos, ref int Bpos, ref int Cpos);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddLinearMove(ByVal x As Double, ByVal y As Double, ByVal z As Double, ByVal a As Double, ByVal b As Double, ByVal c As Double, ByVal Feed As Double, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddCircularMove(ByVal x As Double, ByVal y As Double, ByVal z As Double, ByVal rx As Double, ByVal ry As Double, ByVal rz As Double, ByVal Dir As Boolean, ByVal Feed As Double, ByVal Plane As Integer, ByVal ID As Integer, ByVal NextID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddDwell(ByVal Time As Double, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddDummyMove(ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetSpindleSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _SPSetting As SPSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetSpindleSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _SPSetting As SPSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SpindleOn(
    <MarshalAs(UnmanagedType.I1)> ByVal CCW As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetSpindleSpeed(ByVal Speed As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the spindle speed.
    '    /// </summary>
    '    /// <param name="Speed">Spindle speed parameter.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetSpindleSpeed(ref double Speed);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SpindleOff() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetIndexSetting(ByVal Pin As Integer, ByVal Prescale As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the index prescaler and pin of the spindle index sensor.
    '    /// </summary>
    '    /// <param name="Pin">Input pin of spindle index.</param>
    '    /// <param name="Prescale">Index pulse count per spindle turn.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetIndexSetting(ref int Pin, ref double Prescale);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetTHCSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _THCSetting As THCSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetTHCSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _THCSetting As THCSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function THCNullCorrection() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetTHCCorrection(ByRef THCCorr As Double) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function THCEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetStatus(
    <MarshalAs(UnmanagedType.Struct)> ByRef SStat As Stat) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function HomeOn(ByVal Axis As Integer, ByVal SpeedUp As Double, ByVal SpeedDown As Double,
    <MarshalAs(UnmanagedType.I1)> ByVal Dir As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function JogOn(ByVal Axis As Integer,
    <MarshalAs(UnmanagedType.I1)> ByVal Dir As Boolean,
    <MarshalAs(UnmanagedType.I1)> ByVal MaxSpeed As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function JogOff(ByVal Axis As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetOffline(
    <MarshalAs(UnmanagedType.I1)> ByVal State As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the offline state.
    '    /// </summary>
    '    /// <param name="State">Enabled/Disabled.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetOffline([MarshalAs(UnmanagedType.I1)]ref bool State); 

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetProbeSetting(ByVal Pin1 As Integer,
    <MarshalAs(UnmanagedType.I1)> ByVal Pin1Neg As Boolean, ByVal Pin2 As Integer,
    <MarshalAs(UnmanagedType.I1)> ByVal Pin2Neg As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the probe sensors settings.
    '    /// </summary>
    '    /// <param name="Pin1">Probe1. input pin.</param>
    '    /// <param name="Pin1Neg">Inverts the probe1. input.</param>
    '    /// <param name="Pin2">Probe2. input pin.</param>
    '    /// <param name="Pin2Neg">Inverts the probe 2. input.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetProbeSetting(ref int Pin1, [MarshalAs(UnmanagedType.I1)] ref bool Pin1Neg, ref int Pin2, [MarshalAs(UnmanagedType.I1)] ref bool Pin2Neg);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function ProbeStart(ByVal Axis As Integer, ByVal ProbePos As Double, ByVal Speed As Double, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function ProbeStop() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetSoftLimit(
    <MarshalAs(UnmanagedType.I1)> ByVal SoftLimitEnable As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the softlimit enable.
    '    /// </summary>
    '    /// <param name="SoftLimitEnable"></param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)] 
    '     unsafe public static extern int GetSoftLimit([MarshalAs(UnmanagedType.I1)] ref bool SoftLimitEnable);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function LimitOverRide() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetVersio(
    <MarshalAs(UnmanagedType.Struct)> ByRef Version As Versio) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetFRO(ByVal FRO As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the FRO (feedrate override).
    '    /// </summary>
    '    /// <param name="FRO">FRO percentage (0-300%).</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetFRO(ref double FRO);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetSRO(ByVal SRO As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the SRO (spindle rate override).
    '    /// </summary>
    '    /// <param name="SRO">SRO percentage (0-300%).</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetSRO(ref double SRO);

''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetJRO(ByVal JRO As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '     /// <summary>
    '     /// Gets the JRO (jog rate override).
    '     /// </summary>
    '     /// <param name="JRO">JRO percentage (0-100%).</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetJRO(ref double JRO);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function MPGJogOn(ByVal Axis As Integer, ByVal MPG As Integer, ByVal Mode As Integer, ByVal [Step] As Double) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function MPGJogOff(ByVal MPG As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the analog inputs values.
    '    /// </summary>
    '    /// <param name="AnIn1">Analog input channel 1. value.</param>
    '    /// <param name="AnIn2">Analog input channel 2. value.</param>
    '    /// <param name="AnIn3">Analog input channel 3. value.</param>
    '    /// <param name="AnIn4">Analog input channel 4. value.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAnalogInput(ref int AnIn1,ref int AnIn2,ref int AnIn3,ref int AnIn4);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAnalogOut(ByVal AnOut1 As Integer, ByVal AnOut2 As Integer, ByVal AnOut3 As Integer, ByVal AnOut4 As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '     /// <summary>
    '     /// Gets the analog output channel values.
    '     /// </summary>
    '     /// <param name="AnOut1">Analog output channel 1. value.</param>
    '     /// <param name="AnOut2">Analog output channel 2. value.</param>
    '     /// <param name="AnOut3">Analog output channel 3. value.</param>
    '     /// <param name="AnOut4">Analog output channel 4. value.</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAnalogOut(ref int AnOut1,ref int AnOut2,ref int AnOut3,ref int AnOut4);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAnalogSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _AnalogSetting As AnalogSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetAnalogSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _AnalogSetting As AnalogSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddSyncMove(ByVal x As Double, ByVal z As Double, ByVal Pitch As Double, ByVal Degree As Double, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetEncoderSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _EncoderSetting As EncoderSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetEncoderSetting(
    <MarshalAs(UnmanagedType.Struct)> ByRef _EncoderSetting As EncoderSetting) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddRigidTappingMove(ByVal z As Double, ByVal Pitch As Double,
    <MarshalAs(UnmanagedType.I1)> ByVal Dir As Boolean, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function ClearSoftlimitState() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetFeedHold(ByVal State As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetFeedHold(
    <MarshalAs(UnmanagedType.I1)> ByRef State As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddPinSwitch(ByVal PinDuty As Integer, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddPinSwitch2(ByVal Output As Integer, ByVal Active As Boolean, ByVal ID As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Loads the laser image data array for later execution.
    '    /// </summary>
    '    /// <param name="_LaserPictureData">The laserpicture data array struct.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe private static extern int SetLaserPictureData([MarshalAs(UnmanagedType.Struct)] ref LaserPictureData _LaserPictureData);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function StartLaserPicture() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetLaserProgress(ByRef Percent As Double) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function UnloadLaserPictureData() As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetLaserOutPin(ByVal Pin As Integer,
    <MarshalAs(UnmanagedType.I1)> ByVal PinNeg As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the laser output pin.
    '    /// </summary>
    '    /// <param name="Pin">Laser output pin.</param>
    '    /// <param name="PinNeg">Inverts the laser output pin.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetLaserOutPin(ref int Pin, [MarshalAs(UnmanagedType.I1)] ref bool PinNeg);	//Lézer kimenet lekérdezése

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' '''     
    '    /// <summary>
    '    /// Gets the debug data from the API. (For internal use only, not for developers)
    '    /// </summary>
    '    /// <param name="D1">Data1. value</param>
    '    /// <param name="D2">Data2. value</param>
    '    /// <param name="D3">Data3. value</param>
    '    /// <param name="D4">Data4. value</param>
    '    /// <param name="D5">Data5. value</param>
    '    /// <param name="D6">Data6. value</param>
    '    /// <param name="D7">Data7. value</param>
    '    /// <param name="D8">Data8. value</param>
    '    /// <param name="D9">Data9. value</param>
    '    /// <param name="D10">Data10. value</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetDebugData(ref double D1, ref double D2, ref double D3, ref double D4, ref double D5, ref double D6, ref double D7, ref double D8, ref double D9, ref double D10);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Adds a THC on/off command to the motion buffer for execution.
    '    /// </summary>
    '    /// <param name="Enable">Enable/disable</param>
    '    /// <param name="ID">Identifier of the motion command.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int AddTHCEnable([MarshalAs(UnmanagedType.I1)] bool Enable, int ID);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function JogOnSpeed(ByVal Axis As Integer,
    <MarshalAs(UnmanagedType.I1)> ByVal Dir As Boolean, ByVal Speed As Double) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddLinearMoveRel(ByVal Axis As Integer, ByVal [Step] As Double, ByVal StepCount As Integer, ByVal Speed As Double,
    <MarshalAs(UnmanagedType.I1)> ByVal Dir As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddOEMVar(ByVal Num As Integer, ByVal Val As Double, ByVal ID As Integer) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the value of an OEM variable.
    '    /// </summary>
    '    /// <param name="Num">The number of the OEM var.(range:0-100)</param>
    '    /// <param name="Val">Returned value of the OEM var.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetOEMVar(int Num, ref double Val);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddIvar(ByVal Num As Integer, ByVal Val As Double, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetIvar(ByVal Num As Integer, ByVal Val As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the value of a variable.
    '    /// </summary>
    '    /// <param name="Num">The number of the variable.(range:0-6000)</param>
    '    /// <param name="Val">Returned value of the variable.</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetIvar(int Num, ref double Val);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the reason for the last e-stop reset event.
    '    /// </summary>
    '    /// <param name="Cause">Reason for the e-stop reset. (0=no reset, 1=e-stop input, 2=limit input.)</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetEstopCause(ref int Cause);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function THCAntiDiveEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function THCDelayEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function THCAntiDownEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddTHCAntiDiveEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddTHCDelayEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function AddTHCAntiDownEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean, ByVal ID As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetTHCVirtualSignal(
    <MarshalAs(UnmanagedType.I1)> ByVal THCArcOn As Boolean,
    <MarshalAs(UnmanagedType.I1)> ByVal THCUp As Boolean,
    <MarshalAs(UnmanagedType.I1)> ByVal THCDown As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the THC virtual control signals
    '    /// </summary>
    '    /// <param name="THCArcOn">Switches the THC arc on virtual signal on.</param>
    '    /// <param name="THCUp">Switches the THC up virtual signal on.</param>
    '    /// <param name="THCDown">Switches the THC down virtual signal on.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetTHCVirtualSignal([MarshalAs(UnmanagedType.I1)]ref bool THCArcOn,[MarshalAs(UnmanagedType.I1)]ref bool THCUp,[MarshalAs(UnmanagedType.I1)]ref bool THCDown);	    //THC virtuális jelek kiolvasása

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetProbePosition(ByRef Xpos As Double, ByRef Ypos As Double, ByRef Zpos As Double, ByRef Apos As Double, ByRef Bpos As Double, ByRef Cpos As Double) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SafeProbeEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function JogSafeProbeEnable(
    <MarshalAs(UnmanagedType.I1)> ByVal Enable As Boolean) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetProbeState(
    <MarshalAs(UnmanagedType.I1)> ByRef Finish As Boolean) As Integer
    End Function

    '<DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    'Public Shared Function GetStatistics(ByRef _Statistics As Statistics) As Integer
    'End Function

    '<DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    'Public Shared Function SetStatistics(ByRef _Statistics As Statistics) As Integer
    'End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the system communication latency. it returns a pointer with 500 data bytes. Each data bytes represents one latency point.
    '    /// </summary>
    '    /// <param name="ThreadUsage">Communication latency data byte array.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetThreadUsage(out IntPtr ThreadUsage);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Reads the auxiliary encoder counts per turn.
    '    /// </summary>
    '    /// <param name="Num">Number of aux encoder (0 to 5).</param>
    '    /// <param name="CountsPer">Counts per turn value.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAuxEncoderCountsPer(int Num, ref double CountsPer);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAuxEncoderCountsPer(ByVal Num As Integer, ByVal CountsPer As Double) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetAuxEncoderPos(ByVal Num As Integer, ByVal Pos As Double) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '     /// <summary>
    '     /// Gets the auxiliary encoder position.
    '     /// </summary>
    '     /// <param name="Num">Number of aux encoder (0 to 5).</param>
    '     /// <param name="Pos">Position of the encoder.</param>
    '     /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetAuxEncoderPos(int Num, ref double Pos);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Sets the spindle closed loop PID controller parameters.
    '    /// </summary>
    '    /// <param name="_SpindlePID">Spindle PID parameters structure.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int SetSpindlePID(ref SpindlePID _SpindlePID);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the spindle closed loop PID controller parameters.
    '    /// </summary>
    '    /// <param name="_SpindlePID">Spindle PID parameters structure.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetSpindlePID(ref SpindlePID _SpindlePID);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the spindle PID feedback data in an array of 500.
    '    /// </summary>
    '    /// <param name="CommandedRPM">The programmed spindle RPM.</param>
    '    /// <param name="MeasuredRPM">The measured spindle RPM.</param>
    '    /// <param name="PIDOut">The calculated PID PWM value.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetPIDData(out IntPtr CommandedRPM, out IntPtr MeasuredRPM, out IntPtr PIDOut);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the actual spindle PID PWM output.
    '    /// </summary>
    '    /// <param name="PidOut">The calculated PID PWM value.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetPIDOut(ref double PidOut);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetMotionProgressState(
    <MarshalAs(UnmanagedType.I1)> ByVal Run As Boolean) As Integer
    End Function

    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Sets the state of 10 dedicated fast outputs.
    '    /// </summary>
    '    /// <param name="_OutPin">Outpin structure which holds the pin states.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int SetOutputPin(ref OutPin _OutPin);

    ' ''' 
    '        ''' Cannot convert MethodDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitMethodDeclaration(MethodDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 407
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Gets the state of 10 dedicated fast outputs.
    '    /// </summary>
    '    /// <param name="_OutPin">Outpin structure which holds the pin states.</param>
    '    /// <returns>ReturnVal, UC error code.</returns>
    '     [DllImport("UC100.dll", CallingConvention = CallingConvention.Cdecl)]
    '     unsafe public static extern int GetOutputPin(ref OutPin _OutPin);

    ' ''' 

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetOutputBit(ByVal Num As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function ClearOutputBit(ByVal Num As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function SetFeedMode(ByVal Num As Integer) As Integer
    End Function

    <DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    Public Shared Function GetFeedMode(ByRef Num As Integer) As Integer
    End Function

    '<DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    'Public Shared Function SetTangentialCutter(
    '<MarshalAs(UnmanagedType.Struct)> ByRef _TangentCutterParam As TangentCutterParam) As Integer
    'End Function

    '<DllImport("UC100.dll", CallingConvention:=CallingConvention.Cdecl)>
    'Public Shared Function GetTangentialCutter(
    '<MarshalAs(UnmanagedType.Struct)> ByRef _TangentCutterParam As TangentCutterParam) As Integer
    'End Function

    '    Public Shared Function SetPictureData(ByVal _LaserPictureData As LaserPictureData, ByVal BrightnessDataInput As Byte()()) As Integer
    '        Dim counter = 0
    '        Dim BrightnessData = New Byte(BrightnessDataInput.Length * BrightnessDataInput(0).Length - 1) {}

    '        For i = 0 To BrightnessDataInput.Length - 1

    '            For j = 0 To BrightnessDataInput(i).Length - 1
    '                BrightnessData(counter) = BrightnessDataInput(i)(j)
    '                counter += 1
    '            Next
    '        Next

    '                ''' Cannot convert UnsafeStatementSyntax, CONVERSION ERROR: Conversion for UnsafeStatement not implemented, please report this issue in 'unsafe
    '   {
    '    fixed (byte...' at character 61037
    ' '''    at ICSharpCode.CodeConverter.VB.MethodBodyVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\MethodBodyVisitor.cs:line 56
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.VisitUnsafeStatement(UnsafeStatementSyntax node)
    ' '''    at Microsoft.CodeAnalysis.CSharp.Syntax.UnsafeStatementSyntax.Accept[TResult](CSharpSyntaxVisitor`1 visitor)
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.ConvertWithTrivia(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingMethodBodyVisitor.cs:line 42
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingMethodBodyVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingMethodBodyVisitor.cs:line 34
    ' ''' 
    ' ''' Input: 
    ' '''          unsafe
    '         {
    '             fixed (byte* Data = BrightnessData)
    '             {
    '                 _LaserPictureData.BrightnessData = Data;
    '                 return UC100.SetLaserPictureData(ref _LaserPictureData);
    '             }
    '         }

    ' ''' 
    '    End Function

    Public Shared Function AddSyncMoveP(ByVal x As Double?, ByVal z As Double?, ByVal Pitch As Double, ByVal Degree As Double?, ByVal ID As Integer) As Integer
        Dim xp, zp, de As Double

        If x IsNot Nothing Then
            xp = CDbl(x)
        Else
            xp = Double.MaxValue
        End If

        If z IsNot Nothing Then
            zp = CDbl(z)
        Else
            zp = Double.MaxValue
        End If

        If Degree IsNot Nothing Then
            de = CDbl(Degree)
        Else
            de = Double.MaxValue
        End If

        Return AddSyncMove(xp, zp, Pitch, de, ID)
    End Function

    Public Shared Function AddCircularMoveP(ByVal x As Double?, ByVal y As Double?, ByVal z As Double?, ByVal rx As Double, ByVal ry As Double, ByVal rz As Double, ByVal Dir As Boolean, ByVal Feed As Double, ByVal Plane As Integer, ByVal ID As Integer, ByVal NextID As Integer) As Integer
        Dim xp, yp, zp As Double

        If x IsNot Nothing Then
            xp = CDbl(x)
        Else
            xp = Double.MaxValue
        End If

        If y IsNot Nothing Then
            yp = CDbl(y)
        Else
            yp = Double.MaxValue
        End If

        If z IsNot Nothing Then
            zp = CDbl(z)
        Else
            zp = Double.MaxValue
        End If

        Return AddCircularMove(xp, yp, zp, rx, ry, rz, Dir, Feed, Plane, ID, NextID)
    End Function

    Public Shared Function AddLinearMoveP(ByVal x As Double?, ByVal y As Double?, ByVal z As Double?, ByVal a As Double?, ByVal b As Double?, ByVal c As Double?, ByVal Feed As Double, ByVal ID As Integer) As Integer
        Dim xp, yp, zp, ap, bp, cp As Double

        If x IsNot Nothing Then
            xp = CDbl(x)
        Else
            xp = Double.MaxValue
        End If

        If y IsNot Nothing Then
            yp = CDbl(y)
        Else
            yp = Double.MaxValue
        End If

        If z IsNot Nothing Then
            zp = CDbl(z)
        Else
            zp = Double.MaxValue
        End If

        If a IsNot Nothing Then
            ap = CDbl(a)
        Else
            ap = Double.MaxValue
        End If

        If b IsNot Nothing Then
            bp = CDbl(b)
        Else
            bp = Double.MaxValue
        End If

        If c IsNot Nothing Then
            cp = CDbl(c)
        Else
            cp = Double.MaxValue
        End If

        Return AddLinearMove(xp, yp, zp, ap, bp, cp, Feed, ID)
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure EncoderSetting
        <MarshalAs(UnmanagedType.I1)>
        Public MPGEnable As Boolean
        Public MPGPinA As Integer
        Public MPGPinB As Integer
        Public MPGPrescale As Integer
        Public MPGFilter As Integer
        Public MPGSpeedMultiplier As Double
        <MarshalAs(UnmanagedType.I1)>
        Public EnableJROToMPG As Boolean
        Public EncoderPinA As Integer
        Public EncoderPinB As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public EncoderReverseDirection As Boolean
        Public EncoderPPR As Integer
        Public EncoderCorrection As Double
        Public Aux1EncoderPinA As Integer
        Public Aux1EncoderPinB As Integer
        Public Aux2EncoderPinA As Integer
        Public Aux2EncoderPinB As Integer
        Public Aux3EncoderPinA As Integer
        Public Aux3EncoderPinB As Integer
        Public Aux4EncoderPinA As Integer
        Public Aux4EncoderPinB As Integer
        Public Aux5EncoderPinA As Integer
        Public Aux5EncoderPinB As Integer
        Public Aux6EncoderPinA As Integer
        Public Aux6EncoderPinB As Integer
        Public Aux1EncoderStepPer As Double
        Public Aux2EncoderStepPer As Double
        Public Aux3EncoderStepPer As Double
        Public Aux4EncoderStepPer As Double
        Public Aux5EncoderStepPer As Double
        Public Aux6EncoderStepPer As Double
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure MPGSetting
        <MarshalAs(UnmanagedType.I1)>
        Public MPG1Enable As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public MPG2Enable As Boolean
        Public MPG1PinA As Integer
        Public MPG1PinB As Integer
        Public MPG2PinA As Integer
        Public MPG2PinB As Integer
        Public MPG1Prescale As Integer
        Public MPG2Prescale As Integer
        Public MPG1Filter As Integer
        Public MPG2Filter As Integer
        Public MPG1SpeedMultiplier As Double
        Public MPG2SpeedMultiplier As Double
        <MarshalAs(UnmanagedType.I1)>
        Public EnableJROToMPG As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure AxisSetting
        Public Axis As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public Enable As Boolean
        Public StepPin As Integer
        Public DirPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public StepNeg As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public DirNeg As Boolean
        Public MaxAccel As Double
        Public MaxVel As Double
        Public StepPer As Double
        Public HomePin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public HomeNeg As Boolean
        Public LimitPPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public LimitPNeg As Boolean
        Public LimitNPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public LimitNNeg As Boolean
        Public SoftLimitP As Double
        Public SoftLimitN As Double
        Public SlaveAxis As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public BacklashOn As Boolean
        Public BacklashDist As Double
        Public CompAccel As Double
        Public EnablePin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public EnablePinNeg As Boolean
        Public EnableDelay As Integer
        Public CurrentHiLowPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public CurrentHiLowPinNeg As Boolean
        Public HomeBackOff As Double
        <MarshalAs(UnmanagedType.I1)>
        Public RotaryAxis As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public RotaryRollover As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure SPSetting
        Public Mode As Integer
        Public SPPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public SPPinNeg As Boolean
        Public SPDirPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public SPDirPinNeg As Boolean
        Public PWMFreq As Integer
        Public SPAccel As Double
        Public SPStepPerRev As Double
        Public SPMinVel As Double
        Public SPMaxVel As Double
        Public SPMinPWMPercent As Double
        Public SPMaxPWMPercent As Double
        Public SPM3Pin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public SPM3PinNeg As Boolean
        Public SPM4Pin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public SPM4PinNeg As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public EnableM3M4Output As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure THCSetting
        Public THCOnPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public THCOnPinNeg As Boolean
        Public THCUpPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public THCUpPinNeg As Boolean
        Public THCDownPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public THCDownPinNeg As Boolean
        Public THCmin As Double
        Public THCmax As Double
        Public THCFeed As Double
        <MarshalAs(UnmanagedType.I1)>
        Public THCAlwaysOn As Boolean
        Public THCOnTime As Double
        Public THCAntiDiveVel As Double
        Public THCEnPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public THCEnPinNeg As Boolean
        Public THCAntiDivePin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public THCAntiDivePinNeg As Boolean
        Public THCAntiDownPin As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public THCAntiDownPinNeg As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure Stat
        <MarshalAs(UnmanagedType.I1)>
        Public Idle As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Jog As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Dwell As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Backlash As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Home As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Probe As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Estop As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public SoftLimit As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public HardLimit As Boolean
        Public Puffer As Integer
        Public Feed As Double
        Public SpindleRPM As Double
        Public CurrentID As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public LimitOverride As Boolean
        Public OriginalFeed As Double
        <MarshalAs(UnmanagedType.I1)>
        Public MPG1JogOn As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public MPG2JogOn As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public THCOnWaiting As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public SyncThread As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public SpindleOn As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public SpindleDir As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public LaserRunning As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public LaserDataValid As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public THCEnabled As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public THCAntiDive As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public THCAntiDiveEnable As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public THCDelayEnable As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public THCAntiDownEnable As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public ProbeActive As Boolean
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure Versio
        Public FWVersion As Integer
        Public HWVersion As Integer
        Public DLLVersion As Integer
        Public SerialNumber As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure TrajParam
        Public StopAngle As Double
        <MarshalAs(UnmanagedType.I1)>
        Public ConstantVel As Boolean
        <MarshalAs(UnmanagedType.I1)>
        Public Units As Boolean
        Public LinearErr As Double
        Public MaxLinearUnificationLenght As Double
        Public MaxLinearAddLenght As Double
        Public CornerError As Double
        Public USBPufferSize As Double
    End Structure

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure SpindlePID
        <MarshalAs(UnmanagedType.I1)>
        Public EnablePID As Boolean
        Public PIDTimePrescaler As Integer
        Public Kp As Double
        Public Ki As Double
        Public Kd As Double
    End Structure

    Public Enum FeedMode
        G93 = 0
        G94 = 1
        G95 = 2
    End Enum

    Public Enum ReturnVal
        UC100_OK = 0
        UC100_DEVICE_NOT_OPENED = 1
        UC100_DEVICE_NOT_FOUND = 2
        UC100_FIRMWARE_ERROR = 3
        UC100_IO_ERROR = 4
        UC100_MOVEMENT_IN_PROGRESS = 5
        UC100_HOME_IN_PROGRESS = 6
        UC100_ESTOP = 7
        UC100_LIMIT = 8
        UC100_PARAMETER_ERROR = 9
        UC100_COMMAND_BUFFER_FULL = 10
        UC100_FW_UPDATE = 11
        UC100_PROBEPIN_ACTIVE = 12
    End Enum

    Public Enum DeviceType
        Demo_AXBB = -19
        Demo_UC300ETH_UB1 = -18
        Demo_UC300ETH_M45 = -17
        Demo_UC300ETH_5441 = -16
        Demo_UC300_5441 = -15
        Demo_UC300ETH_STEPPER = -14
        Demo_UC300ETH_ISOBOB = -13
        Demo_UC300ETH_M44 = -12
        Demo_UC300ETH_5LPT = -11
        Demo_UC300ETH_Low = -10
        Demo_UC300ETH_Hi = -9
        Demo_UC400ETH = -8
        Demo_UC300_STEPPER = -7
        Demo_UC300_ISOBOB = -6
        Demo_UC300_M44 = -5
        Demo_UC300_5LPT = -4
        Demo_UC300_Low = -3
        Demo_UC300_Hi = -2
        Demo_UC100 = -1
        Demo_mode = 0
        UC100 = 1
        UC300_Hi = 2
        UC300_Low = 3
        UC300_5LPT = 4
        UC300_M44 = 5
        UC300_ISOBOB = 6
        UC300_STEPPER = 7
        UC400ETH = 8
        UC300ETH_Hi = 9
        UC300ETH_Low = 10
        UC300ETH_5LPT = 11
        UC300ETH_M44 = 12
        UC300ETH_ISOBOB = 13
        UC300ETH_STEPPER = 14
        UC300_5441 = 15
        UC300ETH_5441 = 16
        UC300ETH_M45 = 17
        UC300ETH_UB1 = 18
        AXBB = 19
    End Enum

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Public Structure AnalogSetting
        <MarshalAs(UnmanagedType.I1)>
        Public FROAnalogEnable As Boolean
        Public FROAnalogIn As Integer
        Public FROMinPercent As Double
        Public FROMaxPercent As Double
        <MarshalAs(UnmanagedType.I1)>
        Public SROAnalogEnable As Boolean
        Public SROAnalogIn As Integer
        Public SROMinPercent As Double
        Public SROMaxPercent As Double
        Public SpindlePWMEnable As Integer
        <MarshalAs(UnmanagedType.I1)>
        Public JROAnalogEnable As Boolean
        Public JROAnalogIn As Integer
        Public JROMinPercent As Double
        Public JROMaxPercent As Double
    End Structure

    '        ''' Cannot convert StructDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiers(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 385
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitStructDeclaration(StructDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 237
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Laser picture data structure.
    '    /// </summary>
    '        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    '        unsafe public struct LaserPictureData
    '        {
    '            /// <summary>
    '            /// Laser mode (0=Grayscale with PWM output, 1=Halftone, 2=Black and white).
    '            /// </summary>
    '            public int      LaserMode;
    '            /// <summary>
    '            /// X start position for the laser picture engraving.
    '            /// </summary>
    '            public double   StartPosX;
    '            /// <summary>
    '            /// Y start position for the laser picture engraving.
    '            /// </summary>
    '            public double   StartPosY;
    '            /// <summary>
    '            /// Laser picture engraving feedrate in Units/sec.
    '            /// </summary>
    '            public double   Feed;
    '            /// <summary>
    '            /// Point X dimension in Units.
    '            /// </summary>
    '            public double   PointXsize;
    '            /// <summary>
    '            /// Point Y dimension in Units.
    '            /// </summary>
    '            public double   PointYsize;
    '            /// <summary>
    '            /// Picture points brightness data in a byte array pointer.
    '            /// </summary>
    '            public byte*    BrightnessData;	
    '            /// <summary>
    '            /// Picture array X dimension (number of points in X).
    '            /// </summary>
    '            public int      ArrayXsize;
    '            /// <summary>
    '            /// Picture array Y dimension (number of points in Y).
    '            /// </summary>
    '            public int      ArrayYsize;
    '        };

    ' ''' 
    '        ''' Cannot convert StructDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiers(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 385
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitStructDeclaration(StructDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 237
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Statistics structure.
    '    /// </summary>
    '        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    '        unsafe public struct Statistics
    '        {
    '            /// <summary>
    '            /// Total distance run by the X axis.
    '            /// </summary>
    '            public double DistX;
    '            /// <summary>
    '            /// Total distance run by the X axis with running spindle.
    '            /// </summary>
    '            public double DistCutX;
    '            /// <summary>
    '            /// Total distance run by the Y axis.
    '            /// </summary>
    '            public double DistY;
    '            /// <summary>
    '            /// Total distance run by the Y axis with running spindle.
    '            /// </summary>
    '            public double DistCutY;
    '            /// <summary>
    '            /// Total distance run by the Z axis.
    '            /// </summary>
    '            public double DistZ;
    '            /// <summary>
    '            /// Total distance run by the Z axis with running spindle.
    '            /// </summary>
    '            public double DistCutZ;
    '            /// <summary>
    '            /// Total distance run by the A axis.
    '            /// </summary>
    '            public double DistA;
    '            /// <summary>
    '            /// Total distance run by the A axis with running spindle.
    '            /// </summary>
    '            public double DistCutA;
    '            /// <summary>
    '            /// Total distance run by the B axis.
    '            /// </summary>
    '            public double DistB;
    '            /// <summary>
    '            /// Total distance run by the B axis with running spindle.
    '            /// </summary>
    '            public double DistCutB;
    '            /// <summary>
    '            /// Total distance run by the C axis.
    '            /// </summary>
    '            public double DistC;
    '            /// <summary>
    '            /// Total distance run by the C axis with running spindle.
    '            /// </summary>
    '            public double DistCutC;
    '        };

    ' ''' 
    '        ''' Cannot convert StructDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiers(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 385
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitStructDeclaration(StructDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 237
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Fast output pin switch structure.
    '    /// </summary>
    '        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    '        unsafe public struct OutPin
    '        {
    '            public int Out1Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out1PinNeg;
    '            public int Out2Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out2PinNeg;
    '            public int Out3Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out3PinNeg;
    '            public int Out4Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out4PinNeg;
    '            public int Out5Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out5PinNeg;
    '            public int Out6Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out6PinNeg;
    '            public int Out7Pin;	
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out7PinNeg;	
    '            public int Out8Pin;	
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out8PinNeg;	
    '            public int Out9Pin;	
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out9PinNeg;
    '            public int Out10Pin;
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Out10PinNeg;
    '        };

    ' ''' 
    '        ''' Cannot convert StructDeclarationSyntax, System.NotSupportedException: UnsafeKeyword is not supported!
    ' '''    at ICSharpCode.CodeConverter.VB.SyntaxKindExtensions.ConvertToken(SyntaxKind t, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\SyntaxKindExtensions.cs:line 186
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifier(SyntaxToken m, TokenContext context) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 391
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiersCore(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor)+MoveNext() in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 349
    ' '''    at Microsoft.CodeAnalysis.SyntaxTokenList.CreateNode(IEnumerable`1 tokens)
    ' '''    at ICSharpCode.CodeConverter.VB.CommonConversions.ConvertModifiers(IReadOnlyCollection`1 modifiers, TokenContext context, Boolean isConstructor) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommonConversions.cs:line 385
    ' '''    at ICSharpCode.CodeConverter.VB.NodesVisitor.VisitStructDeclaration(StructDeclarationSyntax node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\NodesVisitor.cs:line 237
    ' '''    at Microsoft.CodeAnalysis.CSharp.CSharpSyntaxVisitor`1.Visit(SyntaxNode node)
    ' '''    at ICSharpCode.CodeConverter.VB.CommentConvertingNodesVisitor.DefaultVisit(SyntaxNode node) in D:\GitWorkspace\CodeConverter\ICSharpCode.CodeConverter\VB\CommentConvertingNodesVisitor.cs:line 35
    ' ''' 
    ' ''' Input: 
    ' ''' 
    '    /// <summary>
    '    /// Tangential cutter knife structure.
    '    /// </summary>
    '        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    '        unsafe public struct TangentCutterParam
    '        {
    '            /// <summary>
    '            /// Enables the tangential cutter knife function.
    '            /// </summary>
    '            [MarshalAs(UnmanagedType.I1)]
    '            public bool Enable;
    '            /// <summary>
    '            /// Knife stops above this connection angle.
    '            /// </summary>
    '            public double StopAtAngle;
    '            /// <summary>
    '            /// Knife retracts above this connection angle.
    '            /// </summary>
    '            public double RetractAtAngle;
    '            /// <summary>
    '            /// Knife retracts with this distance.
    '            /// </summary>
    '            public double Retract;
    '            /// <summary>
    '            /// Knife feedrate when put back to the workpiece after a retraction.
    '            /// </summary>
    '            public double MoveBackFeedrate;
    '            /// <summary>
    '            /// ???
    '            /// </summary>
    '            public double PullOutFeedrate;
    '        };

    ' ''' 
End Class