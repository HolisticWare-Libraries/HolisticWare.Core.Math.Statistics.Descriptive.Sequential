using DataFrames, CSV, Statistics, StatsBase
data = CSV.read("Pejcic_318.csv", copycols = true)

# eltypes(data)

# eltype.(eachcol(data))



#fname = "Pejcic_318.csv"
#data = readtable(fname, separator = ',')
typeof(data) # DataFrame
size(data) # (1599,12)


