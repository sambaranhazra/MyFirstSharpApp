open System
let replace (oldString:string) (newString:string) (input:string) = 
    input.Replace(oldString, newString)

let toRomanNumerals number = 
    let replace_IIIII_V = replace "IIIII" "V"
    let replace_VV_X = replace "VV" "X"
    let replace_XXXXX_L = replace "XXXXX" "L"
    let replace_LL_C = replace "LL" "C"
    let replace_CCCCC_D = replace "CCCCC" "D"
    let replace_DD_M = replace "DD" "M"

    String.replicate number "I"
    |> replace_IIIII_V
    |> replace_VV_X
    |> replace_XXXXX_L
    |> replace_LL_C
    |> replace_CCCCC_D
    |> replace_DD_M