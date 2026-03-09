using System;

// README.md를 읽고 코드를 작성하세요.
FilePermission filePermission = FilePermission.None;

Console.WriteLine("=== 파일 권한 관리 ===");
Console.WriteLine($"\n현재 권한: {filePermission}");

Console.WriteLine("\n[권한 추가]");
filePermission |= FilePermission.Read;
Console.WriteLine($"+ Read 추가: {filePermission}");

filePermission |= FilePermission.Write;
Console.WriteLine($"+ Write 추가: {filePermission}");

AddPermission(FilePermission.Execute);
Console.WriteLine($"+ Execute 추가: {filePermission}");

Console.WriteLine($"\n[권한 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

Console.WriteLine($"\n[권한 제거]");
filePermission &= ~FilePermission.Write;
Console.WriteLine($"- Write 제거: {filePermission}");

Console.WriteLine($"\n[제거 후 확인]");
Console.WriteLine($"Read 권한: {HasFlag(FilePermission.Read)}");
Console.WriteLine($"Write 권한: {HasFlag(FilePermission.Write)}");
Console.WriteLine($"Execute 권한: {HasFlag(FilePermission.Execute)}");

void AddPermission(FilePermission permission)
{
    filePermission |= permission;
}

bool HasFlag(FilePermission permission)
{
    return (filePermission & permission) != 0;
}

[Flags]
enum FilePermission
{
    None = 0,
    Read = 1,
    Write = 1 << 1,
    Execute = 1 << 2
}