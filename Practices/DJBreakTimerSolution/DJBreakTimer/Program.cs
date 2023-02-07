Console.WriteLine("Enter how long in minutes is your break:");
var minutes = int.Parse(Console.ReadLine());

Console.WriteLine("Enter how long the song is (in minutes:seconds):");
var songLength = Console.ReadLine();
string[] song = songLength.Split(":");
var songMinutes = int.Parse(song[0]);
var songSeconds = int.Parse(song[1]);

var now = DateTime.Now;
TimeSpan.FromMinutes(minutes);
var endOfBreak = now + TimeSpan.FromMinutes(minutes);
var startOfSong = endOfBreak - TimeSpan.FromMinutes(songMinutes) - TimeSpan.FromSeconds(songSeconds);
Console.WriteLine($"End of break: {endOfBreak}");
Console.WriteLine($"Suggested start of the song: {startOfSong}");
Thread.Sleep(1000); //When the program stops a certain amount of seconds, 1000 = 1 sec