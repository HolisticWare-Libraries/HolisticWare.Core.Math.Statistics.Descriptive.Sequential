using DataFrames, CSV, Statistics, StatsBase
data = CSV.read("Pejcic_318.csv", copycols = true)

# eltypes(data)

eltype.(eachcol(data))