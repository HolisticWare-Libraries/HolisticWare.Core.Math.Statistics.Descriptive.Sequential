# HolisticWare.Core.Math.Statistics.Sequential

Statistics library for .NET Standard 1.0. 

*   Nuget https://www.nuget.org/packages/HolisticWare.Core.Math.Statistics.Sequential/

Basic Descriptive Statistics Algorithms implemented as sequential in both synchronous and
aynchronous variants. Implementations are based on `IEnumerable<T>` as extension methods
(similar to LINQ - `System.Linq` )

NOTE: Parallel algorithms based on (TPL) can be found in 

*   Repo:  https://github.com/moljac/HolisticWare.Core.Math.Statistics.Descriptive.Parallel

*   Nuget: 

## Algorithms

Group categorization might be wrong (accepting comments as issues), but the idea was just to simplify implementation
and maintenance.


Implemented and planned (TODOs):

1.  [x] Measures of Central Tendency
    1.   Average (Mean) Value algorithms
        1.  [x] [Arithmetic mean](https://en.wikipedia.org/wiki/Arithmetic_mean)
        2.  [x] [Weighted aritmetic mean](https://en.wikipedia.org/wiki/Weighted_arithmetic_mean)

        3.  [x] [Geometric mean](https://en.wikipedia.org/wiki/Geometric_mean)

        4   [x] [Harmonic mean](https://en.wikipedia.org/wiki/Harmonic_mean)

        5.  Quadratic

        6.  Cubic

        7.  Generalized

        8.  Weighted

    *   [x] [Median](https://en.wikipedia.org/wiki/Median)

    *   [x] [Mode](https://en.wikipedia.org/wiki/Mode_(statistics))

    *   [ ] [Quantile](https://en.wikipedia.org/wiki/Quantile)

    *   [ ] [Quartile](https://en.wikipedia.org/wiki/Quartile)

    *   [ ] [Percentile](https://en.wikipedia.org/wiki/Percentile)

    *   [ ] [Moments](https://en.wikipedia.org/wiki/Moment_(mathematics))

        * generalised

        * central

        * central absolute

        * row

        * row absolute

3.  [ ] Measures of Assymetry (Shape) Distribution                                              

    *   [x] Frequencies

    *   [] Distribution Asymmetry Measures

        *   [] Skewness

            *   [x] [Skewnes (Alpha 3)](https://en.wikipedia.org/wiki/Skewness)

                *   _Pearson's moment coefficient of skewness_

                *   _Pearson's first skewness coefficient (mode skewness)_
            
                *   _Pearson's second skewness coefficient (median skewness)_

        *   Distribution Roundness Measures

            *   [ ] Kurtosis

                *   [x] [Kurtosis (Alpha 4)](https://en.wikipedia.org/wiki/Kurtosis#Mesokurtic)

                * _Differences between formulas: more references on [R package 'e1071'](https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&cad=rja&uact=8&ved=0ahUKEwjDw8PLkavbAhUBApoKHf0dB4wQFggqMAA&url=https%3A%2F%2Fcran.r-project.org%2Fweb%2Fpackages%2Fe1071%2Fe1071.pdf&usg=AOvVaw02nj4Mk-mh5km97z9ukTdc), pages -  `27`-  and -  `47`._

4.   [x] Variability/Dispersion Measures

    *   Moments

    *   Standard Deviation (Sample and Population)

    *   Variance (Sample and Population)

2.   [x] Measures of Variability

    *   [x] [Range](https://en.wikipedia.org/wiki/Range_(statistics))

    *   [ ] [Interquartile range](https://en.wikipedia.org/wiki/Interquartile_range)

    *   [x] [Mean absolute difference](https://en.wikipedia.org/wiki/Mean_absolute_difference)

    *   [x] [Variance](https://en.wikipedia.org/wiki/Variance)

    *   [x] [Standard deviation](https://en.wikipedia.org/wiki/Standard_deviation)

    *   [ ] [Coefficient of variation](https://en.wikipedia.org/wiki/Coefficient_of_variation)

    *   [ ] [Quartile coefficient of dispersion](https://en.wikipedia.org/wiki/Quartile_coefficient_of_dispersion)

4.   Dependency Measures

    *   Correlation 

    *   Covariance

5.   Inferential Methods (will be moved to separate repo/nuget)

    *   F Statistics

    *   Studentt Statistic

    *   Welcht Statistic

TODO:

* naming discussion

|                                          |                                                             |
| -----------------------------------------|-------------------------------------------------------------|
| To Consider:                             |                                                             |
| Central Tendencies                       | **OK**                                                      |
| Dispersion                               | *Variability seems to be* **OK**                            |
| Shape                                    | *Was named* - **Distribution**<br>*Asymmetry*<br>*Roundness*|
| Central Tendencies                       | **OK**                                                      |
| Dependency /Dependencies                 | ***Correlation***<br>***Covariance***                       |

### Comparison Table


|                    |   `x = IEnumerable<T>`               |                             |                           |                           |
|--------------------| ------------------------------------ | --------------------------- | ------------------------- |  ------------------------ |
|                    |   extension methods                  |                             |                           |                           |


|                    |   C# HolisticWare                    | Octave                      | R                         | Python                    |
|--------------------| ------------------------------------ | --------------------------- | ------------------------- | ------------------------- |
| Central Tendencies | `x.MeanArithmetic();`                | `mean(vector_list, "a")`    | `mean(vector_list)`       |                           |
|                    | `x.MeanGeometric();`                 | `mean(vector_list, "g")`    | `N/A (custom function)`   |                           |
|                    | `x.MeanGeometricNaive();`            | `mean(vector_list, "g")`    | `N/A (custom function)`   |                           |
|                    | `x.MeanHarmonic();`                  | `mean(vector_list, "h")`    | `???`                     |                           |
|                    | `x.MeanSquared();`                   | `meansq(vector_list)`       | `???`                     |                           |
|                    | `x.MeanCubic();`                     | `???`                       | `????`                    |                           |
|                    | `x.MeanWeighted();`                  | `???`                       | `????`                    |                           |
|                    | `x.Median();`                        | `???`                       | `????`                    |                           |
|                    | `x.MedianWeighted();`                | `???`                       | `????`                    |                           |
|                    | `x.Modes();`                         | `???`                       | `????`                    |                           |
|                    | `x.ModesRank();`                     | `???`                       | `????`                    |                           |
| Dispersion         | `x.Moment();`                        | `???`                       | `????`                    |                           |
|                    | `x.MomentCentral();`                 | `???`                       | `????`                    |                           |
|                    | `x.MomentCentralAbsolute();`         | `???`                       | `????`                    |                           |
|                    | `x.MomentRaw();`                     | `???`                       | `????`                    |                           |
|                    | `x.MomentRawAbsolute();`             | `???`                       | `????`                    |                           |
|                    | `x.Range();`                         | `???`                       | `????`                    |                           |
|                    | `x.StandardDeviationPopulation();`   | `???`                       | `????`                    |                           |
|                    | `x.StandardDeviationSample();`       | `???`                       | `????`                    |                           |
|                    | `x.VariancePopulation();`            | `???`                       | `????`                    |                           |
|                    | `x.Variance();`                      | `???`                       | `????`                    |                           |
| Distribution       | `x.FrequencyCounter();`              | `???`                       | `????`                    |                           |
|                    | `x.FrequencyDistribution();`         | `???`                       | `????`                    |                           |
|                    | `x.Frequencies();`                   | `???`                       | `????`                    |                           |
|                    | `x.Percentiles();`                   | `???`                       | `????`                    |                           |
|                    | `x.PercentilesRank();`               | `???`                       | `????`                    |                           |
| Distribution Asymm | `x.Skewness();`                      | `???`                       | `????`                    |                           |
| Distribution Round | `x.Kurtosis();`                      | `???`                       | `????`                    |                           |
|                    | `x.KurtosisSample();`                | `???`                       | `????`                    |                           |
|                    | `x.KurtosisSampleExcess();`          | `???`                       | `????`                    |                           |
| Dependency         | `x.Correlation(y);`                  | `???`                       | `????`                    |                           |
|                    | `x.CorrelationOptimized(y);`         | `???`                       | `????`                    |                           |
|                    | `x.Covariance(y);`                   | `???`                       | `????`                    |                           |
| Inferential        | `x.StudenttStatisticIndependent(y);` | `???`                       | `????`                    |                           |
|                    | `x.FStatistic(y);`                   | `???`                       | `????`                    |                           |
|                    | `x.Welcht(y);`                       | `???`                       | `????`                    |                           |


## Usage

### Central Tendencies Measures

### Dispersion Measures

### Distribution Measures

#### Distribution Asymmetry Measures

### Distribution Roundness Measures

## Technical/Platform Implementation Details

*   `IEnumerable<T>` extension methods (LINQ like)

*   `async`/`await` API

    Each synchronous (blocking) method has processor bound async (TPL counterpart).

    https://docs.microsoft.com/en-us/dotnet/csharp/async#recognize-cpu-bound-and-io-bound-work

    https://docs.microsoft.com/en-us/dotnet/standard/async-in-depth

    

*   TPL/PLINQ

    Parallel versions target .NET Standard 1.1, so they are in placed separate nuget and repo:

    *   https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/task-parallel-library-tpl

    *   https://docs.microsoft.com/en-us/dotnet/standard/parallel-programming/parallel-linq-plinq

### `IEnumerable<Nullable<T>>` implementation

There are 2 reasons for the lack of `IEnumerable<Nullable<T>>` implementations:

####  1. Mathematical Consistency

When Nullable Arithmetic is extended to LINQ implementation the results are not consistent

```
// suppose
int? i_sum_1     = 2 + null;
int? i_product_1 = 2 * null;
// 
// suppose
int? i_sum_2     = 2 + 5 + null;
int? i_product_2 = 2 * 5 + null;
// generalized case (LINQ)
// sum(i)
int? i_sum_3     = (new[] {2, 5, null}).Sum();      //  7
```

It is possible to avoid this with `Aggregate()` extension method, but the decision was made to skip this 
implementation, because of following reason.

#### 2. Data Science Data Preparation (Data Munging/ Data Wrangling)

One of the first steps in analyzing and processing data is missing data processing, where missing data
is usually represented as `null` values. So, every `IEnumerable<Nullable<T>>` must be converted/transformed 
to  `IEnumerable<T>` prior to further analysis and processing.


## Comparison

*   Octave

    *   https://www.gnu.org/software/octave/doc/v4.0.1/Descriptive-Statistics.html#Descriptive-Statistics



## TODOs / Plans

*   API

    *   flexible API for Skewness and Kurtosis

*   testing

    *   unit testing

        *   Moments

        *   Dispersion

*   C# 7.2 

    stub already in : `tests/unit-tests/UnitTests.CommonShared/Sync/DarkVaderTests/Tests20180119Dataset01/Tests011MeacuresCentralTendencies.MeanArithmetic.cs`

    *   `Span<T>`, 

    *   `ReadOnlySpan<T>`, 

    *   `Memory<T>`,

    *   `ReadOnlyMemory<T>`


*   optimizations

    *   data caching

        reuse of precalculated values

    *   `async`/`await` tuning

    *   parallel algorithms (separate repo/nuget)

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

    *   http://calculator.vhex.net/function-index/statistics

    *   https://www.wessa.net/rwasp_correlation.wasp#output

    *   https://www.numberempire.com/statisticscalculator.php

    *   https://www.easycalculation.com/statistics/statistics.php

    *   http://www.calculator.net/statistics-calculator.html

    *   http://www.alcula.com/calculators/statistics/

    *   https://www.mathportal.org/calculators/statistics-calculator/descriptive-statistics-calculator.php

    *   http://powerandsamplesize.com/Calculators/

    *   https://www.miniwebtool.com/root-mean-square-calculator/

    *   http://elsenaju.eu/Calculator/mean-value-calculator.htm

    *   https://www.calculatorsoup.com/calculators/statistics/index.php

    *   http://www.socscistatistics.com/tests/

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


## Authors / Contributirs

*   Authors

    *   Darko Katovic - Katodix

        KIF (Faculty of Kinesiology, University of Zagreb, Croatia)

    *   Miljenko Cvjetko - moljac
        
        Microsoft (Xamarin Inc.), HolisticWare
