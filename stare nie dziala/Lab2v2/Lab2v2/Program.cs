namespace Lab2v2 {
    internal class Program {
        static void Main(string[] args) {
            GetAPI api = new GetAPI();
            api.GetData().Wait();
        }
    }
}
