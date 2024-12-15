let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printfn "%d %d" x y // Output: 20 10

//However, if you try this:

let swap' (x,y) = (y,x)
let x', y' = swap' (x, y)
printfn "%d %d" x y // Output: 20 10

//The values of x and y are changed in the first example because the function modifies mutable variables that are passed by reference.
//In the second example, the values are not changed because the tuple is passed by value, and the function returns a new tuple.
//This is a subtle difference that can cause unexpected behavior if you're not careful.