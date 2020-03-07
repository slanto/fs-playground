// Learn more about F# at http://fsharp.org

open System
open City

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn  "%A" (isCapital "Warsaw")
    printfn  "%A" (isCapitalSlow "Warsaw")
    printfn  "%A" (isCapitalSlow2 "Warsaw")
    printfn  "%A" (isCapitalSlow3 "Warsaw")
    0 // return an integer exit code
