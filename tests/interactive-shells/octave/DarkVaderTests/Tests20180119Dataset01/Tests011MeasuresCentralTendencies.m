
pwd
# source "Tests00Data.m"
# run("Tests00Data.m")
# Tests00Data

tic ();
mean_arithmetic = mean(data, "a");
elapsed_time = toc ();
mean_arithmetic
elapsed_time

mean_geometric = mean(data, "g");
mean_geometric
mean_harmonic = mean(data, "h");
mean_harmonic
mean_squared = meansq(data);
mean_squared

median = median(data);
median
