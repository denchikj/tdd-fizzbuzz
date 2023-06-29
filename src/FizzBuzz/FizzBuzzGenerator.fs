namespace FizzBuzz

module FizzBuzzGenerator =
    let gen x =
        [| (if x % 3 = 0 then "Fizz" else ""); (if x % 5 = 0 then "Buzz" else "") |]
        |> Array.reduce (+)
        |> function
            | "" -> sprintf "%d" x
            | __ -> __

    let genSimplified x =
        let array =
            [| (if x % 3 = 0 then "Fizz" else ""); (if x % 5 = 0 then "Buzz" else "") |]

        let reduction acc item = acc + item
        let arrayReducer = Array.reduce reduction array

        match arrayReducer with
        | "" -> sprintf "%d" x
        | __ -> __
