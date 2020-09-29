using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgramProject
{
    class Program
    {
        static void Main()
        {
            bool continueToRun = true;
            while (continueToRun)
            {


                Console.WriteLine("Before you stand three doors of mysterious origin. You are compelled to enter. \n\n Choose: Left, Middle, or Right.\n");
                string userInput = Console.ReadLine().ToLower();
                var room1 = ""; var room2 = ""; var room3 = ""; var room4 = ""; var room5 = ""; var room6 = ""; var room7 = ""; var room8 = ""; var room9 = "";
                int wall;
                // room 1 (Room of Three Doors)
                switch (userInput)
                {
                    case "left":
                        Console.Clear();
                        Console.WriteLine("You leap recklessly through the magical doorway and fall headfirst into a pit of snakes. Luckily the snakes are terrified of your arrival and flee before you hit the ground. \n\n" +
                            "Unfortunately, these snakes evolved to live atop sharpened stalagmites. The short remained of your life is one as a swissed cheese.\n\n" +
                            "Better luck next time. ");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "middle":
                        Console.Clear();
                        Console.WriteLine("You enter a room filled with swirling mists that flood around you. They cling to your skin as you walk past, dying you all the colors of the rainbow. As you walk through the room it becomes harder to make out anything through the technicolor haze. \n\n " +
                            "Choose: Explore, Dance, or Vape");
                        room1 = "Middle";

                        break;


                    case "right":
                        Console.Clear();
                        Console.WriteLine("You catch a glimpse of a person walking away from you who looks just like your grandmother, Betty Crocker. She enters a rustic cottage surrounded by parsnips and rutabagas. There is a winnebago parked amongst the rutabagas. You catch a fading scent of oatmeal cookies from her direction. \n\n" +
                            "Choose: Follow, Explore, or Eat");
                        room1 = "Right";
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }
                string userInput2 = Console.ReadLine().ToLower();
                // room 2 (Room of Swirling Mists AND Room of Grandma's House)
                switch (userInput2)
                {
                    case "explore":
                        Console.Clear();
                        if (room1 is "Middle")
                        {
                            Console.WriteLine("You  enter deeper in the Joseph's Technicolor Dream Mist. The wisps begin climbing higher up your body and sparking in more radiant hues. They seem to gesture and call to you. Inviting you deeper and deeper into their world. They promise shelter and respite tinged with mystery and wonder. You succumb to their lure, never realizing you have lost sight of the door you entered from.\n\n" +
                                "By the time you notice, if you ever notice, it will be too late.\n\n" +
                                "'Not all explorers go down in history. Most die and are simply forgotten.' -Buddha, probably. ");
                            Console.ReadKey();
                            Console.ReadKey();
                            continueToRun = false;
                        }
                        else if (room1 is "Right")
                        {
                            Console.WriteLine("Your grandmother does not have a Winebago. Suspicious you climb inside and discover rows upon rows of neatly stack human skulls. They are dinged and chipped - as though knawed upon by some wild animal. You feel a sharp pain in your ankle and fall to the floor of the Winebago. You do not get up again.\n\n" +
                                "As the last embers of consciousness slip away you remember - your grandmother wasn't twelve feet tall either");
                            Console.ReadKey();
                            Console.ReadKey();
                            continueToRun = false;
                        }
                        break;

                    case "dance":
                        Console.Clear();
                        Console.WriteLine(" As you watch the mists swirl and spin around you, you feel a chill run up your spine. You are overcome with a desire to become one with the mists. To swirl as they do, to flow and be free as they are. A part of this knows that this is unnatural that you could fight this feeling. \n\n" +
                            "You choose not to. Why would you want to fight against your home. You abandon yourself to the mists - you spring through the air leaving sparks of stardust in your wake. Each spark fueled by the the life you once had and the person you never were. \n\n" +
                            "You are home. You are free. You are unbound. You are mist.");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;


                    case "vape":
                        Console.Clear();
                        Console.WriteLine("You look at the mist and for some ungodly reason you decide to smoke it. You pull out your vape pen, empty the cartridge and wander through the mists until you find a veridian stream that seems to seep wisps of fog into the air. You fill up your vape and take a hit. \n\n" +
                            "You hear a cold, distant laughter as you asphyxiate to death.");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "follow":
                        Console.Clear();
                        Console.WriteLine("You follow your grandmother into the her cottage as any good grandchild would. It is quaint and lovely, filled with nicknacks, and you politely ignore the fact that it is filled with photos of you that you have never seen before. Some you can prove could not have been taken. Your grandmother offers you a cookie. Recalling the oatmeal in the air you accept. \n\n" +
                            "It’s gingerbread. It’s delicious. For some reason you need to use the restroom urgently. After asking your grandmother to put on a lovely pot of tea, you run to the bathroom (not question why you know where it is). In the bathroom you see that the window is outline with a mystical shimmering light.\n\n" +
                            "You squeeze through the window to prevent your grandmother from turning you into baked goods. You enter a land with bright sun and blazing heat. \n\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "eat":
                        Console.Clear();
                        Console.WriteLine("Using your fairy tale knowledge you know what to do! This cottage has to be made of candy and your safest course of action is to eat all of it and pray you don’t get diabetes or have a heart attack halfway through.\n\n" +
                            "You take a huge bite out of the gingerbread corner of the cottage and break all of your teeth. You lie there screaming, hoping the witch inside will put you out of your misery. Eventually you hear sirens and pass out.\n\n" +
                            "Who would make a house out of candy? That would melt in like a day. Stop trying to eat houses. And be nicer to your grandmother!");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                // room 3 (Room of Desert)

                Console.WriteLine("Before you stands a desert with arrows pointing in three directions.The arrow pointing to the right says “Oasis.” The arrow pointing left says, “Death.” The third arrow points directly up into the sky and says nothing.\n\n" +
                    "Choose: Right, Left, or Jump");
                string userInput3 = Console.ReadLine().ToLower();
                switch (userInput3)
                {
                    case "right":
                        Console.Clear();
                        Console.WriteLine("It’s a wall. A wonderful wall. Impenetrable and unscalable. You could try to run full speed into it and break through to the other side. Though tempted, you decided against it as you like your body in an unbroken state.\n\n" +
                            "Choose: Wait, Wait, or Wait");

                        break;

                    case "left":
                        Console.Clear();
                        Console.WriteLine("As you step left your foot lands upon a field of red flowers, spanning farther than you can see. You look in all around you and around surrounded by a lovely meadow of beautiful flowers. A pleasant scent fills the air. The sun shines brightly. The wind rustles your hair. Whoever you voted for won that last election. All is right in the world.\n\n" +
                            "Choose: Run, Nap, or Burn");
                        room3 = "fieldOfFlowers";
                        break;

                    case "jump":
                        Console.Clear();
                        Console.WriteLine("You leap with all your might into the air, the power of your legs suddenly expanding beyond your wildest dreams. As you reach the sky you notice it shrinking and turning dark. You hit your head on something dark and pass out. You awake in a world filled with short green grass and pipes. Your clothes have been replaced with overalls. A swarm of snapping turtles charges at you. \n\n" +
                            "Choose: Run, Jump, or Pet");
                        room3 = "mario";

                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                // room 4 (Rooms of Wonderwall, Poppies, Turtles)

                string userInput4 = Console.ReadLine().ToLower();
                switch (userInput4)
                {
                    case "run":
                        Console.Clear();
                        if (room3 is "fieldOfFlowers")
                        {
                            Console.WriteLine("Enjoying the scene you decide to take a break and run through the meadow. You’ve had a rough day after all. You prance and frolic to your heart’s content. Birds join you singing happily. Kittens seem to appear out of nowhere and leap into your arms purring. \n\n" +
                                "Eventually you grow tired. Your breathing starts to slow. Your throat is sore. Too sore. You try to move but you can’t. There’s a cat sleeping on you. You can’t wake a sleeping cat even if it means you have to die. \n\n" +
                                "And die you do. /n/n" +
                                "The cat eats your face.");
                            Console.ReadKey();
                            Console.ReadKey();
                            continueToRun = false;

                        }
                        else if (room3 is "mario")
                        {
                            Console.WriteLine("You’re no plumber. You immediately run away. As they say, discretion is the better part of valor. You find a large green pipe and decide to hide from the turtles inside. You sprint through the circular entrance and immediately are teleported away. \n\n" +
                                "The turtles continue on their way to revolt against their liege for unjust taxation, theft, and the wanton massacre of turtle-kind at the hands of mushroom powered plumbers.");
                        }
                        break;

                    case "wait":
                        for (wall = 1; wall < 16; wall++)
                        {
                            if (wall < 10)
                            {
                                Console.WriteLine("You stare at this majestic piece of architecture, inspired by its beauty and the sheer amount of labor and money required to construct such a thing. As you do, you begin to wonder what kind of idiot builds a 50 foot high wall in the middle of nowhere?\n\n");
                                Console.Write("Press any key to continue waiting..");
                                Console.ReadKey();
                            }
                            else if (wall >= 10 && wall < 15)
                            {
                                Console.WriteLine("Man, you must really like walls...");
                                Console.Write("Press any key to continue waiting..");
                                Console.ReadKey();
                            }
                            else
                            {
                                continueToRun = false;
                            }
                        }
                        break;

                    case "nap":
                        Console.Clear();
                        Console.WriteLine("You decide to take a nap in the flower field and you never wake up. They’re demon flowers. Get it? \n\n" +
                            "Look they can’t all be elaborately weird or funny. Get over it and make better choices in life. ");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    case "burn":
                        Console.Clear();
                        Console.WriteLine(" You’ve been around the block or time or two. You know suspicious fields of blood red flowers when you see them. Using your magical powers of Amazon Prime Now you conjure gasoline and a lighter. \n\n" +
                            "You hear demonic screeches and yowls as you torch the fields. You sit back in a camp chair you conjured and knock back a couple of beers as you watch the world burn. You feel a satisfactory sense of smug as a glowing neon doorway appears before you once the meadow is reduced to ashes. \n\n" +
                            "You chuck your empty beer at full force through the doorway in case anything is waiting for you on the other side and then calmly walk through.");
                        break;

                    case "jump":
                        Console.Clear();
                        Console.WriteLine("You scream your name in a fake italian accent at the rampaging reptiles and leap for all your worth. The power in your legs surprises you as you get more air than a Boeing 707. You slam onto the head of a turtle with all the force of a deranged soccer mom at a black friday sale with an adderall addiction.\n\n" +
                            "The turtle collapses into its shell and slides away, knocking over its comrades-in-shells. You get a strike. The turtle hits the gutter then rebounds and comes soaring right back at you - striking you in the gut. \n\n" +
                            "You topple to the ground and are devoured by the horde of snapping turtles, who have decided to remind you they are omnivorous.");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "pet":
                        Console.Clear();
                        Console.WriteLine("Either you didn’t try to jump on the turtles yet or you just didn’t learn your lesson. They devour you all the same but this time you are more aware of it because your spine has not been dislocated via shell ricochet. \n\n" +
                            "Either way you have the survival instincts of a dead fish and a similar lifespan.");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                // room 5 (Room of Bus Stop)
                Console.WriteLine("You arrive at a bus stop in the middle of nowhere there is a bench. The land around you is bleak and grey. \n\n Choose: Sit on bench, SiT oN BeNcH, or Sit on BENCH.\n");
                string userInput5 = Console.ReadLine().ToLower();
                switch (userInput5)
                {
                    case "sit on bench":
                        Console.Clear();
                        Console.WriteLine("I don’t know what you expected here. You just sit down and wait for the bus to arrive… it’s a bus stop, fam.\n\n" +
                            "Press the same key you’ve been spamming to continue...");
                        Console.ReadKey();
                        Console.WriteLine("You feel an odd rhythm pounding through the ground and reverberating up the bench.Like a staccato being played by the shifting of the earth.It gets louder and deeper and you begin to shake and hop in the air.\n\n" +
                            "A gigantic orange tabby shaped like a bus stops in front of you and lets out a melodious yowl. A shaggy furred door opens up in its center and reveals stairs and rows of seats. You consider waiting for the next bus, but catbus growls at you while the door closes and opens again.\n\n" +
                            "Taking the hint, you enter and seat yourself in the back.");
                        break;

                    case "sit":
                        Console.Clear();
                        Console.WriteLine("I don’t know what you expected here. You just sit down and wait for the bus to arrive… it’s a bus stop, fam.\n\n" +
                            "Press the same key you’ve been spamming to continue...");
                        Console.ReadKey();
                        Console.WriteLine("You feel an odd rhythm pounding through the ground and reverberating up the bench.Like a staccato being played by the shifting of the earth.It gets louder and deeper and you begin to shake and hop in the air.\n\n" +
                           "A gigantic orange tabby shaped like a bus stops in front of you and lets out a melodious yowl. A shaggy furred door opens up in its center and reveals stairs and rows of seats. You consider waiting for the next bus, but catbus growls at you while the door closes and opens again.\n\n" +
                           "Taking the hint, you enter and seat yourself in the back.");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }
                //room 6 (Room of Cat Bus)
                Console.WriteLine("The catbus stops at a railroad floating in a violet sea. A figure draped in a black cloak enters. Their head ducks to avoid scraping the roof of the bus. They take a seat across from you.\n\n" +
                    "Choose: Hello, Silence, Leave");
                string userInput6 = Console.ReadLine().ToLower();
                switch (userInput6)
                {
                    case "hello":
                        Console.Clear();
                        Console.WriteLine("Blackhole to spaceship placeholder");
                        break;

                    case "silence":
                        Console.Clear();
                        Console.WriteLine("YOU WON THE GAME placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "leave":
                        Console.Clear();
                        Console.WriteLine("stuck in ocean bustop placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //room 7 (Room of Space)
                Console.WriteLine("You fall and fall and fall. The darkness breaks away and you are assaulted by the blaring claxons and glaring artificial light. You slam into a cold pristine floor. All around you is white branching halls, screens, and flashing lights. It might be calm if it weren’t for the alarms screaming in your ears.\n\n" +
                    "Choose: Explore, Wait, or Sleep");
                string userInput7 = Console.ReadLine().ToLower();
                switch (userInput7)
                {
                    case "explore":
                        Console.Clear();
                        Console.WriteLine("exploring the spaceship placeholder");
                        room7 = "explore";
                        break;
                    case "wait":
                        Console.Clear();
                        Console.WriteLine("your wait lasts an eternity, because you die placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "sleep":
                        Console.Clear();
                        Console.WriteLine("sleep also lasts an eternity, because you also die placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //room 8 (Room of Space Cafeteria)
                Console.WriteLine("You walk into a room filled with tables and benches, all pristine and empty. Seemingly never used. In the center of this room is a table with a large red button. Around this table are 5 figures each clad in a different colored suit: Red, Blue, Black, Yellow, Pink. They are screaming and pointing at each other. Their faces are hidden behind the visors of their round helmets - expression unknown. They all turn to face you as you arrive!\n\n" +
                    "Choose: Hello, Run, or Vent");
                string userInput8 = Console.ReadLine().ToLower();
                switch (userInput8)
                {
                    case "hello":
                        Console.Clear();
                        Console.WriteLine("voted off the spaceship placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    case "run":
                        Console.Clear();
                        Console.WriteLine("shot in the head by an alien placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;

                    case "vent":
                        Console.Clear();
                        Console.WriteLine("to screen 8 placeholder");
                        room8 = "escapedRoom8";
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //room 9 (Room of Space Cafeteria)
                Console.WriteLine("You crawl through the vents until you find a glowing portal. Seeing your chance, you dive through. You find your head submerged in water, and your body free from the oppressive claustrophobia of the ventilation shafts. You look down, water dripping from your hair, to see a solid gold toilet. While debating whether you can steal a toilet, you notice the entire room is covered in gold as well. The sink is also made of gold. The walls seem to be plastered in a thin gold filament. The floor is covered in a gold-colored tile.  Clearly whoever owns this place is compensating for something. Outside the bathroom is a man sitting in a chair with his back to you. From what you can see,  his flesh seems to be an oddly tinted shade of orange.\n\n" +
                    "Choose: Steal, Murder, or Explore");
                string userInput9 = Console.ReadLine().ToLower();
                switch (userInput9)
                {
                    case "steal":
                        Console.Clear();
                        Console.WriteLine("You pry a golden faucet handle from the sink. Outside the bathroom is a man sitting in a chair with his back to you. From what you can see,  his flesh seems to be an oddly tinted shade of orange.\n\n" +
                            "Inventory: 1 Gold Handle " +
                    "Choose: Murder or Explore");
                        string stealInput = Console.ReadLine().ToLower() ;
                            switch (stealInput)
                        {
                            case "murder":
                                Console.Clear();
                                Console.WriteLine("murder the orange man placeholder");
                                room9 = "murder";
                                break;

                            case "explore":
                                Console.Clear();
                                Console.WriteLine("lost in gaudy maze placeholder");
                                Console.ReadKey();
                                Console.ReadKey();
                                continueToRun = false;
                                break;
                        }
                        break;

                    case "murder":
                        Console.Clear();
                        Console.WriteLine("murder the orange man placeholder");
                        room9 = "murder";
                        break;

                    case "explore":
                        Console.Clear();
                        Console.WriteLine("lost in gaudy maze placeholder");
                        break;

                    default:
                        Console.WriteLine("Invalid Entry");
                        Console.ReadKey();
                        break;
                }

                //Room 10 (Room of Golden Nonsense)
                Console.WriteLine("You see a piece of crumpled loose leaf paper tacked to the door in front of you. Unlike the previous doors, this one does not shimmer with the mysteries of the universe. It flickers like the dying embers of a campfire.\n\n" +
                    "Choose: Inspect or Run");
                string userInput10 = Console.ReadLine().ToLower();
                switch (userInput8)
                {
                    case "inspect":
                        Console.Clear();
                        Console.WriteLine("door under construction placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                    case "run":
                        Console.Clear();
                        Console.WriteLine("shot in the head by secret service placeholder");
                        Console.ReadKey();
                        Console.ReadKey();
                        continueToRun = false;
                        break;
                }




            }
        }
    }
}



