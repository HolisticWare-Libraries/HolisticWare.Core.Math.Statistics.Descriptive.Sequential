#! "netcoreapp2.0"
#r "nuget:BenchmarkDotNet, 0.10.14"

// Assembly 
//      ℛ*fb910604-00e0-4b59-9928-09dd640dd1f3#2-0 
//  which defines benchmarks references non-optimized 
//     HolisticWare.Core.Math.Statistics.Descriptive.Sequential
//	If you own this dependency, please, build it in RELEASE.
//	If you don't, you can create custom config with DontFailOnError to disable our custom policy 
//  and allow this benchmark to run.
#r "../../../../../source/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.NetStandard10/bin/Release/netstandard1.0/HolisticWare.Core.Math.Statistics.Descriptive.Sequential.dll"

#load "../../../ScriptTests.CommonShared/Sync/DarkVaderTests/Tests20180119Dataset01/Tests00Data.cs"
#load "../../../ScriptTests.CommonShared/Sync/DarkVaderTests/Tests20180119Dataset01/Tests011MeasuresCentralTendencies.MeanArithmetic.cs"
//#load "../../../ScriptTests.CommonShared/Sync/DarkVaderTests/Tests20180119Dataset01/Tests011MeasuresCentralTendencies.MeanArithmeticWeighted.cs"

# define BENCHMARKDOTNET

#if BENCHMARKDOTNET
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run<Tests20180119Dataset01>();
# endif

// Tests20180119Dataset01 test = new Tests20180119Dataset01();
// test.Array_MeanArithmetic();
