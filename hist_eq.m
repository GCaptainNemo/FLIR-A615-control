path = './calib/';
fileFolder=fullfile(path);
 
dirOutput=dir(fullfile(fileFolder,'*.jpg'));
 
fileNames={dirOutput.name};
Length_Names = numel(fileNames);    % 获取所提取数据文件的个数
for k = 1 : Length_Names
    % 连接路径和文件名得到完整的文件路径
    K_Trace = strcat(path, fileNames{k});
    disp(K_Trace);
    im = imread(K_Trace);
    imout = histeq(im);
    figure(1);
    imshow(imout);
    out_path = [path, 'histeq', fileNames{k}];
    imwrite(imout, out_path);
end





