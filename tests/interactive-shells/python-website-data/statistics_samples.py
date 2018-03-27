import statistics
import timeit

# samples from: https://docs.python.org/3/library/statistics.html

#==================================================================================
# Arrange
data01 = [1, 2, 3, 4, 4]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
mean_arithmetic = statistics.mean(data01)
end = timeit.default_timer()
# Assert
print ("mean_arithmetic = ", mean_arithmetic)
print ("      time [us] = ", (end - start) * 100000)
assert(mean_arithmetic == 2.8)
#==================================================================================

#==================================================================================
# Arrange
data01 = [-1.0, 2.5, 3.25, 5.75]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
mean_arithmetic = statistics.mean(data01)
end = timeit.default_timer()
# Assert
print ("mean_arithmetic = ", mean_arithmetic)
print ("      time [us] = ", (end - start) * 100000)
assert(mean_arithmetic == 2.625)
#==================================================================================

#==================================================================================
# Arrange
data01 = [2.5, 3, 10]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
mean_harmonic = statistics.harmonic_mean(data01)
end = timeit.default_timer()
# Assert
print ("mean_harmonic = ", mean_harmonic)
print ("      time [us] = ", (end - start) * 100000)
assert(mean_harmonic == 3.6)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 5]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median = statistics.median(data01)
end = timeit.default_timer()
# Assert
print ("median = ", median)
print ("      time [us] = ", (end - start) * 100000)
assert(median == 3)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 5, 7]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median = statistics.median(data01)
end = timeit.default_timer()
# Assert
print ("median = ", median)
print ("      time [us] = ", (end - start) * 100000)
assert(median == 4)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 5]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_low = statistics.median_low(data01)
end = timeit.default_timer()
# Assert
print ("median_low = ", median_low)
print ("      time [us] = ", (end - start) * 100000)
assert(median_low == 3)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 5, 7]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_low = statistics.median_low(data01)
end = timeit.default_timer()
# Assert
print ("median_low = ", median_low)
print ("      time [us] = ", (end - start) * 100000)
assert(median_low == 3)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 5]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_high = statistics.median_high(data01)
end = timeit.default_timer()
# Assert
print ("median_high = ", median_high)
print ("      time [us] = ", (end - start) * 100000)
assert(median_high == 3)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 5, 7]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_high = statistics.median_high(data01)
end = timeit.default_timer()
# Assert
print ("median_high     = ", median_high)
print ("      time [us] = ", (end - start) * 100000)
assert(median_high == 5)
#==================================================================================

#==================================================================================
# Arrange
data01 = [52, 52, 53, 54]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_grouped = statistics.median_grouped(data01)
end = timeit.default_timer()
# Assert
print ("median_grouped  = ", median_grouped)
print ("      time [us] = ", (end - start) * 100000)
assert(median_grouped == 52.5)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 2, 2, 3, 4, 4, 4, 4, 4, 5]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_grouped = statistics.median_grouped(data01)
end = timeit.default_timer()
# Assert
print ("median_grouped  = ", median_grouped)
print ("      time [us] = ", (end - start) * 100000)
assert(median_grouped == 3.7)
#==================================================================================

# 
# https://help.gnome.org/users/gnumeric/stable/gnumeric.html#gnumeric-function-SSMEDIAN
# https://mail.gnome.org/archives/gnumeric-list/2011-April/msg00018.html
#==================================================================================
# Arrange
data01 = [1, 3, 3, 5, 7]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_grouped = statistics.median_grouped(data01, interval=1)
end = timeit.default_timer()
# Assert
print ("median_grouped  = ", median_grouped)
print ("      time [us] = ", (end - start) * 100000)
assert(median_grouped == 3.25)
#==================================================================================

#==================================================================================
# Arrange
data01 = [1, 3, 3, 5, 7]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_grouped = statistics.median_grouped(data01, interval=2)
end = timeit.default_timer()
# Assert
print ("median_grouped  = ", median_grouped)
print ("      time [us] = ", (end - start) * 100000)
assert(median_grouped == 3.5)
#==================================================================================

#==================================================================================
# Arrange
data01 = [7, 8, 8]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
median_grouped = statistics.median_grouped(data01, interval=1)
end = timeit.default_timer()
# Assert
print ("median_grouped  = ", median_grouped)
print ("      time [us] = ", (end - start) * 100000)
assert(median_grouped == 7.75)
#==================================================================================




#==================================================================================
# Arrange
data01 = [1, 1, 2, 3, 3, 3, 3, 4]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
mode = statistics.mode(data01)
end = timeit.default_timer()
# Assert
print ("mode            = ", mode)
print ("      time [us] = ", (end - start) * 100000)
assert(mode == 3)
#==================================================================================

#==================================================================================
# Arrange
data01 = ["red", "blue", "blue", "red", "green", "red", "red"]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
mode = statistics.mode(data01)
end = timeit.default_timer()
# Assert
print ("mode            = ", mode)
print ("      time [us] = ", (end - start) * 100000)
assert(mode == "red")
#==================================================================================



#==================================================================================
# Arrange
data01 = [1.5, 2.5, 2.5, 2.75, 3.25, 4.75]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
pstdev = statistics.pstdev(data01)
end = timeit.default_timer()
# Assert
print ("pstdev          = ", pstdev)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(pstdev - 0.98689) < 0.00001)
#==================================================================================

#==================================================================================
# Arrange
mu = statistics.mean(data01)
start = timeit.default_timer()
# Act
pstdev = statistics.pstdev(data01, mu)
end = timeit.default_timer()
# Assert
print ("pstdev          = ", pstdev)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(pstdev - 0.98689) < 0.00001)
#==================================================================================



#==================================================================================
# Arrange
data01 = [0.0, 0.25, 0.25, 1.25, 1.5, 1.75, 2.75, 3.25]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
pvariance = statistics.pvariance(data01)
end = timeit.default_timer()
# Assert
print ("pvariance       = ", pvariance)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(pvariance - 1.25) < 0.001)
#==================================================================================

#==================================================================================
# Arrange
mu = statistics.mean(data01)
start = timeit.default_timer()
# Act
pvariance = statistics.pvariance(data01, mu)
end = timeit.default_timer()
# Assert
print ("pvariance       = ", pvariance)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(pvariance - 1.25) < 0.001)
#==================================================================================



#==================================================================================
# Arrange
data01 = [1.5, 2.5, 2.5, 2.75, 3.25, 4.75]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
stdev = statistics.stdev(data01)
end = timeit.default_timer()
# Assert
print ("stdev           = ", stdev)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(stdev - 1.08108) < 0.00001)
#==================================================================================

#==================================================================================
# Arrange
mu = statistics.mean(data01)
start = timeit.default_timer()
# Act
stdev = statistics.stdev(data01, mu)
end = timeit.default_timer()
# Assert
print ("stdev           = ", stdev)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(stdev - 1.08108) < 0.00001)
#==================================================================================



#==================================================================================
# Arrange
data01 = [2.75, 1.75, 1.25, 0.25, 0.5, 1.25, 3.5]
print ("data01          = ", data01)
start = timeit.default_timer()
# Act
variance = statistics.variance(data01)
end = timeit.default_timer()
# Assert
print ("variance        = ", variance)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(variance - 1.37202) < 0.00001)
#==================================================================================

#==================================================================================
# Arrange
mu = statistics.mean(data01)
start = timeit.default_timer()
# Act
variance = statistics.variance(data01, mu)
end = timeit.default_timer()
# Assert
print ("variance        = ", variance)
print ("      time [us] = ", (end - start) * 100000)
assert(abs(variance - 1.37202) < 0.00001)
#==================================================================================


