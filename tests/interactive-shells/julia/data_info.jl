using DataFrames, CSV, Statistics, StatsBase
data = CSV.read("../../../externals/Core.Math.Samples/data/Pejcic_318.csv", copycols = true)

println(size(data),"\n")
println(names(data),"\n")
println(first(data, 6),"\n")
println(describe(data),"\n")