let x = 10
let y = 20

let add x y = x + y

let z = add x y

printfn "%d" z // Output: 30

// To dynamically update based on changes in x and y, create a function which takes x and y as arguments rather than using mutable variables:

let addDynamic x y = x + y

let mutable x1 = 10
let mutable y1 = 20

printfn "%d" (addDynamic x1 y1) //Output 30

x1 <- 30
y1 <- 40

printfn "%d" (addDynamic x1 y1) // Output 70