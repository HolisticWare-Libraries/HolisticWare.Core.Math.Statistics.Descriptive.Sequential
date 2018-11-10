
#-------------------------------------------------------------------------------------------
# path setup
this_script_path = fileparts(mfilename('fullpath'));
addpath(this_script_path);
csv_filename = '../../../../../externals/Core.Math.Samples/data/HolisticWare.Core.Sample.Data/Xtras-SampleData/Basketball.comma.csv';
filename = [this_script_path,'/',csv_filename]
#-------------------------------------------------------------------------------------------

filecontent = fileread(filename);
filecontent
data = csvread(filename);
data
# data = dlmread(filename)(:,1:8);
# data
# data = importread(filename).data(:,1:8);


run("Tests011MeasuresCentralTendencies.data_2pts_fail.m");
run("Tests011MeasuresCentralTendencies.data_2pts_success.m");
data_2pts_success = data(2:end, 1); 
data_2pts_success
run("Tests011MeasuresCentralTendencies.data_3pts_fail.m");
run("Tests011MeasuresCentralTendencies.data_3pts_success.m");
run("Tests011MeasuresCentralTendencies.data_free_throw_fail.m");
run("Tests011MeasuresCentralTendencies.data_free_throw_success.m");
run("Tests011MeasuresCentralTendencies.data_jumps_defensive.m");
run("Tests011MeasuresCentralTendencies.data_jumps_offensive.m");
run("Tests011MeasuresDistribution.data_2pts_success.m");
run("Tests011MeasuresDistribution.data_assistence.m");
run("Tests011MeasuresDistribution.data_balls_lost.m");
run("Tests011MeasuresDistribution.data_balls_stolen.m");
run("Tests011MeasuresDistribution.data_blocks.m");
run("Tests011MeasuresDistribution.data_personal_faults.m");
run("Tests011MeasuresCentralTendencies.data_2pts_success.m");

