// Learn more about F# at http://fsharp.org

open System
open Capital

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn  "%A" (Capital.isCapital "Warsaw")
    0 // return an integer exit code
