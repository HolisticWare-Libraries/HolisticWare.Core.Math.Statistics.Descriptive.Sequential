# HolisticWare.Core.Math.Statistics.Sequential

Statistics library for .NET Standard 1.0. 

*   Nuget https://www.nuget.org/packages/HolisticWare.Core.Math.Statistics.Sequential/

Basic Descriptive Statistics Algorithms implemented as sequential in both synchronous and
aynchronous variants. Implementations are based on IEnumerable<T> as extension methods
(similar to LINQ - System.Linq )

NOTE: Parallel algorithms based on (TPL) can be found in 

*   Nuget: https://www.nuget.org/packages/HolisticWare.Core.Math.Statistics.Sequential/

*   Repo: 

## Algorithms

*   Average (Mean) Arithmetic and GeoMetric
*   Frequencies
*   Modes
*   Median
*   Moment
*   Standard Deviation (Sample and Population)
*   Variance (Sample and Population)
*   Skewness
*   Kurtosis
*   Correlation 
*   Covariance
*   F Statistics
*   Studentt Statistic
*   Welcht Statistic

## TODOs / Plans

*   async/await

*   TPL/PLINQ

    *   https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-parallel-library-tpl

    *   https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/parallel-linq-plinq

*   more algorithms

    *   Multivariate Statistics

        *   https://en.wikipedia.org/wiki/Multivariate_statistics

    *   Inferential Statistics (Statistical Inference)

        *   https://en.wikipedia.org/wiki/Statistical_inference

*   unit tests

*   RX 


## References Links

*   some ideas and inspirations came from following libraries:

    *   https://www.mathdotnet.com/

        http://mathnetnumerics.codeplex.com/
        
    *   https://www.calculatorsoup.com/calculators/statistics/
    
    *   http://ilnumerics.net/

    *   http://www.ni.com/mstudio/

    *   http://www.centerspace.net/products/nmath/

    *   http://numericalmethod.com/suanshu/

    *   https://code.msdn.microsoft.com/Basic-C-Statistics-Library-26ac5403/sourcecode?fileId=145263&pathId=196059644    

    *   Correlation

        *   https://en.wikipedia.org/wiki/Correlation_and_dependence

        *   http://www.mathsisfun.com/data/correlation.html


### Alternatives

*   LinqStatistics
    
    *   https://www.nuget.org/packages/LinqStatistics/

    *   https://github.com/dkackman/LinqStatistics

*   Meta.Numerics

    *   http://www.meta-numerics.net/
    
    *   https://www.nuget.org/packages/Meta.Numerics/


