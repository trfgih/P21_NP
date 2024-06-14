#for i in range(1,1000):
#    n = i
#    s=""
#    while n>0:
#        s+=str(n%3)
#        n//=3
#    s = str(i%3)+s
#    r=0
#    for j in range(len(s)):
#        r+=int(s[j])*3**j 
#        if r>999:
#            print(r)
#            break

#from itertools import product
#c=0
#for i in product("012345678", repeat=7):
#    if i.count("6")==1 and i[0]!="0" and (i.count("1")+i.count("3")+i.count("5")+i.count("7"))==2:
#        c+=1
#print(c)

#s=2*729**2014 + 2*81**2018 + 2*27**2020 - 2*9**2022 - 2024
#c=0
#while s!=0:
#    if s%27>9: c+=1
#    s=s//27
#print(c)'

#for a in range(100,0,-1):
#    k=0
#    for x in range(1,1000):
#        if(x%a!=0)<=((x%14==0)<=(x%4!=0)):
#            k+=1
#    if k==999:
#        print (a)
#        break

for x in range(174457,174505+1):
    k=0
    s=[]
    for y in range(2,x//2+1):
        if x%y==0:
            k+=1
            s.append(y)
            if k>2:
                break
    if k==2:
        print(*s)