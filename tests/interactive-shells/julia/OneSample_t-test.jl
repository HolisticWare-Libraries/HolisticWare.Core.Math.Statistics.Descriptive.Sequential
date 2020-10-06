#import Pkg; 
#Pkg.add("HypothesisTests")
#Pkg.add("Random")

using HypothesisTests, Random 

Random.seed!(0); x= randn(100); y= randn(100);

println(OneSampleTTest(x,y))