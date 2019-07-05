// 16.1
let notDivisible (n, m) = m % n = 0

// 16.2
let rec loop_func = function 
    | (n, i) when n = i -> true
    | (n, i) when (n % i) = 0 -> false
    | (n, i) -> loop_func(n, i+ 1)

let prime = function
    | 1 -> false
    | 2 -> true
    | n -> loop_func(n, 2)

