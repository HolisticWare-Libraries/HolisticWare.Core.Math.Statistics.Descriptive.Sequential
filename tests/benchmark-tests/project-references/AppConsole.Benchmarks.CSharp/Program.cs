
BenchmarkDotNet.Reports.Summary summary = null;

summary = BenchmarkDotNet.Running
                           .BenchmarkRunner.Run<Average>();
System.IO.File.Move
                (
                    summary.LogFilePath,
                    System.IO.Path.Combine("..", "..", "..", "Average.log"),
                    true
                );

return;
