
BenchmarkDotNet.Reports.Summary summary = null;

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<AverageArray>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine("..", "..", "..", "AverageArray.log"),
                    true
                );

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<AverageMemory>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine("..", "..", "..", "AverageMemory.log"),
                    true
                );

return;
