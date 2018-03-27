
from Tests00Data import *
import statistics

# https://docs.python.org/3/library/statistics.html

print ("data01          = ", data01)

mean_arithmetic = statistics.mean(data01)
print ("mean_arithmetic = ", mean_arithmetic)

mean_harmonic = statistics.harmonic_mean(data01)
print ("mean_harmonic   = ", mean_harmonic)

mean_arithmetic = statistics.mean(data01)
print ("mean_arithmetic = ", mean_arithmetic)

mean_harmonic = statistics.harmonic_mean(data01)
print ("mean_harmonic   = ", mean_harmonic)

median = statistics.median(data01)
print ("median          = ", median)

median_low = statistics.median_low(data01)
print ("median_low      = ", median_low)

median_high = statistics.median_high(data01)
print ("median_high     = ", median_high)

median_grouped = statistics.median_grouped(data01)
print ("median_grouped  = ", median_grouped)

mode = statistics.mode(data01)
print ("mode  = ", mode)

