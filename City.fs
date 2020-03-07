module City
    let private isWord (words: string list) =
        let wordTable = Set.ofList words
        fun w -> wordTable |> Set.contains w

    let private isWordSlow2 (words: string list) (word: string) =
        List.exists (fun w -> word = w) words //wrong data structure -> list O(n)

    let private isWordSlow3 (words: string list) (word: string) =
        let wordTable = Set<string>(words)
        wordTable.Contains word

    let Capitals = ["Warsaw";"London";"Paris";"Madrit"]

    let isCapital = isWord Capitals 
    let isCapitalSlow word = isWord Capitals word
    let isCapitalSlow2 word = isWordSlow2 Capitals word
    let isCapitalSlow3 word = isWordSlow3 Capitals word