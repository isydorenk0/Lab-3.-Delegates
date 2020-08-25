using LabC;
using System;
using static Common.GetPlayableType;

namespace Common
{
    public class GetPlayback
    {
        public static IPlayback GetPlaybackType(HeadSetTypes headSetType)
        {
            IPlayback playback = null;
            IOutput output = new TextBoxOutput();

            switch (headSetType)
            {
                case HeadSetTypes.iPhoneHeadset:
                    playback = new iPhoneHeadset(output);
                    break;
                case HeadSetTypes.SamsungHeadset:
                    playback = new SamsungHeadset(output);
                    break;
                case HeadSetTypes.UnofficialiPhoneHeadset:
                    playback = new UnofficialiPhoneHeadset(output);
                    break;
                case HeadSetTypes.PhoneSpeaker:
                    playback = new PhoneSpeaker(output);
                    break;
                default:
                    throw new ArgumentException("Invalid playback type");
            }
            return playback;
        }
    }
}
