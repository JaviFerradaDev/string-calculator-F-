namespace StringCalculator

module Tests =
    // Define a function to run tests
    let RunTests (addFunction: string -> int) =
        printfn "Test Case 1: Empty String"
        printfn "Result: %d (Expected: 0)" (addFunction "")
        printfn ""

        printfn "Test Case 2: Single Number"
        printfn "Result: %d (Expected: 5)" (addFunction "5")
        printfn ""

        printfn "Test Case 3: Multiple Numbers"
        printfn "Result: %d (Expected: 6)" (addFunction "1,2,3")
        printfn ""

        
