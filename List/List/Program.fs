﻿// 34.1
let rec upto = function
    |n -> 1 :: [2..n]
    
// 34.2
let rec dnto = function
    |1 -> [1] 
    |n -> n :: dnto (n-1)
    
//34.3
let rec iter = function
    |(n,i) when i <= n -> i :: iter(n , i + 2)
    |(n,i) when i > n -> []
    |(n,i) -> []
let rec evenn = function
    |n -> iter(n, 0)
