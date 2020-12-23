# -*- coding: utf-8 -*-
import cv2

def detect(filename):
    #face_cascade = cv2.CascadeClassifier(
    #        r'C:\Users\lenovo\AppData\Local\Programs\Python\Python37\Lib\site-packages\cv2\data\haarcascade_frontalface_default.xml')
    
    face_cascade = cv2.CascadeClassifier(
            r'F:\train\train_over_xml\out_17364\0.9995\cascade_17364_9_0.9995.xml')    
    img = cv2.imread(filename)
    gray = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
    
    faces = face_cascade.detectMultiScale(gray,1.3,5)
    
    for (x,y,w,h) in faces:
        img = cv2.rectangle(img, (x,y), (x+w,y+h), (255,0,0),2)
    
    cv2.namedWindow('Person Detected!')
    cv2.imshow('Person Detected!',img)
    cv2.waitKey(0)
    cv2.destroyAllWindows()

if __name__ == '__main__':
    #detect(r'C:\Users\lenovo\Desktop\piture\6.jpg')
    detect(r'F:\train\test\17.jpg')
    
