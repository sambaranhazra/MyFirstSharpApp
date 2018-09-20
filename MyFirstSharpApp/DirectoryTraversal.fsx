module DirectoryTraversal =
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
    