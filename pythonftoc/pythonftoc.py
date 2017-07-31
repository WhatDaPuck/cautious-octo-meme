#!/usr/bin/env python3
import time


lower = 0
upper = 1000000
step = 5

fahr = lower
start = time.time()
while(fahr <= upper):
    celsius = (5.0 / 9.0) * (fahr - 32.0);
    print(fahr, celsius)
    fahr = fahr + step
end = time.time()
print(end - start)