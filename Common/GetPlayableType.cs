using System;

namespace Common
{
    public static class GetPlayableType
    {
        public static HeadSetTypes GetHeadSetType()
        {

            string userInput;
            bool wrongb = true;
            HeadSetTypes headSetType = new HeadSetTypes();
            Console.WriteLine("Select playback component:");
            do
            {                
                foreach (HeadSetTypes headsettype in Enum.GetValues(typeof(HeadSetTypes)))
                {
                    Console.WriteLine("{0}). {1}", (int)headsettype, headsettype.ToString());
                }
                Console.WriteLine("Choose 0 to exit");
                userInput = Console.ReadLine();
                try
                {
                    headSetType = (HeadSetTypes)Convert.ToInt32(userInput);
                }
                catch (Exception)
                {
                    headSetType = 0;
                }

                if (headSetType == 0 | Enum.IsDefined(typeof(HeadSetTypes), headSetType))
                {
                    wrongb = false;
                }
                else
                {
                    Console.WriteLine($"{userInput} is not a valid choice. Choose a number between 0 and 4.\n");
                }
            } while (wrongb);

            return headSetType;
        }

        public enum HeadSetTypes
        {
            iPhoneHeadset = 1, SamsungHeadset, UnofficialiPhoneHeadset, PhoneSpeaker
        }
    }
}
