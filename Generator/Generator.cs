namespace Generator
{
    public class Generator
    {
        public class ClassInfo
        {
            public string ClassName { get; }
            public string TestsFile { get; }

            public ClassInfo(string className, string testsFile)
            {
                ClassName = className;
                TestsFile = testsFile;
            }
        }

        private class ClassData
        {
            public string ClassName { get; }

        }
    }
}