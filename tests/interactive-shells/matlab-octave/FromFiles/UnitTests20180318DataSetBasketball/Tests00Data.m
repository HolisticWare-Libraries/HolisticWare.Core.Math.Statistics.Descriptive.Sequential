
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

# SUT_2_US,SUT_2_NE,SUT_3_US,SUT_3_NE,SL_BA_US,SL_BA_NE,SKOK_NAP,SKOK_OBR,ASISTENC,OSOB_GRE,IZG_LOPT,UKR_LOPT,BLOKADE,K1,K2

data_2pts_success = data(2:end, 1); 
data_2pts_success
run("Tests011MeasuresCentralTendencies.data_2pts_success.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresCentralTendencies.data_2pts_fail.m");

data_3pts_success = data(2:end, 3); 
data_3pts_success
run("Tests011MeasuresCentralTendencies.data_3pts_success.m");

data_3pts_fail = data(2:end, 4); 
data_3pts_fail
run("Tests011MeasuresCentralTendencies.data_3pts_fail.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresCentralTendencies.data_free_throw_fail.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresCentralTendencies.data_free_throw_success.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresCentralTendencies.data_jumps_defensive.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresCentralTendencies.data_jumps_offensive.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresDistribution.data_2pts_success.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresDistribution.data_assistence.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresDistribution.data_balls_lost.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresDistribution.data_balls_stolen.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresDistribution.data_blocks.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresDistribution.data_personal_faults.m");

data_2pts_fail = data(2:end, 2); 
data_2pts_fail
run("Tests011MeasuresCentralTendencies.data_2pts_success.m");


