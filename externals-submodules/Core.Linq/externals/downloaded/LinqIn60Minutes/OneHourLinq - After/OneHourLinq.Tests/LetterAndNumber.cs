namespace OneHourLinq.Tests
{
    class LetterAndNumber
    {
        public char Letter { get; set; }
        public int Number { get; set; }

        public LetterAndNumber(char letter, int number)
        {
            Letter = letter;
            Number = number;
        }

        public LetterAndNumber(string both)
        {
            Letter = (char)both[0];
            Number = int.Parse(both.Substring(1));
        }

        public static implicit operator LetterAndNumber(string both)
        {
            return new LetterAndNumber(both);
        }

        public override bool Equals(object obj)
        {
            LetterAndNumber other = (LetterAndNumber)obj;
            return Letter == other.Letter && Number == other.Number;
        }

        public override int GetHashCode()
        {
            return Number * 37 + Letter;
        }

        public override string ToString()
        {
            return Letter + "" + Number;
        }
    }
}