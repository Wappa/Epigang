"""
This is my my repository for Homework/training in Python
I Hope you will found it useful.

Have Fun my friend !

S/o Apero
S/o Belveteh
"""
def search(x):
    # Base Cases: root is null or key is present at root
    if B.key == None or B == None:
        return B.key
    if x < B.key :
        return search(x.left.key)
    if x > B.key:
        return search(x.right.key)

def insert(x):
    if B.key == None:
        return x
    else:
        if x > B.key:
            if B.right == None:
                B.right = x
            else:
                insert(B.right.key)
        else:
            if B.left == None:
                B.left = x
            else:
                insert(B.left.key)
