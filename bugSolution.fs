let x = 10
let y = 20

let swap x y =
    (y, x)

let x', y' = swap x y
printfn "%d %d" x y // Output: 10 20
printfn "%d %d" x' y' // Output: 20 10

//Alternatively, using a record:

type Swappable = {X : int; Y : int}

let swapRecord (r: Swappable) = { r with X = r.Y; Y = r.X }

let r = { X = 10; Y = 20 }
let r' = swapRecord r
printfn "%d %d" r.X r.Y // Output: 10 20
printfn "%d %d" r'.X r'.Y // Output: 20 10