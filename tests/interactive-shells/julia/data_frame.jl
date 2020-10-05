# fname = "Pejcic_318.csv" 
# data = readdlm(fname, separator = ',')                               
# using DataFrames, CSV, Statistics, StatsBase
# data = CSV.read("Pejcic_318.csv", header=true, delim=',', copycols = true)

# println((data),"\n")

#-----------------------------------------------------------------------------------------------
# 1st run - packages installation

#import Pkg; 
#Pkg.add("HypothesisTests")
#Pkg.add("Random")

using HypothesisTests, Random 

Random.seed!(0); x= randn(100); y= randn(100);

OneSampleTTest(x,y)