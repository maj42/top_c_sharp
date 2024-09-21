using System.Text;

namespace homework_16_16._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.a
            // 1.b
            Dot<double> dot1 = new Dot<double>(1.2, 3.3);
            Dot<double> dot2 = new Dot<double>(5.4, 2.2);
            Line<double> line1 = new Line<double>(dot1, dot2);
            Line<int> line2 = new Line<int>(3, 4, 12, 34);
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine();

            // 1.c
            string text = "What the fuck did you just fucking say about me, you little bitch? " +
                "I'll have you know I graduated top of my class in the Navy Seals, and I've been involved in numerous secret raids on Al-Quaeda, " +
                "and I have over 300 confirmed kills. I am trained in gorilla warfare and I'm the top sniper in the entire US armed forces. " +
                "You are nothing to me but just another target. I will wipe you the fuck out with precision the likes of which has never been " +
                "seen before on this Earth, mark my fucking words. You think you can get away with saying that shit to me over the Internet? " +
                "Think again, fucker. As we speak I am contacting my secret network of spies across the USA and your IP is being traced right" +
                " now so you better prepare for the storm, maggot. The storm that wipes out the pathetic little thing you call your life." +
                " You're fucking dead, kid. I can be anywhere, anytime, and I can kill you in over seven hundred ways, and that's just with my bare hands." +
                " Not only am I extensively trained in unarmed combat, but I have access to the entire arsenal of the United States Marine Corps " +
                "and I will use it to its full extent to wipe your miserable ass off the face of the continent, you little shit. " +
                "If only you could have known what unholy retribution your little \"clever\" comment was about to bring down upon you, " +
                "maybe you would have held your fucking tongue. But you couldn't, you didn't, and now you're paying the price, you goddamn idiot. " +
                "I will shit fury all over you and you will drown in it. You're fucking dead, kiddo.";
            Dictionary<string, int> words = new();
            foreach (var word in text.Split('.', ' ', ',', '?', '!'))
            {
                if (word == "") continue;
                if (words.ContainsKey(word)) words[word]++;
                else words[word] = 1;
            }
            foreach (var kvp in words.OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine();

            //2
            List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6 };
            ints.RemoveAll(x => x % 2 != 0 );
            Console.WriteLine("List without odds:");
            ints.ForEach(x => Console.Write(x + " "));
            Console.WriteLine("\n");

            //3
            ToDoList list = new ToDoList();
            list.AddTask("Go to store");
            list.AddTask("Go to work", 2);
            list.AddTask("Rest", 1);
            list.AddTask("Go from work", 2);

            Console.WriteLine("Print:");
            Console.WriteLine(list);
            Console.WriteLine("Priority:");
            list.ShowPriority(2);
            Console.WriteLine();
            list.RemoveTask(1);
            Console.WriteLine("Removed: ");
            Console.WriteLine(list);
        }
    }
}
