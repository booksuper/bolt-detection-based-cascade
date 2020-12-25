import os
from cv2 import cv2
import random
import numpy as np

def rename(path1,num):
    '''
    对文件夹中文件进行批量重命名，文件名为1.jpg，2.jpg。。。。。。这种形式。
    参数解释，
    path1:以绝对路径传入文件路径
    num：代表文件名从哪个数开始计数，如num = 200，则第一个文件名为200.jpg
    '''
    filename = os.listdir(path1)
    print(len(filename))
    for i,name in enumerate(filename):
        i+=num
        st = str(i)+'.jpg'
        os.renames(os.path.join(path1,name),os.path.join(path1,st))

def cut(loadpath,size1,size2,savepath):
    '''
    将文件夹中的图片进行批量灰度化并且改变尺寸
    参数说明，
    loadpath：图片所在文件夹的绝对地址
    size1：图片尺寸变化后的长
    size2：图片尺寸变化后的宽
    savepath：处理后图片的保存路径（绝对地址）
    '''
    
    filename = os.listdir(loadpath)
    for i,name in enumerate(filename):
        i+= 1
        i = str(i)
        imgpath = loadpath + '\\' + name
        o = cv2.imread(imgpath)
        o = cv2.cvtColor(o,cv2.COLOR_BGR2GRAY)
        img = cv2.resize(o,(size1,size2))
        cv2.imwrite(savepath + '\\' + i +'.jpg' ,img)

def name(loadpath,savepath,strname):
    '''
    该函数功能为生成一个带有规律的文件名TXT文件，比如每个图片文件都是pos\1.jpg,pos\2.jpg
    这样的命名格式。参数说明，
    loadpath：需要生成TXT文件的图片文件夹绝对地址
    savepath：TXT文件的保存路径（不需要新建相应文件夹，没有会自动创建
    strname：想要生成的文件名格式，如neg/%s.jpg\n，%s是占位符，从1开始计数，\n是换行
    注意！！！生成的TXT文件最后会有一个空行，需要手动把该空行删除
    '''
    filename = os.listdir(loadpath)
    n = len(filename)
    with open(savepath,'a+') as f:
        for i in range(n):
            i+=1
            f.write(strname % str(i))      

def create_img(path,num):
    '''
    对每一张图片进行翻转，旋转，仿射变换，具体执行哪种操作是随机的，以此来增大样本数量
    参数解释，
    path：需要加载的图片绝对地址
    num：每一张图片生成几张样本图片，如num = 5，则对每一张图片对会再随机生成五张样本图片
    '''
    filename = os.listdir(path)
    for i,name in enumerate(filename):
        i+=1
        imgpath = path + '\\' + name
        img = cv2.imread(imgpath)
        h,w,c= img.shape
        for j in range(num):
            j+=1
            a = random.randint(1,4)
            if a == 1:
                #  将图片绕x轴翻转
                img = cv2.flip(img,0)
                cv2.imwrite(path + '\\' + str(i) + '_' + str(j) + '.jpg',img)
            elif a == 2:
                #  将图片绕y轴翻转
                img =cv2.flip(img,1)
                cv2.imwrite(path + '\\' + str(i) + '_' + str(j) + '.jpg',img)
            elif a == 3:
                #  将图片绕x，y轴翻转
                img = cv2.flip(img,-1)
                cv2.imwrite(path + '\\' + str(i) + '_' + str(j) + '.jpg',img)
            # elif a == 4:
            #     #  将图片绕图片中心旋转，旋转角度在（-180,180）随机
            #     m = cv2.getRotationMatrix2D((w/2,h/2),random.randint(-180,180),1)
            #     img = cv2.warpAffine(img,m,(w,h))
            #     cv2.imwrite(path + '\\' + str(i) + '_' + str(j) + '.jpg',img)
            # elif a == 5:
            #  将图片进行仿射变换，该功能笔者舍弃没用了，需要的取消注释即可
            #     # p1 = np.float32([[0,0],[w-1,0],[0,h-1]])
            #     # p2 = np.float32([[0,h*0.33],[w*0.85,h*0.25],[w*0.15,h*0.7]])
            #     m = cv2.getAffineTransform(p1,p2)
            #     img = cv2.warpAffine(img,m,(w,h))
            #     cv2.imwrite(path + '\\' + str(i) + '_' + str(j) + '.jpg',img)   

if __name__ == '__main__':
    #rename('C:\\Users\\Administrator\\Desktop\\bolt\\badminton\\neg',1)
    #create_img('C:\\Users\\Administrator\\Desktop\\bg',5)
    #cut('C:\\Users\\Administrator\\Desktop\\bg',40,25,'C:\\Users\\Administrator\\Desktop\\lcc')
    name('C:\\Users\\Administrator\\Desktop\\bolt\\badminton\\neg','C:\\Users\\Administrator\\Desktop\\bolt\\badminton\\neg.txt','neg/%s.jpg\n') #pos/1.jpg 1 0 0 40 40
  
  
  # p2 = np.float32([[0,h*random.uniform(0,1)],[w*random.uniform(0,1),h*random.uniform(0,1)],[w*random.uniform(0,1),h*random.uniform(0,1)]])
        
