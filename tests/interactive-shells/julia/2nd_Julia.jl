using DataFrames, CSV, Statistics, StatsBase
data = CSV.read("Pejcic_318.csv", copycols = true)

# @show data.ATV
# println()

for col in eachcol(data,true); 
    if  (
        eltype(col[2]) <: Real) 
        println(mean(col[2])
        ); 
    end; 
end;

# println(names(data),"\n")

println("Sample Mean: ", mean(data[:ATT]))
# println("Harmonic <= Geometric <= Arithmetic ",(harmmean(data), geomean(data), mean(data)))
# println("Sample Variance: ",var(data))
# println("Sample Standard Deviation: ",std(data))
# println("Minimum: ", minimum(data))
# println("Maximum: ", maximum(data))
# println("Median: ", median(data))
# println("95th percentile: ", percentile(data, 95))
# println("0.95 quantile: ", quantile(data, 0.95))
# println("Interquartile range: ", iqr(data),"\n")

