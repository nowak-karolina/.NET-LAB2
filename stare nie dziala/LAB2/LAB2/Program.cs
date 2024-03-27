namespace LAB2 {
    internal class Program {
        static void Main(string[] args) {
            ApiTest test = new ApiTest();
            test.GetData().Wait();

        }
    }
}
