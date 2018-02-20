// namespace inclusion (using) necessary for LINQ Extension methods
using Core.Math.Statistics.Descriptive.Sequential;

ShowUsing (); 

List<int> data01 = new List<int>(){1,2,4,5};

double mean_arithmetic_01 = data01.MeanArithmetic();
