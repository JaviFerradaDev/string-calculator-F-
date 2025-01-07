namespace StringCalculator

module Main = // Define the main module
    open System // Import the System library
    open Tests // Import the Tests module

    // Function to add numbers in a string
    let Add (numbers: string) : int = // string -> int
        if String.IsNullOrWhiteSpace(numbers) then
            0 // Return 0 for empty or whitespace string
        else
            let parts: string array = numbers.Split(separator = ',') // Split the string by commas
            parts |> Array.map Int32.Parse |> Array.sum // Convert to integers and sum them

    [<EntryPoint>]
    let main argv: int = // []<string> -> int
        Tests.RunTests(Add) // Pass the Add function to the Tests module
        0 // Exit code

