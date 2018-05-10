``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.4 (17E202) [Darwin 17.5.0]
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]   : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 32bit 
  ShortRun : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 64bit 

Job=ShortRun  LaunchCount=1  TargetCount=3  
WarmupCount=3  

```
|                                      Method |        Mean |         Error |     StdDev |
|-------------------------------------------- |------------:|--------------:|-----------:|
|                        Array_MeanArithmetic |   123.83 ns |    18.2327 ns |  1.0302 ns |
|                 ArraySegment_MeanArithmetic |    96.06 ns |     4.5006 ns |  0.2543 ns |
|                         List_MeanArithmetic |   108.66 ns |   175.5929 ns |  9.9213 ns |
|                        Queue_MeanArithmetic |   121.31 ns |    14.7830 ns |  0.8353 ns |
|                        Stack_MeanArithmetic |   119.77 ns |    70.2369 ns |  3.9685 ns |
|                   LinkedList_MeanArithmetic |   108.05 ns |     7.6379 ns |  0.4316 ns |
|         ObservableCollection_MeanArithmetic |    98.66 ns |    36.1508 ns |  2.0426 ns |
|                         Array_MeanGeometric |   143.43 ns |    38.8256 ns |  2.1937 ns |
|                  ArraySegment_MeanGeometric |   151.17 ns |    11.6997 ns |  0.6611 ns |
|                          List_MeanGeometric |   134.19 ns |     1.8869 ns |  0.1066 ns |
|                         Queue_MeanGeometric |   726.86 ns |    15.9748 ns |  0.9026 ns |
|                         Stack_MeanGeometric |   695.00 ns |    96.7636 ns |  5.4673 ns |
|                    LinkedList_MeanGeometric |   725.12 ns |   242.6878 ns | 13.7123 ns |
|          ObservableCollection_MeanGeometric |   149.43 ns |    12.3927 ns |  0.7002 ns |
|                          Array_MeanHarmonic |   102.69 ns |    16.3494 ns |  0.9238 ns |
|                   ArraySegment_MeanHarmonic |   113.88 ns |    17.8395 ns |  1.0080 ns |
|                           List_MeanHarmonic |   109.41 ns |    29.1040 ns |  1.6444 ns |
|                          Queue_MeanHarmonic |   717.69 ns |   348.4144 ns | 19.6861 ns |
|                          Stack_MeanHarmonic |   640.30 ns |    31.6875 ns |  1.7904 ns |
|                     LinkedList_MeanHarmonic |   679.49 ns |    66.0885 ns |  3.7341 ns |
|           ObservableCollection_MeanHarmonic |   121.92 ns |    57.3535 ns |  3.2406 ns |
|                Array_MeanArithmeticWeighted |   192.14 ns |    21.2144 ns |  1.1987 ns |
|         ArraySegment_MeanArithmeticWeighted |   225.41 ns |   146.1970 ns |  8.2604 ns |
|                 List_MeanArithmeticWeighted |   185.14 ns |    59.6696 ns |  3.3714 ns |
|                Queue_MeanArithmeticWeighted |   794.93 ns |   194.6305 ns | 10.9970 ns |
|                Stack_MeanArithmeticWeighted |   848.50 ns | 1,156.0653 ns | 65.3198 ns |
|           LinkedList_MeanArithmeticWeighted |   796.27 ns |    75.8342 ns |  4.2848 ns |
| ObservableCollection_MeanArithmeticWeighted |   222.64 ns |    94.4209 ns |  5.3350 ns |
|                 Array_MeanGeometricWeighted |   335.27 ns |    15.1184 ns |  0.8542 ns |
|          ArraySegment_MeanGeometricWeighted |   350.83 ns |    56.3872 ns |  3.1860 ns |
|                  List_MeanGeometricWeighted |   333.08 ns |    33.8641 ns |  1.9134 ns |
|                 Queue_MeanGeometricWeighted |   965.73 ns |    51.2878 ns |  2.8979 ns |
|                 Stack_MeanGeometricWeighted |   935.12 ns |   101.4262 ns |  5.7308 ns |
|            LinkedList_MeanGeometricWeighted |   976.54 ns |   128.5412 ns |  7.2628 ns |
|  ObservableCollection_MeanGeometricWeighted |   355.68 ns |   122.9670 ns |  6.9479 ns |
|                  Array_MeanHarmonicWeighted |   190.77 ns |    31.3847 ns |  1.7733 ns |
|           ArraySegment_MeanHarmonicWeighted |   197.89 ns |    13.5260 ns |  0.7642 ns |
|                   List_MeanHarmonicWeighted |   178.11 ns |    11.9188 ns |  0.6734 ns |
|                  Queue_MeanHarmonicWeighted |   787.50 ns |    93.2050 ns |  5.2663 ns |
|                  Stack_MeanHarmonicWeighted |   754.79 ns |   105.0185 ns |  5.9337 ns |
|             LinkedList_MeanHarmonicWeighted |   802.83 ns |    63.7063 ns |  3.5995 ns |
|   ObservableCollection_MeanHarmonicWeighted |   197.05 ns |    17.5576 ns |  0.9920 ns |
|                           Array_Frequencies |   668.44 ns |   113.6439 ns |  6.4211 ns |
|                    ArraySegment_Frequencies |   656.91 ns |    12.9052 ns |  0.7292 ns |
|                            List_Frequencies |   657.55 ns |   131.4302 ns |  7.4261 ns |
|                           Queue_Frequencies | 1,419.86 ns |   654.5348 ns | 36.9824 ns |
|                           Stack_Frequencies | 1,341.75 ns | 1,369.4972 ns | 77.3791 ns |
|                      LinkedList_Frequencies | 1,509.09 ns |   149.9607 ns |  8.4731 ns |
|            ObservableCollection_Frequencies |   700.90 ns |   105.8119 ns |  5.9786 ns |
|                                 Array_Modes | 1,288.19 ns |   108.7485 ns |  6.1445 ns |
|                          ArraySegment_Modes | 1,281.01 ns |   140.7154 ns |  7.9507 ns |
|                                  List_Modes | 1,273.32 ns |    57.0005 ns |  3.2206 ns |
|                                 Queue_Modes | 1,921.01 ns |   114.2775 ns |  6.4569 ns |
|                                 Stack_Modes | 1,873.95 ns |    75.4352 ns |  4.2622 ns |
|                            LinkedList_Modes | 1,891.55 ns |   102.8896 ns |  5.8135 ns |
|                  ObservableCollection_Modes | 1,605.45 ns |   116.5792 ns |  6.5869 ns |
|                 Array_FrequencyDistribution |   657.57 ns |    42.9451 ns |  2.4265 ns |
|          ArraySegment_FrequencyDistribution |   648.36 ns |    38.3747 ns |  2.1682 ns |
|                  List_FrequencyDistribution |   651.04 ns |    17.4640 ns |  0.9867 ns |
|                 Queue_FrequencyDistribution | 1,286.56 ns |    17.4379 ns |  0.9853 ns |
|                 Stack_FrequencyDistribution | 1,242.57 ns |    99.8110 ns |  5.6395 ns |
|            LinkedList_FrequencyDistribution | 1,269.63 ns |    56.3191 ns |  3.1821 ns |
|  ObservableCollection_FrequencyDistribution |   681.19 ns |    85.6119 ns |  4.8372 ns |
|                                   Array_Max |   107.26 ns |     8.1772 ns |  0.4620 ns |
|                            ArraySegment_Max |    87.27 ns |     3.3475 ns |  0.1891 ns |
|                                    List_Max |    94.12 ns |     2.6546 ns |  0.1500 ns |
|                                   Queue_Max |   106.88 ns |     1.3028 ns |  0.0736 ns |
|                                   Stack_Max |   111.82 ns |     4.9989 ns |  0.2824 ns |
|                              LinkedList_Max |   101.33 ns |     3.7247 ns |  0.2105 ns |
|                    ObservableCollection_Max |    94.12 ns |     3.4609 ns |  0.1955 ns |
|                                   Array_Min |   116.79 ns |     7.5340 ns |  0.4257 ns |
|                            ArraySegment_Min |    86.33 ns |     0.8910 ns |  0.0503 ns |
|                                    List_Min |    98.02 ns |     3.7636 ns |  0.2127 ns |
|                                   Queue_Min |   115.40 ns |    16.8698 ns |  0.9532 ns |
|                                   Stack_Min |    98.99 ns |     7.7838 ns |  0.4398 ns |
|                              LinkedList_Min |   100.14 ns |    32.9027 ns |  1.8591 ns |
|                    ObservableCollection_Min |    96.57 ns |     5.0366 ns |  0.2846 ns |
|                                 Array_Range |          NA |            NA |         NA |
|                          ArraySegment_Range |          NA |            NA |         NA |
|                                  List_Range |          NA |            NA |         NA |
|                                 Queue_Range |          NA |            NA |         NA |
|                                 Stack_Range |          NA |            NA |         NA |
|                            LinkedList_Range |          NA |            NA |         NA |
|                  ObservableCollection_Range |          NA |            NA |         NA |
|                             Array_MeanCubic |   140.18 ns |     9.5476 ns |  0.5395 ns |
|                      ArraySegment_MeanCubic |   150.54 ns |    18.3097 ns |  1.0345 ns |
|                              List_MeanCubic |   138.30 ns |    21.8618 ns |  1.2352 ns |
|                             Queue_MeanCubic |   717.85 ns |    40.8541 ns |  2.3083 ns |
|                             Stack_MeanCubic |   684.87 ns |    69.2556 ns |  3.9131 ns |
|                        LinkedList_MeanCubic |   701.72 ns |    47.0904 ns |  2.6607 ns |
|              ObservableCollection_MeanCubic |   150.59 ns |     5.4100 ns |  0.3057 ns |
|                    Array_MeanGeneralized_20 |   435.04 ns |    25.0466 ns |  1.4152 ns |
|             ArraySegment_MeanGeneralized_20 |   441.86 ns |    26.3172 ns |  1.4870 ns |
|                     List_MeanGeneralized_20 |   431.12 ns |    30.8192 ns |  1.7413 ns |
|                    Queue_MeanGeneralized_20 | 1,009.45 ns |    10.5362 ns |  0.5953 ns |
|                    Stack_MeanGeneralized_20 |   984.12 ns |   242.0986 ns | 13.6790 ns |
|               LinkedList_MeanGeneralized_20 | 1,034.67 ns |    48.5808 ns |  2.7449 ns |
|     ObservableCollection_MeanGeneralized_20 |   442.40 ns |     6.1777 ns |  0.3490 ns |
|                    Array_MeanGeneralized_30 |   434.78 ns |    33.9912 ns |  1.9206 ns |
|             ArraySegment_MeanGeneralized_30 |   439.91 ns |    22.9831 ns |  1.2986 ns |
|                     List_MeanGeneralized_30 |   432.36 ns |     9.4037 ns |  0.5313 ns |
|                    Queue_MeanGeneralized_30 | 1,010.69 ns |    62.8540 ns |  3.5514 ns |
|                    Stack_MeanGeneralized_30 |   981.25 ns |   132.4993 ns |  7.4865 ns |
|               LinkedList_MeanGeneralized_30 | 1,030.17 ns |    74.4364 ns |  4.2058 ns |
|     ObservableCollection_MeanGeneralized_30 |   443.24 ns |    51.4804 ns |  2.9087 ns |
|                         Array_MeanQuadratic |   138.58 ns |     1.7761 ns |  0.1004 ns |
|                  ArraySegment_MeanQuadratic |   149.07 ns |     5.0203 ns |  0.2837 ns |
|                          List_MeanQuadratic |   143.66 ns |     6.8955 ns |  0.3896 ns |
|                         Queue_MeanQuadratic |   719.52 ns |    24.0179 ns |  1.3571 ns |
|                         Stack_MeanQuadratic |   685.96 ns |    25.0623 ns |  1.4161 ns |
|                    LinkedList_MeanQuadratic |   703.81 ns |    89.4155 ns |  5.0521 ns |
|          ObservableCollection_MeanQuadratic |   149.19 ns |     2.6028 ns |  0.1471 ns |
|                          Array_MeanWeighted |   178.65 ns |    17.0580 ns |  0.9638 ns |
|                   ArraySegment_MeanWeighted |   192.24 ns |    48.3631 ns |  2.7326 ns |
|                           List_MeanWeighted |   170.14 ns |     6.5485 ns |  0.3700 ns |
|                          Queue_MeanWeighted |   731.71 ns |    62.6656 ns |  3.5407 ns |
|                          Stack_MeanWeighted | 2,177.43 ns |   464.5533 ns | 26.2481 ns |
|                     LinkedList_MeanWeighted |   784.27 ns |    32.4207 ns |  1.8318 ns |
|           ObservableCollection_MeanWeighted |   189.99 ns |    19.5456 ns |  1.1044 ns |
|                                Array_Median |   688.92 ns |    96.8756 ns |  5.4737 ns |
|                         ArraySegment_Median |   687.89 ns |    50.3429 ns |  2.8445 ns |
|                                 List_Median |   680.07 ns |    33.8892 ns |  1.9148 ns |
|                                Queue_Median | 1,078.95 ns |    54.4081 ns |  3.0742 ns |
|                                Stack_Median | 1,082.82 ns |    61.9865 ns |  3.5023 ns |
|                           LinkedList_Median |   640.05 ns |    48.5279 ns |  2.7419 ns |
|                 ObservableCollection_Median |   682.46 ns |    33.6618 ns |  1.9020 ns |

Benchmarks with issues:
  Tests20180119Dataset01.Array_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
  Tests20180119Dataset01.ArraySegment_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
  Tests20180119Dataset01.List_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
  Tests20180119Dataset01.Queue_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
  Tests20180119Dataset01.Stack_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
  Tests20180119Dataset01.LinkedList_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
  Tests20180119Dataset01.ObservableCollection_Range: ShortRun(LaunchCount=1, TargetCount=3, WarmupCount=3)
