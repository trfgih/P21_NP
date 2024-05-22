#for x in 0,1:
#    for y in 0,1:
#        for z in 0,1:
#            if not((y==(not x)) <=((z or x) ==y)):
#                print(x,y,z)

#from turtle import*
#speed(10);
#m=20
#right(30)

#for i in range(10):
#    forward(10*m)
#    right(120)
#up()

#for x in range(-15,15):
#    for y in range(-15,15):
#        goto(x*m,y*m)
#        dot(5,'red')

k=0
for x1 in '123':
    for x2 in '0123':
        for x3 in '0123':
            for x4 in '0123':
                for x5 in '0123':
                    s=x1+x2+x3+x4+x5
                    if s.count('02')==0 and s.count('20')==0 and s.count('13')==0 and s.count('31')==0:
                        k+=1
print(k)

