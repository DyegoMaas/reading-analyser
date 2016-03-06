module ReadingAnalyser.Tests

open ReadingAnalyser.BookStatistics
open System
open NUnit.Framework
open FsUnit

[<Test>]
let ``getting 20% remaining from 2h listened and 8h remaining`` () =
    let timeListened = TimeSpan.FromHours 2.0
    let timeRemained = TimeSpan.FromHours 8.0
    let remainingPercentage = Audiobook.GetRemainingPercentage 
    
    remainingPercentage |> should equal 20.0
//    let result = Library.hello 42
//    printfn "%i" result
//    Assert.AreEqual(42,result)
