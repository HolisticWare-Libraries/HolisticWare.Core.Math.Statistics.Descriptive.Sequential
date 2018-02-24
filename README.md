# HolisticWare.Core.Math.Statistics.Sequential

Statistics library for .NET Standard 1.0. 

*   Nuget https://www.nuget.org/packages/HolisticWare.Core.Math.Statistics.Sequential/

Basic Descriptive Statistics Algorithms implemented as sequential in both synchronous and
aynchronous variants. Implementations are based on IEnumerable<T> as extension methods
(similar to LINQ - System.Linq )

NOTE: Parallel algorithms based on (TPL) can be found in 

*   Nuget: 

*   Repo:  https://github.com/moljac/HolisticWare.Core.Math.Statistics.Descriptive.Parallel


## DONE

### Algorithms

*   Average (Mean) 

    *   Arithmetic 

    *   Geometric

    *   Harmonic

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



## Technical/Platform Implementation Details

*   async/await

    Each synchronous (blocking) method has processor bound async (TPL counterpart).

*   TPL/PLINQ

    Parallel versions taget .NET Standard 1.1, so they are in placed separate nuget and repo:

    *   https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-parallel-library-tpl

    *   https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/parallel-linq-plinq



## TODOs / Plans

    *   unit tests

        *   currently (2018-02-24): 48

        *   online calculator sources (references / links) 

            mainly used for comparing results

            *   https://www.easycalculation.com/statistics/measures-central-tendency.php

            *   http://elsenaju.eu/Calculator/mean-value-calculator.htm

        *   mathematical tools

            *   octave

            *   R

*   more algorithms

    *   Multivariate Statistics

        *   https://en.wikipedia.org/wiki/Multivariate_statistics

    *   Inferential Statistics (Statistical Inference)

        *   https://en.wikipedia.org/wiki/Statistical_inference

*   unit tests

*   RX 

## Performance 

Performance question boils down to use of `for` vs `foreach`. Current implementation uses `for`.

After benchmarks will be added and tests conducted, implementation might change in the future.


*   https://stackoverflow.com/questions/365615/in-net-which-loop-runs-faster-for-or-foreach

*   https://codeblog.jonskeet.uk/2009/01/29/for-vs-foreach-on-arrays-and-lists/



## References Links

*   http://statpages.info/#WhichAnalysis

*   online calculators

    *   http://www.calculator.net/statistics-calculator.html

    *   http://www.alcula.com/calculators/statistics/

    *   https://www.mathportal.org/calculators/statistics-calculator/standard-deviation-calculator.php

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


