# https://octave.sourceforge.io

# javaMethod ("getProperty", "java.lang.System", "MyProperty");

# if "OpenJDK 64-Bit Server VM warning..." then: javaMethod ("getProperty", "java.lang.System", "MyProperty");

# pkg install -forge io
# pkg install -forge statistics
# pkg install -forge nan
# pkg install -forge dataframe

pkg load io statistics nan dataframe

addpath('../../../externals/Core.Math.Samples/data')

# data = csv2cell('Pejcic_318.csv')
# data(1, :) %
# data(2:end, :) %

# dlmread ('Pejcic_318.csv',',',1,5)

# csvread('Pejcic_318.csv')
# data = csvread('Pejcic_318.csv')

mean(data)
median(data)
mode(data)
range(data)
var(data)
std(data)
skewness(data)
kurtosis(data)

statistics(data)

#############
# DataFrame #
#############
data = dataframe('Pejcic_318.csv')

# prvi arg.: od kojeg do kojeg retka; drugi arg.: koje varijable
#df = data(1:318, ["ATV"; "ATT"; "AOP"; "ANN"; "MKUS"; "MPOL"; "MP20"; "MPRR"; "MTAP"; "MSDM"; "MDTR"; "MVIS"])

class(df)
df.colnames
size(df)
columns(df)
rows(df)

data(:, 5:8)
df1 = data(:, 5:8)
summary(df1)

df2 = data(1:318, ["ATV"; "ATT"])
mean(df.ATV)
statistics(df.ATV)
