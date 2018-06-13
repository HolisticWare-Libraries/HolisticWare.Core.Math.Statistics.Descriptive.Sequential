
pwd
# source "Tests00Data.m"
# run("Tests00Data.m")
# Tests00Data


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_arithmetic = mean_arithmetic = mean(data, "a");
elapsed_time = toc ();
# Assert
disp ("mean_arithmetic               = "), disp(mean_arithmetic)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_geometric = mean(data, "g");
elapsed_time = toc ();
# Assert
disp ("mean_geometric               = "), disp(mean_geometric)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_harmonic = mean(data, "h");
elapsed_time = toc ();
# Assert
disp ("mean_harmonic                = "), disp(mean_harmonic)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mean_squared = meansq(data);
elapsed_time = toc ();
# Assert
disp ("mean_squared                 = "), disp(mean_squared)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")

disp ("==================================================================================")
# Arrange
tic ();
# Act
median = median(data);
elapsed_time = toc ();
# Assert
disp ("median                       = "), disp(median)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
mode = mode(data);
elapsed_time = toc ();
# Assert
disp ("mode                         = "), disp(mode)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
range1 = range(data);
elapsed_time = toc ();
# Assert
disp ("range                        = "), disp(range1)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")
