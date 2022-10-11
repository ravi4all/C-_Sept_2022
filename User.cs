namespace Greet {
    class GreetApp {
        public static void greetUser()  {
	        System.Console.WriteLine("Hello User...");
        }
    }
}

class User {
     public static void Main(string[] args) {
            Greet.GreetApp.greetUser();
    }
}






