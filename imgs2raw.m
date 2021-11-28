close all
clear

%##### Load image #####
[FILENAME, PATHNAME, FILTERINDEX] = uigetfile('*.jpg;*.seq', 'Choose IR file (jpg) or radiometric sequence (seq)');
videoFileName=[PATHNAME FILENAME];

% Load the Atlats SDK
atPath = getenv('FLIR_Atlas_MATLAB');
atImage = strcat(atPath,'Flir.Atlas.Image.dll');
asmInfo = NET.addAssembly(atImage);
%open the IR-file
file = Flir.Atlas.Image.ThermalImageFile(videoFileName);
seq = file.ThermalSequencePlayer();
%Get the pixels // Get the signal image as a double array.When integrating Atlas SDK in Matlab use this method. 
frame_count = file.Count();
save = true;
i = 0;
while 1
    i = i + 1;
    img = seq.ThermalImage.ImageProcessing.GetPixelsArray;
    im = double(img);
    % figure(1)
    % imshow(im,[])
    if save
        im16 = uint16(im);
        imwrite(im16,['image_', num2str(i), '.png'],'png','bitdepth',16);
    end

    if (~seq.Next)
        break;
    end
    %show image
end
%% im就是原始数据

