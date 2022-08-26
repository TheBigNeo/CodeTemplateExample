using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;

namespace CodeTemplateExample;

public static class StringHelper
{
    /// <summary>
    ///     Check if the given <paramref name="value" /> has non white-space text.
    /// </summary>
    /// <param name="value">to test</param>
    /// <returns><c>true</c> if the <paramref name="value" /> has text</returns>
    [CodeTemplate("string.IsNullOrWhiteSpace($expr$) is false",
        Message = $"Suggestion: Simplify with '{nameof(HasText)}'",
        ReplaceTemplate = $"$expr$.{nameof(HasText)}()",
        ReplaceMessage = $"Convert to '{nameof(StringHelper)}.{nameof(HasText)}'",
        SuppressionKey = $"SimplifyWith{nameof(HasText)}",
        MatchSimilarConstructs = true,
        ShortenReferences = true)]
    [CodeTemplate("!string.IsNullOrWhiteSpace($expr$)",
        Message = $"Suggestion: Simplify with '{nameof(HasText)}'",
        ReplaceTemplate = $"$expr$.{nameof(HasText)}()",
        ReplaceMessage = $"Convert to '{nameof(StringHelper)}.{nameof(HasText)}'",
        SuppressionKey = $"SimplifyWith{nameof(HasText)}",
        MatchSimilarConstructs = true,
        ShortenReferences = true)]
    [Pure]
    [ExcludeFromCodeCoverage]
    public static bool HasText([NotNullWhen(true)] this string? value)
    {
        // ReSharper disable once SimplifyWithHasText
        return string.IsNullOrWhiteSpace(value) is false;
    }
}