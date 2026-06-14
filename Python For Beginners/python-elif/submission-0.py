def check_range(num: int) -> str:
    if num >= 10:
        return "positive multi digit"
    elif num >= 1:
        return "positive single digit"
    elif num == 0:
        return "zero"
    else:
        return "negative"







  
# don't modify code below this line
print(check_range(-10))
print(check_range(0))
print(check_range(9))
print(check_range(1000))
