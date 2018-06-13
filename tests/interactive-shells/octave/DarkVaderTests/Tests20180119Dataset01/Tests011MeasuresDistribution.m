

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


