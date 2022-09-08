using System;

namespace EventDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var clubMember = new ClubMember();
            var welcomer = new MemberWelcomer();
            var group = new Group();

            clubMember.NewMemberAdded += welcomer.WelcomeMember;
            clubMember.NewMemberAdded += group.AddToGroup;

            clubMember.AddMember("Jenny");

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg", filterHandler);
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}
