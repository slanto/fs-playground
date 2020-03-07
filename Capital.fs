module Capital
    let private isWord (words: string list) =
        let wordTable = Set.ofList words
        fun w -> wordTable |> Set.contains w

    let isCapital = isWord ["Warsaw";"London";"Paris";"Madrit"] 