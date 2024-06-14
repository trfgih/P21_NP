#s = 82 * "8"
#while("1111" in s) or ("8888" in s):
#    if "1111" in s: s=s.replace("1111","8",1)
#    else: s=s.replace("8888","11",1)
#print(s)

#s=2*729**2014+2*81**2018+2*27**2020-2*9**2022-2024
#count=0
#while s!=0:
#    if s%27>9:
#        count +=1
#    s=s//27
#print(count)

#for a in range(100,0,-1):
#    k=0
#    for x in range(1,1000):
#        if (x%a !=0) <= ((x%14==0)<=(x%4 !=0)):
#            k+=1
#        if k==999:
#            print(a)
#            break

#import sys 
#sys.setrecursionlimit(10**6)
#def f(n):
#    if n==1:return 1
#    else: return n*f(n-1)
#print((f(2024)-f(2023))//f(2022))

#count = max_i = 0
#f=open('17.txt')
#a=[int(i) for i in f]
#ax=min([x for x in a if x%19==0])
#for i in range(len(a) - 1):
#    if (a[i]%ax==0) or (a[i+1]%ax==0):
#        count+=1
#        max_i=max(max_i,a[i]+a[i+1])
#print(count,max_i)



