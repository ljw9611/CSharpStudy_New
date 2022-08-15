namespace N_Placeholder
{
    public class Placeholder
    {
        public void PlaceholderEx()
        {
            Console.WriteLine("{0}", "한놈", "두시기", "석삼", "너구리", "오징어");// {0} 자리 출력
            Console.WriteLine("{0},{1}", "한놈", "두시기", "석삼", "너구리", "오징어");// {0,1} 자리 출력

            Console.WriteLine("{0},{1}","{2}", "한놈", "두시기", "석삼", "너구리", "오징어");
            // {0,1} 자리 출력 - 첫번째에서 선언한 인덱스만 출력이 된다 result = {2}, 한놈
            Console.WriteLine("{0},{1},{2}", "한놈, 두시기", "석삼, 너구리", "오징어");
            Console.WriteLine("{0},{1},{2},{3},    {4}", "한놈", "두시기", "석삼", "너구리", "오징어");
        }
    }
}
