
/*
dotnet run \
    --project ./AppConsole.Benchmarks.CSharp/AppConsole.Benchmarks.CSharp.csproj \
        -c Release \
        -f net6.0

*/
BenchmarkDotNet.Reports.Summary summary = null;

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Loops>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine("..", "..", "..", "Loops.log"),
                    true
                );

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<ControlStructures_vs_PatternMatching>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine("..", "..", "..", "ControlStructures_vs_PatternMatching.log"),
                    true
                );


return;
