``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.4 (17E202) [Darwin 17.5.0]
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 32bit 
  DefaultJob : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 64bit 


```
|                                      Method |        Mean |      Error |    StdDev |
|-------------------------------------------- |------------:|-----------:|----------:|
|                        Array_MeanArithmetic |    580.2 ns |   1.469 ns |  1.302 ns |
|                 ArraySegment_MeanArithmetic |    378.6 ns |   2.050 ns |  1.917 ns |
|                         List_MeanArithmetic |    417.6 ns |   1.584 ns |  1.482 ns |
|                        Queue_MeanArithmetic |    514.1 ns |   1.360 ns |  1.206 ns |
|                        Stack_MeanArithmetic |    544.9 ns |   2.119 ns |  1.878 ns |
|                   LinkedList_MeanArithmetic |    471.3 ns |   1.354 ns |  1.200 ns |
|         ObservableCollection_MeanArithmetic |    420.3 ns |   1.962 ns |  1.836 ns |
|                Array_MeanArithmeticWeighted |  1,027.8 ns |   6.260 ns |  5.549 ns |
|         ArraySegment_MeanArithmeticWeighted |  1,016.1 ns |   3.675 ns |  3.068 ns |
|                 List_MeanArithmeticWeighted |    953.1 ns |   7.559 ns |  7.070 ns |
|                Queue_MeanArithmeticWeighted | 13,198.4 ns |  78.001 ns | 69.146 ns |
|                Stack_MeanArithmeticWeighted | 13,068.7 ns |  79.241 ns | 66.170 ns |
|           LinkedList_MeanArithmeticWeighted | 12,046.7 ns |  78.910 ns | 73.813 ns |
| ObservableCollection_MeanArithmeticWeighted |  1,071.8 ns |   5.625 ns |  5.262 ns |
|                         Array_MeanGeometric |    558.9 ns |   2.386 ns |  2.115 ns |
|                  ArraySegment_MeanGeometric |    553.3 ns |   3.391 ns |  3.172 ns |
|                          List_MeanGeometric |    517.1 ns |   2.515 ns |  2.352 ns |
|                         Queue_MeanGeometric | 11,802.7 ns |  38.042 ns | 31.767 ns |
|                         Stack_MeanGeometric | 11,284.7 ns | 100.609 ns | 94.110 ns |
|                    LinkedList_MeanGeometric | 12,534.6 ns |  52.423 ns | 49.036 ns |
|          ObservableCollection_MeanGeometric |    598.3 ns |   3.253 ns |  3.043 ns |
|                 Array_MeanGeometricWeighted |  1,853.4 ns |   8.750 ns |  8.185 ns |
|          ArraySegment_MeanGeometricWeighted |  1,780.4 ns |   7.198 ns |  6.733 ns |
|                  List_MeanGeometricWeighted |  1,698.8 ns |  10.157 ns |  9.500 ns |
|                 Queue_MeanGeometricWeighted | 13,819.2 ns |  31.087 ns | 25.959 ns |
|                 Stack_MeanGeometricWeighted | 13,752.4 ns |  25.500 ns | 19.908 ns |
|            LinkedList_MeanGeometricWeighted | 13,410.0 ns |  32.799 ns | 30.680 ns |
|  ObservableCollection_MeanGeometricWeighted |  1,861.0 ns |   9.168 ns |  8.576 ns |
|                          Array_MeanHarmonic |    540.2 ns |   4.037 ns |  3.777 ns |
|                   ArraySegment_MeanHarmonic |    529.6 ns |   2.653 ns |  2.482 ns |
|                           List_MeanHarmonic |    537.3 ns |   1.541 ns |  1.366 ns |
|                          Queue_MeanHarmonic | 12,168.5 ns |  62.180 ns | 58.163 ns |
|                          Stack_MeanHarmonic | 11,236.7 ns |  64.636 ns | 60.461 ns |
|                     LinkedList_MeanHarmonic | 11,699.6 ns |  34.469 ns | 32.243 ns |
|           ObservableCollection_MeanHarmonic |    612.4 ns |   2.873 ns |  2.547 ns |
|                  Array_MeanHarmonicWeighted |  1,027.9 ns |   4.905 ns |  4.588 ns |
|           ArraySegment_MeanHarmonicWeighted |  1,019.0 ns |   3.598 ns |  3.366 ns |
|                   List_MeanHarmonicWeighted |    946.6 ns |   4.658 ns |  4.357 ns |
|                  Queue_MeanHarmonicWeighted | 13,098.2 ns |  40.195 ns | 35.632 ns |
|                  Stack_MeanHarmonicWeighted | 12,730.7 ns |  49.210 ns | 46.031 ns |
|             LinkedList_MeanHarmonicWeighted | 11,949.3 ns |  47.662 ns | 44.583 ns |
|   ObservableCollection_MeanHarmonicWeighted |  1,066.8 ns |   5.140 ns |  4.808 ns |
|                                 Array_Modes |  9,000.3 ns |  23.216 ns | 21.717 ns |
|                          ArraySegment_Modes |  8,960.8 ns |  39.454 ns | 36.906 ns |
|                                  List_Modes |  8,878.6 ns |  33.223 ns | 31.077 ns |
|                                 Queue_Modes | 21,769.0 ns |  42.839 ns | 30.976 ns |
|                                 Stack_Modes | 21,615.7 ns |  76.564 ns | 71.618 ns |
|                            LinkedList_Modes | 20,757.9 ns |  75.500 ns | 70.622 ns |
|                  ObservableCollection_Modes |  9,060.1 ns |  33.756 ns | 29.924 ns |
|                           Array_Frequencies |  3,922.9 ns |  24.138 ns | 22.579 ns |
|                    ArraySegment_Frequencies |  3,758.6 ns |  22.354 ns | 19.817 ns |
|                            List_Frequencies |  3,785.4 ns |  22.351 ns | 20.907 ns |
|                           Queue_Frequencies | 15,979.6 ns |  95.964 ns | 89.765 ns |
|                           Stack_Frequencies | 15,096.6 ns |  88.996 ns | 78.892 ns |
|                      LinkedList_Frequencies | 15,661.2 ns |  95.205 ns | 89.054 ns |
|            ObservableCollection_Frequencies |  4,003.2 ns |  20.737 ns | 18.383 ns |
|                 Array_FrequencyDistribution |  3,907.0 ns |  10.747 ns |  9.527 ns |
|          ArraySegment_FrequencyDistribution |  3,803.5 ns |  11.064 ns | 10.349 ns |
|                  List_FrequencyDistribution |  3,741.0 ns |  11.515 ns | 10.772 ns |
|                 Queue_FrequencyDistribution | 15,939.1 ns |  67.841 ns | 63.459 ns |
|                 Stack_FrequencyDistribution | 15,075.9 ns |  51.167 ns | 47.861 ns |
|            LinkedList_FrequencyDistribution | 15,668.0 ns |  60.427 ns | 53.567 ns |
|  ObservableCollection_FrequencyDistribution |  4,005.0 ns |  10.558 ns |  9.876 ns |
|                                   Array_Max |    654.6 ns |   2.284 ns |  2.137 ns |
|                            ArraySegment_Max |    373.4 ns |   1.437 ns |  1.274 ns |
|                                    List_Max |    488.0 ns |   3.044 ns |  2.847 ns |
|                                   Queue_Max |    579.2 ns |   2.687 ns |  2.513 ns |
|                                   Stack_Max |    558.4 ns |   3.433 ns |  3.211 ns |
|                              LinkedList_Max |    534.6 ns |   3.509 ns |  3.283 ns |
|                    ObservableCollection_Max |    479.7 ns |   2.093 ns |  1.958 ns |
|                                   Array_Min |    810.3 ns |   3.710 ns |  3.471 ns |
|                            ArraySegment_Min |    557.7 ns |   1.962 ns |  1.835 ns |
|                                    List_Min |    662.8 ns |   2.286 ns |  2.138 ns |
|                                   Queue_Min |    734.4 ns |   2.964 ns |  2.772 ns |
|                                   Stack_Min |    687.8 ns |   2.529 ns |  2.242 ns |
|                              LinkedList_Min |    673.7 ns |   2.849 ns |  2.665 ns |
|                    ObservableCollection_Min |    644.8 ns |   2.593 ns |  2.425 ns |
|                                 Array_Range |          NA |         NA |        NA |
|                          ArraySegment_Range |          NA |         NA |        NA |
|                                  List_Range |          NA |         NA |        NA |
|                                 Queue_Range |          NA |         NA |        NA |
|                                 Stack_Range |          NA |         NA |        NA |
|                            LinkedList_Range |          NA |         NA |        NA |
|                  ObservableCollection_Range |          NA |         NA |        NA |
|                             Array_MeanCubic |    576.3 ns |   2.420 ns |  2.264 ns |
|                      ArraySegment_MeanCubic |    572.1 ns |   2.838 ns |  2.655 ns |
|                              List_MeanCubic |    521.1 ns |   3.117 ns |  2.915 ns |
|                             Queue_MeanCubic | 11,774.9 ns |  78.125 ns | 69.255 ns |
|                             Stack_MeanCubic | 11,467.7 ns |  36.192 ns | 32.083 ns |
|                        LinkedList_MeanCubic | 12,508.0 ns |  35.662 ns | 31.613 ns |
|              ObservableCollection_MeanCubic |    732.0 ns |   2.759 ns |  2.581 ns |
|                    Array_MeanGeneralized_20 |  2,571.5 ns |  14.114 ns | 13.202 ns |
|             ArraySegment_MeanGeneralized_20 |  2,546.5 ns |  12.309 ns | 10.911 ns |
|                     List_MeanGeneralized_20 |  2,526.2 ns |  11.350 ns | 10.617 ns |
|                    Queue_MeanGeneralized_20 | 14,243.7 ns |  68.249 ns | 60.501 ns |
|                    Stack_MeanGeneralized_20 | 14,063.4 ns |  52.400 ns | 49.015 ns |
|               LinkedList_MeanGeneralized_20 | 14,274.7 ns |  39.492 ns | 36.941 ns |
|     ObservableCollection_MeanGeneralized_20 |  2,608.9 ns |   7.433 ns |  6.952 ns |
|                    Array_MeanGeneralized_30 |  2,569.9 ns |  16.905 ns | 15.813 ns |
|             ArraySegment_MeanGeneralized_30 |  2,536.5 ns |  12.531 ns | 11.721 ns |
|                     List_MeanGeneralized_30 |  2,517.6 ns |   6.624 ns |  6.196 ns |
|                    Queue_MeanGeneralized_30 | 14,238.0 ns |  51.758 ns | 45.882 ns |
|                    Stack_MeanGeneralized_30 | 14,025.7 ns |  66.979 ns | 62.653 ns |
|               LinkedList_MeanGeneralized_30 | 14,262.1 ns |  53.577 ns | 47.495 ns |
|     ObservableCollection_MeanGeneralized_30 |  2,613.5 ns |  14.498 ns | 12.852 ns |
|                         Array_MeanQuadratic |    576.0 ns |   2.768 ns |  2.311 ns |
|                  ArraySegment_MeanQuadratic |    568.1 ns |   2.686 ns |  2.381 ns |
|                          List_MeanQuadratic |    525.8 ns |   1.147 ns |  1.016 ns |
|                         Queue_MeanQuadratic | 12,568.5 ns |  55.326 ns | 51.752 ns |
|                         Stack_MeanQuadratic | 12,560.7 ns |  30.021 ns | 25.069 ns |
|                    LinkedList_MeanQuadratic | 11,857.2 ns |  64.813 ns | 60.626 ns |
|          ObservableCollection_MeanQuadratic |    611.5 ns |   2.311 ns |  1.930 ns |
|                          Array_MeanWeighted |          NA |         NA |        NA |
|                   ArraySegment_MeanWeighted |          NA |         NA |        NA |
|                           List_MeanWeighted |          NA |         NA |        NA |
|                          Queue_MeanWeighted |          NA |         NA |        NA |
|                          Stack_MeanWeighted |          NA |         NA |        NA |
|                     LinkedList_MeanWeighted |          NA |         NA |        NA |
|           ObservableCollection_MeanWeighted |          NA |         NA |        NA |
|                                Array_Median |  5,107.3 ns |  15.798 ns | 13.192 ns |
|                         ArraySegment_Median |  5,131.7 ns |  37.144 ns | 34.744 ns |
|                                 List_Median |  5,203.4 ns |  26.091 ns | 24.405 ns |
|                                Queue_Median |  6,684.1 ns |  38.521 ns | 36.033 ns |
|                                Stack_Median |  6,646.9 ns |  22.661 ns | 21.197 ns |
|                           LinkedList_Median |  5,185.7 ns |  25.042 ns | 23.424 ns |
|                 ObservableCollection_Median |  5,153.9 ns |  19.566 ns | 18.302 ns |

Benchmarks with issues:
  Tests20180119Dataset02.Array_Range: DefaultJob
  Tests20180119Dataset02.ArraySegment_Range: DefaultJob
  Tests20180119Dataset02.List_Range: DefaultJob
  Tests20180119Dataset02.Queue_Range: DefaultJob
  Tests20180119Dataset02.Stack_Range: DefaultJob
  Tests20180119Dataset02.LinkedList_Range: DefaultJob
  Tests20180119Dataset02.ObservableCollection_Range: DefaultJob
  Tests20180119Dataset02.Array_MeanWeighted: DefaultJob
  Tests20180119Dataset02.ArraySegment_MeanWeighted: DefaultJob
  Tests20180119Dataset02.List_MeanWeighted: DefaultJob
  Tests20180119Dataset02.Queue_MeanWeighted: DefaultJob
  Tests20180119Dataset02.Stack_MeanWeighted: DefaultJob
  Tests20180119Dataset02.LinkedList_MeanWeighted: DefaultJob
  Tests20180119Dataset02.ObservableCollection_MeanWeighted: DefaultJob
