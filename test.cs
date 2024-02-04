Integer: Gcd(Integer: a, Integer: b)
    while   (b != 0)
        Integer: remainder = a mod b
        a = b 
        b = remainder
    End while
    return a 
end Gcd