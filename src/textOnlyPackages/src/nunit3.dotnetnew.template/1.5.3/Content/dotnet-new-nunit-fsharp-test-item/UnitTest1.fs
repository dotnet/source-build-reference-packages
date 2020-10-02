namespace Tests

open NUnit.Framework

[<TestClass>]
type UnitTest1 () =

    [<SetUp>]
    member this.Setup () =
        ()

    [<Test>]
    member this.Test1 () =
        Assert.Pass()
