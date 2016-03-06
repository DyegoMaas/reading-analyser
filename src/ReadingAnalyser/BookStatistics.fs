namespace ReadingAnalyser

open System

module BookStatistics =

    module Audiobook =
    
        let GetRemainingPercentage (timeListened:TimeSpan, timeRemaining:TimeSpan) : double = 
            let milisecondsCompleted = timeListened.TotalMilliseconds
            let milisecondsRemaining = timeRemaining.TotalMilliseconds

            let audiobookDuration = milisecondsCompleted + milisecondsRemaining
            let percentageCompleted =  milisecondsCompleted / audiobookDuration * 100.0
            percentageCompleted
            