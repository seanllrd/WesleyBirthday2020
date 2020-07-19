using System;
using System.Threading;

namespace WesleyBirthdayWishes
{
    class Wish
    {
        static void Main(string[] args)
        {
            string cakeAscii = @"
           ~                  ~
     *                   *                *       *
                  *               *
  ~       *                *         ~    *
              *       ~        *              *   ~
                  )         (         )              *
    *    ~     ) (_)   (   (_)   )   (_) (  *
           *  (_) # ) (_) ) # ( (_) ( # (_)       *
              _#.-#(_)-#-(_)#(_)-#-(_)#-.#_
  *         .' #  # #  #  # # #  #  # #  # `.   ~     *
           :   #    #  #  #   #  #  #    #   :
    ~      :.       #     #   #     #       .:      *
        *  | `-.__                     __.-' | *
           |      `````'''''''''''`````      |         *
     *     |         | ||\ |~)|~)\ /         |
           |         |~||~\|~ |~  |          |       ~
   ~   *   |                                 | *
           |      |~)||~)~|~| ||~\|\ \ /     |         *
   *    _.-|      |~)||~\ | |~|| /|~\ |      |-._
      .'   '.      ~            ~           .'   `.  *
      :      `-.__                     __.-'      :
       `.         `````''''''''''''`````         .'
         `-.._                             _..-'
              `````''''-----------''''`````";

            string cakeAscii2 = @"
                             
          ~                 ~                    
     *                 *               *       *  
                *               * 
  ~       *               *         ~    *   
              *   (   ~     )  *      )       *   ~  
               ( (_)   )   (_)   (   (_) )         *
    *    ~    (_) # ( (_) ( # ) (_) ) # (_) *
           *  _#.-#(_)-#-(_)#(_)-#-(_)#-.#_       *  
            .' #  # #  #  # # #  #  # #  # `.      
  *        :   #    #  #  #   #  #  #    #   :   ~     *
           :.       #     #   #     #       .:      
    ~      | `-.__                     __.-' |      *  
        *  |      `````'''''''''''`````      | *       
           |         | ||\ |~)|~)\ /         |        *
     *     |         |~||~\|~ |~  |          |       
           |                                 |       ~
   ~    *  |      |~)||~)~|~| ||~\|\ \ /     |   *     
        _.-|      |~)||~\ | |~|| /|~\ |      |-._      *
   *  .'   '.      ~            ~           .'   `.  
      :      `-.__                     __.-'      :  *
       `.         `````''''''''''''`````         .'
         `-.._                             _..-'
              `````''''-----------''''`````";

            string[] text = new string[] { "Happy Birthday, Wesley!!" };
            string header = GetHeader(text);
            int count = 1;

            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter))
            {
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                string PADDING = new string(' ', (Console.WindowWidth) / 10);
                foreach (var section in header.Split('\n'))
                {
                    Console.WriteLine($"{PADDING}{section}");
                }
                Console.WriteLine("Press Enter to stop loop");

                Console.ForegroundColor = ConsoleColor.Cyan;
                if (count % 2 == 1)
                {
                    Console.WriteLine(cakeAscii);
                }
                else
                {
                    Console.WriteLine(cakeAscii2);
                }
                
                Thread.Sleep(1000);
                count++;
            }

            Console.WriteLine("Press enter to quit...");
            Console.ReadLine();
        }

        private static string GetHeader(string[] headerText)
        {
            string TOPLEFT = "\u2554";
            string MIDDLE = new string('\u2550', (Console.WindowWidth - 2) / 4);
            string TOPRIGHT = "\u2557";
            string SIDE = "\u2551";
            string BOTTOMLEFT = "\u255A";
            string BOTTOMRIGHT = "\u255D";
            string header = "";

            int middleLength = (Console.WindowWidth - 2);

            header += $"{TOPLEFT}{MIDDLE}{TOPRIGHT}\n";

            foreach (var item in headerText)
            {
                string leftSpace = new string(' ', (MIDDLE.Length - item.Length) / 2);
                string rightSpace = new string(' ', MIDDLE.Length - leftSpace.Length - item.Length);
                header += $"{SIDE}{leftSpace}{item}{rightSpace}{SIDE}\n";
            }

            header += $"{BOTTOMLEFT}{MIDDLE}{BOTTOMRIGHT}\n";

            return header;
        }
    }
}
