module FizzBuzz.Tests

open NUnit.Framework
open FizzBuzz

type FizzBuzzGenerationTests () =

    [<Test>]
    member __.TestOneReturnOne () =
        Assert.AreEqual("1", FizzBuzzGenerator.gen 1)
        Assert.AreEqual("1", FizzBuzzGenerator.genSimplified 1)

    [<Test>]
    member __.TestOneReturnFizz () =
        Assert.AreEqual("Fizz", FizzBuzzGenerator.gen 3)
        Assert.AreEqual("Fizz", FizzBuzzGenerator.genSimplified 3)

    [<Test>]
    member __.TestFiveReturnBuzz () =
        Assert.AreEqual("Buzz", FizzBuzzGenerator.gen 5)
        Assert.AreEqual("Buzz", FizzBuzzGenerator.genSimplified 5)

    [<Test>]
    member __.TestFifteenReturnFizzBuzz () =
        Assert.AreEqual("FizzBuzz", FizzBuzzGenerator.gen 15)
        Assert.AreEqual("FizzBuzz", FizzBuzzGenerator.genSimplified 15)