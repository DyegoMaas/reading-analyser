namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ReadingAnalyser")>]
[<assembly: AssemblyProductAttribute("ReadingAnalyser")>]
[<assembly: AssemblyDescriptionAttribute("Analisa o progresso de leitura de livros e audiobooks")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
