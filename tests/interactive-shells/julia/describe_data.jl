using DataFrames, CSV, Statistics, StatsBase
data = CSV.read("Pejcic_318.csv", copycols = true)

# describe(data[:ATT])

for col in eachcol(data,true); 
    if (eltype(col[2]) <: Real) println(describe(col[2])); 
    end; 
end;