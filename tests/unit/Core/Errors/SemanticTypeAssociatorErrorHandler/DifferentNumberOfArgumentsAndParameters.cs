﻿namespace Paraminter.Semantic.Type.Apheleia.Errors;

using Paraminter.Cqs.Handlers;
using Paraminter.Semantic.Type.Apheleia.Errors.Commands;

using Xunit;

public sealed class DifferentNumberOfArgumentsAndParameters
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsHandler()
    {
        var result = Target();

        Assert.Same(Fixture.DifferentNumberOfArgumentsAndParametersMock.Object, result);
    }

    private ICommandHandler<IHandleDifferentNumberOfArgumentsAndParametersCommand> Target() => Fixture.Sut.DifferentNumberOfArgumentsAndParameters;
}