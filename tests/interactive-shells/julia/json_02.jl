import Pkg; 
Pkg.add("JSON")
Pkg.add("JSON3")
Pkg.add("LazyJSON")

import JSON;
import JSON3;
import LazyJSON;

open("array_02_numeric.json", "r") do file
    global dicttxt = read(file, String)  # file information to string
    global a1 = LazyJSON.value(dicttxt)  # parse and transform data
end

a2 = JSON3.read(dicttxt)

println("a2 = ", a2)
println("a1 = ", a1)


Pkg.add("Statistics")
Pkg.add("StatsBase")
using Statistics;
using StatsBase;

# https://rosettacode.org/wiki/Averages/Arithmetic_mean#Julia

#m1 = mean(a1)
mean_arithmetic_2 = mean(a2)
mode_2 = StatsBase.mode(a2)

#println(m1)
println("mean arithmetic (m2)   = ", mean_arithmetic_2)
println("mode (m2)              = ", mode_2)


dict_result = Dict(
                    "mean arithmetic" => mean_arithmetic_2, 
                    "mode" => mode_2
                )
string_data_results = JSON.json(dict_result)

# write the file with the stringdata variable information
open("results.json", "w") do f
    write(f, string_data_results)
end
                