fname = "../../../externals/Core.Math.Samples/data/Pejcic_318.csv"
data = readdlm(fname, separator = ',')

print(data)
# using DataFrames, CSV, Statistics, StatsBase
# data = CSV.read("Pejcic_318.csv", header=true, delim=',', copycols = true)

# println((data),"\n")