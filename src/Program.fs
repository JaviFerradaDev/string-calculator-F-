open System //import the module of the .NET library 

//Function to add numbers in a string ("let" define a function en F#)
let Add (numbers: string) : int = //means that the function receives an argument called numbers, which is a string and return a int (número entero)
    if String.IsNullOrWhiteSpace(numbers) then
        0 //for empty string
    else
        let parts = numbers.Split(',') //split the string by comma
        parts |> Array.map Int32.Parse |> Array.sum //convert to integers and sum them

[<EntryPoint>]
let main argv =
    printfn "Result: %d" (Add "1,2") // Test the Add function
    0 // Exit code
