``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.4 (17E202) [Darwin 17.5.0]
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 32bit 
  DefaultJob : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 64bit 


```
|                                      Method |        Mean |      Error |      StdDev |
|-------------------------------------------- |------------:|-----------:|------------:|
|                        Array_MeanArithmetic |    541.1 ns |   3.468 ns |   3.0740 ns |
|                 ArraySegment_MeanArithmetic |    364.0 ns |   1.483 ns |   1.3146 ns |
|                         List_MeanArithmetic |    418.0 ns |   1.470 ns |   1.3753 ns |
|                        Queue_MeanArithmetic |    505.5 ns |   1.796 ns |   1.4996 ns |
|                        Stack_MeanArithmetic |    474.0 ns |   1.478 ns |   1.2345 ns |
|                   LinkedList_MeanArithmetic |    474.9 ns |   1.983 ns |   1.8545 ns |
|         ObservableCollection_MeanArithmetic |    437.9 ns |   2.357 ns |   2.2052 ns |
|                Array_MeanArithmeticWeighted |  1,016.6 ns |   6.732 ns |   6.2969 ns |
|         ArraySegment_MeanArithmeticWeighted |  1,000.0 ns |   3.569 ns |   3.3385 ns |
|                 List_MeanArithmeticWeighted |    953.3 ns |   4.429 ns |   3.6982 ns |
|                Queue_MeanArithmeticWeighted | 13,481.3 ns |  94.431 ns |  88.3305 ns |
|                Stack_MeanArithmeticWeighted | 12,511.3 ns |  88.353 ns |  82.6456 ns |
|           LinkedList_MeanArithmeticWeighted | 12,116.7 ns |  46.383 ns |  43.3869 ns |
| ObservableCollection_MeanArithmeticWeighted |  1,172.7 ns |   8.108 ns |   7.1877 ns |
|                         Array_MeanGeometric |    564.9 ns |   3.048 ns |   2.8512 ns |
|                  ArraySegment_MeanGeometric |    554.6 ns |   2.251 ns |   2.1053 ns |
|                          List_MeanGeometric |    504.6 ns |   1.567 ns |   1.3082 ns |
|                         Queue_MeanGeometric | 11,451.3 ns |  56.447 ns |  52.8007 ns |
|                         Stack_MeanGeometric | 11,354.5 ns |  59.828 ns |  55.9628 ns |
|                    LinkedList_MeanGeometric | 10,724.0 ns |  34.418 ns |  30.5102 ns |
|          ObservableCollection_MeanGeometric |    613.1 ns |   3.094 ns |   2.7428 ns |
|                 Array_MeanGeometricWeighted |  1,828.9 ns |   8.300 ns |   7.7637 ns |
|          ArraySegment_MeanGeometricWeighted |  1,792.9 ns |   8.888 ns |   8.3140 ns |
|                  List_MeanGeometricWeighted |  1,681.7 ns |   4.677 ns |   4.3753 ns |
|                 Queue_MeanGeometricWeighted | 13,088.0 ns |  33.062 ns |  27.6084 ns |
|                 Stack_MeanGeometricWeighted | 12,873.4 ns |  46.423 ns |  41.1528 ns |
|            LinkedList_MeanGeometricWeighted | 12,376.3 ns |  56.534 ns |  52.8823 ns |
|  ObservableCollection_MeanGeometricWeighted |  1,862.0 ns |   4.767 ns |   3.7218 ns |
|                          Array_MeanHarmonic |    538.6 ns |   3.056 ns |   2.8584 ns |
|                   ArraySegment_MeanHarmonic |    538.7 ns |   3.262 ns |   3.0517 ns |
|                           List_MeanHarmonic |    568.9 ns |   1.563 ns |   1.4620 ns |
|                          Queue_MeanHarmonic | 12,524.7 ns |  45.529 ns |  42.5875 ns |
|                          Stack_MeanHarmonic | 12,227.6 ns |  30.397 ns |  26.9465 ns |
|                     LinkedList_MeanHarmonic | 11,596.4 ns |  45.458 ns |  40.2970 ns |
|           ObservableCollection_MeanHarmonic |    576.2 ns |   2.494 ns |   2.3325 ns |
|                  Array_MeanHarmonicWeighted |  1,026.9 ns |   3.737 ns |   3.3131 ns |
|           ArraySegment_MeanHarmonicWeighted |  1,014.2 ns |   6.583 ns |   6.1575 ns |
|                   List_MeanHarmonicWeighted |    994.1 ns |   5.933 ns |   5.5496 ns |
|                  Queue_MeanHarmonicWeighted | 13,547.2 ns |  59.158 ns |  55.3363 ns |
|                  Stack_MeanHarmonicWeighted | 12,804.1 ns |  57.535 ns |  53.8180 ns |
|             LinkedList_MeanHarmonicWeighted | 12,188.5 ns |  46.788 ns |  39.0701 ns |
|   ObservableCollection_MeanHarmonicWeighted |  1,104.6 ns |   5.017 ns |   4.4476 ns |
|                                 Array_Modes |  5,280.8 ns |  28.326 ns |  26.4959 ns |
|                          ArraySegment_Modes |  5,073.1 ns |  27.532 ns |  25.7531 ns |
|                                  List_Modes |  5,133.2 ns |  27.755 ns |  25.9616 ns |
|                                 Queue_Modes | 16,678.6 ns |  73.877 ns |  69.1047 ns |
|                                 Stack_Modes | 16,521.0 ns | 270.442 ns | 225.8316 ns |
|                            LinkedList_Modes | 16,748.5 ns |  55.220 ns |  43.1125 ns |
|                  ObservableCollection_Modes |  5,351.8 ns |  21.145 ns |  19.7793 ns |
|                           Array_Frequencies |  3,663.3 ns |   9.315 ns |   7.2725 ns |
|                    ArraySegment_Frequencies |  3,550.2 ns |  12.153 ns |  11.3684 ns |
|                            List_Frequencies |  3,534.2 ns |  15.543 ns |  14.5389 ns |
|                           Queue_Frequencies | 16,306.0 ns | 143.391 ns | 127.1120 ns |
|                           Stack_Frequencies | 15,649.9 ns |  81.080 ns |  75.8425 ns |
|                      LinkedList_Frequencies | 15,211.4 ns |  54.979 ns |  51.4276 ns |
|            ObservableCollection_Frequencies |  3,790.1 ns |  20.552 ns |  19.2247 ns |
|                 Array_FrequencyDistribution |  3,675.8 ns |  12.399 ns |  11.5980 ns |
|          ArraySegment_FrequencyDistribution |  3,585.7 ns |  20.212 ns |  18.9059 ns |
|                  List_FrequencyDistribution |  3,588.5 ns |  20.495 ns |  19.1710 ns |
|                 Queue_FrequencyDistribution | 16,233.7 ns |  97.842 ns |  86.7348 ns |
|                 Stack_FrequencyDistribution | 15,798.5 ns | 110.408 ns |  97.8741 ns |
|            LinkedList_FrequencyDistribution | 15,269.8 ns | 106.325 ns |  99.4569 ns |
|  ObservableCollection_FrequencyDistribution |  3,810.3 ns |  17.096 ns |  15.9915 ns |
|                                   Array_Max |    582.9 ns |   1.891 ns |   1.4766 ns |
|                            ArraySegment_Max |    367.0 ns |   1.913 ns |   1.6962 ns |
|                                    List_Max |    447.7 ns |   1.367 ns |   1.2784 ns |
|                                   Queue_Max |    549.9 ns |   2.532 ns |   2.3685 ns |
|                                   Stack_Max |    540.2 ns |   1.847 ns |   1.6370 ns |
|                              LinkedList_Max |    500.5 ns |   2.936 ns |   2.7460 ns |
|                    ObservableCollection_Max |    458.8 ns |   1.211 ns |   1.0735 ns |
|                                   Array_Min |    570.2 ns |   1.454 ns |   1.1353 ns |
|                            ArraySegment_Min |    367.3 ns |   1.941 ns |   1.8154 ns |
|                                    List_Min |    439.7 ns |   1.540 ns |   1.2860 ns |
|                                   Queue_Min |    532.2 ns |   3.988 ns |   3.7304 ns |
|                                   Stack_Min |    538.0 ns |   2.643 ns |   2.4721 ns |
|                              LinkedList_Min |    481.8 ns |   1.961 ns |   1.6378 ns |
|                    ObservableCollection_Min |    451.6 ns |   1.056 ns |   0.9361 ns |
|                                 Array_Range |          NA |         NA |          NA |
|                          ArraySegment_Range |          NA |         NA |          NA |
|                                  List_Range |          NA |         NA |          NA |
|                                 Queue_Range |          NA |         NA |          NA |
|                                 Stack_Range |          NA |         NA |          NA |
|                            LinkedList_Range |          NA |         NA |          NA |
|                  ObservableCollection_Range |          NA |         NA |          NA |
|                             Array_MeanCubic |    578.6 ns |   2.384 ns |   2.2302 ns |
|                      ArraySegment_MeanCubic |    572.1 ns |   2.647 ns |   2.3467 ns |
|                              List_MeanCubic |    523.4 ns |   3.459 ns |   2.8881 ns |
|                             Queue_MeanCubic | 11,504.8 ns |  65.903 ns |  61.6460 ns |
|                             Stack_MeanCubic | 11,422.7 ns |  64.118 ns |  59.9757 ns |
|                        LinkedList_MeanCubic | 10,785.4 ns |  91.008 ns |  85.1294 ns |
|              ObservableCollection_MeanCubic |    633.8 ns |   3.093 ns |   2.8935 ns |
|                    Array_MeanGeneralized_20 |  2,908.9 ns |  14.893 ns |  13.9310 ns |
|             ArraySegment_MeanGeneralized_20 |  2,905.2 ns |   7.848 ns |   6.9567 ns |
|                     List_MeanGeneralized_20 |  2,908.5 ns |   9.242 ns |   8.6448 ns |
|                    Queue_MeanGeneralized_20 | 14,752.0 ns |  75.360 ns |  70.4914 ns |
|                    Stack_MeanGeneralized_20 | 13,487.8 ns |  58.524 ns |  54.7435 ns |
|               LinkedList_MeanGeneralized_20 | 13,927.3 ns |  29.839 ns |  24.9166 ns |
|     ObservableCollection_MeanGeneralized_20 |  2,917.7 ns |  12.813 ns |  11.9856 ns |
|                    Array_MeanGeneralized_30 |  2,902.1 ns |  12.002 ns |  11.2263 ns |
|             ArraySegment_MeanGeneralized_30 |  2,907.3 ns |  12.455 ns |  11.6507 ns |
|                     List_MeanGeneralized_30 |  2,916.6 ns |  12.104 ns |  10.7302 ns |
|                    Queue_MeanGeneralized_30 | 14,801.8 ns |  69.967 ns |  65.4469 ns |
|                    Stack_MeanGeneralized_30 | 13,516.3 ns |  47.384 ns |  42.0049 ns |
|               LinkedList_MeanGeneralized_30 | 13,930.2 ns |  46.143 ns |  40.9048 ns |
|     ObservableCollection_MeanGeneralized_30 |  2,912.0 ns |   7.711 ns |   7.2124 ns |
|                         Array_MeanQuadratic |    575.8 ns |   1.924 ns |   1.7056 ns |
|                  ArraySegment_MeanQuadratic |    570.1 ns |   2.596 ns |   2.4285 ns |
|                          List_MeanQuadratic |    556.8 ns |   2.435 ns |   2.2777 ns |
|                         Queue_MeanQuadratic | 11,475.2 ns |  50.396 ns |  47.1400 ns |
|                         Stack_MeanQuadratic | 11,340.9 ns |  57.909 ns |  54.1680 ns |
|                    LinkedList_MeanQuadratic | 10,859.9 ns |  84.006 ns |  78.5796 ns |
|          ObservableCollection_MeanQuadratic |    635.0 ns |   4.102 ns |   3.8370 ns |
|                          Array_MeanWeighted |          NA |         NA |          NA |
|                   ArraySegment_MeanWeighted |          NA |         NA |          NA |
|                           List_MeanWeighted |          NA |         NA |          NA |
|                          Queue_MeanWeighted |          NA |         NA |          NA |
|                          Stack_MeanWeighted |          NA |         NA |          NA |
|                     LinkedList_MeanWeighted |          NA |         NA |          NA |
|           ObservableCollection_MeanWeighted |          NA |         NA |          NA |
|                                Array_Median |  3,866.7 ns |  21.427 ns |  17.8925 ns |
|                         ArraySegment_Median |  3,930.1 ns |  36.683 ns |  34.3134 ns |
|                                 List_Median |  3,937.5 ns |  28.236 ns |  26.4118 ns |
|                                Queue_Median |  5,677.1 ns |  22.305 ns |  20.8641 ns |
|                                Stack_Median |  6,472.4 ns |  48.365 ns |  45.2403 ns |
|                           LinkedList_Median |  4,013.9 ns |  25.784 ns |  24.1187 ns |
|                 ObservableCollection_Median |  3,906.6 ns |  19.287 ns |  17.0973 ns |

Benchmarks with issues:
  Tests20180119Dataset03.Array_Range: DefaultJob
  Tests20180119Dataset03.ArraySegment_Range: DefaultJob
  Tests20180119Dataset03.List_Range: DefaultJob
  Tests20180119Dataset03.Queue_Range: DefaultJob
  Tests20180119Dataset03.Stack_Range: DefaultJob
  Tests20180119Dataset03.LinkedList_Range: DefaultJob
  Tests20180119Dataset03.ObservableCollection_Range: DefaultJob
  Tests20180119Dataset03.Array_MeanWeighted: DefaultJob
  Tests20180119Dataset03.ArraySegment_MeanWeighted: DefaultJob
  Tests20180119Dataset03.List_MeanWeighted: DefaultJob
  Tests20180119Dataset03.Queue_MeanWeighted: DefaultJob
  Tests20180119Dataset03.Stack_MeanWeighted: DefaultJob
  Tests20180119Dataset03.LinkedList_MeanWeighted: DefaultJob
  Tests20180119Dataset03.ObservableCollection_MeanWeighted: DefaultJob
