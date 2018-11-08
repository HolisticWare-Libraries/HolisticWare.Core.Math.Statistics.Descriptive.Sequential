
#-------------------------------------------------------------------------------------------
# path setup
this_script_path = fileparts(mfilename('fullpath'));
addpath(this_script_path);
csv_filename = '../../../../../externals/Core.Math.Samples/tests/data/HolisticWare.Core.Math.Samples/Xtras-SampleData/Basketball.comma.csv';
filename = [this_script_path,'/',csv_filename]
#-------------------------------------------------------------------------------------------

filecontent = fileread(filename);
filecontent
data = csvread(filename);
data
# data = dlmread(filename)(:,1:8);
# data
# data = importread(filename).data(:,1:8);

data_2pts_success = data(2:end, 1); 
data_2pts_success

run("Tests011MeasuresCentralTendencies.data_2pts_success.m");
run("Tests011MeasuresDistribution.data_2pts_success.m");

