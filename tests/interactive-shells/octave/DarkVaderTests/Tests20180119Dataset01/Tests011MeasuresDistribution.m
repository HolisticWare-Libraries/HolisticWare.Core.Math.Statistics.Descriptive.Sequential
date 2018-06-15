

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


disp ("==================================================================================")
# Arrange
tic ();
# Act
iqr = iqr(data);
elapsed_time = toc ();
# Assert
disp ("iqr                          = "), disp(iqr)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
std = std(data);
elapsed_time = toc ();
# Assert
disp ("iqr                          = "), disp(std)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
var = var(data);
elapsed_time = toc ();
# Assert
disp ("var                          = "), disp(var)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
skewness = skewness(data, 1);
elapsed_time = toc ();
# Assert
disp ("skewness                     = "), disp(skewness)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
kurtosis = kurtosis(data, 1);
elapsed_time = toc ();
# Assert
disp ("kurtosis                     = "), disp(kurtosis)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")


disp ("==================================================================================")
# Arrange
tic ();
# Act
skewness0 = skewness(data, 0);
elapsed_time = toc ();
# Assert
disp ("skewness0                    = "), disp(skewness0)
disp ("              time [\u00B5s] = "), disp(elapsed_time * 1000000)
#assert(mean_arithmetic == 3.8)
disp ("==================================================================================")
