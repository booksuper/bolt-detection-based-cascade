opencv_traincascade.exe -data bolt -vec posvec.vec -bg neg.txt -numPos 217 -numNeg 1000 -numStages 10 -w 40 -h 40 -minHitRate 0.999 -maxFalseAlarmRate 0.2 -weightTrimRate 0.95 -featureType LBP
pause
