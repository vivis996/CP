using System;
using System.Media;

namespace CP3
{
   class Recursos
   {
      //static string m1 = "███████╗███╗   ██╗████████╗███████╗██████╗ ";
      //static string m2 = "██╔════╝████╗  ██║╚══██╔══╝██╔════╝██╔══██╗";
      //static string m3 = "█████╗  ██╔██╗ ██║   ██║   █████╗  ██████╔╝";
      //static string m4 = "██╔══╝  ██║╚██╗██║   ██║   ██╔══╝  ██╔══██╗";
      //static string m5 = "███████╗██║ ╚████║   ██║   ███████╗██║  ██║";
      //static string m6 = "╚══════╝╚═╝  ╚═══╝   ╚═╝   ╚══════╝╚═╝  ╚═╝";
      //static string m7 = "Presione la tecla [Esc] (Escape):";
      static string m1 = "  █████╗ ███╗   ██╗██╗   ██╗███╗   ██╗ ██████╗██╗ ██████╗ ███████╗"; // Tipo de Letra: ANSI Shadow
      static string m2 = " ██╔══██╗████╗  ██║██║   ██║████╗  ██║██╔════╝██║██╔═══██╗██╔════╝"; // patorjk.com/software/taag/#p=display&f=ANSI%20Shadow&t=ANUNCIOS
      static string m3 = " ███████║██╔██╗ ██║██║   ██║██╔██╗ ██║██║     ██║██║   ██║███████╗";
      static string m4 = " ██╔══██║██║╚██╗██║██║   ██║██║╚██╗██║██║     ██║██║   ██║╚════██║";
      static string m5 = " ██║  ██║██║ ╚████║╚██████╔╝██║ ╚████║╚██████╗██║╚██████╔╝███████║";
      static string m6 = " ╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝╚═╝ ╚═════╝ ╚══════╝";
      static string m7 = " Presione la tecla [Esc] (Escape) para Continuar...";
      #region Matrix
      public void matrix()
      {
         Console.BackgroundColor = ConsoleColor.Black;
         Console.Title = " ..:: ANUNCIOS - UPQROO ::..";
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.WindowLeft = Console.WindowTop = 0;
         Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
         Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
#if readkey

#endif
         SoundPlayer player = new SoundPlayer();
         player.SoundLocation = "click.mp3";
         Random r = new Random();
         Constructor con = new Constructor();
         Console.CursorVisible = false;
         int width2, height2;
         int[] y2;
         int[] l2;
         Initialize2(out width2, out height2, out y2, out l2);
         int ms;
         while (true)
         {
            char c = (char)r.Next(27, 27);
            DateTime t1 = DateTime.Now;
            MatrixStep2(width2, height2, y2, l2);
            ms = 10 - (int)((TimeSpan)(DateTime.Now - t1)).TotalMilliseconds;
            byte ps1 = 60;
            byte ps2 = 25;
            Console.SetCursorPosition(ps1, ps2);
            Console.WriteLine(m1);
            Console.SetCursorPosition(ps1, ps2 + 1);
            Console.WriteLine(m2);
            Console.SetCursorPosition(ps1, ps2 + 2);
            Console.WriteLine(m3);
            Console.SetCursorPosition(ps1, ps2 + 3);
            Console.WriteLine(m4);
            Console.SetCursorPosition(ps1, ps2 + 4);
            Console.WriteLine(m5);
            Console.SetCursorPosition(ps1, ps2 + 5);
            Console.WriteLine(m6);
            Console.SetCursorPosition(ps1, ps2 + 6);
            Console.Write(m7);
            switch (tecla2(c))
            {
               case 1:
                  con.constructor();
                  // Termina la ejecución del Programa
                  break;
               case 2:
                  Initialize2(out width2, out height2, out y2, out l2);
                  break;
            }
            if (ms > 0)
               System.Threading.Thread.Sleep(ms);
            if (Console.KeyAvailable)
               if (Console.ReadKey().Key == ConsoleKey.F5)
                  Initialize2(out width2, out height2, out y2, out l2);
         }
      }
      static bool thistime2 = false;
      static int tecla2(char c)
      {
         if (Console.KeyAvailable)
         {
            ConsoleKeyInfo cc = Console.ReadKey(true);
            while (Console.KeyAvailable) Console.ReadKey(true);
            if (cc.KeyChar == c) return 1;
            else return 2;
         }
         return 3;
      }
      private static void MatrixStep2(int width2, int height2, int[] y2, int[] l2)
      {
         int x;
         thistime2 = !thistime2;
         for (x = 0; x < width2; ++x)
         {
            if (x % 11 == 10)
            {
               if (!thistime2)
                  continue;

               Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
               Console.ForegroundColor = ConsoleColor.DarkGreen;
               Console.SetCursorPosition(x, inBoxY2(y2[x] - 2 - (l2[x] / 40 * 2), height2));
               Console.Write(R2);
               Console.ForegroundColor = ConsoleColor.Green;
            }
            Console.SetCursorPosition(x, y2[x]);
            Console.Write(R2);
            y2[x] = inBoxY2(y2[x] + 1, height2);
            Console.SetCursorPosition(x, inBoxY2(y2[x] - l2[x], height2));
            Console.Write(' ');
         }
      }
      private static void Initialize2(out int width2, out int height2, out int[] y2, out int[] l2)
      {
         int h1;
         int h2 = (h1 = (height2 = Console.WindowHeight) / 2) / 2;
         width2 = Console.WindowWidth - 1;
         y2 = new int[width2];
         l2 = new int[width2];
         int x;
         Console.Clear();
         for (x = 0; x < width2; ++x)
         {
            y2[x] = r2.Next(height2);
            l2[x] = r.Next(h2 * ((x % 11 != 10) ? 2 : 1), h1 * ((x % 11 != 10) ? 2 : 1));
         }
      }
      static Random r2 = new Random();
      static char R2
      {
         get
         {
            int t = r.Next(10);
            if (t <= 2)
               return (char)('0' + r.Next(10));
            else if (t <= 4)
               return (char)('a' + r.Next(27));
            else if (t <= 6)
               return (char)('A' + r.Next(27));
            else
               return (char)(r.Next(32, 255));
         }
      }
      public static int inBoxY2(int n, int height2)
      {
         n = n % height2;
         if (n < 0)
            return n + height2;
         else
            return n;
      }
      #endregion
      public void Marco_de_Texto(int horizon, int horizon2, int verti, int verti2)
      {
         int x, y;
         for (x = verti + 1; x < verti2; x++)
         {
            Console.SetCursorPosition(x, horizon);
            Console.Write("═");
         }
         for (x = verti + 1; x < verti2; x++)
         {
            Console.SetCursorPosition(x, horizon2);
            Console.Write("═");
         }
         for (y = horizon + 1; y < horizon2; y++)
         {
            Console.SetCursorPosition(verti, y);
            Console.Write("║");
         }
         for (y = horizon + 1; y < horizon2; y++)
         {
            Console.SetCursorPosition(verti2, y);
            Console.Write("║");
         }

         Console.SetCursorPosition(verti, horizon);
         Console.Write("╔");
         Console.SetCursorPosition(verti, horizon2);
         Console.Write("╚");
         Console.SetCursorPosition(verti2, horizon);
         Console.Write("╗");
         Console.SetCursorPosition(verti2, horizon2);
         Console.Write("╝");
      }
      public void Marco()
      {
         int x;
         for (x = 40; x < 119; x++)
         {
            Console.SetCursorPosition(x, 5);
            Console.Write("═");
         }
         for (x = 40; x < 119; x++)
         {
            Console.SetCursorPosition(x, 40);
            Console.Write("═");
         }
         for (x = 5; x < 40; x++)
         {
            Console.SetCursorPosition(40, x);
            Console.Write("║");
         }
         for (x = 5; x < 40; x++)
         {
            Console.SetCursorPosition(119, x);
            Console.Write("║");
         }
         Console.SetCursorPosition(40, 5);
         Console.Write("╔");
         Console.SetCursorPosition(40, 40);
         Console.Write("╚");
         Console.SetCursorPosition(119, 5);
         Console.Write("╗");
         Console.SetCursorPosition(119, 40);
         Console.Write("╝");
         Console.SetCursorPosition(120, 5);
         Console.Write("         @%##              ");
         Console.SetCursorPosition(120, 6);
         Console.Write("      /%%%...@%%.            ");
         Console.SetCursorPosition(120, 7);
         Console.Write("@&&&%@@%...../%%@            ");
         Console.SetCursorPosition(120, 8);
         Console.Write("##########@//@%%/            ");
         Console.SetCursorPosition(120, 9);
         Console.Write("@@@@#########&%@             ");
         Console.SetCursorPosition(120, 10);
         Console.Write("@@@@%##########/             ");
         Console.SetCursorPosition(120, 11);
         Console.Write("@@@###########@            ");
         Console.SetCursorPosition(120, 12);
         Console.Write("################%@           ");
         Console.SetCursorPosition(120, 13);
         Console.Write("################%%%          ");
         Console.SetCursorPosition(120, 14);
         Console.Write("*###############%%%          ");
         Console.SetCursorPosition(120, 15);
         Console.Write("@/#############%%%%*         ");
         Console.SetCursorPosition(120, 16);
         Console.Write("**############%%%%%@         ");
         Console.SetCursorPosition(120, 17);
         Console.Write("**/###@@@#%%%%%%%%%%#&,    ");
         Console.SetCursorPosition(120, 18);
         Console.Write("**@##@@@@@&%%%%%%%%(//@%#@   ");
         Console.SetCursorPosition(120, 19);
         Console.Write("*(%%%@@@@@%%%%%%%%%/***&%#   ");
         Console.SetCursorPosition(120, 20);
         Console.Write("%%%%%%%%%%%%%%%%%%@/**/&%#   ");
         Console.SetCursorPosition(120, 21);
         Console.Write("%%%%%%%%%%%%%%%%%#**/(&%##   ");
         Console.SetCursorPosition(120, 22);
         Console.Write("%%%%%%%%%%%%%%%%&%%%%%%@     ");
         Console.SetCursorPosition(120, 23);
         Console.Write("%%%%%%%%%%%%%%@  ,%&(        ");
         Console.SetCursorPosition(120, 24);
         Console.Write("%%%%%%%%%%%%@                ");
         Console.SetCursorPosition(120, 25);
         Console.Write("%%%%%%%%&%                   ");
         Console.SetCursorPosition(120, 26);
         Console.Write("%%%%%@                       ");
         Console.SetCursorPosition(120, 27);
         Console.Write("@%%@                         ");
         Console.SetCursorPosition(120, 28);
         Console.Write("@@                           ");
      }
      public void Marco_Acciones()
      {
         int x;
         for (x = 2; x < 50; x++)
         {
            Console.SetCursorPosition(x, 5);
            Console.Write("═");
         }
         for (x = 2; x < 50; x++)
         {
            Console.SetCursorPosition(x, 50);
            Console.Write("═");
         }
         for (x = 5; x < 50; x++)
         {
            Console.SetCursorPosition(2, x);
            Console.Write("║");
         }
         for (x = 5; x < 50; x++)
         {
            Console.SetCursorPosition(50, x);
            Console.Write("║");
         }
         Console.SetCursorPosition(2, 5);
         Console.Write("╔");
         Console.SetCursorPosition(2, 50);
         Console.Write("╚");
         Console.SetCursorPosition(50, 5);
         Console.Write("╗");
         Console.SetCursorPosition(50, 50);
         Console.Write("╝");
      }
      public void Marco_Seleccion()
      {
         int x;
         for (x = 2; x < 100; x++)
         {
            Console.SetCursorPosition(x, 8);
            Console.Write("═");
         }
         for (x = 2; x < 100; x++)
         {
            Console.SetCursorPosition(x, 50);
            Console.Write("═");
         }
         for (x = 8; x < 50; x++)
         {
            Console.SetCursorPosition(2, x);
            Console.Write("║");
         }
         for (x = 8; x < 50; x++)
         {
            Console.SetCursorPosition(100, x);
            Console.Write("║");
         }
         Console.SetCursorPosition(2, 8);
         Console.Write("╔");
         Console.SetCursorPosition(2, 50);
         Console.Write("╚");
         Console.SetCursorPosition(100, 8);
         Console.Write("╗");
         Console.SetCursorPosition(100, 50);
         Console.Write("╝");
      }
      #region Error
      public void Error()
      {
         SoundPlayer player = new SoundPlayer();
         player.SoundLocation = "matrix.mp3";
         player.Play();
         byte psx = 60;
         byte psy = 25;
         Console.Clear();
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 40, psy - 15);
         Console.WriteLine("     ██╗██╗███╗   ██╗██╗  ██╗██╗   ██╗ ");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 40, psy - 14);
         Console.WriteLine("     ██║██║████╗  ██║╚██╗██╔╝╚██╗ ██╔╝");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 40, psy - 13);
         Console.WriteLine("     ██║██║██╔██╗ ██║ ╚███╔╝  ╚████╔╝ ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 40, psy - 12);
         Console.WriteLine("██   ██║██║██║╚██╗██║ ██╔██╗   ╚██╔╝  ");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 40, psy - 11);
         Console.WriteLine("╚█████╔╝██║██║ ╚████║██╔╝ ██╗   ██║   ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 40, psy - 10);
         Console.WriteLine(" ╚════╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝   ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 50, psy - 10);
         Console.WriteLine("████████╗██╗   ██╗██╗  ██╗ ██████╗ ███╗   ██╗██╗  ██╗");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 50, psy - 9);
         Console.WriteLine("╚══██╔══╝██║   ██║╚██╗██╔╝██╔═══██╗████╗  ██║██║  ██║");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 50, psy - 8);
         Console.WriteLine("   ██║   ██║   ██║ ╚███╔╝ ██║   ██║██╔██╗ ██║███████║");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 50, psy - 7);
         Console.WriteLine("   ██║   ██║   ██║ ██╔██╗ ██║   ██║██║╚██╗██║██╔══██║");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 50, psy - 6);
         Console.WriteLine("   ██║   ╚██████╔╝██╔╝ ██╗╚██████╔╝██║ ╚████║██║  ██║");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 50, psy - 5);
         Console.WriteLine("   ╚═╝    ╚═════╝ ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 30, psy);
         Console.WriteLine("██████╗  █████╗ ██████╗  ██████╗ ");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 30, psy + 1);
         Console.WriteLine("██╔════╝ ██╔══██╗██╔══██╗██╔═══██╗");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 30, psy + 2);
         Console.WriteLine("██║  ███╗███████║██████╔╝██║   ██║");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 30, psy + 3);
         Console.WriteLine("██║   ██║██╔══██║██╔══██╗██║   ██║");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 30, psy + 4);
         Console.WriteLine("╚██████╔╝██║  ██║██████╔╝╚██████╔╝");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 30, psy + 5);
         Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═════╝  ╚═════╝ ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 10, psy + 20);
         Console.WriteLine("███╗   ███╗ █████╗ ███╗   ███╗ █████╗ ██╗      ██████╗ ██████╗ ██████╗ ");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 10, psy + 21);
         Console.WriteLine("████╗ ████║██╔══██╗████╗ ████║██╔══██╗██║     ██╔═══██╗██╔══██╗██╔══██╗");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 10, psy + 22);
         Console.WriteLine("██╔████╔██║███████║██╔████╔██║███████║██║     ██║   ██║██████╔╝██║  ██║");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 10, psy + 23);
         Console.WriteLine("██║╚██╔╝██║██╔══██║██║╚██╔╝██║██╔══██║██║     ██║   ██║██╔══██╗██║  ██║");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx - 10, psy + 24);
         Console.WriteLine("██║ ╚═╝ ██║██║  ██║██║ ╚═╝ ██║██║  ██║███████╗╚██████╔╝██║  ██║██████╔╝");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx - 10, psy + 25);
         Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 40, psy - 7);
         Console.Write("███████╗███████╗ █████╗  ██████╗██████╗ ███████╗██╗     ");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 40, psy - 6);
         Console.Write("██╔════╝██╔════╝██╔══██╗██╔════╝██╔══██╗██╔════╝██║     ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 40, psy - 5);
         Console.Write("███████╗█████╗  ███████║██║     ██████╔╝█████╗  ██║     ");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 40, psy - 4);
         Console.Write("╚════██║██╔══╝  ██╔══██║██║     ██╔══██╗██╔══╝  ██║     ");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.SetCursorPosition(psx + 40, psy - 3);
         Console.Write("███████║███████╗██║  ██║╚██████╗██║  ██║███████╗███████╗");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.SetCursorPosition(psx + 40, psy - 2);
         Console.Write("╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚══════╝");
      }


      #endregion Error
      #region Error_2
      public void Error_2()
      {


         Console.BackgroundColor = ConsoleColor.Black;
         Console.Title = " ..:: ANUNCIOS - UPQROO ::..";
         Console.ForegroundColor = ConsoleColor.DarkGreen;
         Console.WindowLeft = Console.WindowTop = 0;
         Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
         Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
#if readkey

#endif
         Random r = new Random();
         Anuncios anun = new Anuncios();
         Variables objVariables = new Variables();
         Console.CursorVisible = false;
         int width, height;
         int[] y;
         int[] l;
         Initialize(out width, out height, out y, out l);
         int ms;
         int n = 0;
         byte psx = 60;
         byte psy = 25;
         int milis = 42999999;
         long a = DateTime.Now.Ticks;

         Anuncios an = new Anuncios();


         thistime = !thistime;
         do
         {


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 40, psy - 15);
            Console.WriteLine("     ██╗██╗███╗   ██╗██╗  ██╗██╗   ██╗ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx + 40, psy - 14);
            Console.WriteLine("     ██║██║████╗  ██║╚██╗██╔╝╚██╗ ██╔╝");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx + 40, psy - 13);
            Console.WriteLine("     ██║██║██╔██╗ ██║ ╚███╔╝  ╚████╔╝ ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 40, psy - 12);
            Console.WriteLine("██   ██║██║██║╚██╗██║ ██╔██╗   ╚██╔╝  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx + 40, psy - 11);
            Console.WriteLine("╚█████╔╝██║██║ ╚████║██╔╝ ██╗   ██║   ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 40, psy - 10);
            Console.WriteLine(" ╚════╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝   ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 50, psy - 15);
            Console.WriteLine("████████╗██╗   ██╗██╗  ██╗ ██████╗ ███╗   ██╗██╗  ██╗");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 50, psy - 14);
            Console.WriteLine("╚══██╔══╝██║   ██║╚██╗██╔╝██╔═══██╗████╗  ██║██║  ██║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 50, psy - 13);
            Console.WriteLine("   ██║   ██║   ██║ ╚███╔╝ ██║   ██║██╔██╗ ██║███████║");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 50, psy - 12);
            Console.WriteLine("   ██║   ██║   ██║ ██╔██╗ ██║   ██║██║╚██╗██║██╔══██║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 50, psy - 11);
            Console.WriteLine("   ██║   ╚██████╔╝██╔╝ ██╗╚██████╔╝██║ ╚████║██║  ██║");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 50, psy - 10);
            Console.WriteLine("   ╚═╝    ╚═════╝ ╚═╝  ╚═╝ ╚═════╝ ╚═╝  ╚═══╝╚═╝  ╚═╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 30, psy);
            Console.WriteLine("██████╗  █████╗ ██████╗  ██████╗ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 30, psy + 1);
            Console.WriteLine("██╔════╝ ██╔══██╗██╔══██╗██╔═══██╗");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 30, psy + 2);
            Console.WriteLine("██║  ███╗███████║██████╔╝██║   ██║");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 30, psy + 3);
            Console.WriteLine("██║   ██║██╔══██║██╔══██╗██║   ██║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 30, psy + 4);
            Console.WriteLine("╚██████╔╝██║  ██║██████╔╝╚██████╔╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 30, psy + 5);
            Console.WriteLine(" ╚═════╝ ╚═╝  ╚═╝╚═════╝  ╚═════╝ ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 10, psy + 15);
            Console.WriteLine("███╗   ███╗ █████╗ ███╗   ███╗ █████╗ ██╗      ██████╗ ██████╗ ██████╗ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 10, psy + 16);
            Console.WriteLine("████╗ ████║██╔══██╗████╗ ████║██╔══██╗██║     ██╔═══██╗██╔══██╗██╔══██╗");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 10, psy + 17);
            Console.WriteLine("██╔████╔██║███████║██╔████╔██║███████║██║     ██║   ██║██████╔╝██║  ██║");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 10, psy + 18);
            Console.WriteLine("██║╚██╔╝██║██╔══██║██║╚██╔╝██║██╔══██║██║     ██║   ██║██╔══██╗██║  ██║");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx - 10, psy + 19);
            Console.WriteLine("██║ ╚═╝ ██║██║  ██║██║ ╚═╝ ██║██║  ██║███████╗╚██████╔╝██║  ██║██████╔╝");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx - 10, psy + 20);
            Console.WriteLine("╚═╝     ╚═╝╚═╝  ╚═╝╚═╝     ╚═╝╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝  ╚═╝╚═════╝ ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 40, psy - 2);
            Console.Write("███████╗███████╗ █████╗  ██████╗██████╗ ███████╗██╗     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx + 40, psy - 1);
            Console.Write("██╔════╝██╔════╝██╔══██╗██╔════╝██╔══██╗██╔════╝██║     ");
            Console.SetCursorPosition(psx + 40, psy);
            Console.Write("███████╗█████╗  ███████║██║     ██████╔╝█████╗  ██║     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx + 40, psy + 1);
            Console.Write("╚════██║██╔══╝  ██╔══██║██║     ██╔══██╗██╔══╝  ██║     ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(psx + 40, psy + 2);
            Console.Write("███████║███████╗██║  ██║╚██████╗██║  ██║███████╗███████╗");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(psx + 40, psy + 3);
            Console.Write("╚══════╝╚══════╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝╚══════╝╚══════╝");

         } while (a + milis > DateTime.Now.Ticks);

         while (n < 9)
         {

            char c = (char)r.Next(27, 27);
            DateTime t1 = DateTime.Now;
            MatrixStep(width, height, y, l);
            ms = 10 - (int)((TimeSpan)(DateTime.Now - t1)).TotalMilliseconds;



         }
      }

      static bool thistime = false;

      private static void MatrixStep(int width, int height, int[] y, int[] l)
      {
         int x;
         int milis = 52999999;
         long a = DateTime.Now.Ticks;

         Anuncios an = new Anuncios();



         do
         {
            thistime = !thistime;
            for (x = 0; x < width; ++x)
            {
               if (x % 11 == 10)
               {
                  if (!thistime)
                     continue;

                  Console.ForegroundColor = ConsoleColor.White;
               }
               else
               {
                  Console.ForegroundColor = ConsoleColor.DarkGreen;
                  Console.SetCursorPosition(x, inBoxY(y[x] - 2 - (l[x] / 40 * 2), height));
                  Console.Write(R);
                  Console.ForegroundColor = ConsoleColor.Green;
               }
               Console.SetCursorPosition(x, y[x]);
               Console.Write(R);
               y[x] = inBoxY(y[x] + 1, height);
               Console.SetCursorPosition(x, inBoxY(y[x] - l[x], height));
               Console.Write(' ');

            }
         } while (a + milis > DateTime.Now.Ticks);
         an.Principal();


      }
      private static void Initialize(out int width, out int height, out int[] y, out int[] l)
      {
         int h1;
         int h2 = (h1 = (height = Console.WindowHeight) / 2) / 2;
         width = Console.WindowWidth - 1;
         y = new int[width];
         l = new int[width];
         int x;
         Console.Clear();
         for (x = 0; x < width; ++x)
         {
            y[x] = r.Next(height);
            l[x] = r.Next(h2 * ((x % 11 != 10) ? 2 : 1), h1 * ((x % 11 != 10) ? 2 : 1));
         }
      }
      static Random r = new Random();
      static char R
      {
         get
         {
            int t = r.Next(10);
            if (t <= 2)
               return (char)('0' + r.Next(10));
            else if (t <= 4)
               return (char)('a' + r.Next(27));
            else if (t <= 6)
               return (char)('A' + r.Next(27));
            else
               return (char)(r.Next(32, 255));
         }
      }
      public static int inBoxY(int n, int height)
      {
         n = n % height;
         if (n < 0)
            return n + height;
         else
            return n;
      }
      #endregion
      public void Ovni()
      {
         byte psx = 130;
         byte psy = 45;
         Console.SetCursorPosition(psx, psy);
         Console.Write("──────────────▄▀█▀█▀▄");
         Console.SetCursorPosition(psx, psy + 1);
         Console.Write("─────────────▀▀▀▀▀▀▀▀▀ ");
         Console.SetCursorPosition(psx, psy + 2);
         Console.Write("─────────────▄─░░░░░▄");
         Console.SetCursorPosition(psx, psy + 3);
         Console.Write("───█──▄─▄───▐▌▌░░░░░▌▌");
         Console.SetCursorPosition(psx, psy + 4);
         Console.Write("▌▄█▐▌▐█▐▐▌█▌█▌█░░░░░▌▌");
      }
      public void Anonimo()
      {
         byte psx = 69;
         byte psy = 20;
         Console.SetCursorPosition(psx, psy);
         Console.Write("     █─▄▀█──█▀▄─█");
         Console.SetCursorPosition(psx, psy + 1);
         Console.Write("    ▐▌──────────▐▌");
         Console.SetCursorPosition(psx, psy + 2);
         Console.Write("    █▌▀▄──▄▄──▄▀▐█");
         Console.SetCursorPosition(psx, psy + 3);
         Console.Write("   ▐██──▀▀──▀▀──██▌");
         Console.SetCursorPosition(psx, psy + 4);
         Console.Write("  ▄████▄──▐▌──▄████▄");
      }
      public void UFO()
      {
         byte psx = 119;
         byte psy = 20;
         Console.SetCursorPosition(psx, psy);
         Console.Write("▒▒▄▀▀▀▀▀▄▒▒▒▒▒▄▄▄▄▄▒▒▒");
         Console.SetCursorPosition(psx, psy + 1);
         Console.Write("▒▐░▄░░░▄░▌▒▒▄█▄█▄█▄█▄▒");
         Console.SetCursorPosition(psx, psy + 2);
         Console.Write("▒▐░▀▀░▀▀░▌▒▒▒▒▒░░░▒▒▒▒");
         Console.SetCursorPosition(psx, psy + 3);
         Console.Write("▒▒▀▄░═░▄▀▒▒▒▒▒▒░░░▒▒▒▒");
         Console.SetCursorPosition(psx, psy + 4);
         Console.Write("▒▒▐░▀▄▀░▌▒▒▒▒▒▒░░░▒▒▒▒");
      }
      public void tv()
      {
         byte psx = 27;
         byte psy = 20;
         Console.SetCursorPosition(psx, psy);
         Console.Write("░▀▄░░▄▀");
         Console.SetCursorPosition(psx, psy + 1);
         Console.Write("▄▄▄██▄▄▄▄▄");
         Console.SetCursorPosition(psx, psy + 2);
         Console.Write("█▒░▒░▒░█▀█");
         Console.SetCursorPosition(psx, psy + 3);
         Console.Write("█░▒░▒░▒█▀█");
         Console.SetCursorPosition(psx, psy + 4);
         Console.Write("█▄▄▄▄▄▄███");
      }
      public void SATMM()
      {
         byte x = 51;
         byte y = 1;
         Console.SetCursorPosition(x + 40, y + 10);
         Console.Write("█▀▀  █  █  █  █ ▀▀█▀▀  █  █  █▀▀▄ 　 ");
         Console.SetCursorPosition(x + 40, y + 11);
         Console.Write("▀▀█  █▀▀█  █  █   █    █  █  █ ▄█ 　 ");
         Console.SetCursorPosition(x + 40, y + 12);
         Console.Write("▀▀▀  ▀  ▀  ▀▀▀▀   ▀    ▀▀▀▀  █ 　 ");
         Console.SetCursorPosition(x + 40, y + 13);
         Console.Write("      ▄▀▀▄ █▀▀▄  █▀▀▄ ");
         Console.SetCursorPosition(x + 40, y + 14);
         Console.Write("      █▄▄█ █   █ █   █ ");
         Console.SetCursorPosition(x + 40, y + 15);
         Console.Write("      █  █ █   █ █▄▄▀");
         Console.SetCursorPosition(x + 40, y + 16);
         Console.Write("");
         Console.SetCursorPosition(x, y + 7);
         Console.Write("─────███────██");
         Console.SetCursorPosition(x, y + 8);
         Console.Write("──────████───███");
         Console.SetCursorPosition(x, y + 9);
         Console.Write("────────████──███");
         Console.SetCursorPosition(x, y + 10);
         Console.Write("─────────████─█████");
         Console.SetCursorPosition(x, y + 11);
         Console.Write("████████──█████████");
         Console.SetCursorPosition(x, y + 12);
         Console.Write("████████████████████");
         Console.SetCursorPosition(x, y + 13);
         Console.Write("████████████████████");
         Console.SetCursorPosition(x, y + 14);
         Console.Write("█████████████████████");
         Console.SetCursorPosition(x, y + 15);
         Console.Write("█████████████████████");
         Console.SetCursorPosition(x, y + 16);
         Console.Write("█████████████████████");
         Console.SetCursorPosition(x, y + 17);
         Console.Write("██─────██████████████");
         Console.SetCursorPosition(x, y + 18);
         Console.Write("███────────█████████");
         Console.SetCursorPosition(x, y + 19);
         Console.Write("█──█───────────████");
         Console.SetCursorPosition(x, y + 20);
         Console.Write("█──────────────██");
         Console.SetCursorPosition(x, y + 21);
         Console.Write("██──────────────█────────▄███████▄");
         Console.SetCursorPosition(x, y + 22);
         Console.Write("██───███▄▄──▄▄███──────▄██$█████$██▄");
         Console.SetCursorPosition(x, y + 23);
         Console.Write("██──█▀───▀███────█───▄██$█████████$██▄");
         Console.SetCursorPosition(x, y + 24);
         Console.Write("██──█───█──██───█─█──█$█████████████$█");
         Console.SetCursorPosition(x, y + 25);
         Console.Write("██──█──────██─────█──█████████████████");
         Console.SetCursorPosition(x, y + 26);
         Console.Write("██──██────██▀█───█─────██████████████");
         Console.SetCursorPosition(x, y + 27);
         Console.Write("─█───██████──▀████───────███████████");
         Console.SetCursorPosition(x, y + 28);
         Console.Write("──────────────────█───────█████████");
         Console.SetCursorPosition(x, y + 29);
         Console.Write("─────────────▀▀████──────███████████");
         Console.SetCursorPosition(x, y + 30);
         Console.Write("────────────────█▀──────██───████▀─▀█");
         Console.SetCursorPosition(x, y + 31);
         Console.Write("────────────────▀█──────█─────▀█▀───█");
         Console.SetCursorPosition(x, y + 32);
         Console.Write("──▄▄▄▄▄▄▄────────██────█───████▀───██");
         Console.SetCursorPosition(x, y + 33);
         Console.Write("─█████████████────▀█──█───███▀──▄▄██");
         Console.SetCursorPosition(x, y + 34);
         Console.Write("─█▀██▀██▀████▀█████▀──█───██████▀─▀█");
         Console.SetCursorPosition(x, y + 35);
         Console.Write("─█────────█▄─────────██───████▀───██");
         Console.SetCursorPosition(x, y + 36);
         Console.Write("─██▄████▄──██────────██───██──▄▄▄██");
         Console.SetCursorPosition(x, y + 37);
         Console.Write("──██▄▄▄▄▄██▀─────────██──█████▀───█");
         Console.SetCursorPosition(x, y + 38);
         Console.Write("─────────███────────███████▄────███");
         Console.SetCursorPosition(x, y + 39);
         Console.Write("────────███████─────█████████████");
         Console.SetCursorPosition(x, y + 40);
         Console.Write("───────▄██████████████████████");
         Console.SetCursorPosition(x, y + 41);
         Console.Write("████████─██████████████████");
         Console.SetCursorPosition(x, y + 42);
         Console.Write("─────────██████████████");
         Console.SetCursorPosition(x, y + 43);
         Console.Write("────────███████████");
         Console.SetCursorPosition(x, y + 44);
         Console.Write("───────█████");
         Console.SetCursorPosition(x, y + 45);
         Console.Write("──────████");
         Console.SetCursorPosition(x, y + 46);
         Console.Write("─────████");
         Console.SetCursorPosition(x, y + 47);
         Console.Write("");
         Console.SetCursorPosition(x + 45, y + 17);
         Console.Write("          ▀▀█▀▀ █▀▀█ █ ▄█ █▀▀ ");
         Console.SetCursorPosition(x + 45, y + 18);
         Console.Write("            █   █▄▄█ █▀▀▄ █▀▀ ");
         Console.SetCursorPosition(x + 45, y + 19);
         Console.Write("            ▀   ▀  ▀ ▀  ▀ ▀▀▀ ");
         Console.SetCursorPosition(x + 40, y + 20);
         Console.Write("");
         Console.SetCursorPosition(x + 40, y + 21);
         Console.Write("█▀▄▀█ █  █   █▀▄▀█  ▄▀▀▄  █▀▀▄ █▀▀  █  █  █ ");
         Console.SetCursorPosition(x + 40, y + 22);
         Console.Write("█─▀─█ █▄▄█   █─▀─█  █  █ █   █ █▀▀  █▄▄█  █");
         Console.SetCursorPosition(x + 40, y + 23);
         Console.Write("█   █ ▄▄▄█   █   █   ▀▀  ▀   ▀ ▀▀▀  ▄▄▄█  ▄");
      }
   }
}