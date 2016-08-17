        private static int _id = 1;

        public FileDiff()
        {
            Id = _id++;
        }

        public int Id { get; }

            ParserAction start = (line, m) =>
            {
            ParserAction restart = (line, m) =>
            {
            ParserAction new_file = (line, m) =>
            {
            ParserAction deleted_file = (line, m) =>
            {
            ParserAction index = (line, m) =>
            {
            ParserAction from_file = (line, m) =>
            {
            ParserAction to_file = (line, m) =>
            {
            ParserAction chunk = (line, match) =>
            {
            ParserAction del = (line, match) =>
            {
            ParserAction add = (line, m) =>
            {
            Action<string> normal = line =>
            {
            Func<string, bool> parse = line =>
            {
            s = s.TrimStart('-', '+');
            // ignore possible time stamp
            var t = new Regex(@"\t.*|\d{4}-\d\d-\d\d\s\d\d:\d\d:\d\d(.\d+)?\s(\+|-)\d\d\d\d").Match(s);
            // ignore git prefixes a/ or b/
            return Regex.IsMatch(s, @"^(a|b)\/")
                ? s.Substring(2)