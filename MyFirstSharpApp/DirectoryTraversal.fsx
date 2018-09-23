module DirectoryTraversal =
    open System
    open System.IO
    
    let directories = Directory.GetDirectories(@"D:\Learning\Python\Automate the Boring Stuff with Python Programming")
    
    directories
    |> Array.map (fun d -> DirectoryInfo(d))
    |> Array.collect (fun dir -> dir.GetFiles())
    |> Array.groupBy (fun file -> file.DirectoryName)
    |> Array.map (fun dir -> 
           fst dir,snd dir
           |> Array.map (fun f -> f.Length)
           |> Array.sum)
    |> Array.sortByDescending(fun f-> snd f)
    
    
    let sum inputs = 
        let mutable accumulator = 0
        for input in inputs do 
            accumulator <- accumulator + input
            
        accumulator
    
    
    let length inputs = 
        let mutable size = 0
        for input in inputs do 
            size <- size + 1
        size
        
    let max (inputs : seq<int>) =
        let mutable max = System.Int32.MinValue
        for input in inputs do
            if input < max then max <- max
            else max <- input
        max
        
    let sumFold inputs = 
        Seq.fold 
            (fun state input -> state + input)
            0
            inputs
    
    let lengthFold inputs = 
        Seq.fold
            (fun state input -> state + 1)
            0
            inputs
    let maxFold inputs =
        (System.Int32.MinValue, inputs)
        ||> Seq.fold (fun state input -> 
                if state > input then state
                else input)