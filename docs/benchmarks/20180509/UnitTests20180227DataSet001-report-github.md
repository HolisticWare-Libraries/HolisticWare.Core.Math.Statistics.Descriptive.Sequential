``` ini

BenchmarkDotNet=v0.10.14, OS=macOS High Sierra 10.13.4 (17E202) [Darwin 17.5.0]
Intel Core i7-7820HQ CPU 2.90GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 32bit 
  DefaultJob : Mono 5.10.1.47 (2017-12/8eb8f7d5e74 Fri), 64bit 


```
|                                      Method |        Mean |      Error |     StdDev |
|-------------------------------------------- |------------:|-----------:|-----------:|
|                        Array_MeanArithmetic |   118.28 ns |  0.6952 ns |  0.6503 ns |
|                 ArraySegment_MeanArithmetic |    86.14 ns |  0.3699 ns |  0.3460 ns |
|                         List_MeanArithmetic |    93.68 ns |  0.3748 ns |  0.3506 ns |
|                        Queue_MeanArithmetic |   115.72 ns |  0.4723 ns |  0.4418 ns |
|                        Stack_MeanArithmetic |   110.17 ns |  0.6205 ns |  0.5804 ns |
|                   LinkedList_MeanArithmetic |   104.16 ns |  0.3275 ns |  0.2903 ns |
|         ObservableCollection_MeanArithmetic |    98.10 ns |  0.6237 ns |  0.5834 ns |
|                Array_MeanArithmeticWeighted |   187.27 ns |  0.9100 ns |  0.8512 ns |
|         ArraySegment_MeanArithmeticWeighted |   195.37 ns |  1.0043 ns |  0.8903 ns |
|                 List_MeanArithmeticWeighted |   176.86 ns |  0.7677 ns |  0.7181 ns |
|                Queue_MeanArithmeticWeighted |   777.94 ns |  5.5397 ns |  5.1818 ns |
|                Stack_MeanArithmeticWeighted |   738.00 ns |  3.4655 ns |  3.2416 ns |
|           LinkedList_MeanArithmeticWeighted |   766.14 ns |  5.2040 ns |  4.8678 ns |
| ObservableCollection_MeanArithmeticWeighted |   200.83 ns |  0.7738 ns |  0.7239 ns |
|                         Array_MeanGeometric |   138.08 ns |  0.5381 ns |  0.4493 ns |
|                  ArraySegment_MeanGeometric |   145.64 ns |  0.9575 ns |  0.8957 ns |
|                          List_MeanGeometric |   132.21 ns |  0.7168 ns |  0.6705 ns |
|                         Queue_MeanGeometric |   678.82 ns |  3.0554 ns |  2.7085 ns |
|                         Stack_MeanGeometric |   661.12 ns |  3.3256 ns |  2.9481 ns |
|                    LinkedList_MeanGeometric |   705.84 ns |  4.2402 ns |  3.9663 ns |
|          ObservableCollection_MeanGeometric |   148.93 ns |  1.1522 ns |  1.0777 ns |
|                 Array_MeanGeometricWeighted |   337.80 ns |  1.7181 ns |  1.6071 ns |
|          ArraySegment_MeanGeometricWeighted |   346.11 ns |  1.6509 ns |  1.5442 ns |
|                  List_MeanGeometricWeighted |   321.27 ns |  1.9255 ns |  1.7069 ns |
|                 Queue_MeanGeometricWeighted |   943.65 ns |  3.6073 ns |  3.3743 ns |
|                 Stack_MeanGeometricWeighted |   908.78 ns |  6.9230 ns |  6.4758 ns |
|            LinkedList_MeanGeometricWeighted |   982.62 ns |  8.6318 ns |  8.0742 ns |
|  ObservableCollection_MeanGeometricWeighted |   361.36 ns |  3.2133 ns |  3.0057 ns |
|                          Array_MeanHarmonic |   116.40 ns |  0.6778 ns |  0.6340 ns |
|                   ArraySegment_MeanHarmonic |   111.70 ns |  0.8244 ns |  0.7711 ns |
|                           List_MeanHarmonic |    98.12 ns |  0.8116 ns |  0.7195 ns |
|                          Queue_MeanHarmonic |   686.83 ns |  6.4855 ns |  6.0665 ns |
|                          Stack_MeanHarmonic |   659.06 ns |  4.1414 ns |  3.8739 ns |
|                     LinkedList_MeanHarmonic |   682.26 ns |  4.9555 ns |  4.6353 ns |
|           ObservableCollection_MeanHarmonic |   112.94 ns |  0.7674 ns |  0.7178 ns |
|                  Array_MeanHarmonicWeighted |   191.33 ns |  1.5069 ns |  1.4096 ns |
|           ArraySegment_MeanHarmonicWeighted |   198.71 ns |  1.7690 ns |  1.6547 ns |
|                   List_MeanHarmonicWeighted |   184.00 ns |  1.4184 ns |  1.3267 ns |
|                  Queue_MeanHarmonicWeighted |   799.24 ns |  6.0068 ns |  5.3249 ns |
|                  Stack_MeanHarmonicWeighted |   766.75 ns |  6.7534 ns |  6.3171 ns |
|             LinkedList_MeanHarmonicWeighted |   798.25 ns |  7.1494 ns |  6.6876 ns |
|   ObservableCollection_MeanHarmonicWeighted |   207.29 ns |  0.9604 ns |  0.8514 ns |
|                                 Array_Modes | 1,358.35 ns | 14.5405 ns | 13.6012 ns |
|                          ArraySegment_Modes | 1,338.46 ns |  8.3230 ns |  7.3781 ns |
|                                  List_Modes | 1,338.86 ns | 11.6375 ns | 10.8857 ns |
|                                 Queue_Modes | 1,950.67 ns | 19.0049 ns | 17.7772 ns |
|                                 Stack_Modes | 1,900.72 ns | 11.7852 ns | 11.0239 ns |
|                            LinkedList_Modes | 1,954.91 ns | 15.6670 ns | 14.6550 ns |
|                  ObservableCollection_Modes | 1,371.27 ns |  9.4561 ns |  8.8452 ns |
|                           Array_Frequencies |   631.30 ns |  5.6776 ns |  5.0330 ns |
|                    ArraySegment_Frequencies |   624.44 ns |  3.9468 ns |  3.6919 ns |
|                            List_Frequencies |   614.31 ns |  5.0390 ns |  4.7135 ns |
|                           Queue_Frequencies | 1,240.82 ns |  5.3866 ns |  4.7751 ns |
|                           Stack_Frequencies | 1,193.69 ns | 11.4722 ns | 10.7311 ns |
|                      LinkedList_Frequencies | 1,256.14 ns | 13.9528 ns | 13.0515 ns |
|            ObservableCollection_Frequencies |   680.83 ns |  4.1142 ns |  3.8484 ns |
|                 Array_FrequencyDistribution |   625.82 ns |  3.7962 ns |  3.3652 ns |
|          ArraySegment_FrequencyDistribution |   622.71 ns |  3.9369 ns |  3.4900 ns |
|                  List_FrequencyDistribution |   601.54 ns |  3.0776 ns |  2.8788 ns |
|                 Queue_FrequencyDistribution | 1,228.24 ns |  7.3241 ns |  6.8509 ns |
|                 Stack_FrequencyDistribution | 1,174.62 ns |  5.1918 ns |  4.8564 ns |
|            LinkedList_FrequencyDistribution | 1,227.26 ns |  7.5188 ns |  6.6652 ns |
|  ObservableCollection_FrequencyDistribution |   642.15 ns |  3.3877 ns |  3.1688 ns |
|                         Array_MeanQuadratic |   140.17 ns |  0.7416 ns |  0.6937 ns |
|                  ArraySegment_MeanQuadratic |   148.80 ns |  0.7586 ns |  0.7096 ns |
|                          List_MeanQuadratic |   136.66 ns |  0.9219 ns |  0.8172 ns |
|                         Queue_MeanQuadratic |   687.77 ns |  4.6897 ns |  4.3868 ns |
|                         Stack_MeanQuadratic |   659.81 ns |  4.7570 ns |  4.4497 ns |
|                    LinkedList_MeanQuadratic |   705.19 ns |  3.1187 ns |  2.9172 ns |
|          ObservableCollection_MeanQuadratic |   167.06 ns |  0.5778 ns |  0.5405 ns |
|                             Array_MeanCubic |   149.79 ns |  0.6657 ns |  0.5901 ns |
|                      ArraySegment_MeanCubic |   149.70 ns |  0.5425 ns |  0.5074 ns |
|                              List_MeanCubic |   138.77 ns |  0.8087 ns |  0.7565 ns |
|                             Queue_MeanCubic |   692.34 ns |  3.9393 ns |  3.4921 ns |
|                             Stack_MeanCubic |   670.20 ns |  7.1328 ns |  6.6720 ns |
|                        LinkedList_MeanCubic |   715.83 ns |  7.2880 ns |  6.8172 ns |
|              ObservableCollection_MeanCubic |   152.56 ns |  0.5292 ns |  0.4419 ns |
|                    Array_MeanGeneralized_20 |   412.55 ns |  1.2774 ns |  1.1324 ns |
|             ArraySegment_MeanGeneralized_20 |   421.27 ns |  1.9590 ns |  1.8325 ns |
|                     List_MeanGeneralized_20 |   408.85 ns |  1.4641 ns |  1.3695 ns |
|                    Queue_MeanGeneralized_20 |   999.12 ns |  7.6526 ns |  7.1583 ns |
|                    Stack_MeanGeneralized_20 |   971.32 ns |  7.0121 ns |  6.5592 ns |
|               LinkedList_MeanGeneralized_20 | 1,020.62 ns | 10.6198 ns |  9.9338 ns |
|     ObservableCollection_MeanGeneralized_20 |   419.69 ns |  3.5018 ns |  3.2756 ns |
|                    Array_MeanGeneralized_30 |   413.03 ns |  2.3877 ns |  2.2335 ns |
|             ArraySegment_MeanGeneralized_30 |   420.15 ns |  4.0336 ns |  3.7731 ns |
|                     List_MeanGeneralized_30 |   407.51 ns |  2.1901 ns |  2.0487 ns |
|                    Queue_MeanGeneralized_30 | 1,001.91 ns |  5.1004 ns |  4.5214 ns |
|                    Stack_MeanGeneralized_30 |   970.30 ns |  8.0090 ns |  7.4916 ns |
|               LinkedList_MeanGeneralized_30 | 1,054.37 ns |  7.4856 ns |  6.6358 ns |
|     ObservableCollection_MeanGeneralized_30 |   413.72 ns |  2.4004 ns |  2.2453 ns |
|                          Array_MeanWeighted |   177.57 ns |  1.4401 ns |  1.2766 ns |
|                   ArraySegment_MeanWeighted |   197.85 ns |  0.8027 ns |  0.6267 ns |
|                           List_MeanWeighted |   171.88 ns |  1.6787 ns |  1.5702 ns |
|                          Queue_MeanWeighted |   781.11 ns |  5.6266 ns |  5.2631 ns |
|                          Stack_MeanWeighted | 2,527.56 ns | 17.0176 ns | 15.0857 ns |
|                     LinkedList_MeanWeighted |   772.64 ns |  4.6702 ns |  4.1400 ns |
|           ObservableCollection_MeanWeighted |   190.58 ns |  0.9607 ns |  0.8516 ns |
|                                Array_Median | 1,175.78 ns | 10.5072 ns |  9.8284 ns |
|                         ArraySegment_Median | 1,172.00 ns |  8.6088 ns |  7.1887 ns |
|                                 List_Median | 1,170.54 ns | 13.3955 ns | 12.5302 ns |
|                                Queue_Median | 1,586.23 ns |  9.1895 ns |  8.1462 ns |
|                                Stack_Median | 1,508.27 ns |  7.8763 ns |  7.3675 ns |
|                           LinkedList_Median | 1,116.10 ns |  3.4473 ns |  2.4926 ns |
|                 ObservableCollection_Median | 1,176.93 ns |  9.4134 ns |  8.3448 ns |
|                        Array_MedianWeighted |          NA |         NA |         NA |
|                 ArraySegment_MedianWeighted |          NA |         NA |         NA |
|                         List_MedianWeighted |          NA |         NA |         NA |
|                        Queue_MedianWeighted |          NA |         NA |         NA |
|                        Stack_MedianWeighted |          NA |         NA |         NA |
|                   LinkedList_MedianWeighted |          NA |         NA |         NA |
|         ObservableCollection_MedianWeighted |          NA |         NA |         NA |

Benchmarks with issues:
  UnitTests20180227DataSet001.Array_MedianWeighted: DefaultJob
  UnitTests20180227DataSet001.ArraySegment_MedianWeighted: DefaultJob
  UnitTests20180227DataSet001.List_MedianWeighted: DefaultJob
  UnitTests20180227DataSet001.Queue_MedianWeighted: DefaultJob
  UnitTests20180227DataSet001.Stack_MedianWeighted: DefaultJob
  UnitTests20180227DataSet001.LinkedList_MedianWeighted: DefaultJob
  UnitTests20180227DataSet001.ObservableCollection_MedianWeighted: DefaultJob
