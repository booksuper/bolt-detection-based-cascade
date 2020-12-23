import cv2
def detect():
    # 加载Haar级联数据文件，用于检测人面
    face_cascade = cv2.CascadeClassifier('F:/train/train_over_xml/out_6804/0.9995/cascade_6804_12_0.9995.xml')
    #eye_cascade = cv2.CascadeClassifier('cascades/haarcascade_eye.xml')
    camera = cv2.VideoCapture('F:/train/0.5.mp4')
    while True:
        ret, frame = camera.read()
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
        # 人面识别。detectMultiScale参数说明：
        # gray: 进行检测的图像, 这里是转换后的。
        # scaleFactor: 官网文档说是每次图片缩小的比例, 其实可以这么理解, 距离相机不同的距离, 物体大小是不一样的,
        # 在物体大小不一致的情况下识别一个东西是不方便的, 这就需要进行多次的缩放, 这就是这个参数的作用。
        # minNeighbors: 可以理解为每次检测时, 对检测点(Scale)周边多少有效点同时检测, 因为可能选取的检测点大小不足而导致遗漏。
        # minSize: 检测点的最小值, 或者说就是检测点的最终值。
        faces = face_cascade.detectMultiScale(gray, scaleFactor=1.2, minNeighbors=5, minSize=(5,5))
        # 画出面部位置
        for (x, y, w, h) in faces:
            img = cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 2)
            # 画出眼部位置
            #eyes = eye_cascade.detectMultiScale(gray, scaleFactor=1.2, minNeighbors=5, minSize=(5, 5))
            #for (ex, ey, ew, eh) in eyes:
            #    cv2.rectangle(img, (ex, ey), (ex + ew, ey + eh), (0, 255, 0), 2)
            # 显示图像
            cv2.imshow('pic', frame)
        # 停止程序
        if cv2.waitKey(120) & 0xff == ord('q'):
            break
    camera.release()
    cv2.destroyAllWindows()

detect()
