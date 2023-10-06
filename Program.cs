namespace RoomCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isValid = false;
            double LengthRoom = 0;
            double WidthRoom = 0;
            double HeightRoom = 0;
            double RoomPerimiter = 0;
            double RoomArea = 0;
            double RoomVolume = 0;
            double RoomSurfaceArea = 0;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine("");

            while (isValid == false)
                {
                    Console.WriteLine("Enter Length:");
                    string inputLengthRoom = Console.ReadLine();
                    if (double.TryParse(inputLengthRoom, out LengthRoom))
                    {
                        isValid = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid Length, please try again!!");
                    }

                }
            isValid = false;
            while (isValid == false)
            {
                Console.WriteLine("Enter Width:");
                string inputWidthRoom = Console.ReadLine();
                if (double.TryParse(inputWidthRoom, out WidthRoom))
                {
                    isValid = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid Width, please try again!!");
                }

            }

            isValid = false;
            while (isValid == false)
            {
                Console.WriteLine("Enter Height:");
                string inputHeightRoom = Console.ReadLine();
                if (double.TryParse(inputHeightRoom, out HeightRoom))
                {
                    isValid = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid Height, please try again!!");
                }

            }

            RoomPerimiter = (2 * (LengthRoom + WidthRoom));
            RoomArea = (LengthRoom * WidthRoom);
            RoomVolume = (LengthRoom * WidthRoom * HeightRoom);
            RoomSurfaceArea = (2 * LengthRoom * HeightRoom) + (2 * WidthRoom * HeightRoom) + (2 * LengthRoom * WidthRoom);
            Console.WriteLine($"Area: {RoomArea}");
            Console.WriteLine($"Perimiter:{RoomPerimiter}");
            Console.WriteLine($"Surface Area:{RoomSurfaceArea}");
            Console.WriteLine($"Volume:{RoomVolume}");

            if ( RoomArea ==  0 )
            {
                Console.WriteLine("Nothing to do, area is zero");
            }
            else
            {
                if ( RoomArea <= 250 )
                {
                    Console.WriteLine("This is a small-sized room");
                }
                else if ( RoomArea > 250 && RoomArea < 650  )
                {
                    Console.WriteLine("This is a medium-sized room");
                }
                else if( RoomArea >= 650)
                {
                    Console.WriteLine("This is a large-sized room");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Thank you for using the Room Detail Generator!");

        }
    }
}