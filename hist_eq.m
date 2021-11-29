path = './calib/';
fileFolder=fullfile(path);
 
dirOutput=dir(fullfile(fileFolder,'*.jpg'));
 
fileNames={dirOutput.name};
Length_Names = numel(fileNames);    % ��ȡ����ȡ�����ļ��ĸ���
for k = 1 : Length_Names
    % ����·�����ļ����õ��������ļ�·��
    K_Trace = strcat(path, fileNames{k});
    disp(K_Trace);
    im = imread(K_Trace);
    imout = histeq(im);
    figure(1);
    imshow(imout);
    out_path = [path, 'histeq', fileNames{k}];
    imwrite(imout, out_path);
end





