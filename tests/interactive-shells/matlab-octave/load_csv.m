# pkg install -forge io

pkg load io

# javaMethod ("getProperty", "java.lang.System", "MyProperty");

# if "OpenJDK 64-Bit Server VM warning..." then: javaMethod ("getProperty", "java.lang.System", "MyProperty");

addpath('/Users/katodix/Projects/HolisticWare.Core.Math.Statistics.Descriptive.Sequential/externals/Core.Math.Samples/data')

data = csv2cell('Pejcic_318.csv')

data(1, :) %

data(2:end, :) %

# dlmread ('Pejcic_318.csv',',',2,0)

csvread('Pejcic_318.csv')

data = csvread('Pejcic_318.csv')