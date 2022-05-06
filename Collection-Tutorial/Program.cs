

var frames = new List<int>(); //constructor to initialize new instance of list
var rand = new Random();
var highscore = 300;
var total = 0;
long games = 0;
var highest = 0;

while (total < highscore) {

    frames.Clear();
    total = 0;
    games++;

    for (int idx = 1; idx <= 10; idx++) {
        var score = rand.Next(0, 31);
        frames.Add(score);
    }

    foreach (var frame in frames) {//not necessary can total during for loop
        total += frame;
        
    }
    if (total > highest) { highest = total; }
    if (games % 100000000 ==0) {
        Console.WriteLine($"{games:n0} games have been played. Highest score: {highest}");
    }
}


Console.WriteLine($"{total} points after {games} games");