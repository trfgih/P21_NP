#f= open('17.txt')
#a=[int(i) for i in f]
#c=0
#e=30000
#for i in range(1,len(a)-1):
#    x,y,z = a[i-1],a[i], a[i+1]
#    if 100<=abs(x)<=999 or 100<=abs(y)<=999 or 100<=abs(z)<=999:
#        if x+y+z <= max(x,y,z):
#            if abs(max(x,y,z))%10 !=1:
#                c+=1
#                e=min(e,x+y+z)
#print(c,e)

#from functools import lru_cache

#def moves(h):
#    a,b=h 
#    return (a+2,b),(a,b+2),(a*2,b),(a,b*2)

#@lru_cache(None)
#def f(h):
#    if sum(h)>=74:return 'end'
#    if any (f(x) == 'end' for x in moves(h)): return 'p1'
#    if all (f(x) == 'p1' for x in moves(h)): return 'v1'
#    if any (f(x) == 'v1' for x in moves(h)): return 'p2'
#    if all (f(x) == 'p1' or f(x) =='p2'  for x in moves(h)): return 'v2'


#for i in range(1,66):
#    h=7,i 
#    if f(h) =='v2':
#        print(i)


#a=[0]*20
#a[3]=1
#for i in range(4,18):
#    a[i] = a[i-1]+a[i//2]*(i%2==0)
#    if i == 7 or i==10:
#        for x in range(i):
#            a[x]=0
#print(a[17])

#f=open("24.txt")
#l=f.readline()
#l=l.replace("AAA","A A A").replace("AA","A A").split()
#ans=0
#for i in l:
#    ans=max(ans,len(i))
#print(ans)

#from fnmatch import*

#for i in range(2024,10**8+1,2024):
#    if fnmatch(str(i),"2*93?28"):
#        print(i,i//2024)

#f=open("26.txt")
#n=int(f.readline())
#a=[int(x) for x in f.readlines()]
#a.sort(reverse=True)
#gift=[a[0]]
#for i in range(n):
#    if gift[-1]-a[i]>=6:
#        gift.append(a[i])
#print(len(gift), gift[-1])