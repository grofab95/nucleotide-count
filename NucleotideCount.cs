using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        var acceptedLetters = new List<char> { 'A', 'C', 'G', 'T' };
        if (sequence.Any(c => !acceptedLetters.Contains(c)))
            throw new ArgumentException();

        var nucleotides = acceptedLetters.ToDictionary(x => x, x => 0);
        sequence.ToCharArray()
            .GroupBy(x => x)
            .ToList()
            .ForEach(y => nucleotides[y.Key] = y.Count());

        return nucleotides;
    }
}