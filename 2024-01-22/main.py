# A - 7-el osztható 100-nál kisebb páros számok
A =[]
for szam in range(1,100):
    if szam % 2 == 0:
        A.append(szam)
print(*A)# csillag lista előtt - 