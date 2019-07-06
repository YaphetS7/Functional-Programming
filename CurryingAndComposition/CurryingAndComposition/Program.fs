// 20.3.1
let vat n x = x*(1.0 + float(n / 100))

// 20.3.2
let unvat n x = x * 100.0 / float(n + 100)

// 20.3.3
let rec find_min = function
    |(f,n) when f(n) = 0 -> n
    |(f,n) -> find_min(f,n+1)

let rec min f = find_min(f, 1)