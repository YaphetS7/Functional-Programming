﻿// 17.1
let rec pow  = function
    | (s, 0) -> ""
    | (s, n) when s = "" || n < 0 -> ""
    | (s, n) -> s + pow(s, n - 1)

// 17.2
let rec isIthChar  = function
    | (s, n, c) when n < 0 || n + 1 > String.length s -> false
    | (s, n, c) -> s.[n] = c

// 17.3
let rec occFromIth  = function 
    | (s, n, c) when n + 1 > String.length s || n < 0 -> 0
    | (s, n, c) when s.[n] = c -> 1 + occFromIth(s, n + 1, c)
    | (s, n, c) -> occFromIth(s, n + 1, c)
