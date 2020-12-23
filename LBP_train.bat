opencv_traincascade.exe -data bolt -vec posvec.vec -bg neg.txt -numPos 295 -numNeg 1500 -numStages 12 -w 40 -h 25 -minHitRate 0.999 -maxFalseAlarmRate 0.2 -weightTrimRate 0.95 -featureType LBP -precalcValBufSize 1024 -precalcIdxBufSize 1024
pause
