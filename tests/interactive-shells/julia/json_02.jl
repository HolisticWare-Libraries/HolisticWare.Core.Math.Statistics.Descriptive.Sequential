import Pkg; 
Pkg.add("JSON3")
Pkg.add("LazyJSON")

import JSON3;
import LazyJSON;

open("array_02_numeric.json", "r") do file
    global dicttxt = read(file, String)  # file information to string
    global a1 = LazyJSON.value(dicttxt)  # parse and transform data
end

a2 = JSON3.read(dicttxt)

println(a2)
println(a1)


import Pkg; 
Pkg.add("Statistics")
using Statistics; 

#m1 = mean(a1)
m2 = mean(a2)

#println(m1)
println("mean arithmetic = ", m2)
