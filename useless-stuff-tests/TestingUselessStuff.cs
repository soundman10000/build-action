﻿// Tests for useless stuff

using FluentAssertions;
using UselessStuff;
using Xunit;

namespace useless_stuff_tests;

public class TestingUselessStuff
{
    [Fact]
    public void TestOne()
    {
        const string world = "world";
        world.TurnStringIntoHello().Should().Be("Hello");
    }

    [Fact]
    public void BadTest()
    {
        "a".Equals("b").Should().BeFalse();
    }

    [Fact]
    public void AnotherTest()
    {
        "a".Equals("b").Should().BeFalse();
    }

    [Fact]
    public void AnotherTest1()
    {
        "a".Equals("b").Should().BeFalse();
    }

    [Fact]
    public void AnotherTest2()
    {
        "a".Equals("b").Should().BeFalse();
    }

    [Fact]
    public void AnotherTest3()
    {
        "a".Equals("b").Should().BeFalse();
    }

    [Fact]
    public void AnotherTest4()
    {
        "a".Equals("b").Should().BeFalse();
    }
}