clear;clc;close all;
Files=dir('F:\train\train\train5600\1852\pos\*.jpg');%读取图像路径
N=length(Files);
Names={};
for k=1:N
        Names{k}=Files(k).name;
        B = imread(['F:\train\train\train5600\1852\pos\' Names{k}]);%读取图像 
%        n = unidrnd(180);%n个整数中以相同的概率抽样的离散均匀分布的整数随机数
%        PSF = fspecial('motion',4,n);	%运动模糊函数，运动位移是15像素，角度是n
%        B=imfilter(B,PSF,'conv','circular');%对图像运动模糊处理
%        B = imnoise(B, 'salt & pepper', 0.1);%椒盐噪声
%        B = imnoise(B, 'speckle', 0.01);%斑点噪声
%         B = imnoise(B, 'gaussian', 0.01);%高斯噪声
         B = rgb2gray(B);%灰度处理
%         B = imresize(B,[20,20]);%将图像缩放为20*20的大小
%        B1 = imadjust(B,[0.3,1],[0.3,1]);%图像线性变换
%         B2 = imadjust(B,[0,1],[0,0.7]);
%         B3 = imadjust(B,[0,1],[0.3,1]);
%         B4 = imadjust(B,[0,1],[0.2,0.8]);
%         B5 = imadjust(B,[0,0.7],[0,1]);
%         B6 = imadjust(B,[0.3,1],[0,1]);
%         B7 = imadjust(B,[0.3,0.7],[0,1]);
        path='F:\train\piture\尺寸30\20变48_64\'; %图像处理后的保存路径
        file=Files(k).name; 
        pathfile=fullfile(path,file); 
        imwrite(B,pathfile,'jpg');%保存图像
end