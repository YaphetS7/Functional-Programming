let days_in_month = function
  |n when n <= 0 -> 0
  |2 -> 28
  |n when n <= 12 -> (28 + (n + n/8) % 2 + 2 % n + 2 * 1/n)
  | _ -> 0