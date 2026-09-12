using HelloActions;
using Xunit;

namespace HelloActions.Tests;

public class GreetingTests
{
    [Fact]
    public void MessageFor_includes_the_name()
    {
        Assert.Equal("Hello, GitHub Actions!", Greeting.MessageFor("GitHub Actions"));
    }

    [Fact]
    public void MessageFor_handles_a_different_name()
    {
        Assert.Equal("Hello, learner!", Greeting.MessageFor("learner"));
    }
}
