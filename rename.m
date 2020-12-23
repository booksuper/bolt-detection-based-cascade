clc;clear;
dir1='F:\train\train800\neg';
dir2='F:\train\train800\neg\';
file_dat=dir([dir1 '\*.jpg']);
num_file=length(file_dat);

for i=1:num_file
    file_name=file_dat(i,1).name;
    filename1=strcat(dir2,file_name);
    disp(file_name);
    temp_str = int2str(i);
    temp_length = length(temp_str);
    k=4-temp_length;
    a=char('0');
    temp_str=repmat(a,1,k);

    new_file=num2str(temp_str);
    disp(new_file);
    c=int2str(i);
    b=strcat(new_file,c);
    d=strcat(b,'.jpg');
    d1=strcat('neg',d);
    disp(d1);
    e=strcat(dir2,d1);
    disp(e);
    disp(filename1);
movefile(filename1,e);
end
