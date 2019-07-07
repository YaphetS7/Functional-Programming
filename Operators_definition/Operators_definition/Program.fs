// 23.4.1
let change (a,b,c) = 
    let total = a * 240 + b * 12 + c
    let gold = total / 240
    let silver = (total - gold * 240) / 12
    let copper = total - gold * 240 - silver * 12
    (gold, silver, copper)

let (.+.) x y =
    let (x1, y1, z1) = x 
    let (x2, y2, z2) = y 
    change(x1 + x2, y1 + y2, z1 + z2)

let (.-.) x y = 
    let (x1, y1, z1) = x 
    let (x2, y2, z2) = y 
    change(x1 - x2, y1 - y2, z1 - z2)

// 23.4.2
let (.+) x y = 
    let (x1, y1) = x 
    let (x2, y2) = y
    (x1 + x2,y1 + y2)

let (.-) x y = 
    let (x1, y1) = x 
    let (x2, y2) = y
    (x1 - x2,y1 - y2)

let (.*) x y = 
    let (x1, y1) = x
    let (x2, y2) = y 
    (x1 * x2 - y1 * y2, x1 * y2 + y1 * x2)

let (./) x y = 
    let (x1, y1) = x
    let (x2, y2) = y 
    ((x1 * x2 + y1 * y2)/(x2 * x2 + y2 * y2),(y1 * x2 - x1 * y2)/(x2 * x2 + y2 * y2))