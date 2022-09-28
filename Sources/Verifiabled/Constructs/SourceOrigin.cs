namespace Verifiabled.Constructs
{
    public readonly struct SourceOrigin
    {
        public string FilePath { get; }
        public int LineNumber { get; }

        public SourceOrigin(string filePath, int lineNumber)
        {
            FilePath = filePath;
            LineNumber = lineNumber;
        }
    }
}
