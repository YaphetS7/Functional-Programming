type F = 
  | AM
  | PM

type TimeOfDay = { hours : int; minutes : int; f: F }

let (.>.) x y =
    if x.f = y.f then
        if x.hours = y.hours then
            x.minutes > y.minutes
        else
            x.hours > y.hours
    else
        x.f > y.f