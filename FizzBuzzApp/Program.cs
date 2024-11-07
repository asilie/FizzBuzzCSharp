// See https://aka.ms/new-console-template for more information

for (int i = 1; i <= 100; i++) {
    string answer = "";
    
    if (i % 3 == 0) { 
        answer = "Fizz";
    } 
    
    if (i % 5 == 0) {
       answer += "Buzz";
    }

    if (i % 7 == 0)
    {
        answer += "Bang";
    }
    
    if (string.IsNullOrEmpty(answer)){
        Console.WriteLine(i);
    } else {
        Console.WriteLine(answer);
    }
}