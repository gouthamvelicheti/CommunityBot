﻿namespace Data.Challenges;

public enum ProgrammingLanguage
{
    Python
}

public class ProgrammingChallenge
{
    public int Id { get; set; }
    public string Title { get; set; } = default!;
    
    /// <summary>
    /// Question to pose to the user
    /// </summary>
    public string Question { get; set; } = default!;
    
    /// <summary>
    /// Bit more explanation to provide to the user
    /// </summary>
    public string Explanation { get; set; } = default!;
    
    /// <summary>
    /// Optional tip to give to user on how to solve it
    /// </summary>
    public string? Tip { get; set; } = default!;
    
    /// <summary>
    /// Associated tests that go with this challenge, if any
    /// </summary>
    public List<ProgrammingTest> Tests { get; set; } = new();

    /// <summary>
    /// Indicates whether this challenge takes performance into consideration
    /// </summary>
    public bool IsTimed { get; set; } = false;
}

public class ProgrammingTest
{
    public int Id { get; set; }
    
    /// <summary>
    /// Foreign key to <see cref="ProgrammingChallenge"/> 
    /// </summary>
    public int ProgrammingChallengeId { get; set; }
    
    /// <summary>
    /// Optional amount of time to specify. If a test takes more than specified amount of time - it will shut down. Otherwise, no timeout
    /// </summary>
    public int? TimeoutInMinutes;

    /// <summary>
    /// Language the user can utilize for solving the challenge.
    /// </summary>
    public ProgrammingLanguage Language { get; set; }

    /// <summary>
    /// Docker image to utilize for things
    /// </summary>
    public string TestDockerImage { get; set; } = default!;

    /// <summary>
    /// This overrides the entrypoint on <see cref="TestDockerImage"/>
    /// </summary>
    public string DockerEntryPoint { get; set; } = default!;

    /// <summary>
    /// Path in which to mount a file to within <see cref="TestDockerImage"/>
    /// </summary>
    public string ExecutableFileMountDestination { get; set; } = default!;
}