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

"""
test Balance Tree AVL
"""

    def Height(B):
    if B is None:
        return -1
    return max(Height(B.left), Height(B.right))+1

def __isbalanced(B):
    """
    retourne (la hauteur de l'arbre, booléen = est-ce que l'arbre est h-équilibré)
    """
    l = Height(B.left)
    r = Height(B.right)
    if abs(l - r) <= 1:
        return True
    else:
        return False

def isbalanced(B):
    result = __isbalanced(B)
    return result
